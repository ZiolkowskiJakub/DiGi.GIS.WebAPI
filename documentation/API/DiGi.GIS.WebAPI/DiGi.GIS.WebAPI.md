#### [DiGi\.GIS\.WebAPI](DiGi.GIS.WebAPI.Overview.md 'DiGi\.GIS\.WebAPI\.Overview')

## DiGi\.GIS\.WebAPI Namespace
### Classes

<a name='DiGi.GIS.WebAPI.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.GIS.WebAPI.Create.GISWebAPIConfigurationFileWatcher()'></a>

## Create\.GISWebAPIConfigurationFileWatcher\(\) Method

Creates a new instance of the GISWebAPIConfigurationFileWatcher class\.

```csharp
public static DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher GISWebAPIConfigurationFileWatcher();
```

#### Returns
[GISWebAPIConfigurationFileWatcher](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIConfigurationFileWatcher')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Create.GISWebAPIManager()'></a>

## Create\.GISWebAPIManager\(\) Method

Creates a new instance of the GISWebAPIManager class\.

```csharp
public static DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager();
```

#### Returns
[GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Create.HttpClient_Geoportal(DiGi.GIS.WebAPI.Classes.GISWebAPIManager)'></a>

## Create\.HttpClient\_Geoportal\(GISWebAPIManager\) Method

Creates and configures an [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient') instance for the Geoportal service, including a custom User\-Agent header based on the executing assembly's name and version\.

```csharp
public static System.Net.Http.HttpClient? HttpClient_Geoportal(DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Create.HttpClient_Geoportal(DiGi.GIS.WebAPI.Classes.GISWebAPIManager).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The manager used to create the HTTP client instance\.

#### Returns
[System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Create.HttpClient_GUGiK(DiGi.GIS.WebAPI.Classes.GISWebAPIManager)'></a>

## Create\.HttpClient\_GUGiK\(GISWebAPIManager\) Method

Creates and configures an [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient') instance for the "Główny Urząd Geodezji i Kartografii" service, including a custom User\-Agent header based on the executing assembly's name and version\.

```csharp
public static System.Net.Http.HttpClient? HttpClient_GUGiK(DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Create.HttpClient_GUGiK(DiGi.GIS.WebAPI.Classes.GISWebAPIManager).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The manager used to create the HTTP client instance\.

#### Returns
[System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Create.HttpContent(thisbyte[],System.IO.Compression.CompressionLevel,System.Threading.CancellationToken)'></a>

## Create\.HttpContent\(this byte\[\], CompressionLevel, CancellationToken\) Method

Asynchronously creates GZip\-compressed HttpContent from the provided byte array using the specified compression level\.

```csharp
public static System.Threading.Tasks.Task<System.Net.Http.HttpContent?> HttpContent(this byte[] bytes, System.IO.Compression.CompressionLevel compressionLevel, System.Threading.CancellationToken cancellationToken);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Create.HttpContent(thisbyte[],System.IO.Compression.CompressionLevel,System.Threading.CancellationToken).bytes'></a>

`bytes` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The raw byte array to be compressed\.

<a name='DiGi.GIS.WebAPI.Create.HttpContent(thisbyte[],System.IO.Compression.CompressionLevel,System.Threading.CancellationToken).compressionLevel'></a>

`compressionLevel` [System\.IO\.Compression\.CompressionLevel](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.compressionlevel 'System\.IO\.Compression\.CompressionLevel')

The compression level applied to the payload\.

<a name='DiGi.GIS.WebAPI.Create.HttpContent(thisbyte[],System.IO.Compression.CompressionLevel,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A token to monitor for cancellation requests\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Net\.Http\.HttpContent](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpcontent 'System\.Net\.Http\.HttpContent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Create.HttpContent(thisbyte[],System.Threading.CancellationToken)'></a>

## Create\.HttpContent\(this byte\[\], CancellationToken\) Method

Asynchronously creates GZip\-compressed HttpContent from the provided byte array\.

```csharp
public static System.Threading.Tasks.Task<System.Net.Http.HttpContent?> HttpContent(this byte[] bytes, System.Threading.CancellationToken cancellationToken);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Create.HttpContent(thisbyte[],System.Threading.CancellationToken).bytes'></a>

`bytes` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The raw byte array to be compressed\.

<a name='DiGi.GIS.WebAPI.Create.HttpContent(thisbyte[],System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A token to monitor for cancellation requests\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Net\.Http\.HttpContent](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpcontent 'System\.Net\.Http\.HttpContent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Create.HttpContent(thisstring,System.Threading.CancellationToken)'></a>

## Create\.HttpContent\(this string, CancellationToken\) Method

Converts a JSON string into an asynchronous [System\.Net\.Http\.HttpContent](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpcontent 'System\.Net\.Http\.HttpContent') object\.

```csharp
public static System.Threading.Tasks.Task<System.Net.Http.HttpContent?> HttpContent(this string json, System.Threading.CancellationToken cancellationToken);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Create.HttpContent(thisstring,System.Threading.CancellationToken).json'></a>

`json` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The JSON string to be converted\.

<a name='DiGi.GIS.WebAPI.Create.HttpContent(thisstring,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellationToken\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Net\.Http\.HttpContent](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpcontent 'System\.Net\.Http\.HttpContent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Create.HttpContent(thisSystem.Collections.Generic.IEnumerable_string_,System.Threading.CancellationToken)'></a>

## Create\.HttpContent\(this IEnumerable\<string\>, CancellationToken\) Method

Converts a collection of strings into an [System\.Net\.Http\.HttpContent](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpcontent 'System\.Net\.Http\.HttpContent') object holding a JSON array\.

```csharp
public static System.Threading.Tasks.Task<System.Net.Http.HttpContent?> HttpContent(this System.Collections.Generic.IEnumerable<string>? values, System.Threading.CancellationToken cancellationToken);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Create.HttpContent(thisSystem.Collections.Generic.IEnumerable_string_,System.Threading.CancellationToken).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of strings to be serialized and converted to HTTP content\.

<a name='DiGi.GIS.WebAPI.Create.HttpContent(thisSystem.Collections.Generic.IEnumerable_string_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A token to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Net\.Http\.HttpContent](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpcontent 'System\.Net\.Http\.HttpContent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Create.HttpContent_TSerializableObject_(thisSystem.Collections.Generic.IEnumerable_TSerializableObject_,System.Threading.CancellationToken)'></a>

## Create\.HttpContent\<TSerializableObject\>\(this IEnumerable\<TSerializableObject\>, CancellationToken\) Method

Converts a collection of serializable objects into an [System\.Net\.Http\.HttpContent](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpcontent 'System\.Net\.Http\.HttpContent') object by first serializing them to a JSON string\.

```csharp
public static System.Threading.Tasks.Task<System.Net.Http.HttpContent?> HttpContent<TSerializableObject>(this System.Collections.Generic.IEnumerable<TSerializableObject> serializableObjects, System.Threading.CancellationToken cancellationToken)
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.GIS.WebAPI.Create.HttpContent_TSerializableObject_(thisSystem.Collections.Generic.IEnumerable_TSerializableObject_,System.Threading.CancellationToken).TSerializableObject'></a>

`TSerializableObject`

The type of the objects in the collection, which must implement [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.
#### Parameters

<a name='DiGi.GIS.WebAPI.Create.HttpContent_TSerializableObject_(thisSystem.Collections.Generic.IEnumerable_TSerializableObject_,System.Threading.CancellationToken).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[TSerializableObject](DiGi.GIS.WebAPI.md#DiGi.GIS.WebAPI.Create.HttpContent_TSerializableObject_(thisSystem.Collections.Generic.IEnumerable_TSerializableObject_,System.Threading.CancellationToken).TSerializableObject 'DiGi\.GIS\.WebAPI\.Create\.HttpContent\<TSerializableObject\>\(this System\.Collections\.Generic\.IEnumerable\<TSerializableObject\>, System\.Threading\.CancellationToken\)\.TSerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of objects to be serialized and converted to HTTP content\.

<a name='DiGi.GIS.WebAPI.Create.HttpContent_TSerializableObject_(thisSystem.Collections.Generic.IEnumerable_TSerializableObject_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A token to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Net\.Http\.HttpContent](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpcontent 'System\.Net\.Http\.HttpContent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Create.ServiceProvider()'></a>

## Create\.ServiceProvider\(\) Method

Creates and configures a service provider with the registered services\.

```csharp
public static System.IServiceProvider ServiceProvider();
```

#### Returns
[System\.IServiceProvider](https://learn.microsoft.com/en-us/dotnet/api/system.iserviceprovider 'System\.IServiceProvider')  
An [System\.IServiceProvider](https://learn.microsoft.com/en-us/dotnet/api/system.iserviceprovider 'System\.IServiceProvider') containing the registered services\.

<a name='DiGi.GIS.WebAPI.Create.UpdateItemsResult(thisDiGi.GIS.PostgreSQL.Classes.PostgreSQLUpdateResult,int)'></a>

## Create\.UpdateItemsResult\(this PostgreSQLUpdateResult, int\) Method

Creates the response payload of a write endpoint from what the database converter reported\.

```csharp
public static DiGi.GIS.WebAPI.Classes.UpdateItemsResult? UpdateItemsResult(this DiGi.GIS.PostgreSQL.Classes.PostgreSQLUpdateResult? postgreSQLUpdateResult, int sent);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Create.UpdateItemsResult(thisDiGi.GIS.PostgreSQL.Classes.PostgreSQLUpdateResult,int).postgreSQLUpdateResult'></a>

`postgreSQLUpdateResult` [DiGi\.GIS\.PostgreSQL\.Classes\.PostgreSQLUpdateResult](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.postgresqlupdateresult 'DiGi\.GIS\.PostgreSQL\.Classes\.PostgreSQLUpdateResult')

The outcome returned by the converter's update\.

<a name='DiGi.GIS.WebAPI.Create.UpdateItemsResult(thisDiGi.GIS.PostgreSQL.Classes.PostgreSQLUpdateResult,int).sent'></a>

`sent` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of rows handed to the converter\.

#### Returns
[UpdateItemsResult](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.UpdateItemsResult 'DiGi\.GIS\.WebAPI\.Classes\.UpdateItemsResult')  
A new [UpdateItemsResult](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.UpdateItemsResult 'DiGi\.GIS\.WebAPI\.Classes\.UpdateItemsResult'), or null if [postgreSQLUpdateResult](DiGi.GIS.WebAPI.md#DiGi.GIS.WebAPI.Create.UpdateItemsResult(thisDiGi.GIS.PostgreSQL.Classes.PostgreSQLUpdateResult,int).postgreSQLUpdateResult 'DiGi\.GIS\.WebAPI\.Create\.UpdateItemsResult\(this DiGi\.GIS\.PostgreSQL\.Classes\.PostgreSQLUpdateResult, int\)\.postgreSQLUpdateResult') is null\.

<a name='DiGi.GIS.WebAPI.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.GIS.WebAPI.Modify.InitializeAsync(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection)'></a>

## Modify\.InitializeAsync\(this IServiceCollection\) Method

Initializes the GIS PostgreSQL Web API services, including the configuration file watcher and converter manager\.

```csharp
public static System.Threading.Tasks.Task InitializeAsync(this Microsoft.Extensions.DependencyInjection.IServiceCollection serviceCollection);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.InitializeAsync(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection).serviceCollection'></a>

`serviceCollection` [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection')

The [Microsoft\.Extensions\.DependencyInjection\.IServiceCollection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection 'Microsoft\.Extensions\.DependencyInjection\.IServiceCollection') to add services to\.

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')  
A [System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task') representing the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,byte[],int,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, byte\[\], int, PostOptions\) Method

Asynchronously updates building items for one explicitly identified county row from an already\-serialized UTF\-8 JSON payload via the PostgreSQL Web API\.

For a county stored as several polygon parts, pass every part to the [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') overload instead - naming one part files the whole batch there whether or not the buildings belong to it.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, byte[]? utf8Json, int countyId, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,byte[],int,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') instance used to perform the update operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,byte[],int,DiGi.WebAPI.Classes.PostOptions).utf8Json'></a>

`utf8Json` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The UTF\-8 encoded JSON array of [DiGi\.CityGML\.Classes\.Building](https://learn.microsoft.com/en-us/dotnet/api/digi.citygml.classes.building 'DiGi\.CityGML\.Classes\.Building') items to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,byte[],int,DiGi.WebAPI.Classes.PostOptions).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county row the buildings belong to\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,byte[],int,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,byte[],string,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, byte\[\], string, PostOptions\) Method

Asynchronously updates building items from an already\-serialized UTF\-8 JSON payload via the PostgreSQL Web API\.

Used by [BuildingsPostTask](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingsPostTask 'DiGi\.GIS\.WebAPI\.Classes\.BuildingsPostTask'), where the batch was serialized once while being sized, so it must not be serialized again here.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, byte[]? utf8Json, string? code=null, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,byte[],string,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') instance used to perform the update operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,byte[],string,DiGi.WebAPI.Classes.PostOptions).utf8Json'></a>

`utf8Json` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The UTF\-8 encoded JSON array of [DiGi\.CityGML\.Classes\.Building](https://learn.microsoft.com/en-us/dotnet/api/digi.citygml.classes.building 'DiGi\.CityGML\.Classes\.Building') items to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,byte[],string,DiGi.WebAPI.Classes.PostOptions).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional code used for the update operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,byte[],string,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,byte[],System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, byte\[\], IEnumerable\<int\>, PostOptions\) Method

Asynchronously updates building items for an explicitly identified county row from an already\-serialized UTF\-8 JSON payload via the PostgreSQL Web API\.

Used by [BuildingsPostTask](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingsPostTask 'DiGi\.GIS\.WebAPI\.Classes\.BuildingsPostTask'), where the batch was serialized once while being sized, so it must not be serialized again here.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, byte[]? utf8Json, System.Collections.Generic.IEnumerable<int>? countyIds, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,byte[],System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') instance used to perform the update operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,byte[],System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).utf8Json'></a>

`utf8Json` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The UTF\-8 encoded JSON array of [DiGi\.CityGML\.Classes\.Building](https://learn.microsoft.com/en-us/dotnet/api/digi.citygml.classes.building 'DiGi\.CityGML\.Classes\.Building') items to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,byte[],System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).countyIds'></a>

`countyIds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The identifiers of the county rows the buildings belong to\. Normally every polygon part of one county\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,byte[],System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, AdministrativeAreal2D, PostOptions\) Method

Updates a single administrative area item asynchronously\.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, DiGi.GIS.Classes.AdministrativeAreal2D? administrativeAreal2D, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The GIS PostgreSQL Web API manager instance\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.WebAPI.Classes.PostOptions).administrativeAreal2D'></a>

`administrativeAreal2D` [DiGi\.GIS\.Classes\.AdministrativeAreal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.administrativeareal2d 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')

The administrative area item to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,DiGi.GIS.Classes.AdministrativeAreal2D,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the HTTP POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,DiGi.GIS.Classes.Building2D,int,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, Building2D, int, PostOptions\) Method

Asynchronously updates a single 2D building item for an explicitly identified county row via the PostgreSQL Web API\.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, DiGi.GIS.Classes.Building2D? building2D, int countyId, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,DiGi.GIS.Classes.Building2D,int,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The manager instance used to facilitate the web API communication\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,DiGi.GIS.Classes.Building2D,int,DiGi.WebAPI.Classes.PostOptions).building2D'></a>

`building2D` [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')

The [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D') object to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,DiGi.GIS.Classes.Building2D,int,DiGi.WebAPI.Classes.PostOptions).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county row the building belongs to\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,DiGi.GIS.Classes.Building2D,int,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,DiGi.GIS.Classes.Building2D,string,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, Building2D, string, PostOptions\) Method

Asynchronously updates building items in the PostgreSQL GIS database via the web API\.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, DiGi.GIS.Classes.Building2D? building2D, string? code=null, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,DiGi.GIS.Classes.Building2D,string,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The manager instance used to handle communication with the PostgreSQL Web API\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,DiGi.GIS.Classes.Building2D,string,DiGi.WebAPI.Classes.PostOptions).building2D'></a>

`building2D` [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')

The [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D') object containing the data to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,DiGi.GIS.Classes.Building2D,string,DiGi.WebAPI.Classes.PostOptions).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional identification code associated with the update request\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,DiGi.GIS.Classes.Building2D,string,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration settings for the HTTP POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,string,bool,bool,bool,DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions,System.IProgress_long_,System.Nullable_System.Threading.CancellationToken_)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, string, bool, bool, bool, SerializableObjectsPostOptions, IProgress\<long\>, Nullable\<CancellationToken\>\) Method

Asynchronously updates items from the specified file system path\.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, string? path, bool oT_ADJA_A=true, bool oT_ADMS_A=true, bool oT_BUBD_A=true, DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions? serializableObjectsPostOptions=null, System.IProgress<long>? progress=null, System.Nullable<System.Threading.CancellationToken> cancellationToken=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,string,bool,bool,bool,DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions,System.IProgress_long_,System.Nullable_System.Threading.CancellationToken_).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The GIS PostgreSQL Web API manager instance\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,string,bool,bool,bool,DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions,System.IProgress_long_,System.Nullable_System.Threading.CancellationToken_).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file system path to the source data files\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,string,bool,bool,bool,DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions,System.IProgress_long_,System.Nullable_System.Threading.CancellationToken_).oT_ADJA_A'></a>

`oT_ADJA_A` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether items with the OT\_ADJA\_A suffix should be updated\. Defaults to `true`\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,string,bool,bool,bool,DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions,System.IProgress_long_,System.Nullable_System.Threading.CancellationToken_).oT_ADMS_A'></a>

`oT_ADMS_A` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether items with the OT\_ADMS\_A suffix should be updated\. Defaults to `true`\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,string,bool,bool,bool,DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions,System.IProgress_long_,System.Nullable_System.Threading.CancellationToken_).oT_BUBD_A'></a>

`oT_BUBD_A` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether items with the OT\_BUBD\_A suffix should be updated\. Defaults to `true`\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,string,bool,bool,bool,DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions,System.IProgress_long_,System.Nullable_System.Threading.CancellationToken_).serializableObjectsPostOptions'></a>

