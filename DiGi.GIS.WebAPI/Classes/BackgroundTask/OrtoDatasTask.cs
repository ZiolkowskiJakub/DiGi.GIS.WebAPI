using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.PostgreSQL;
using DiGi.GIS.PostgreSQL.Classes;
using DiGi.GIS.PostgreSQL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.GIS.WebAPI.Classes
{
    /// <summary>
    /// Handles the background processing of orthophoto data within the GIS PostgreSQL context.
    /// </summary>
    public class OrtoDatasTask : ReportableBackgroundTask<long>, IGISPostgreSQLObject
    {
        private readonly GISPostgreSQLConverterManager? gISPostgreSQLConverterManager;
        private readonly GISWebAPIManager? GISWebAPIManager;

        /// <summary>
        /// Initializes a new instance of the OrtoDatasTask class.
        /// </summary>
        /// <param name="GISWebAPIManager">The manager responsible for handling GIS PostgreSQL Web API operations.</param>
        /// <param name="gISPostgreSQLConverterManager">The manager that handles conversion processes for GIS data within a PostgreSQL database context.</param>
        public OrtoDatasTask(GISWebAPIManager? GISWebAPIManager, GISPostgreSQLConverterManager? gISPostgreSQLConverterManager)
        {
            this.GISWebAPIManager = GISWebAPIManager ?? throw new ArgumentNullException(nameof(GISWebAPIManager));
            this.gISPostgreSQLConverterManager = gISPostgreSQLConverterManager ?? throw new ArgumentNullException(nameof(gISPostgreSQLConverterManager));
        }

        protected override async Task<bool> ExecuteAsync(IProgress<long> progress, CancellationToken cancellationToken)
        {
            Serilog.Modify.Log("{Type}:{Name} started", nameof(OrtoDatasTask), nameof(ExecuteAsync));

            if (GISWebAPIManager is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "GISWebAPIManager cannot be null");
                return false;
            }

            OrtoDatasPostgreSQLConverter? ortoDatasPostgreSQLConverter = gISPostgreSQLConverterManager?.GetPostgreSQLConverter<OrtoDatasPostgreSQLConverter>();
            if (ortoDatasPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "OrtoDatasPostgreSQLConverter cannot be null");
                return false;
            }

            Building2DPostgreSQLConverter? building2DPostgreSQLConverter = gISPostgreSQLConverterManager?.GetPostgreSQLConverter<Building2DPostgreSQLConverter>();
            if (building2DPostgreSQLConverter is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Building2DPostgreSQLConverter cannot be null");
                return false;
            }

            HttpClient? httpClient_Geoportal = Create.HttpClient_Geoportal(GISWebAPIManager);
            if (httpClient_Geoportal is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Error, "Geoportal HttpClient cannot be null");
                return false;
            }

            cancellationToken.ThrowIfCancellationRequested();

            int count = 5;
            Serilog.Modify.Log("Items count: {Count}", count);

            List<Building2DReference>? building2DReferences = await ortoDatasPostgreSQLConverter.GetNextBuilding2DReferencesAsync(count, cancellationToken: cancellationToken);
            if (building2DReferences is null)
            {
                Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "No Building2DReferences found in database");
                return false;
            }

            LongProgressWrapper? longProgressWrapper = Core.Create.LongProgressWrapper(progress);

            OrtoDatasBuilding2DOptions ortoDatasBuilding2DOptions = new();

            while (building2DReferences is not null && building2DReferences.Count > 0)
            {
                cancellationToken.ThrowIfCancellationRequested();

                List<PostgreSQL.Classes.OrtoDatas> ortoDatasList_PostgreSQL = [];

                try
                {
                    Serilog.Modify.Log("PostgreSQL Building2Ds extraction starting");

                    List<PostgreSQL.Classes.Building2D>? building2Ds_PostgreSQL = await building2DPostgreSQLConverter.GetBuilding2DsByBuilding2DReferencesAsync(building2DReferences, fallbackByReference: true, cancellationToken: cancellationToken);

                    Serilog.Modify.Log("PostgreSQL Building2Ds extraction ended");

                    if (building2Ds_PostgreSQL is not null && building2Ds_PostgreSQL.Count > 0)
                    {
                        foreach (PostgreSQL.Classes.Building2D building2D_PostgreSQL in building2Ds_PostgreSQL)
                        {
                            cancellationToken.ThrowIfCancellationRequested();

                            GIS.Classes.Building2D? building2D = building2D_PostgreSQL.ToDiGi();
                            if (building2D is null)
                            {
                                continue;
                            }

                            GIS.Classes.OrtoDatas? ortoDatas = await GIS.Create.OrtoDatas(httpClient_Geoportal, building2D, ortoDatasBuilding2DOptions.Years, ortoDatasBuilding2DOptions.Offset, ortoDatasBuilding2DOptions.Width, ortoDatasBuilding2DOptions.Reduce, squared: true);
                            if (ortoDatas is null)
                            {
                                continue;
                            }

                            int? countyId = building2D_PostgreSQL.CountyId > 0 ? building2D_PostgreSQL.CountyId : null;
                            int? subdivisionId = building2D_PostgreSQL.SubdivisionId;
                            if (subdivisionId is null && building2DReferences is not null)
                            {
                                Building2DReference? matchingReference = building2DReferences.FirstOrDefault(r => r is not null && r.Reference == building2D_PostgreSQL.Reference);
                                subdivisionId = matchingReference?.SubdivisionId;
                            }

                            if (ortoDatas.ToPostgreSQL(countyId, subdivisionId) is PostgreSQL.Classes.OrtoDatas ortoDatas_PostgreSQL)
                            {
                                ortoDatasList_PostgreSQL.Add(ortoDatas_PostgreSQL);
                            }
                        }

                        Serilog.Modify.Log("OrtoDatas extracted {Count}", ortoDatasList_PostgreSQL.Count);
                    }
                    else
                    {
                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "No PostgreSQL Building2Ds found for {Count} references", building2DReferences.Count);
                    }
                }
                catch (OperationCanceledException)
                {
                    Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "{Type}:{Name} canceled", nameof(OrtoDatasTask), nameof(ExecuteAsync));
                    return false;
                }
                catch (HttpRequestException httpRequestException)
                {
                    Serilog.Modify.Log(httpRequestException, "HTTP error during OrtoDatas extraction");
                }
                catch (Exception exception)
                {
                    Serilog.Modify.Log(exception, "Unexpected error during OrtoDatas processing");
                    return false;
                }

                if (ortoDatasList_PostgreSQL.Count > 0)
                {
                    Serilog.Modify.Log("OrtoDatas updating starting");

                    PostgreSQLUpdateResult? postgreSQLUpdateResult = await ortoDatasPostgreSQLConverter.UpdateAsync(ortoDatasList_PostgreSQL);

                    UpdateItemsResult? updateItemsResult = postgreSQLUpdateResult.UpdateItemsResult(ortoDatasList_PostgreSQL.Count);
                    if (updateItemsResult is null)
                    {
                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "OrtoDatas updating could not be attempted");
                    }
                    else if (updateItemsResult.Rejected.Count != 0)
                    {
                        Serilog.Modify.Log(Serilog.Enums.LogEventLevel.Warning, "OrtoDatas rejected before the database: {Count}/{Total}. References: {References}", updateItemsResult.Rejected.Count, updateItemsResult.Sent, updateItemsResult.Rejected.RejectionSample());
                    }

                    longProgressWrapper?.Increment(ortoDatasList_PostgreSQL.Count);

                    Serilog.Modify.Log("OrtoDatas updating ended");

                    List<long> ids = [];
                    if (building2DReferences is not null)
                    {
                        foreach (Building2DReference building2DReference in building2DReferences)
                        {
                            if (building2DReference is not null && building2DReference.Id > 0)
                            {
                                ids.Add(building2DReference.Id);
                            }
                        }
                    }

                    if (ids.Count > 0)
                    {
                        await ortoDatasPostgreSQLConverter.AcknowledgeBuilding2DReferencesAsync(ids, cancellationToken: cancellationToken);
                    }
                }

                cancellationToken.ThrowIfCancellationRequested();

                Serilog.Modify.Log("Getting new Building2DReferences");

                building2DReferences = await ortoDatasPostgreSQLConverter.GetNextBuilding2DReferencesAsync(count, cancellationToken: cancellationToken);

                Serilog.Modify.Log("Getting new Building2DReferences ended. Count: {Count}", building2DReferences?.Count ?? 0);
            }

            return true;
        }
    }
}