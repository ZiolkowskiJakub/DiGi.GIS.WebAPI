#### [DiGi\.GIS\.WebAPI](DiGi.GIS.WebAPI.Overview.md 'DiGi\.GIS\.WebAPI\.Overview')

## DiGi\.GIS\.WebAPI\.Constants Namespace
### Classes

<a name='DiGi.GIS.WebAPI.Constants.Compression'></a>

## Compression Class

Provides the compression settings applied to request payloads sent to the GIS PostgreSQL Web API\.

```csharp
public static class Compression
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Compression
### Fields

<a name='DiGi.GIS.WebAPI.Constants.Compression.Level'></a>

## Compression\.Level Field

The GZip compression level used for request payloads\.

[System\.IO\.Compression\.CompressionLevel\.Fastest](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.compressionlevel.fastest 'System\.IO\.Compression\.CompressionLevel\.Fastest') rather than [System\.IO\.Compression\.CompressionLevel\.Optimal](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.compressionlevel.optimal 'System\.IO\.Compression\.CompressionLevel\.Optimal'): on the bulk import path the client is CPU bound, and compressing a multi-megabyte JSON batch at [System\.IO\.Compression\.CompressionLevel\.Optimal](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.compressionlevel.optimal 'System\.IO\.Compression\.CompressionLevel\.Optimal') costs several times more than it saves in transfer. Revisit if the link to the host becomes the bottleneck.

```csharp
public static readonly CompressionLevel Level;
```

#### Field Value
[System\.IO\.Compression\.CompressionLevel](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.compressionlevel 'System\.IO\.Compression\.CompressionLevel')

<a name='DiGi.GIS.WebAPI.Constants.FileName'></a>

## FileName Class

Provides constant values for file names used within the GIS PostgreSQL Web API\.

```csharp
public static class FileName
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → FileName
### Fields

<a name='DiGi.GIS.WebAPI.Constants.FileName.GISWebAPIConfigurationFile'></a>

## FileName\.GISWebAPIConfigurationFile Field

Gets the filename of the configuration file for the GIS PostgreSQL Web API\.

```csharp
public const string GISWebAPIConfigurationFile = "GIS_WebAPI.conf";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.WebAPI.Constants.Name'></a>

## Name Class

Provides a collection of constant name identifiers used within the GIS PostgreSQL Web API\.

```csharp
public static class Name
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Name
### Fields

<a name='DiGi.GIS.WebAPI.Constants.Name.Client'></a>

## Name\.Client Field

Represents the identifier for the GIS client\.

```csharp
public static string Client;
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.WebAPI.Constants.Terrain'></a>

## Terrain Class

Provides the limits applied to terrain queries served by the GIS PostgreSQL Web API\.

```csharp
public static class Terrain
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Terrain
### Fields

<a name='DiGi.GIS.WebAPI.Constants.Terrain.MaximumDensityCountyCount'></a>

## Terrain\.MaximumDensityCountyCount Field

The largest number of counties a single density request may name\.

A density costs the reading of every subdivision outline of the county it is asked for, so this is what keeps one request from pulling the administrative geometry of the whole country. Sweeping every county means several requests, which is also what makes the sweep interruptible.

```csharp
public static readonly int MaximumDensityCountyCount;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.GIS.WebAPI.Constants.Terrain.MaximumEdgeLength'></a>

## Terrain\.MaximumEdgeLength Field

The longest edge, in model units, a terrain mesh triangle may have\.

A Delaunay triangulation covers the convex hull of its sites, so without a limit the mesh bridges county edges, no-data gaps and concave outlines with a skirt of long thin triangles that look like terrain and are not.

The value has to clear the diagonal of the coarsest lattice cell or it would shred genuine data: a regular 100 m lattice needs edges of 141.4 m. The cost of clearing it is that on a 10 m lattice a real gap of up to this width is still bridged.

```csharp
public static readonly double MaximumEdgeLength;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.WebAPI.Constants.Terrain.MaximumGapExtent'></a>

## Terrain\.MaximumGapExtent Field

The longest side, in model units, a gap request may ask for\.

Larger than the mesh endpoints admit, because a gap request returns coordinates rather than a triangulated surface and is meant for looking over a region at once. It is still bounded by [MaximumNodeCount](DiGi.GIS.WebAPI.Constants.md#DiGi.GIS.WebAPI.Constants.Terrain.MaximumNodeCount 'DiGi\.GIS\.WebAPI\.Constants\.Terrain\.MaximumNodeCount') at any given lattice.

```csharp
public static readonly double MaximumGapExtent;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.WebAPI.Constants.Terrain.MaximumNodeCount'></a>

## Terrain\.MaximumNodeCount Field

The largest number of lattice nodes a single coverage or gap request may generate\.

Checked against the requested area before any node is built, so an area and a lattice that would together exceed it are refused rather than started. This is the cap that holds when a large county meets a fine lattice, both of which are individually allowed.

```csharp
public static readonly long MaximumNodeCount;
```

#### Field Value
[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

<a name='DiGi.GIS.WebAPI.Constants.Terrain.MaximumRadius'></a>

## Terrain\.MaximumRadius Field

The largest search radius, in model units, a terrain request may ask for\.

The terrain endpoints are unauthenticated reads with no natural ceiling of their own: the radius alone decides how many stored points are gathered, triangulated and serialised, and the store is partitioned by county rather than capped by extent. Without this a single request can ask for the whole country.

The cap is a half-extent, so the largest search area is 4 km by 4 km. Counties are sampled onto a lattice between 10 m and 100 m, which puts the worst case at roughly 160 000 points. Raising this is safe only if the finest lattice is never queried at the new size - at 5 000 m the same lattice yields about a million points.

```csharp
public static readonly double MaximumRadius;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.WebAPI.Constants.Terrain.MinimumGridSize'></a>

## Terrain\.MinimumGridSize Field

The finest lattice, in model units, a coverage or gap request may be measured against\.

The work of those endpoints rises with the square of how fine the lattice is: they generate every node of a county and decide each one against its outlines. A county of 1 000 square kilometres is 100 000 nodes at 100 m and 10 million at 10 m, and below that the request stops being a diagnostic and becomes a denial of service that anyone can send.

```csharp
public static readonly double MinimumGridSize;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.GIS.WebAPI.Constants.Uri'></a>

## Uri Class

Provides constant URI values used throughout the PostgreSQL Web API application\.

```csharp
public static class Uri
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Uri
### Fields

<a name='DiGi.GIS.WebAPI.Constants.Uri.BaseAddress'></a>

## Uri\.BaseAddress Field

Gets or sets the base address for the Web API services\.

```csharp
public static Uri BaseAddress;
```

#### Field Value
[System\.Uri](https://learn.microsoft.com/en-us/dotnet/api/system.uri 'System\.Uri')