`serializableObjectsPostOptions` [SerializableObjectsPostOptions](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostOptions')

The options used for serializing objects during the POST request\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,string,bool,bool,bool,DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions,System.IProgress_long_,System.Nullable_System.Threading.CancellationToken_).progress'></a>

`progress` [System\.IProgress&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1 'System\.IProgress\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1 'System\.IProgress\`1')

The progress reporter for reporting progress updates\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,string,bool,bool,bool,DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions,System.IProgress_long_,System.Nullable_System.Threading.CancellationToken_).cancellationToken'></a>

`cancellationToken` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,int,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<BuildingModel\>, int, PostOptions\) Method

Asynchronously updates multiple building models for one explicitly identified county row via the PostgreSQL Web API\.

For a county stored as several polygon parts, pass every part to the [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') overload instead - naming one part files the whole batch there whether or not the models belong to it.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Classes.BuildingModel>? buildingModels, int countyId, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,int,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') instance used to perform the update operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,int,DiGi.WebAPI.Classes.PostOptions).buildingModels'></a>

`buildingModels` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') items to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,int,DiGi.WebAPI.Classes.PostOptions).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county row the building models belong to\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,int,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,string,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<BuildingModel\>, string, PostOptions\) Method

Asynchronously updates multiple building models via the PostgreSQL Web API\.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Classes.BuildingModel>? buildingModels, string? code=null, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,string,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') instance used to perform the update operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,string,DiGi.WebAPI.Classes.PostOptions).buildingModels'></a>

`buildingModels` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') items to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,string,DiGi.WebAPI.Classes.PostOptions).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The administrative area code the building models belong to, resolved server\-side to a county identifier\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,string,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<BuildingModel\>, IEnumerable\<int\>, PostOptions\) Method

Asynchronously updates multiple building models for an explicitly identified county row via the PostgreSQL Web API\.

The counterpart of the `code` overload, for a caller that already holds the identifiers: a multi-part county holds one `administrative_areal_2d` row per polygon part, so pass every part rather than picking one - the server files each item under the part it belongs to.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Classes.BuildingModel>? buildingModels, System.Collections.Generic.IEnumerable<int>? countyIds, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') instance used to perform the update operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).buildingModels'></a>

`buildingModels` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') items to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).countyIds'></a>

`countyIds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The identifiers of the county rows the building models belong to\. Normally every polygon part of one county\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,int,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<Building\>, int, PostOptions\) Method

