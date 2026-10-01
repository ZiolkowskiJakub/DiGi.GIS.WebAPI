using DiGi.WebAPI.Interfaces;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.OpenApi;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS.WebAPI.Classes.Filters
{
    /// <summary>
    /// Adds example values to parameters, request bodies, and responses in the OpenAPI document.
    /// </summary>
    public class AddExamplesOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation == null) return;

            // Add examples to parameters
            foreach (var parameter in operation.Parameters ?? Enumerable.Empty<OpenApiParameter>())
            {
                if (parameter.Schema != null)
                {
                    TrySetExample(parameter.Schema, context.SchemaRepository, context.SchemaGenerator);
                }
            }

            // Add examples to request body
            if (operation.RequestBody != null)
            {
                foreach (var mediaType in operation.RequestBody.Content.Values)
                {
                    if (mediaType.Schema != null)
                    {
                        TrySetExample(mediaType.Schema, context.SchemaRepository, context.SchemaGenerator);
                    }
                }
            }

            // Add examples to responses (focus on 2xx and 4xx/5xx that have schema)
            if (operation.Responses != null)
            {
                foreach (var kvp in operation.Responses)
                {
                    var response = kvp.Value;
                    if (response.Content != null)
                    {
                        foreach (var mediaType in response.Content.Values)
                        {
                            if (mediaType.Schema != null)
                            {
                                TrySetExample(mediaType.Schema, context.SchemaRepository, context.SchemaGenerator);
                            }
                        }
                    }
                }
            }
        }

        private static void TrySetExample(OpenApiSchema schema, ISchemaRepository schemaRepository, ISchemaGenerator schemaGenerator)
        {
            if (schema == null || schema.Example != null) return;

            // Try to generate an example based on the schema's actual type if possible
            // For simplicity, we generate a primitive example based on schema type/format
            // For objects, we create a sample with one property per defined property.
            // For arrays, we create a single-item array.
            // For dictionaries, we leave empty.
            // For unknown, we set a simple string.

            if (schema.Type == JsonSchemaType.String)
            {
                if (!string.IsNullOrWhiteSpace(schema.Format))
                {
                    switch (schema.Format.ToLowerInvariant())
                    {
                        case "date":
                            schema.Example = new OpenApiString("2026-01-01");
                            break;
                        case "date-time":
                            schema.Example = new OpenApiString("2026-01-01T12:00:00Z");
                            break;
                        case "uuid":
                            schema.Example = new OpenApiString("3fa85f64-5717-4562-b3fc-2c963f66afa6");
                            break;
                        default:
                            schema.Example = new OpenApiString("example");
                            break;
                    }
                }
                else
                {
                    schema.Example = new OpenApiString("example");
                }
            }
            else if (schema.Type == JsonSchemaType.Integer || schema.Type == JsonSchemaType.Long)
            {
                schema.Example = new OpenApiInteger(0);
            }
            else if (schema.Type == JsonSchemaType.Boolean)
            {
                schema.Example = new OpenApiBoolean(false);
            }
            else if (schema.Type == JsonSchemaType.Number)
            {
                schema.Example = new OpenApiFloat(0f);
            }
            else if (schema.Type == JsonSchemaType.Object)
            {
                // Create a sample object with one example per property
                if (schema.Properties != null && schema.Properties.Count > 0)
                {
                    var exampleObj = new OpenApiObject();
                    foreach (var prop in schema.Properties)
                    {
                        // For each property, create a shallow copy of its schema and set example
                        var propSchema = prop.Value;
                        if (propSchema != null)
                        {
                            // Recursively set example on a copy? We'll just set a simple example based on type.
                            // To avoid infinite recursion, we limit depth by not recursing into complex objects here.
                            // Instead we set a placeholder.
                            object? exampleValue = null;
                            if (propSchema.Type == JsonSchemaType.String)
                            {
                                exampleValue = "example";
                            }
                            else if (propSchema.Type == JsonSchemaType.Integer || propSchema.Type == JsonSchemaType.Long)
                            {
                                exampleValue = 0;
                            }
                            else if (propSchema.Type == JsonSchemaType.Boolean)
                            {
                                exampleValue = false;
                            }
                            else if (propSchema.Type == JsonSchemaType.Number)
                            {
                                exampleValue = 0f;
                            }
                            else
                            {
                                // For complex types, we leave null or empty object? We'll set empty object.
                                exampleValue = new OpenApiObject();
                            }
                            exampleObj.Add(prop.Key, exampleValue as IOpenApiWritable ?? new OpenApiString("example"));
                        }
                    }
                    schema.Example = exampleObj;
                }
                else
                {
                    // No properties defined, set empty object
                    schema.Example = new OpenApiObject();
                }
            }
            else if (schema.Type == JsonSchemaType.Array)
            {
                // Create a single-item array where the item is an example based on Items schema
                if (schema.Items != null)
                {
                    var itemSchema = schema.Items;
                    // Try to set example on a copy of items schema? We'll just create a simple example based on type.
                    object? exampleItem = null;
                    if (itemSchema.Type == JsonSchemaType.String)
                    {
                        exampleItem = "example";
                    }
                    else if (itemSchema.Type == JsonSchemaType.Integer || itemSchema.Type == JsonSchemaType.Long)
                    {
                        exampleItem = 0;
                    }
                    else if (itemSchema.Type == JsonSchemaType.Boolean)
                    {
                        exampleItem = false;
                    }
                    else if (itemSchema.Type == JsonSchemaType.Number)
                    {
                        exampleItem = 0f;
                    }
                    else if (itemSchema.Type == JsonSchemaType.Object)
                    {
                        exampleItem = new OpenApiObject();
                    }
                    else
                    {
                        exampleItem = new OpenApiString("example");
                    }

                    var array = new OpenApiArray { exampleItem };
                    schema.Example = array;
                }
                else
                {
                    schema.Example = new OpenApiArray();
                }
            }
            else
            {
                // Fallback: string example
                schema.Example = new OpenApiString("example");
            }
        }
    }
}