Asynchronously updates multiple building items for one explicitly identified county row via the PostgreSQL Web API\.

For a county stored as several polygon parts, pass every part to the [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') overload instead - naming one part files the whole batch there whether or not the buildings belong to it.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.CityGML.Classes.Building>? buildings, int countyId, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,int,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') instance used to perform the update operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,int,DiGi.WebAPI.Classes.PostOptions).buildings'></a>

`buildings` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.CityGML\.Classes\.Building](https://learn.microsoft.com/en-us/dotnet/api/digi.citygml.classes.building 'DiGi\.CityGML\.Classes\.Building')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.CityGML\.Classes\.Building](https://learn.microsoft.com/en-us/dotnet/api/digi.citygml.classes.building 'DiGi\.CityGML\.Classes\.Building') items to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,int,DiGi.WebAPI.Classes.PostOptions).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county row the buildings belong to\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,int,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,string,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<Building\>, string, PostOptions\) Method

Asynchronously updates multiple building items via the PostgreSQL Web API\.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.CityGML.Classes.Building>? buildings, string? code=null, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,string,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') instance used to perform the update operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,string,DiGi.WebAPI.Classes.PostOptions).buildings'></a>

`buildings` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.CityGML\.Classes\.Building](https://learn.microsoft.com/en-us/dotnet/api/digi.citygml.classes.building 'DiGi\.CityGML\.Classes\.Building')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.CityGML\.Classes\.Building](https://learn.microsoft.com/en-us/dotnet/api/digi.citygml.classes.building 'DiGi\.CityGML\.Classes\.Building') items to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,string,DiGi.WebAPI.Classes.PostOptions).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional code used for the update operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,string,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<Building\>, IEnumerable\<int\>, PostOptions\) Method

Asynchronously updates multiple building items for an explicitly identified county row via the PostgreSQL Web API\.

The counterpart of the `code` overload, for a caller that already holds the identifiers: a multi-part county holds one `administrative_areal_2d` row per polygon part, so pass every part rather than picking one - the server files each item under the part it belongs to.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.CityGML.Classes.Building>? buildings, System.Collections.Generic.IEnumerable<int>? countyIds, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') instance used to perform the update operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).buildings'></a>

`buildings` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.CityGML\.Classes\.Building](https://learn.microsoft.com/en-us/dotnet/api/digi.citygml.classes.building 'DiGi\.CityGML\.Classes\.Building')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.CityGML\.Classes\.Building](https://learn.microsoft.com/en-us/dotnet/api/digi.citygml.classes.building 'DiGi\.CityGML\.Classes\.Building') items to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).countyIds'></a>

`countyIds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The identifiers of the county rows the buildings belong to\. Normally every polygon part of one county\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.EPW.Classes.EPWFile_,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<EPWFile\>, PostOptions\) Method

Asynchronously updates a collection of EPW files\.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.EPW.Classes.EPWFile>? ePWFiles, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.EPW.Classes.EPWFile_,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The GIS PostgreSQL Web API manager instance\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.EPW.Classes.EPWFile_,DiGi.WebAPI.Classes.PostOptions).ePWFiles'></a>

`ePWFiles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.EPW\.Classes\.EPWFile](https://learn.microsoft.com/en-us/dotnet/api/digi.epw.classes.epwfile 'DiGi\.EPW\.Classes\.EPWFile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of EPW files to update\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.EPW.Classes.EPWFile_,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.AdministrativeAreal2D_,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<AdministrativeAreal2D\>, PostOptions\) Method

Asynchronously updates a collection of administrative area items\.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.AdministrativeAreal2D>? administrativeAreal2Ds, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.AdministrativeAreal2D_,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The GIS PostgreSQL Web API manager instance\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.AdministrativeAreal2D_,DiGi.WebAPI.Classes.PostOptions).administrativeAreal2Ds'></a>

`administrativeAreal2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.AdministrativeAreal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.administrativeareal2d 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of administrative area items to update\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.AdministrativeAreal2D_,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,int,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<Building2D\>, int, PostOptions\) Method

Asynchronously updates multiple 2D building items for one explicitly identified county row via the PostgreSQL Web API\.

For a county stored as several polygon parts, pass every part to the [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') overload instead - naming one part files the whole batch there whether or not the buildings belong to it.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2D>? building2Ds, int countyId, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,int,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The manager instance used to facilitate the web API communication\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,int,DiGi.WebAPI.Classes.PostOptions).building2Ds'></a>

`building2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D') objects to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,int,DiGi.WebAPI.Classes.PostOptions).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county row the buildings belong to\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,int,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<Building2D\>, string, PostOptions\) Method

Updates multiple 2D building items asynchronously\.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2D>? building2Ds, string? code=null, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The GIS PostgreSQL Web API manager instance\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.WebAPI.Classes.PostOptions).building2Ds'></a>

`building2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D') items to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.WebAPI.Classes.PostOptions).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional code used for the update operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<Building2D\>, IEnumerable\<int\>, PostOptions\) Method

Asynchronously updates multiple 2D building items for an explicitly identified county row via the PostgreSQL Web API\.

The counterpart of the `code` overload, for a caller that already holds the identifiers: a multi-part county holds one `administrative_areal_2d` row per polygon part, so pass every part rather than picking one - the server files each item under the part it belongs to.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2D>? building2Ds, System.Collections.Generic.IEnumerable<int>? countyIds, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The manager instance used to facilitate the web API communication\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).building2Ds'></a>

`building2Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D') objects to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).countyIds'></a>

`countyIds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The identifiers of the county rows the buildings belong to\. Normally every polygon part of one county\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<OccupancyData\>, PostOptions\) Method

Asynchronously updates multiple occupancy data items via the PostgreSQL Web API\.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.OccupancyData>? occupancyDatas, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The manager instance used to facilitate the API communication\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,DiGi.WebAPI.Classes.PostOptions).occupancyDatas'></a>

`occupancyDatas` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.OccupancyData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.occupancydata 'DiGi\.GIS\.Classes\.OccupancyData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [DiGi\.GIS\.Classes\.OccupancyData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.occupancydata 'DiGi\.GIS\.Classes\.OccupancyData') items to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,int,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<OccupancyData\>, int, PostOptions\) Method

Asynchronously updates multiple building 2D occupancy data items for one explicitly identified county row via the Web API\.

For a county stored as several polygon parts, pass every part to the [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') overload instead - naming one part files the whole batch there whether or not the data belong to it.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.OccupancyData>? occupancyDatas, int countyId, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,int,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') instance used to create the HTTP client for the request\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,int,DiGi.WebAPI.Classes.PostOptions).occupancyDatas'></a>

`occupancyDatas` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.OccupancyData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.occupancydata 'DiGi\.GIS\.Classes\.OccupancyData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.GIS\.Classes\.OccupancyData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.occupancydata 'DiGi\.GIS\.Classes\.OccupancyData') items to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,int,DiGi.WebAPI.Classes.PostOptions).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county row the occupancy data belong to\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,int,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration settings for the HTTP POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,string,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<OccupancyData\>, string, PostOptions\) Method

Asynchronously updates multiple occupancy data items via the Web API\.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.OccupancyData>? occupancyDatas, string? code=null, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,string,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') instance used to create the HTTP client for the request\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,string,DiGi.WebAPI.Classes.PostOptions).occupancyDatas'></a>

`occupancyDatas` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.OccupancyData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.occupancydata 'DiGi\.GIS\.Classes\.OccupancyData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.GIS\.Classes\.OccupancyData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.occupancydata 'DiGi\.GIS\.Classes\.OccupancyData') items to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,string,DiGi.WebAPI.Classes.PostOptions).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional code associated with the update operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,string,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration settings for the HTTP POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<OccupancyData\>, IEnumerable\<int\>, PostOptions\) Method

Asynchronously updates multiple building 2D occupancy data items for an explicitly identified county row via the Web API\.

The counterpart of the `code` overload, for a caller that already holds the identifiers: a multi-part county holds one `administrative_areal_2d` row per polygon part, so pass every part rather than picking one - the server files each item under the part it belongs to.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.OccupancyData>? occupancyDatas, System.Collections.Generic.IEnumerable<int>? countyIds, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') instance used to create the HTTP client for the request\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).occupancyDatas'></a>

`occupancyDatas` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.OccupancyData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.occupancydata 'DiGi\.GIS\.Classes\.OccupancyData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.GIS\.Classes\.OccupancyData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.occupancydata 'DiGi\.GIS\.Classes\.OccupancyData') items to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).countyIds'></a>

`countyIds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The identifiers of the county rows the occupancy data belong to\. Normally every polygon part of one county\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OccupancyData_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration settings for the HTTP POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoDatas_,int,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<OrtoDatas\>, int, PostOptions\) Method

Updates multiple ortho data items for one explicitly identified county row\.

For a county stored as several polygon parts, pass every part to the [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') overload instead - naming one part files the whole batch there whether or not the data belong to it.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.OrtoDatas>? ortoDatas, int countyId, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoDatas_,int,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') instance used to perform the update operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoDatas_,int,DiGi.WebAPI.Classes.PostOptions).ortoDatas'></a>

`ortoDatas` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.OrtoDatas](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.ortodatas 'DiGi\.GIS\.Classes\.OrtoDatas')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [DiGi\.GIS\.Classes\.OrtoDatas](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.ortodatas 'DiGi\.GIS\.Classes\.OrtoDatas') items to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoDatas_,int,DiGi.WebAPI.Classes.PostOptions).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county row the items belong to\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoDatas_,int,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the HTTP POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoDatas_,string,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<OrtoDatas\>, string, PostOptions\) Method

Asynchronously updates multiple ortho data items via the PostgreSQL Web API\.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.OrtoDatas>? ortoDatas, string? code=null, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoDatas_,string,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') instance used to perform the update operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoDatas_,string,DiGi.WebAPI.Classes.PostOptions).ortoDatas'></a>

`ortoDatas` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.OrtoDatas](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.ortodatas 'DiGi\.GIS\.Classes\.OrtoDatas')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.GIS\.Classes\.OrtoDatas](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.ortodatas 'DiGi\.GIS\.Classes\.OrtoDatas') items to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoDatas_,string,DiGi.WebAPI.Classes.PostOptions).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional code used to identify or filter the items for updating\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoDatas_,string,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the update request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoDatas_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<OrtoDatas\>, IEnumerable\<int\>, PostOptions\) Method

Updates multiple ortho data items for a specific county\.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.OrtoDatas>? ortoDatas, System.Collections.Generic.IEnumerable<int>? countyIds, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoDatas_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') instance used to perform the update operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoDatas_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).ortoDatas'></a>

`ortoDatas` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.OrtoDatas](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.ortodatas 'DiGi\.GIS\.Classes\.OrtoDatas')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [DiGi\.GIS\.Classes\.OrtoDatas](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.ortodatas 'DiGi\.GIS\.Classes\.OrtoDatas') items to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoDatas_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).countyIds'></a>

`countyIds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The identifiers of the county rows the items belong to\. Normally every polygon part of one county\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.OrtoDatas_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the HTTP POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_,int,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<YearBuiltData\>, int, PostOptions\) Method

Asynchronously updates multiple year built data items for one explicitly identified county row via the PostgreSQL Web API\.

For a county stored as several polygon parts, pass every part to the [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') overload instead - naming one part files the whole batch there whether or not the data belong to it.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.YearBuiltData>? yearBuiltDatas, int countyId, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_,int,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The manager instance used to facilitate the web API communication\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_,int,DiGi.WebAPI.Classes.PostOptions).yearBuiltDatas'></a>

`yearBuiltDatas` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.YearBuiltData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.yearbuiltdata 'DiGi\.GIS\.Classes\.YearBuiltData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.GIS\.Classes\.YearBuiltData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.yearbuiltdata 'DiGi\.GIS\.Classes\.YearBuiltData') objects to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_,int,DiGi.WebAPI.Classes.PostOptions).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county row the year built data belong to\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_,int,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_,string,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<YearBuiltData\>, string, PostOptions\) Method

Asynchronously updates multiple year built data items via the PostgreSQL Web API\.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.YearBuiltData>? yearBuiltDatas, string? code=null, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_,string,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The manager instance used to facilitate the web API communication\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_,string,DiGi.WebAPI.Classes.PostOptions).yearBuiltDatas'></a>

`yearBuiltDatas` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.YearBuiltData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.yearbuiltdata 'DiGi\.GIS\.Classes\.YearBuiltData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.GIS\.Classes\.YearBuiltData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.yearbuiltdata 'DiGi\.GIS\.Classes\.YearBuiltData') objects to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_,string,DiGi.WebAPI.Classes.PostOptions).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

An optional code identifier for the update request\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_,string,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this GISWebAPIManager, IEnumerable\<YearBuiltData\>, IEnumerable\<int\>, PostOptions\) Method

Asynchronously updates multiple year built data items for an explicitly identified county row via the PostgreSQL Web API\.

The counterpart of the `code` overload, for a caller that already holds the identifiers: a multi-part county holds one `administrative_areal_2d` row per polygon part, so pass every part rather than picking one - the server files each item under the part it belongs to.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.YearBuiltData>? yearBuiltDatas, System.Collections.Generic.IEnumerable<int>? countyIds, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The manager instance used to facilitate the web API communication\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).yearBuiltDatas'></a>

`yearBuiltDatas` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.YearBuiltData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.yearbuiltdata 'DiGi\.GIS\.Classes\.YearBuiltData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.GIS\.Classes\.YearBuiltData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.yearbuiltdata 'DiGi\.GIS\.Classes\.YearBuiltData') objects to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).countyIds'></a>

`countyIds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The identifiers of the county rows the year built data belong to\. Normally every polygon part of one county\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisDiGi.GIS.WebAPI.Classes.GISWebAPIManager,System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.YearBuiltData_,System.Collections.Generic.IEnumerable_int_,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional configuration options for the POST request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisSystem.Net.Http.HttpClient,string,byte[],DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this HttpClient, string, byte\[\], PostOptions\) Method

Asynchronously updates items by sending an already\-serialized UTF\-8 JSON payload to the specified request URI\.

Preferred over the string overload on bulk paths: the payload never has to be materialized as a UTF-16 string and re-encoded back to UTF-8.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this System.Net.Http.HttpClient httpClient, string? requestUri, byte[]? utf8Json, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisSystem.Net.Http.HttpClient,string,byte[],DiGi.WebAPI.Classes.PostOptions).httpClient'></a>

`httpClient` [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient')

The [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient') used to perform the network request\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisSystem.Net.Http.HttpClient,string,byte[],DiGi.WebAPI.Classes.PostOptions).requestUri'></a>

`requestUri` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The target URI where the update request is sent\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisSystem.Net.Http.HttpClient,string,byte[],DiGi.WebAPI.Classes.PostOptions).utf8Json'></a>

`utf8Json` [System\.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System\.Byte')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The UTF\-8 encoded JSON payload containing the data to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisSystem.Net.Http.HttpClient,string,byte[],DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions') used to configure the operation, such as specifying a delay\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisSystem.Net.Http.HttpClient,string,string,DiGi.WebAPI.Classes.PostOptions)'></a>

## Modify\.UpdateItemsAsync\(this HttpClient, string, string, PostOptions\) Method

Asynchronously updates items by sending a JSON payload to the specified request URI\.

```csharp
public static System.Threading.Tasks.Task<bool> UpdateItemsAsync(this System.Net.Http.HttpClient httpClient, string? requestUri, string? json, DiGi.WebAPI.Classes.PostOptions? postOptions=null);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisSystem.Net.Http.HttpClient,string,string,DiGi.WebAPI.Classes.PostOptions).httpClient'></a>

`httpClient` [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient')

The [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient') used to perform the network request\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisSystem.Net.Http.HttpClient,string,string,DiGi.WebAPI.Classes.PostOptions).requestUri'></a>

`requestUri` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The target URI where the update request is sent\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisSystem.Net.Http.HttpClient,string,string,DiGi.WebAPI.Classes.PostOptions).json'></a>

`json` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The JSON string containing the data to be updated\.

<a name='DiGi.GIS.WebAPI.Modify.UpdateItemsAsync(thisSystem.Net.Http.HttpClient,string,string,DiGi.WebAPI.Classes.PostOptions).postOptions'></a>

`postOptions` [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions')

Optional [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions') used to configure the operation, such as specifying a delay\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Modify.Update_Id(thisDiGi.Core.IO.Table.Classes.Table,System.Collections.Generic.IEnumerable_DiGi.GIS.PostgreSQL.Classes.Building2DReference_)'></a>

## Modify\.Update\_Id\(this Table, IEnumerable\<Building2DReference\>\) Method

Updates the Id column of the table based on the provided building2DReferences\. If a matching row is found \(based on CountyId and Reference\), it updates the Id value\. If no matching row is found, it adds a new row with the CountyId, Reference, and Id values\.

```csharp
public static void Update_Id(this DiGi.Core.IO.Table.Classes.Table? table, System.Collections.Generic.IEnumerable<DiGi.GIS.PostgreSQL.Classes.Building2DReference>? building2DReferences);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Modify.Update_Id(thisDiGi.Core.IO.Table.Classes.Table,System.Collections.Generic.IEnumerable_DiGi.GIS.PostgreSQL.Classes.Building2DReference_).table'></a>

`table` [DiGi\.Core\.IO\.Table\.Classes\.Table](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.table.classes.table 'DiGi\.Core\.IO\.Table\.Classes\.Table')

The table to update

<a name='DiGi.GIS.WebAPI.Modify.Update_Id(thisDiGi.Core.IO.Table.Classes.Table,System.Collections.Generic.IEnumerable_DiGi.GIS.PostgreSQL.Classes.Building2DReference_).building2DReferences'></a>

`building2DReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.PostgreSQL\.Classes\.Building2DReference](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.building2dreference 'DiGi\.GIS\.PostgreSQL\.Classes\.Building2DReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The building2DReferences to use for updating

<a name='DiGi.GIS.WebAPI.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.GIS.WebAPI.Query.CountyIdsByReferencesAsync(thisDiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_int_)'></a>

## Query\.CountyIdsByReferencesAsync\(this Building2DPostgreSQLConverter, IEnumerable\<string\>, IEnumerable\<int\>\) Method

Reads which county row each reference belongs to, from the `building_2d` row that holds it\.

A county code names one `administrative_areal_2d` row per polygon part, so a code cannot say which part an item belongs to. The 2D building already answers that - it was filed by geometry when it was imported - and reading it back keeps every table keyed by the same `(county_id, reference)` pair. Filing a whole batch under one part instead is what left sibling parts reading back empty while the upload reported success.

The parts are probed in ascending order, one batched lookup each, and a reference is taken by the first part that holds it. A reference held by more than one part therefore resolves to the same one on every run.

A reference no part holds is simply absent from the result: nothing states where it belongs, and the caller decides whether to drop it or resolve it some other way.

```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string,int>> CountyIdsByReferencesAsync(this DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter? building2DPostgreSQLConverter, System.Collections.Generic.IEnumerable<string?>? references, System.Collections.Generic.IEnumerable<int>? countyIds);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Query.CountyIdsByReferencesAsync(thisDiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_int_).building2DPostgreSQLConverter'></a>

`building2DPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.Building2DPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.building2dpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.Building2DPostgreSQLConverter')

The converter used to look the references up\.

<a name='DiGi.GIS.WebAPI.Query.CountyIdsByReferencesAsync(thisDiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_int_).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The references to resolve\.

<a name='DiGi.GIS.WebAPI.Query.CountyIdsByReferencesAsync(thisDiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_int_).countyIds'></a>

`countyIds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The candidate county rows, normally every polygon part of one code\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The identifier of the county row holding each reference\. Empty when nothing could be resolved\.

<a name='DiGi.GIS.WebAPI.Query.RejectionSample(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.WebAPI.Classes.UpdateItemsResult.Rejection_,int)'></a>

## Query\.RejectionSample\(this IEnumerable\<Rejection\>, int\) Method

Renders the first rejections of a write as a readable log fragment\.

A count alone does not say what to do about a shortfall - the references identify the rows to repost, and the reason says whether reposting them unchanged would achieve anything.

```csharp
public static string RejectionSample(this System.Collections.Generic.IEnumerable<DiGi.GIS.WebAPI.Classes.UpdateItemsResult.Rejection>? rejections, int count=20);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Query.RejectionSample(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.WebAPI.Classes.UpdateItemsResult.Rejection_,int).rejections'></a>

`rejections` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Rejection](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.UpdateItemsResult.Rejection 'DiGi\.GIS\.WebAPI\.Classes\.UpdateItemsResult\.Rejection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The rejections to render; may be null\.

<a name='DiGi.GIS.WebAPI.Query.RejectionSample(thisSystem.Collections.Generic.IEnumerable_DiGi.GIS.WebAPI.Classes.UpdateItemsResult.Rejection_,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of rejections to include\. Defaults to 20\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A comma\-separated list of `reference (reason)` entries, empty when there is nothing to render\.