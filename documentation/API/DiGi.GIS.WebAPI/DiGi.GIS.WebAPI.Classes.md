#### [DiGi\.GIS\.WebAPI](DiGi.GIS.WebAPI.Overview.md 'DiGi\.GIS\.WebAPI\.Overview')

## DiGi\.GIS\.WebAPI\.Classes Namespace
### Classes

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController'></a>

## AdministrativeAreal2DController Class

Web API controller for administrative area 2D operations, providing endpoints to retrieve, filter, and update administrative area data\.

```csharp
public class AdministrativeAreal2DController : DiGi.WebAPI.Classes.WebAPIController
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Microsoft\.AspNetCore\.Mvc\.ControllerBase](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase 'Microsoft\.AspNetCore\.Mvc\.ControllerBase') → [DiGi\.WebAPI\.Classes\.WebAPIController](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.webapicontroller 'DiGi\.WebAPI\.Classes\.WebAPIController') → AdministrativeAreal2DController
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.AdministrativeAreal2DController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter)'></a>

## AdministrativeAreal2DController\(GISWebAPIConfigurationFileWatcher, AdministrativeAreal2DPostgreSQLConverter\) Constructor

Initializes a new instance of the [AdministrativeAreal2DController](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController 'DiGi\.GIS\.WebAPI\.Classes\.AdministrativeAreal2DController') class\.

```csharp
public AdministrativeAreal2DController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher GISWebAPIConfigurationFileWatcher, DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter administrativeAreal2DPostgreSQLConverter);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.AdministrativeAreal2DController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).GISWebAPIConfigurationFileWatcher'></a>

`GISWebAPIConfigurationFileWatcher` [GISWebAPIConfigurationFileWatcher](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIConfigurationFileWatcher')

The configuration file watcher for the GIS PostgreSQL Web API\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.AdministrativeAreal2DController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).administrativeAreal2DPostgreSQLConverter'></a>

`administrativeAreal2DPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.AdministrativeAreal2DPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.administrativeareal2dpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.AdministrativeAreal2DPostgreSQLConverter')

The converter used for administrative area 2D PostgreSQL operations\.
### Methods

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferenceByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetAdministrativeAreal2DReferenceByCodeAsync\(string, Nullable\<AdministrativeArealType\>, CancellationToken\) Method

Gets an administrative area reference by its code and type\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetAdministrativeAreal2DReferenceByCodeAsync(string? code, System.Nullable<DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType> administrativeArealType, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferenceByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique code of the administrative area\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferenceByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).administrativeArealType'></a>

`administrativeArealType` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.administrativearealtype 'DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The type of the administrative area\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferenceByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferenceByIdAsync(int,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetAdministrativeAreal2DReferenceByIdAsync\(int, CancellationToken\) Method

Retrieves an administrative area reference by its identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetAdministrativeAreal2DReferenceByIdAsync(int id, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferenceByIdAsync(int,System.Threading.CancellationToken).id'></a>

`id` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The unique identifier of the administrative area reference to retrieve\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferenceByIdAsync(int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencePathByIdAsync(int,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetAdministrativeAreal2DReferencePathByIdAsync\(int, CancellationToken\) Method

Retrieves the administrative area reference path by its identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetAdministrativeAreal2DReferencePathByIdAsync(int id, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencePathByIdAsync(int,System.Threading.CancellationToken).id'></a>

`id` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The unique identifier of the administrative area reference path to retrieve\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencePathByIdAsync(int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencePathsByNameAsync(string,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetAdministrativeAreal2DReferencePathsByNameAsync\(string, CancellationToken\) Method

Retrieves administrative area reference paths by name\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetAdministrativeAreal2DReferencePathsByNameAsync(string text, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencePathsByNameAsync(string,System.Threading.CancellationToken).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The search text used to find matching administrative area reference paths\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencePathsByNameAsync(string,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencePathsByNameParameterAsync(DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencePathsByNameParameter,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetAdministrativeAreal2DReferencePathsByNameParameterAsync\(AdministrativeAreal2DReferencePathsByNameParameter, CancellationToken\) Method

Retrieves administrative area reference paths by name parameter\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetAdministrativeAreal2DReferencePathsByNameParameterAsync(DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencePathsByNameParameter administrativeAreal2DReferencePathsByNameParameter, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencePathsByNameParameterAsync(DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencePathsByNameParameter,System.Threading.CancellationToken).administrativeAreal2DReferencePathsByNameParameter'></a>

`administrativeAreal2DReferencePathsByNameParameter` [AdministrativeAreal2DReferencePathsByNameParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencePathsByNameParameter 'DiGi\.GIS\.WebAPI\.Classes\.AdministrativeAreal2DReferencePathsByNameParameter')

The parameter containing the search term for querying administrative areas by name\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencePathsByNameParameterAsync(DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencePathsByNameParameter,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencesByAdministrativeArealTypeAsync(System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Nullable_int_,System.Nullable_bool_,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetAdministrativeAreal2DReferencesByAdministrativeArealTypeAsync\(Nullable\<AdministrativeArealType\>, Nullable\<int\>, Nullable\<bool\>, CancellationToken\) Method

Retrieves all administrative area references filtered by administrative area type\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetAdministrativeAreal2DReferencesByAdministrativeArealTypeAsync(System.Nullable<DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType> administrativeArealType, System.Nullable<int> parentId, System.Nullable<bool> uniqueCode, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencesByAdministrativeArealTypeAsync(System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Nullable_int_,System.Nullable_bool_,System.Threading.CancellationToken).administrativeArealType'></a>

`administrativeArealType` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.administrativearealtype 'DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The administrative area type used to filter the references\. Bound as nullable so an omitted parameter can be rejected: a non\-nullable binding would silently take [DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType\.Country](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.administrativearealtype.country 'DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType\.Country'), because that is `default` of the enum while [DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType\.Undefined](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.administrativearealtype.undefined 'DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType\.Undefined') is \-1\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencesByAdministrativeArealTypeAsync(System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Nullable_int_,System.Nullable_bool_,System.Threading.CancellationToken).parentId'></a>

`parentId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional parent identifier used for filtering\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencesByAdministrativeArealTypeAsync(System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Nullable_int_,System.Nullable_bool_,System.Threading.CancellationToken).uniqueCode'></a>

`uniqueCode` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional flag indicating whether to filter by unique code\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencesByAdministrativeArealTypeAsync(System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Nullable_int_,System.Nullable_bool_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencesByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetAdministrativeAreal2DReferencesByCodeAsync\(string, Nullable\<AdministrativeArealType\>, CancellationToken\) Method

Retrieves administrative area references by their code\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetAdministrativeAreal2DReferencesByCodeAsync(string code, System.Nullable<DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType> administrativeArealType, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencesByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier or code used to retrieve the administrative area references\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencesByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).administrativeArealType'></a>

`administrativeArealType` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.administrativearealtype 'DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional filter specifying the type of administrative area\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencesByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencesByIdsAsync(System.Collections.Generic.List_int_,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetAdministrativeAreal2DReferencesByIdsAsync\(List\<int\>, CancellationToken\) Method

Retrieves administrative area references by a list of identifiers\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetAdministrativeAreal2DReferencesByIdsAsync(System.Collections.Generic.List<int> ids, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencesByIdsAsync(System.Collections.Generic.List_int_,System.Threading.CancellationToken).ids'></a>

`ids` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list of unique identifiers of the administrative areas to retrieve\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencesByIdsAsync(System.Collections.Generic.List_int_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencesByNameParameterAsync(DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencesByNameParameter,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetAdministrativeAreal2DReferencesByNameParameterAsync\(AdministrativeAreal2DReferencesByNameParameter, CancellationToken\) Method

Retrieves administrative area references by name parameter\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetAdministrativeAreal2DReferencesByNameParameterAsync(DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencesByNameParameter administrativeAreal2DReferencesByNameParameter, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencesByNameParameterAsync(DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencesByNameParameter,System.Threading.CancellationToken).administrativeAreal2DReferencesByNameParameter'></a>

`administrativeAreal2DReferencesByNameParameter` [AdministrativeAreal2DReferencesByNameParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencesByNameParameter 'DiGi\.GIS\.WebAPI\.Classes\.AdministrativeAreal2DReferencesByNameParameter')

The parameter containing the search term for querying administrative area references by name\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetAdministrativeAreal2DReferencesByNameParameterAsync(DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencesByNameParameter,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetBoundingBox2DAsync(System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetBoundingBox2DAsync\(CancellationToken\) Method

Asynchronously retrieves the 2D bounding box enclosing country administrative areas\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetBoundingBox2DAsync(System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetBoundingBox2DAsync(System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the called method to indicate that the operation should be canceled\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetCodesAsync()'></a>

## AdministrativeAreal2DController\.GetCodesAsync\(\) Method

Retrieves all available administrative area codes\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetCodesAsync();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetCountAsync(System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetCountAsync\(CancellationToken\) Method

Retrieves the count of administrative areas\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetCountAsync(System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetCountAsync(System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetIdByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetIdByCodeAsync\(string, Nullable\<AdministrativeArealType\>, CancellationToken\) Method

Retrieves the identifier for a given code\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetIdByCodeAsync(string code, System.Nullable<DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType> administrativeArealType, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetIdByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique code of the administrative area\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetIdByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).administrativeArealType'></a>

`administrativeArealType` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.administrativearealtype 'DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional type of the administrative area to filter the search\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetIdByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetIdsByAdministrativeArealTypeAsync(System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetIdsByAdministrativeArealTypeAsync\(Nullable\<AdministrativeArealType\>, CancellationToken\) Method

Retrieves all identifiers for a given administrative area type\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetIdsByAdministrativeArealTypeAsync(System.Nullable<DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType> administrativeArealType, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetIdsByAdministrativeArealTypeAsync(System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).administrativeArealType'></a>

`administrativeArealType` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.administrativearealtype 'DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The administrative area type\. Bound as nullable so an omitted parameter can be rejected: a non\-nullable binding would silently take [DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType\.Country](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.administrativearealtype.country 'DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType\.Country'), because that is `default` of the enum while [DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType\.Undefined](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.administrativearealtype.undefined 'DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType\.Undefined') is \-1\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetIdsByAdministrativeArealTypeAsync(System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetIdsByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetIdsByCodeAsync\(string, Nullable\<AdministrativeArealType\>, CancellationToken\) Method

Retrieves all identifiers for a given code\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetIdsByCodeAsync(string code, System.Nullable<DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType> administrativeArealType, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetIdsByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The code of the administrative area\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetIdsByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).administrativeArealType'></a>

`administrativeArealType` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.administrativearealtype 'DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional type of the administrative area to filter the search\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetIdsByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetItemByCodeAsync\(string, Nullable\<AdministrativeArealType\>, CancellationToken\) Method

Retrieves an administrative area item by its code and optional type\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemByCodeAsync(string code, System.Nullable<DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType> administrativeArealType, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique code of the administrative area to retrieve\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).administrativeArealType'></a>

`administrativeArealType` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.administrativearealtype 'DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional type of the administrative area to filter the search\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemByIdAsync(int,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetItemByIdAsync\(int, CancellationToken\) Method

Asynchronously retrieves an administrative area item by its unique identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemByIdAsync(int id, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemByIdAsync(int,System.Threading.CancellationToken).id'></a>

`id` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer identifier of the administrative area item to retrieve\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemByIdAsync(int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByAdministrativeArealTypeAsync(System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetItemsByAdministrativeArealTypeAsync\(Nullable\<AdministrativeArealType\>, CancellationToken\) Method

Retrieves all administrative area items filtered by administrative area type\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemsByAdministrativeArealTypeAsync(System.Nullable<DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType> administrativeArealType, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByAdministrativeArealTypeAsync(System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).administrativeArealType'></a>

`administrativeArealType` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.administrativearealtype 'DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The administrative area type used to filter the results\. Bound as nullable so an omitted parameter can be rejected: a non\-nullable binding would silently take [DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType\.Country](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.administrativearealtype.country 'DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType\.Country'), because that is `default` of the enum while [DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType\.Undefined](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.administrativearealtype.undefined 'DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType\.Undefined') is \-1\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByAdministrativeArealTypeAsync(System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetItemsByBoundingBoxAsync\(double, double, double, double, Nullable\<double\>, Nullable\<AdministrativeArealType\>, CancellationToken\) Method

Retrieves administrative area items within a specified bounding box\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemsByBoundingBoxAsync(double x_1, double y_1, double x_2, double y_2, System.Nullable<double> tolerance, System.Nullable<DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType> administrativeArealType, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).x_1'></a>

`x_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X\-coordinate of the first corner of the bounding box\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).y_1'></a>

`y_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y\-coordinate of the first corner of the bounding box\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).x_2'></a>

`x_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X\-coordinate of the second corner of the bounding box\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).y_2'></a>

`y_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y\-coordinate of the second corner of the bounding box\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).tolerance'></a>

`tolerance` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional tolerance value for the spatial query\. If not provided, a default macro distance is used\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).administrativeArealType'></a>

`administrativeArealType` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.administrativearealtype 'DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional filter to restrict results to a specific type of administrative area\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetItemsByCircleAsync\(double, double, Nullable\<double\>, Nullable\<double\>, Nullable\<double\>, Nullable\<AdministrativeArealType\>, CancellationToken\) Method

Retrieves administrative area items within a specified circle\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemsByCircleAsync(double x, double y, System.Nullable<double> radius, System.Nullable<double> diameter, System.Nullable<double> tolerance, System.Nullable<DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType> administrativeArealType, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X\-coordinate of the center point of the search circle\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y\-coordinate of the center point of the search circle\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).radius'></a>

`radius` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The radius of the search circle\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).diameter'></a>

`diameter` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The diameter of the search circle\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).tolerance'></a>

`tolerance` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The tolerance value for the spatial query\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).administrativeArealType'></a>

`administrativeArealType` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.administrativearealtype 'DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The type of administrative area to retrieve\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') containing a list of administrative area items if found, or an error response\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetItemsByCodeAsync\(string, Nullable\<AdministrativeArealType\>, CancellationToken\) Method

Retrieves administrative area items filtered by code\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemsByCodeAsync(string code, System.Nullable<DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType> administrativeArealType, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The code used to filter the administrative area items\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).administrativeArealType'></a>

`administrativeArealType` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.administrativearealtype 'DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional type of administrative area to filter by\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByCodeAsync(string,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') containing a list of matching administrative area items, or an error response if the code is invalid or no items are found\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByCodesAsync(System.Collections.Generic.List_string_,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetItemsByCodesAsync\(List\<string\>, CancellationToken\) Method

Retrieves administrative area items filtered by multiple codes\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemsByCodesAsync(System.Collections.Generic.List<string> codes, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByCodesAsync(System.Collections.Generic.List_string_,System.Threading.CancellationToken).codes'></a>

`codes` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list of codes used to filter the administrative area items\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByCodesAsync(System.Collections.Generic.List_string_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByIdsAsync(System.Collections.Generic.List_int_,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetItemsByIdsAsync\(List\<int\>, CancellationToken\) Method

Retrieves administrative area items filtered by a list of identifiers\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemsByIdsAsync(System.Collections.Generic.List<int> ids, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByIdsAsync(System.Collections.Generic.List_int_,System.Threading.CancellationToken).ids'></a>

`ids` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The list of identifiers used to retrieve the administrative area items\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByIdsAsync(System.Collections.Generic.List_int_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByPointAsync(double,double,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetItemsByPointAsync\(double, double, Nullable\<double\>, Nullable\<AdministrativeArealType\>, CancellationToken\) Method

Retrieves administrative area items at or near a specified point\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemsByPointAsync(double x, double y, System.Nullable<double> tolerance, System.Nullable<DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType> administrativeArealType, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByPointAsync(double,double,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X\-coordinate of the search point\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByPointAsync(double,double,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y\-coordinate of the search point\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByPointAsync(double,double,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).tolerance'></a>

`tolerance` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional tolerance distance to use when searching for items near the specified point\. If null, a default macro distance is used\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByPointAsync(double,double,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).administrativeArealType'></a>

`administrativeArealType` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.administrativearealtype 'DiGi\.GIS\.PostgreSQL\.Enums\.AdministrativeArealType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional type filter for the administrative area items to be retrieved\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetItemsByPointAsync(double,double,System.Nullable_double_,System.Nullable_DiGi.GIS.PostgreSQL.Enums.AdministrativeArealType_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetSubCodesAsync(string,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.GetSubCodesAsync\(string, CancellationToken\) Method

Retrieves subcodes for a given code\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetSubCodesAsync(string code, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetSubCodesAsync(string,System.Threading.CancellationToken).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The administrative area code used to retrieve the associated subcodes\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.GetSubCodesAsync(string,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.UpdateItemAsync(System.Text.Json.Nodes.JsonObject,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.UpdateItemAsync\(JsonObject, CancellationToken\) Method

Updates a single administrative area item\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateItemAsync(System.Text.Json.Nodes.JsonObject? jsonObject, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.UpdateItemAsync(System.Text.Json.Nodes.JsonObject,System.Threading.CancellationToken).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to update the administrative area item\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.UpdateItemAsync(System.Text.Json.Nodes.JsonObject,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,System.Threading.CancellationToken)'></a>

## AdministrativeAreal2DController\.UpdateItemsAsync\(JsonArray, CancellationToken\) Method

Updates multiple administrative area items\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateItemsAsync(System.Text.Json.Nodes.JsonArray? jsonArray, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,System.Threading.CancellationToken).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The JSON array containing the administrative area items to be updated\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by other objects or threads to receive notice of cancellation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencePathsByNameParameter'></a>

## AdministrativeAreal2DReferencePathsByNameParameter Class

Represents a parameter containing text for querying administrative area reference paths\.

```csharp
public class AdministrativeAreal2DReferencePathsByNameParameter : DiGi.WebAPI.Classes.Parameter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.WebAPI\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.parameter 'DiGi\.WebAPI\.Classes\.Parameter') → AdministrativeAreal2DReferencePathsByNameParameter
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencePathsByNameParameter.AdministrativeAreal2DReferencePathsByNameParameter()'></a>

## AdministrativeAreal2DReferencePathsByNameParameter\(\) Constructor

Initializes a new instance of the [AdministrativeAreal2DReferencePathsByNameParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencePathsByNameParameter 'DiGi\.GIS\.WebAPI\.Classes\.AdministrativeAreal2DReferencePathsByNameParameter') class\.

```csharp
public AdministrativeAreal2DReferencePathsByNameParameter();
```

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencePathsByNameParameter.AdministrativeAreal2DReferencePathsByNameParameter(string)'></a>

## AdministrativeAreal2DReferencePathsByNameParameter\(string\) Constructor

Initializes a new instance of the [AdministrativeAreal2DReferencePathsByNameParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencePathsByNameParameter 'DiGi\.GIS\.WebAPI\.Classes\.AdministrativeAreal2DReferencePathsByNameParameter') class with the specified text \(search phrase\)\.

```csharp
public AdministrativeAreal2DReferencePathsByNameParameter(string text);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencePathsByNameParameter.AdministrativeAreal2DReferencePathsByNameParameter(string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The text to search for\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencePathsByNameParameter.AdministrativeAreal2DReferencePathsByNameParameter(System.Text.Json.Nodes.JsonObject)'></a>

## AdministrativeAreal2DReferencePathsByNameParameter\(JsonObject\) Constructor

Initializes a new instance of the [AdministrativeAreal2DReferencePathsByNameParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencePathsByNameParameter 'DiGi\.GIS\.WebAPI\.Classes\.AdministrativeAreal2DReferencePathsByNameParameter') class using an [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') object\.

```csharp
public AdministrativeAreal2DReferencePathsByNameParameter(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencePathsByNameParameter.AdministrativeAreal2DReferencePathsByNameParameter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the parameter values\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencePathsByNameParameter.Text'></a>

## AdministrativeAreal2DReferencePathsByNameParameter\.Text Property

Text to search for in the names of the administrative areal 2D reference paths\. The search is case\-insensitive and matches any path whose name contains the specified text\.

```csharp
public string? Text { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencesByNameParameter'></a>

## AdministrativeAreal2DReferencesByNameParameter Class

Represents a parameter containing text for querying administrative area references\.

```csharp
public class AdministrativeAreal2DReferencesByNameParameter : DiGi.WebAPI.Classes.Parameter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.WebAPI\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.parameter 'DiGi\.WebAPI\.Classes\.Parameter') → AdministrativeAreal2DReferencesByNameParameter
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencesByNameParameter.AdministrativeAreal2DReferencesByNameParameter()'></a>

## AdministrativeAreal2DReferencesByNameParameter\(\) Constructor

Initializes a new instance of the [AdministrativeAreal2DReferencesByNameParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencesByNameParameter 'DiGi\.GIS\.WebAPI\.Classes\.AdministrativeAreal2DReferencesByNameParameter') class\.

```csharp
public AdministrativeAreal2DReferencesByNameParameter();
```

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencesByNameParameter.AdministrativeAreal2DReferencesByNameParameter(string)'></a>

## AdministrativeAreal2DReferencesByNameParameter\(string\) Constructor

Initializes a new instance of the [AdministrativeAreal2DReferencesByNameParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencesByNameParameter 'DiGi\.GIS\.WebAPI\.Classes\.AdministrativeAreal2DReferencesByNameParameter') class with the specified text\.

```csharp
public AdministrativeAreal2DReferencesByNameParameter(string text);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencesByNameParameter.AdministrativeAreal2DReferencesByNameParameter(string).text'></a>

`text` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The text to search for\.

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencesByNameParameter.AdministrativeAreal2DReferencesByNameParameter(System.Text.Json.Nodes.JsonObject)'></a>

## AdministrativeAreal2DReferencesByNameParameter\(JsonObject\) Constructor

Initializes a new instance of the [AdministrativeAreal2DReferencesByNameParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencesByNameParameter 'DiGi\.GIS\.WebAPI\.Classes\.AdministrativeAreal2DReferencesByNameParameter') class using a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') instance\.

```csharp
public AdministrativeAreal2DReferencesByNameParameter(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencesByNameParameter.AdministrativeAreal2DReferencesByNameParameter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the parameter values\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DReferencesByNameParameter.Text'></a>

## AdministrativeAreal2DReferencesByNameParameter\.Text Property

Gets or sets the text to search for in the names of administrative areal 2D references\.

```csharp
public string? Text { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DsPostTask'></a>

## AdministrativeAreal2DsPostTask Class

Provides functionality to asynchronously post a collection of [DiGi\.GIS\.Classes\.AdministrativeAreal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.administrativeareal2d 'DiGi\.GIS\.Classes\.AdministrativeAreal2D') objects to the PostgreSQL database\.

```csharp
public class AdministrativeAreal2DsPostTask : DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask<DiGi.GIS.Classes.AdministrativeAreal2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.BackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.backgroundtask 'DiGi\.Core\.Classes\.BackgroundTask') → [DiGi\.Core\.Classes\.CancelableBackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cancelablebackgroundtask 'DiGi\.Core\.Classes\.CancelableBackgroundTask') → [DiGi\.Core\.Classes\.ReportableBackgroundTask&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1') → [DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask&lt;](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_ 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>')[DiGi\.GIS\.Classes\.AdministrativeAreal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.administrativeareal2d 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[&gt;](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_ 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>') → AdministrativeAreal2DsPostTask
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DsPostTask.AdministrativeAreal2DsPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager)'></a>

## AdministrativeAreal2DsPostTask\(GISWebAPIManager\) Constructor

Initializes a new instance of the AdministrativeAreal2DsPostTask class\.

```csharp
public AdministrativeAreal2DsPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager GISWebAPIManager);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DsPostTask.AdministrativeAreal2DsPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The GIS PostgreSQL Web API manager used to handle database operations\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController'></a>

## Building2DController Class

Web API controller for building 2D operations, providing endpoints to retrieve, filter, and update building 2D data\.

```csharp
public class Building2DController : DiGi.WebAPI.Classes.WebAPIController
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Microsoft\.AspNetCore\.Mvc\.ControllerBase](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase 'Microsoft\.AspNetCore\.Mvc\.ControllerBase') → [DiGi\.WebAPI\.Classes\.WebAPIController](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.webapicontroller 'DiGi\.WebAPI\.Classes\.WebAPIController') → Building2DController
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.Building2DController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter)'></a>

## Building2DController\(GISWebAPIConfigurationFileWatcher, Building2DPostgreSQLConverter, AdministrativeAreal2DPostgreSQLConverter\) Constructor

Initializes a new instance of the [Building2DController](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.Building2DController 'DiGi\.GIS\.WebAPI\.Classes\.Building2DController') class\.

```csharp
public Building2DController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher GISWebAPIConfigurationFileWatcher, DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter building2DPostgreSQLConverter, DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter administrativeAreal2DPostgreSQLConverter);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.Building2DController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).GISWebAPIConfigurationFileWatcher'></a>

`GISWebAPIConfigurationFileWatcher` [GISWebAPIConfigurationFileWatcher](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIConfigurationFileWatcher')

The configuration file watcher for the GIS PostgreSQL Web API\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.Building2DController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).building2DPostgreSQLConverter'></a>

`building2DPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.Building2DPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.building2dpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.Building2DPostgreSQLConverter')

The converter used for Building 2D data operations in PostgreSQL\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.Building2DController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).administrativeAreal2DPostgreSQLConverter'></a>

`administrativeAreal2DPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.AdministrativeAreal2DPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.administrativeareal2dpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.AdministrativeAreal2DPostgreSQLConverter')

The converter used to resolve administrative area codes to county identifiers\.
### Methods

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.CountAsync(DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter,System.Threading.CancellationToken)'></a>

## Building2DController\.CountAsync\(CountByAdministrativeAreal2DIdsParameter, CancellationToken\) Method

Asynchronously counts the number of buildings based on the administrative areal 2D identifiers\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> CountAsync(DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter countByAdministrativeAreal2DIdsParameter, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.CountAsync(DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter,System.Threading.CancellationToken).countByAdministrativeAreal2DIdsParameter'></a>

`countByAdministrativeAreal2DIdsParameter` [CountByAdministrativeAreal2DIdsParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter 'DiGi\.GIS\.WebAPI\.Classes\.CountByAdministrativeAreal2DIdsParameter')

The parameter object containing the collection of administrative areal 2D identifiers\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.CountAsync(DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetBuilding2DReferenceByIdAsync(long,System.Nullable_int_,System.Threading.CancellationToken)'></a>

## Building2DController\.GetBuilding2DReferenceByIdAsync\(long, Nullable\<int\>, CancellationToken\) Method

Asynchronously retrieves a building 2D reference by its unique identifier and an optional county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetBuilding2DReferenceByIdAsync(long id, System.Nullable<int> countyId, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetBuilding2DReferenceByIdAsync(long,System.Nullable_int_,System.Threading.CancellationToken).id'></a>

`id` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The unique identifier of the building\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetBuilding2DReferenceByIdAsync(long,System.Nullable_int_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional integer representing the county identifier used to filter the search\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetBuilding2DReferenceByIdAsync(long,System.Nullable_int_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetBuilding2DReferenceByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken)'></a>

## Building2DController\.GetBuilding2DReferenceByReferenceAsync\(string, Nullable\<int\>, CancellationToken\) Method

Retrieves a building 2D reference by its unique reference code and an optional county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetBuilding2DReferenceByReferenceAsync(string reference, System.Nullable<int> countyId, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetBuilding2DReferenceByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique reference string of the building to retrieve\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetBuilding2DReferenceByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional integer identifier of the county used to filter the search\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetBuilding2DReferenceByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetBuilding2DReferencesByAdministrativeAreal2DIdAsync(int,System.Threading.CancellationToken)'></a>

## Building2DController\.GetBuilding2DReferencesByAdministrativeAreal2DIdAsync\(int, CancellationToken\) Method

Retrieves building 2D references filtered by administrative area 2D identifier\. Can be used for relatively small number of buildings

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetBuilding2DReferencesByAdministrativeAreal2DIdAsync(int administrativeAreal2DId, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetBuilding2DReferencesByAdministrativeAreal2DIdAsync(int,System.Threading.CancellationToken).administrativeAreal2DId'></a>

`administrativeAreal2DId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The unique identifier of the administrative area 2D used to filter the building references\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetBuilding2DReferencesByAdministrativeAreal2DIdAsync(int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetBuilding2DReferencesByPagingParameterAsync(DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter,System.Threading.CancellationToken)'></a>

## Building2DController\.GetBuilding2DReferencesByPagingParameterAsync\(Building2DReferencesByPagingParameter, CancellationToken\) Method

Retrieves a paginated list of building 2D references\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetBuilding2DReferencesByPagingParameterAsync(DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter building2DReferencesByPagingParameter, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetBuilding2DReferencesByPagingParameterAsync(DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter,System.Threading.CancellationToken).building2DReferencesByPagingParameter'></a>

`building2DReferencesByPagingParameter` [Building2DReferencesByPagingParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter 'DiGi\.GIS\.WebAPI\.Classes\.Building2DReferencesByPagingParameter')

The parameter containing paging options, including county identifier, cursor, and page size\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetBuilding2DReferencesByPagingParameterAsync(DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task representing the asynchronous operation, returning a list of building 2D references\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemByIdAsync(long,System.Nullable_int_,System.Threading.CancellationToken)'></a>

## Building2DController\.GetItemByIdAsync\(long, Nullable\<int\>, CancellationToken\) Method

Retrieves a building 2D item by its identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemByIdAsync(long id, System.Nullable<int> countyId, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemByIdAsync(long,System.Nullable_int_,System.Threading.CancellationToken).id'></a>

`id` [System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')

The unique identifier of the building 2D item to retrieve\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemByIdAsync(long,System.Nullable_int_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional county identifier associated with the building\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemByIdAsync(long,System.Nullable_int_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemByPointAsync(double,double,System.Nullable_double_,System.Threading.CancellationToken)'></a>

## Building2DController\.GetItemByPointAsync\(double, double, Nullable\<double\>, CancellationToken\) Method

Retrieves a building 2D item at or near a specified point\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemByPointAsync(double x, double y, System.Nullable<double> tolerance, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemByPointAsync(double,double,System.Nullable_double_,System.Threading.CancellationToken).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the search point\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemByPointAsync(double,double,System.Nullable_double_,System.Threading.CancellationToken).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the search point\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemByPointAsync(double,double,System.Nullable_double_,System.Threading.CancellationToken).tolerance'></a>

`tolerance` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional tolerance distance in meters to use when searching for the item near the specified point\. If not provided, NaN, or non\-positive, a default tolerance of 0\.5 meters is used\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemByPointAsync(double,double,System.Nullable_double_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') containing the building 2D item if found, or an error response\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken)'></a>

## Building2DController\.GetItemByReferenceAsync\(string, Nullable\<int\>, CancellationToken\) Method

Asynchronously retrieves a building 2D item by its reference code and an optional county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemByReferenceAsync(string reference, System.Nullable<int> countyId, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique reference string used to locate the building 2D item\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional identifier of the county associated with the building\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Threading.CancellationToken)'></a>

## Building2DController\.GetItemsByBoundingBoxAsync\(double, double, double, double, Nullable\<double\>, CancellationToken\) Method

Retrieves building 2D items within a specified bounding box\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemsByBoundingBoxAsync(double x_1, double y_1, double x_2, double y_2, System.Nullable<double> tolerance, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Threading.CancellationToken).x_1'></a>

`x_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X\-coordinate of the first corner of the bounding box\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Threading.CancellationToken).y_1'></a>

`y_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y\-coordinate of the first corner of the bounding box\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Threading.CancellationToken).x_2'></a>

`x_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X\-coordinate of the second corner of the bounding box\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Threading.CancellationToken).y_2'></a>

`y_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y\-coordinate of the second corner of the bounding box\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Threading.CancellationToken).tolerance'></a>

`tolerance` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional tolerance value for the spatial query\. If not provided or NaN, a default macro distance is used\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByBuilding2DReferencesAsync(System.Text.Json.Nodes.JsonArray,System.Threading.CancellationToken)'></a>

## Building2DController\.GetItemsByBuilding2DReferencesAsync\(JsonArray, CancellationToken\) Method

Retrieves building 2D items by their references\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemsByBuilding2DReferencesAsync(System.Text.Json.Nodes.JsonArray? jsonArray, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByBuilding2DReferencesAsync(System.Text.Json.Nodes.JsonArray,System.Threading.CancellationToken).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The JSON array containing the building 2D references to retrieve\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByBuilding2DReferencesAsync(System.Text.Json.Nodes.JsonArray,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken)'></a>

## Building2DController\.GetItemsByCircleAsync\(double, double, Nullable\<double\>, Nullable\<double\>, Nullable\<double\>, CancellationToken\) Method

Retrieves building 2D items within a specified circle\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemsByCircleAsync(double x, double y, System.Nullable<double> radius, System.Nullable<double> diameter, System.Nullable<double> tolerance, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X\-coordinate of the center of the circle\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y\-coordinate of the center of the circle\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).radius'></a>

`radius` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The radius of the search circle\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).diameter'></a>

`diameter` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The diameter of the search circle\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).tolerance'></a>

`tolerance` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The tolerance value to be applied to the search area\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByCountyIdAsync(int,System.Threading.CancellationToken)'></a>

## Building2DController\.GetItemsByCountyIdAsync\(int, CancellationToken\) Method

Retrieves building 2D items for a specified county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemsByCountyIdAsync(int countyId, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByCountyIdAsync(int,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The unique identifier of the county\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByCountyIdAsync(int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result contains the building 2D items as a JSON response, or a 404 status if no items are found\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,System.Threading.CancellationToken)'></a>

## Building2DController\.GetItemsByReferencesAsync\(IEnumerable\<string\>, Nullable\<int\>, CancellationToken\) Method

Asynchronously retrieves building 2D items for each of the provided references and an optional county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemsByReferencesAsync(System.Collections.Generic.IEnumerable<string>? references, System.Nullable<int> countyId, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,System.Threading.CancellationToken).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique reference strings used to identify the 2D buildings\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional integer representing the county ID to filter the results\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetItemsByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task representing the asynchronous operation, returning a list of building 2D items\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetPoint2DsByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,System.Threading.CancellationToken)'></a>

## Building2DController\.GetPoint2DsByReferencesAsync\(IEnumerable\<string\>, Nullable\<int\>, CancellationToken\) Method

Retrieves Point2D coordinates by their references\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetPoint2DsByReferencesAsync(System.Collections.Generic.IEnumerable<string>? references, System.Nullable<int> countyId, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetPoint2DsByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,System.Threading.CancellationToken).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of reference strings used to identify the Point2D objects\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetPoint2DsByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional identifier for the county associated with the coordinates\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetPoint2DsByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetReferenceDuplicatesAsync(int,int,System.Threading.CancellationToken)'></a>

## Building2DController\.GetReferenceDuplicatesAsync\(int, int, CancellationToken\) Method

Asynchronously retrieves duplicate building references that occur across multiple counties, ordered by collision count descending\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetReferenceDuplicatesAsync(int limit=100, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetReferenceDuplicatesAsync(int,int,System.Threading.CancellationToken).limit'></a>

`limit` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of duplicate references to return\. Defaults to 100\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetReferenceDuplicatesAsync(int,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetReferenceDuplicatesAsync(int,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe for cancellation requests\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task representing the asynchronous operation, returning a list of duplicate building references\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetReferencesByCountyIdAsync(int,System.Nullable_int_,System.Threading.CancellationToken)'></a>

## Building2DController\.GetReferencesByCountyIdAsync\(int, Nullable\<int\>, CancellationToken\) Method

Retrieves references of the building2Ds filtered by county Id\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetReferencesByCountyIdAsync(int countyId, System.Nullable<int> subdivisionId=null, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetReferencesByCountyIdAsync(int,System.Nullable_int_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The unique identifier of the county used to filter the building 2D references\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetReferencesByCountyIdAsync(int,System.Nullable_int_,System.Threading.CancellationToken).subdivisionId'></a>

`subdivisionId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional unique identifier of the subdivision used to further filter the building 2D references\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetReferencesByCountyIdAsync(int,System.Nullable_int_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetReferenceUniquenessSummaryAsync(int,System.Threading.CancellationToken)'></a>

## Building2DController\.GetReferenceUniquenessSummaryAsync\(int, CancellationToken\) Method

Asynchronously retrieves overall building reference uniqueness metrics across all partitions in the database\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetReferenceUniquenessSummaryAsync(int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetReferenceUniquenessSummaryAsync(int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.GetReferenceUniquenessSummaryAsync(int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe for cancellation requests\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task representing the asynchronous operation, returning the building reference uniqueness summary\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.UpdateItemAsync(System.Text.Json.Nodes.JsonObject,string,System.Nullable_int_,System.Threading.CancellationToken)'></a>

## Building2DController\.UpdateItemAsync\(JsonObject, string, Nullable\<int\>, CancellationToken\) Method

Updates a single building 2D item\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateItemAsync(System.Text.Json.Nodes.JsonObject? jsonObject, string? code, System.Nullable<int> countyId=null, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.UpdateItemAsync(System.Text.Json.Nodes.JsonObject,string,System.Nullable_int_,System.Threading.CancellationToken).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data to update the building 2D item\. This value can be null\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.UpdateItemAsync(System.Text.Json.Nodes.JsonObject,string,System.Nullable_int_,System.Threading.CancellationToken).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The code identifying the specific building 2D item to be updated\. This value can be null\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.UpdateItemAsync(System.Text.Json.Nodes.JsonObject,string,System.Nullable_int_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional county identifier associated with the building\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.UpdateItemAsync(System.Text.Json.Nodes.JsonObject,string,System.Nullable_int_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string,System.Threading.CancellationToken)'></a>

## Building2DController\.UpdateItemsAsync\(JsonArray, string, CancellationToken\) Method

Updates multiple building 2D items based on the provided JSON array and identification code\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateItemsAsync(System.Text.Json.Nodes.JsonArray? jsonArray, string? code, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string,System.Threading.CancellationToken).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The JSON array containing the building 2D items to be updated\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string,System.Threading.CancellationToken).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The identification code required for the update operation\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[],System.Threading.CancellationToken)'></a>

## Building2DController\.UpdateItemsByCountyIdsAsync\(JsonArray, int\[\], CancellationToken\) Method

Updates multiple building 2D items in the database for the given county rows\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray? jsonArray, int[]? countyIds, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[],System.Threading.CancellationToken).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The JSON array containing the building 2D items to be updated\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[],System.Threading.CancellationToken).countyIds'></a>

`countyIds` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The identifiers of the county rows the buildings belong to\. Normally every polygon part of one county\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[],System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter'></a>

## Building2DReferencesByPagingParameter Class

Parameter class containing options for keyset\-paginated building 2D reference queries\.

```csharp
public class Building2DReferencesByPagingParameter : DiGi.WebAPI.Classes.Parameter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.WebAPI\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.parameter 'DiGi\.WebAPI\.Classes\.Parameter') → Building2DReferencesByPagingParameter
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter.Building2DReferencesByPagingParameter()'></a>

## Building2DReferencesByPagingParameter\(\) Constructor

Initializes a new instance of the [Building2DReferencesByPagingParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter 'DiGi\.GIS\.WebAPI\.Classes\.Building2DReferencesByPagingParameter') class\.

```csharp
public Building2DReferencesByPagingParameter();
```

<a name='DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter.Building2DReferencesByPagingParameter(DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter)'></a>

## Building2DReferencesByPagingParameter\(Building2DReferencesByPagingParameter\) Constructor

Initializes a new instance of the [Building2DReferencesByPagingParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter 'DiGi\.GIS\.WebAPI\.Classes\.Building2DReferencesByPagingParameter') class by copying properties from another instance\.

```csharp
public Building2DReferencesByPagingParameter(DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter building2DReferencesByPagingParameter);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter.Building2DReferencesByPagingParameter(DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter).building2DReferencesByPagingParameter'></a>

`building2DReferencesByPagingParameter` [Building2DReferencesByPagingParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter 'DiGi\.GIS\.WebAPI\.Classes\.Building2DReferencesByPagingParameter')

The parameter instance to copy properties from\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter.Building2DReferencesByPagingParameter(System.Text.Json.Nodes.JsonObject)'></a>

## Building2DReferencesByPagingParameter\(JsonObject\) Constructor

Initializes a new instance of the [Building2DReferencesByPagingParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter 'DiGi\.GIS\.WebAPI\.Classes\.Building2DReferencesByPagingParameter') class using a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') object\.

```csharp
public Building2DReferencesByPagingParameter(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter.Building2DReferencesByPagingParameter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing data used to initialize the parameter\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter.CountyId'></a>

## Building2DReferencesByPagingParameter\.CountyId Property

Gets or sets the target partition identifier \(County ID\)\.

```csharp
public int CountyId { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

### Example
10365

<a name='DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter.Cursor'></a>

## Building2DReferencesByPagingParameter\.Cursor Property

Gets or sets the pagination cursor tracking the last processed building reference\.

```csharp
public string? Cursor { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

### Example
BLDG\-12345

<a name='DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter.PageSize'></a>

## Building2DReferencesByPagingParameter\.PageSize Property

Gets or sets the maximum count of references per page\. Defaults to 250\.

```csharp
public int PageSize { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

### Example
100

<a name='DiGi.GIS.WebAPI.Classes.Building2DReferencesByPagingParameter.SubdivisionId'></a>

## Building2DReferencesByPagingParameter\.SubdivisionId Property

Gets or sets the target subdivision identifier \(Subdivision ID\)\. Leave null to return references for the whole county\.

```csharp
public System.Nullable<int> SubdivisionId { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

### Example
1035

<a name='DiGi.GIS.WebAPI.Classes.Building2DsPostTask'></a>

## Building2DsPostTask Class

Provides functionality to handle the asynchronous posting of multiple [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D') objects to the GIS PostgreSQL database\.

```csharp
public class Building2DsPostTask : DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask<DiGi.GIS.Classes.Building2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.BackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.backgroundtask 'DiGi\.Core\.Classes\.BackgroundTask') → [DiGi\.Core\.Classes\.CancelableBackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cancelablebackgroundtask 'DiGi\.Core\.Classes\.CancelableBackgroundTask') → [DiGi\.Core\.Classes\.ReportableBackgroundTask&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1') → [DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask&lt;](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_ 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>')[DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')[&gt;](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_ 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>') → Building2DsPostTask
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.Building2DsPostTask.Building2DsPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager)'></a>

## Building2DsPostTask\(GISWebAPIManager\) Constructor

Initializes a new instance of the Building2DsPostTask class\.

```csharp
public Building2DsPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager GISWebAPIManager);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DsPostTask.Building2DsPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') used to manage PostgreSQL GIS operations\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.Building2DsPostTask.Code'></a>

## Building2DsPostTask\.Code Property

Gets or sets the code associated with the building 2D post task\.

A code does not identify a single county row - a multi-part county holds one row per polygon part - so set [CountyId](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.Building2DsPostTask.CountyId 'DiGi\.GIS\.WebAPI\.Classes\.Building2DsPostTask\.CountyId') instead wherever the identifier is already known. [CountyId](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.Building2DsPostTask.CountyId 'DiGi\.GIS\.WebAPI\.Classes\.Building2DsPostTask\.CountyId') takes precedence when both are set.

```csharp
public string? Code { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.WebAPI.Classes.Building2DsPostTask.CountyId'></a>

## Building2DsPostTask\.CountyId Property

Gets or sets the identifier of the county row the buildings belong to\. When set it is used in preference to [Code](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.Building2DsPostTask.Code 'DiGi\.GIS\.WebAPI\.Classes\.Building2DsPostTask\.Code'), which leaves the server to choose between the rows of a multi\-part county\.

```csharp
public System.Nullable<int> CountyId { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')
### Methods

<a name='DiGi.GIS.WebAPI.Classes.Building2DsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,int,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken)'></a>

## Building2DsPostTask\.ExecuteAsync\(IEnumerable\<Building2D\>, int, LongProgressWrapper, CancellationToken\) Method

Asynchronously executes the task of posting building 2D objects to the database, keyed by county identifier\.

```csharp
protected System.Threading.Tasks.Task<bool> ExecuteAsync(System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2D>? values, int countyId, DiGi.Core.Classes.LongProgressWrapper? longProgressWrapper, System.Threading.CancellationToken cancellationToken);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,int,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D') instances to post\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,int,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county row the buildings belong to\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,int,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).longProgressWrapper'></a>

`longProgressWrapper` [DiGi\.Core\.Classes\.LongProgressWrapper](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.longprogresswrapper 'DiGi\.Core\.Classes\.LongProgressWrapper')

A [DiGi\.Core\.Classes\.LongProgressWrapper](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.longprogresswrapper 'DiGi\.Core\.Classes\.LongProgressWrapper') tracking the progress of the operation\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,int,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe for cancellation requests\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result is true if all batches were posted successfully; otherwise, false\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken)'></a>

## Building2DsPostTask\.ExecuteAsync\(IEnumerable\<Building2D\>, string, LongProgressWrapper, CancellationToken\) Method

Asynchronously executes the task of posting building 2D objects to the database, keyed by administrative code\.

```csharp
protected System.Threading.Tasks.Task<bool> ExecuteAsync(System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.Building2D>? values, string? code, DiGi.Core.Classes.LongProgressWrapper? longProgressWrapper, System.Threading.CancellationToken cancellationToken);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Building2DsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D') instances to post\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The administrative code associated with the buildings\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).longProgressWrapper'></a>

`longProgressWrapper` [DiGi\.Core\.Classes\.LongProgressWrapper](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.longprogresswrapper 'DiGi\.Core\.Classes\.LongProgressWrapper')

A [DiGi\.Core\.Classes\.LongProgressWrapper](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.longprogresswrapper 'DiGi\.Core\.Classes\.LongProgressWrapper') tracking the progress of the operation\.

<a name='DiGi.GIS.WebAPI.Classes.Building2DsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.GIS.Classes.Building2D_,string,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe for cancellation requests\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController'></a>

## BuildingController Class

Provides API endpoints for managing and updating Building data stored in a PostgreSQL database\.

```csharp
public class BuildingController : DiGi.WebAPI.Classes.WebAPIController
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Microsoft\.AspNetCore\.Mvc\.ControllerBase](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase 'Microsoft\.AspNetCore\.Mvc\.ControllerBase') → [DiGi\.WebAPI\.Classes\.WebAPIController](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.webapicontroller 'DiGi\.WebAPI\.Classes\.WebAPIController') → BuildingController
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.BuildingController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.BuildingPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter)'></a>

## BuildingController\(GISWebAPIConfigurationFileWatcher, BuildingPostgreSQLConverter, Building2DPostgreSQLConverter, AdministrativeAreal2DPostgreSQLConverter\) Constructor

Initializes a new instance of the BuildingController class\.

```csharp
public BuildingController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher GISWebAPIConfigurationFileWatcher, DiGi.GIS.PostgreSQL.Classes.BuildingPostgreSQLConverter buildingPostgreSQLConverter, DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter building2DPostgreSQLConverter, DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter administrativeAreal2DPostgreSQLConverter);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.BuildingController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.BuildingPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).GISWebAPIConfigurationFileWatcher'></a>

`GISWebAPIConfigurationFileWatcher` [GISWebAPIConfigurationFileWatcher](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIConfigurationFileWatcher')

The configuration file watcher used to monitor changes to the PostgreSQL Web API configuration\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.BuildingController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.BuildingPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).buildingPostgreSQLConverter'></a>

`buildingPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.BuildingPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.buildingpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.BuildingPostgreSQLConverter')

The converter for Building objects when interacting with a PostgreSQL database\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.BuildingController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.BuildingPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).building2DPostgreSQLConverter'></a>

`building2DPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.Building2DPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.building2dpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.Building2DPostgreSQLConverter')

The converter for Building2D objects, used to read which county row a reference is already filed under\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.BuildingController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.BuildingPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).administrativeAreal2DPostgreSQLConverter'></a>

`administrativeAreal2DPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.AdministrativeAreal2DPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.administrativeareal2dpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.AdministrativeAreal2DPostgreSQLConverter')

The converter for administrative areal 2D data when interacting with a PostgreSQL database\.
### Methods

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.ContainsByReferencesAsync(System.Collections.Generic.List_string_,System.Nullable_int_,System.Nullable_bool_,System.Threading.CancellationToken)'></a>

## BuildingController\.ContainsByReferencesAsync\(List\<string\>, Nullable\<int\>, Nullable\<bool\>, CancellationToken\) Method

Asynchronously checks for the existence of a collection of building references, optionally filtered by a county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> ContainsByReferencesAsync(System.Collections.Generic.List<string>? references, System.Nullable<int> countyId, System.Nullable<bool> inverted, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.ContainsByReferencesAsync(System.Collections.Generic.List_string_,System.Nullable_int_,System.Nullable_bool_,System.Threading.CancellationToken).references'></a>

`references` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

A list of strings representing the building references to be checked\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.ContainsByReferencesAsync(System.Collections.Generic.List_string_,System.Nullable_int_,System.Nullable_bool_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional county identifier used to filter the search\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.ContainsByReferencesAsync(System.Collections.Generic.List_string_,System.Nullable_int_,System.Nullable_bool_,System.Threading.CancellationToken).inverted'></a>

`inverted` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

A boolean indicating whether to return missing references \(true\) or existing references \(false\)\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.ContainsByReferencesAsync(System.Collections.Generic.List_string_,System.Nullable_int_,System.Nullable_bool_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe for cancellation requests\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') containing the set of matching reference strings\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetCountAsync(System.Nullable_int_,bool,bool,int,System.Threading.CancellationToken)'></a>

## BuildingController\.GetCountAsync\(Nullable\<int\>, bool, bool, int, CancellationToken\) Method

Asynchronously retrieves the count of building records from the database, optionally filtered by a county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetCountAsync(System.Nullable<int> countyId, bool estimated=false, bool analyze=false, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetCountAsync(System.Nullable_int_,bool,bool,int,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional integer identifier of the county to filter the count; if null, the count is retrieved across all counties\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetCountAsync(System.Nullable_int_,bool,bool,int,System.Threading.CancellationToken).estimated'></a>

`estimated` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A boolean value indicating whether to read the estimated count from database statistics for faster execution on large partitions\. An unanalysed partition returns 204 NoContent\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetCountAsync(System.Nullable_int_,bool,bool,int,System.Threading.CancellationToken).analyze'></a>

`analyze` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A boolean value indicating whether to run an analysis operation before fetching the estimated count to ensure higher accuracy\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetCountAsync(System.Nullable_int_,bool,bool,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetCountAsync(System.Nullable_int_,bool,bool,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe for cancellation requests\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') containing the row count as a long integer, 204 NoContent when the partition exists but is unanalysed, or 404 NotFound when the county partition does not exist\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemByLatestCreatedAtAsync(System.Nullable_int_,System.Threading.CancellationToken)'></a>

## BuildingController\.GetItemByLatestCreatedAtAsync\(Nullable\<int\>, CancellationToken\) Method

Asynchronously retrieves the building with the latest created date for an optional county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemByLatestCreatedAtAsync(System.Nullable<int> countyId, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemByLatestCreatedAtAsync(System.Nullable_int_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional integer representing the county ID to filter the results\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemByLatestCreatedAtAsync(System.Nullable_int_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe for cancellation requests\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemByReferenceAsync(string,System.Nullable_int_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken)'></a>

## BuildingController\.GetItemByReferenceAsync\(string, Nullable\<int\>, Nullable\<double\>, Nullable\<double\>, Nullable\<double\>, Nullable\<double\>, CancellationToken\) Method

Asynchronously retrieves the single most relevant building for the provided reference and an optional county identifier\.

When the X, Y or Z coordinates are provided they are used to break ties between candidates resolved from the reference.

When the reference cannot be resolved and a point is provided, a spatial fallback search limited in X and Y by the maximum distance is performed.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemByReferenceAsync(string? reference, System.Nullable<int> countyId, System.Nullable<double> x=null, System.Nullable<double> y=null, System.Nullable<double> z=null, System.Nullable<double> maxDistance=null, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemByReferenceAsync(string,System.Nullable_int_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique reference string used to identify the building\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemByReferenceAsync(string,System.Nullable_int_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional integer representing the county ID to filter the results\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemByReferenceAsync(string,System.Nullable_int_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).x'></a>

`x` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional X coordinate of the point used to break ties and to locate the building when the reference cannot be resolved\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemByReferenceAsync(string,System.Nullable_int_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).y'></a>

`y` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional Y coordinate of the point used to break ties and to locate the building when the reference cannot be resolved\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemByReferenceAsync(string,System.Nullable_int_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).z'></a>

`z` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional Z coordinate of the point used to break ties and to locate the building when the reference cannot be resolved\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemByReferenceAsync(string,System.Nullable_int_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).maxDistance'></a>

`maxDistance` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional distance used to inflate the point in X and Y into the bounding box of the spatial fallback search\. Defaults to 1\.0 when not provided or invalid\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemByReferenceAsync(string,System.Nullable_int_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe for cancellation requests\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemsByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken)'></a>

## BuildingController\.GetItemsByReferenceAsync\(string, Nullable\<int\>, CancellationToken\) Method

Asynchronously retrieves buildings based on a provided reference and an optional county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemsByReferenceAsync(string? reference, System.Nullable<int> countyId, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemsByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique reference string used to identify the buildings\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemsByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional integer representing the county ID to filter the results\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemsByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe for cancellation requests\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemsByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,System.Threading.CancellationToken)'></a>

## BuildingController\.GetItemsByReferencesAsync\(IEnumerable\<string\>, Nullable\<int\>, CancellationToken\) Method

Asynchronously retrieves the single most relevant building for each of the provided references\.

Several rows can share one reference (different level of detail or year); each reference is reduced to one building ranked by level of detail and then by year, matching the behaviour of [GetItemByReferenceAsync\(string, Nullable&lt;int&gt;, Nullable&lt;double&gt;, Nullable&lt;double&gt;, Nullable&lt;double&gt;, Nullable&lt;double&gt;, CancellationToken\)](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingController.GetItemByReferenceAsync(string,System.Nullable_int_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken) 'DiGi\.GIS\.WebAPI\.Classes\.BuildingController\.GetItemByReferenceAsync\(string, System\.Nullable\<int\>, System\.Nullable\<double\>, System\.Nullable\<double\>, System\.Nullable\<double\>, System\.Nullable\<double\>, System\.Threading\.CancellationToken\)') when no coordinates are supplied.

References without a matching building are omitted, so an empty array is a valid response and does not indicate an error.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemsByReferencesAsync(System.Collections.Generic.IEnumerable<string>? references, System.Nullable<int> countyId, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemsByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,System.Threading.CancellationToken).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of unique reference strings used to identify the buildings\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemsByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional integer representing the county ID to filter the results\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.GetItemsByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe for cancellation requests\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string,System.Threading.CancellationToken)'></a>

## BuildingController\.UpdateItemsAsync\(JsonArray, string, CancellationToken\) Method

Updates multiple building items based on the provided JSON array and identification code\.

A county code does not identify a single county row: BDOT10k stores a county whose territory is disconnected as one feature per polygon part, and every part becomes its own row. Every part the code names is passed on, and each building is filed under the part it actually belongs to - see [UpdateItemsByCountyIdsAsync\(JsonArray, int\[\], CancellationToken\)](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[],System.Threading.CancellationToken) 'DiGi\.GIS\.WebAPI\.Classes\.BuildingController\.UpdateItemsByCountyIdsAsync\(System\.Text\.Json\.Nodes\.JsonArray, int\[\], System\.Threading\.CancellationToken\)') for how that is decided.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateItemsAsync(System.Text.Json.Nodes.JsonArray? jsonArray, string? code, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string,System.Threading.CancellationToken).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The JSON array containing the building items to be updated\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string,System.Threading.CancellationToken).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The identification code required for the update operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe for cancellation requests\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') representing the result of the update operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[],System.Threading.CancellationToken)'></a>

## BuildingController\.UpdateItemsByCountyIdsAsync\(JsonArray, int\[\], CancellationToken\) Method

Updates multiple building items in the database for the given county rows\.

The unambiguous counterpart of [UpdateItemsAsync\(JsonArray, string, CancellationToken\)](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string,System.Threading.CancellationToken) 'DiGi\.GIS\.WebAPI\.Classes\.BuildingController\.UpdateItemsAsync\(System\.Text\.Json\.Nodes\.JsonArray, string, System\.Threading\.CancellationToken\)'): it takes county identifiers rather than a code, so the caller states which rows are in play instead of leaving the server to derive them.

A single identifier is taken as stated and every building is filed under it. Several identifiers are the polygon parts of one multi-part county, and each building is then filed under the part it belongs to, decided in two steps:

1. the part already holding the building's `building_2d` row, probed lowest part first. That row was filed by geometry when it was imported, and reusing its answer keeps both tables keyed by the same `(county_id, reference)` pair - a building filed under a part its footprint is not stored in reads back as missing.

2. geometry, for a building no part holds a 2D row for: the part containing its bounding box, else the nearest part, else the part it overlaps most. Done by the converter, which drops a building it cannot place rather than filing it under a guess - such a building is reported as a rejection, not silently omitted.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray? jsonArray, int[]? countyIds, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[],System.Threading.CancellationToken).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The JSON array containing the building items to be updated\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[],System.Threading.CancellationToken).countyIds'></a>

`countyIds` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The identifiers of the county rows the buildings belong to\. Normally every polygon part of one county\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[],System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe for cancellation requests\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') representing the result of the update operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByFilterGroupParameter'></a>

## BuildingDataByFilterGroupParameter Class

Parameter class containing options for building data queries using dynamic hierarchical filters\.

```csharp
public class BuildingDataByFilterGroupParameter : DiGi.WebAPI.Classes.Parameter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.WebAPI\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.parameter 'DiGi\.WebAPI\.Classes\.Parameter') → BuildingDataByFilterGroupParameter
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByFilterGroupParameter.BuildingDataByFilterGroupParameter()'></a>

## BuildingDataByFilterGroupParameter\(\) Constructor

Initializes a new instance of the [BuildingDataByFilterGroupParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingDataByFilterGroupParameter 'DiGi\.GIS\.WebAPI\.Classes\.BuildingDataByFilterGroupParameter') class\.

```csharp
public BuildingDataByFilterGroupParameter();
```

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByFilterGroupParameter.BuildingDataByFilterGroupParameter(System.Text.Json.Nodes.JsonObject)'></a>

## BuildingDataByFilterGroupParameter\(JsonObject\) Constructor

Initializes a new instance of the [BuildingDataByFilterGroupParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingDataByFilterGroupParameter 'DiGi\.GIS\.WebAPI\.Classes\.BuildingDataByFilterGroupParameter') class using an [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') object\.

```csharp
public BuildingDataByFilterGroupParameter(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByFilterGroupParameter.BuildingDataByFilterGroupParameter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing data used to initialize the parameter\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByFilterGroupParameter.ColumnUniqueIds'></a>

## BuildingDataByFilterGroupParameter\.ColumnUniqueIds Property

Gets or sets the optional list of column unique identifiers to project in the result\.

```csharp
public System.Collections.Generic.List<string>? ColumnUniqueIds { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByFilterGroupParameter.FilterGroup'></a>

## BuildingDataByFilterGroupParameter\.FilterGroup Property

Gets or sets the dynamic hierarchical filter group to apply to the database query\.

```csharp
public DiGi.PostgreSQL.Table.Classes.FilterGroup FilterGroup { get; set; }
```

#### Property Value
[DiGi\.PostgreSQL\.Table\.Classes\.FilterGroup](https://learn.microsoft.com/en-us/dotnet/api/digi.postgresql.table.classes.filtergroup 'DiGi\.PostgreSQL\.Table\.Classes\.FilterGroup')

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByPagingParameter'></a>

## BuildingDataByPagingParameter Class

Parameter class containing options for keyset\-paginated building queries\.

```csharp
public class BuildingDataByPagingParameter : DiGi.WebAPI.Classes.Parameter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.WebAPI\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.parameter 'DiGi\.WebAPI\.Classes\.Parameter') → BuildingDataByPagingParameter
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByPagingParameter.BuildingDataByPagingParameter()'></a>

## BuildingDataByPagingParameter\(\) Constructor

Initializes a new instance of the [BuildingDataByPagingParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingDataByPagingParameter 'DiGi\.GIS\.WebAPI\.Classes\.BuildingDataByPagingParameter') class\.

```csharp
public BuildingDataByPagingParameter();
```

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByPagingParameter.BuildingDataByPagingParameter(System.Text.Json.Nodes.JsonObject)'></a>

## BuildingDataByPagingParameter\(JsonObject\) Constructor

Initializes a new instance of the [BuildingDataByPagingParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingDataByPagingParameter 'DiGi\.GIS\.WebAPI\.Classes\.BuildingDataByPagingParameter') class using an [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') object\.

```csharp
public BuildingDataByPagingParameter(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByPagingParameter.BuildingDataByPagingParameter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing data used to initialize the parameter\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByPagingParameter.ColumnUniqueIds'></a>

## BuildingDataByPagingParameter\.ColumnUniqueIds Property

Gets or sets the list of column unique identifiers to project in the result\.

```csharp
public System.Collections.Generic.List<string>? ColumnUniqueIds { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

### Example
\["building\_id", "address"\]

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByPagingParameter.CountyId'></a>

## BuildingDataByPagingParameter\.CountyId Property

Gets or sets the target partition identifier \(County ID\)\.

```csharp
public int CountyId { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

### Example
10365

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByPagingParameter.Cursor'></a>

## BuildingDataByPagingParameter\.Cursor Property

Gets or sets the pagination cursor tracking the last processed building reference\.

```csharp
public string? Cursor { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

### Example
eyJpZCI6MTIzfQ==

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByPagingParameter.PageSize'></a>

## BuildingDataByPagingParameter\.PageSize Property

Gets or sets the maximum count of rows per page\. Defaults to 250\.

Capped because a building data row carries every derived column of a building, so a page is far heavier than its row count suggests. Ask for more pages rather than a bigger one.

```csharp
public int PageSize { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

### Example
100

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter'></a>

## BuildingDataByReferencesParameter Class

Represents a parameter containing references for querying building data\.

```csharp
public class BuildingDataByReferencesParameter : DiGi.WebAPI.Classes.Parameter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.WebAPI\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.parameter 'DiGi\.WebAPI\.Classes\.Parameter') → BuildingDataByReferencesParameter
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter.BuildingDataByReferencesParameter()'></a>

## BuildingDataByReferencesParameter\(\) Constructor

Initializes a new instance of the [BuildingDataByReferencesParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter 'DiGi\.GIS\.WebAPI\.Classes\.BuildingDataByReferencesParameter') class\.

```csharp
public BuildingDataByReferencesParameter();
```

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter.BuildingDataByReferencesParameter(DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter)'></a>

## BuildingDataByReferencesParameter\(BuildingDataByReferencesParameter\) Constructor

Initializes a new instance of the [BuildingDataByReferencesParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter 'DiGi\.GIS\.WebAPI\.Classes\.BuildingDataByReferencesParameter') class using an existing [BuildingDataByReferencesParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter 'DiGi\.GIS\.WebAPI\.Classes\.BuildingDataByReferencesParameter') object\.

```csharp
public BuildingDataByReferencesParameter(DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter buildingDataByReferencesParameter);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter.BuildingDataByReferencesParameter(DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter).buildingDataByReferencesParameter'></a>

`buildingDataByReferencesParameter` [BuildingDataByReferencesParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter 'DiGi\.GIS\.WebAPI\.Classes\.BuildingDataByReferencesParameter')

The parameter object to copy data from\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter.BuildingDataByReferencesParameter(System.Text.Json.Nodes.JsonObject)'></a>

## BuildingDataByReferencesParameter\(JsonObject\) Constructor

Initializes a new instance of the [BuildingDataByReferencesParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter 'DiGi\.GIS\.WebAPI\.Classes\.BuildingDataByReferencesParameter') class using a JSON object\.

```csharp
public BuildingDataByReferencesParameter(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter.BuildingDataByReferencesParameter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing parameter data\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter.ColumnUniqueIds'></a>

## BuildingDataByReferencesParameter\.ColumnUniqueIds Property

Gets or sets the unique identifiers of the columns \(Column\.UniqueId\)\. All columns will be returned if the collection is null or empty\.
Required if performance is a concern and the column unique identifiers are available; otherwise, the column unique identifiers will be determined by the building data PostgreSQL converter\.

```csharp
public System.Collections.Generic.IEnumerable<string> ColumnUniqueIds { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter.CountyId'></a>

## BuildingDataByReferencesParameter\.CountyId Property

Gets or sets the county identifier\.
Required if performance is a concern and the county identifier is available; otherwise, the county identifier will be determined by the building data PostgreSQL converter\.

```csharp
public System.Nullable<int> CountyId { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter.References'></a>

## BuildingDataByReferencesParameter\.References Property

Gets or sets the references for the building data parameter\.

```csharp
public System.Collections.Generic.IEnumerable<string> References { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter'></a>

## BuildingDataBySubdivisionIdsParameter Class

Represents a parameter containing subdivision ids for querying building data\.

```csharp
public class BuildingDataBySubdivisionIdsParameter : DiGi.WebAPI.Classes.Parameter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.WebAPI\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.parameter 'DiGi\.WebAPI\.Classes\.Parameter') → BuildingDataBySubdivisionIdsParameter
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter.BuildingDataBySubdivisionIdsParameter()'></a>

## BuildingDataBySubdivisionIdsParameter\(\) Constructor

Initializes a new instance of the [BuildingDataBySubdivisionIdsParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter 'DiGi\.GIS\.WebAPI\.Classes\.BuildingDataBySubdivisionIdsParameter') class\.

```csharp
public BuildingDataBySubdivisionIdsParameter();
```

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter.BuildingDataBySubdivisionIdsParameter(DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter)'></a>

## BuildingDataBySubdivisionIdsParameter\(BuildingDataBySubdivisionIdsParameter\) Constructor

Initializes a new instance of the [BuildingDataBySubdivisionIdsParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter 'DiGi\.GIS\.WebAPI\.Classes\.BuildingDataBySubdivisionIdsParameter') class using an existing [BuildingDataBySubdivisionIdsParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter 'DiGi\.GIS\.WebAPI\.Classes\.BuildingDataBySubdivisionIdsParameter') object\.

```csharp
public BuildingDataBySubdivisionIdsParameter(DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter buildingDataBySubdivisionIdsParameter);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter.BuildingDataBySubdivisionIdsParameter(DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter).buildingDataBySubdivisionIdsParameter'></a>

`buildingDataBySubdivisionIdsParameter` [BuildingDataBySubdivisionIdsParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter 'DiGi\.GIS\.WebAPI\.Classes\.BuildingDataBySubdivisionIdsParameter')

The parameter object to copy data from\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter.BuildingDataBySubdivisionIdsParameter(System.Text.Json.Nodes.JsonObject)'></a>

## BuildingDataBySubdivisionIdsParameter\(JsonObject\) Constructor

Initializes a new instance of the [BuildingDataBySubdivisionIdsParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter 'DiGi\.GIS\.WebAPI\.Classes\.BuildingDataBySubdivisionIdsParameter') class using a JSON object\.

```csharp
public BuildingDataBySubdivisionIdsParameter(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter.BuildingDataBySubdivisionIdsParameter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing parameter data\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter.ColumnUniqueIds'></a>

## BuildingDataBySubdivisionIdsParameter\.ColumnUniqueIds Property

Gets or sets the unique identifiers of the columns \(Column\.UniqueId\)\. All columns will be returned if the collection is null or empty\.
Required if performance is a concern and the column unique identifiers are available; otherwise, the column unique identifiers will be determined by the building data PostgreSQL converter\.

```csharp
public System.Collections.Generic.IEnumerable<string> ColumnUniqueIds { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter.SubdivisionIds'></a>

## BuildingDataBySubdivisionIdsParameter\.SubdivisionIds Property

Gets or sets the subdivision ids for the building data

```csharp
public System.Collections.Generic.IEnumerable<int> SubdivisionIds { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController'></a>

## BuildingDataController Class

Controller responsible for handling API requests related to building data retrieved from a PostgreSQL database\.

```csharp
public class BuildingDataController : DiGi.WebAPI.Classes.WebAPIController
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Microsoft\.AspNetCore\.Mvc\.ControllerBase](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase 'Microsoft\.AspNetCore\.Mvc\.ControllerBase') → [DiGi\.WebAPI\.Classes\.WebAPIController](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.webapicontroller 'DiGi\.WebAPI\.Classes\.WebAPIController') → BuildingDataController
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.BuildingDataController(DiGi.GIS.PostgreSQL.Classes.BuildingDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter)'></a>

## BuildingDataController\(BuildingDataPostgreSQLConverter, Building2DPostgreSQLConverter\) Constructor

Initializes a new instance of the BuildingDataController class\.

Both converters are taken on the one constructor rather than the building data one alone, because the coverage read compares two tables that sit in different databases. A second constructor is not an option: a controller with more than one public constructor fails activation and answers 500 on every one of its endpoints.

```csharp
public BuildingDataController(DiGi.GIS.PostgreSQL.Classes.BuildingDataPostgreSQLConverter buildingDataPostgreSQLConverter, DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter building2DPostgreSQLConverter);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.BuildingDataController(DiGi.GIS.PostgreSQL.Classes.BuildingDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter).buildingDataPostgreSQLConverter'></a>

`buildingDataPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.BuildingDataPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.buildingdatapostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.BuildingDataPostgreSQLConverter')

The [DiGi\.GIS\.PostgreSQL\.Classes\.BuildingDataPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.buildingdatapostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.BuildingDataPostgreSQLConverter') used to handle building data operations and database conversions\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.BuildingDataController(DiGi.GIS.PostgreSQL.Classes.BuildingDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter).building2DPostgreSQLConverter'></a>

`building2DPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.Building2DPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.building2dpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.Building2DPostgreSQLConverter')

The [DiGi\.GIS\.PostgreSQL\.Classes\.Building2DPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.building2dpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.Building2DPostgreSQLConverter') used to read the buildings a county holds, which is the other half of the coverage comparison\.
### Fields

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.referenceCount_Maximum'></a>

## BuildingDataController\.referenceCount\_Maximum Field

The largest number of references one request may ask for\.

The whole collection travels into a single statement, so an unbounded list is an unbounded statement. A caller with more than this to ask about should page rather than widen the request.

```csharp
private const int referenceCount_Maximum = 10000;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')
### Methods

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetCategoriesAsync(int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetCategoriesAsync\(int, CancellationToken\) Method

Asynchronously retrieves all available building data column categories\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetCategoriesAsync(int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetCategoriesAsync(int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetCategoriesAsync(int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnReferencesAsync(System.Collections.Generic.List_string_,int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetColumnReferencesAsync\(List\<string\>, int, CancellationToken\) Method

Asynchronously retrieves all column references, optionally filtered by the specified categories\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetColumnReferencesAsync(System.Collections.Generic.List<string>? categories=null, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnReferencesAsync(System.Collections.Generic.List_string_,int,System.Threading.CancellationToken).categories'></a>

`categories` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

An optional list of category names to filter the column references by\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnReferencesAsync(System.Collections.Generic.List_string_,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnReferencesAsync(System.Collections.Generic.List_string_,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task representing the asynchronous operation, returning a list of column references\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnsAsync(int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetColumnsAsync\(int, CancellationToken\) Method

Asynchronously retrieves all available column definitions for building data\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetColumnsAsync(int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnsAsync(int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnsAsync(int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnsByCategoriesAsync(System.Collections.Generic.List_string_,int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetColumnsByCategoriesAsync\(List\<string\>, int, CancellationToken\) Method

Asynchronously retrieves all columns filtered by the specified categories\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetColumnsByCategoriesAsync(System.Collections.Generic.List<string>? categories=null, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnsByCategoriesAsync(System.Collections.Generic.List_string_,int,System.Threading.CancellationToken).categories'></a>

`categories` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

An optional list of category names to filter the columns by\. If null, the filtering behavior is determined by the underlying data source\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnsByCategoriesAsync(System.Collections.Generic.List_string_,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnsByCategoriesAsync(System.Collections.Generic.List_string_,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnsByCategoriesParameterAsync(DiGi.GIS.WebAPI.Classes.ColumnsByCategoriesParameter,int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetColumnsByCategoriesParameterAsync\(ColumnsByCategoriesParameter, int, CancellationToken\) Method

Retrieves all columns with given categories by columns by categories parameter \(which contains categories\)\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetColumnsByCategoriesParameterAsync(DiGi.GIS.WebAPI.Classes.ColumnsByCategoriesParameter columnsByCategoriesParameter, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnsByCategoriesParameterAsync(DiGi.GIS.WebAPI.Classes.ColumnsByCategoriesParameter,int,System.Threading.CancellationToken).columnsByCategoriesParameter'></a>

`columnsByCategoriesParameter` [ColumnsByCategoriesParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.ColumnsByCategoriesParameter 'DiGi\.GIS\.WebAPI\.Classes\.ColumnsByCategoriesParameter')

The parameter containing the categories for querying columns\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnsByCategoriesParameterAsync(DiGi.GIS.WebAPI.Classes.ColumnsByCategoriesParameter,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnsByCategoriesParameterAsync(DiGi.GIS.WebAPI.Classes.ColumnsByCategoriesParameter,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Column [DiGi\.PostgreSQL\.Table\.Classes\.Column](https://learn.microsoft.com/en-us/dotnet/api/digi.postgresql.table.classes.column 'DiGi\.PostgreSQL\.Table\.Classes\.Column')

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnUniqueIdsAsync(System.Collections.Generic.List_string_,int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetColumnUniqueIdsAsync\(List\<string\>, int, CancellationToken\) Method

Retrieves the unique identifiers for columns, optionally filtered by the specified categories\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetColumnUniqueIdsAsync(System.Collections.Generic.List<string>? categories=null, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnUniqueIdsAsync(System.Collections.Generic.List_string_,int,System.Threading.CancellationToken).categories'></a>

`categories` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

An optional list of category names used to filter the column references\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnUniqueIdsAsync(System.Collections.Generic.List_string_,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetColumnUniqueIdsAsync(System.Collections.Generic.List_string_,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetCountByCountyIdAsync(int,bool,bool,int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetCountByCountyIdAsync\(int, bool, bool, int, CancellationToken\) Method

Asynchronously retrieves the number of building data rows stored for one county\.

The cheapest question that can be asked of the table, and the one that separates a county no run has reached from one a run reached and wrote nothing for.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetCountByCountyIdAsync(int countyId, bool estimated=false, bool analyze=false, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetCountByCountyIdAsync(int,bool,bool,int,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county to count\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetCountByCountyIdAsync(int,bool,bool,int,System.Threading.CancellationToken).estimated'></a>

`estimated` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Reads the planner's row estimate instead of counting the rows\. Far faster on a partition of millions and accurate to a few percent, but it reflects the last time the partition was analysed rather than this moment\. An unanalysed partition returns 204 NoContent\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetCountByCountyIdAsync(int,bool,bool,int,System.Threading.CancellationToken).analyze'></a>

`analyze` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A boolean value indicating whether to perform an ANALYZE operation before reading the estimate to ensure statistics are current\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetCountByCountyIdAsync(int,bool,bool,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetCountByCountyIdAsync(int,bool,bool,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') carrying the count, 204 NoContent when the partition exists but is unanalysed, or 404 NotFound when the county has no partition\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetCountyIdsByReferenceAsync(string,int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetCountyIdsByReferenceAsync\(string, int, CancellationToken\) Method

Asynchronously retrieves the counties whose building data holds a row for one reference\.

A reference addresses one building of one county, so more than one identifier coming back means the reference was written outside the county it belongs to.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetCountyIdsByReferenceAsync(string reference, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetCountyIdsByReferenceAsync(string,int,System.Threading.CancellationToken).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The building reference to look up\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetCountyIdsByReferenceAsync(string,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetCountyIdsByReferenceAsync(string,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') carrying the county identifiers in ascending order, or 404 when the reference is not stored\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetCoverageByCountyIdAsync(int,int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetCoverageByCountyIdAsync\(int, int, CancellationToken\) Method

Asynchronously measures what one county's building data holds against the buildings that county actually has\.

What a row count cannot answer: how much was left out, and how much of that no run could have reached. A shortfall larger than the unresolved subdivision count is a run that did not finish what it could have.

Reads both databases - the buildings from the main one and their data from the storage one - so it costs more than a count. Call it per county rather than in a sweep.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetCoverageByCountyIdAsync(int countyId, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetCoverageByCountyIdAsync(int,int,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county to measure\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetCoverageByCountyIdAsync(int,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetCoverageByCountyIdAsync(int,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') carrying the [DiGi\.GIS\.PostgreSQL\.Classes\.BuildingDataCoverageResult](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.buildingdatacoverageresult 'DiGi\.GIS\.PostgreSQL\.Classes\.BuildingDataCoverageResult'), or 404 when either side could not be read\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetDuplicateReferencesAsync(int,int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetDuplicateReferencesAsync\(int, int, CancellationToken\) Method

Asynchronously retrieves the references the building data holds under more than one county, ordered by collision count descending\.

Expected to come back empty. A reference addresses one building of one county, so anything listed here was written outside the county it belongs to and nothing removes it afterwards.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetDuplicateReferencesAsync(int limit=100, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetDuplicateReferencesAsync(int,int,System.Threading.CancellationToken).limit'></a>

`limit` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of references to return\. Defaults to 100\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetDuplicateReferencesAsync(int,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetDuplicateReferencesAsync(int,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') carrying the duplicated references, or 404 when there are none\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetHistogramSummaryAsync(DiGi.GIS.WebAPI.Classes.HistogramRequestParameter,int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetHistogramSummaryAsync\(HistogramRequestParameter, int, CancellationToken\) Method

Generates a value range distribution histogram for a specific building data column inside a county partition, applying optional dynamic filters\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetHistogramSummaryAsync(DiGi.GIS.WebAPI.Classes.HistogramRequestParameter histogramRequestParameter, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetHistogramSummaryAsync(DiGi.GIS.WebAPI.Classes.HistogramRequestParameter,int,System.Threading.CancellationToken).histogramRequestParameter'></a>

`histogramRequestParameter` [HistogramRequestParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.HistogramRequestParameter 'DiGi\.GIS\.WebAPI\.Classes\.HistogramRequestParameter')

The parameter containing the target column, county identifier, desired bucket count, and optional dynamic filters\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetHistogramSummaryAsync(DiGi.GIS.WebAPI.Classes.HistogramRequestParameter,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetHistogramSummaryAsync(DiGi.GIS.WebAPI.Classes.HistogramRequestParameter,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task representing the asynchronous operation, returning the histogram bucket list as a JSON array\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetMultivalueAggregateSummaryAsync(DiGi.GIS.WebAPI.Classes.MultivalueAggregateRequestParameter,int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetMultivalueAggregateSummaryAsync\(MultivalueAggregateRequestParameter, int, CancellationToken\) Method

Computes multi\-value statistical summaries \(SplitDistinctCount, SplitValueDistribution\) on a partition column\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetMultivalueAggregateSummaryAsync(DiGi.GIS.WebAPI.Classes.MultivalueAggregateRequestParameter multivalueAggregateRequestParameter, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetMultivalueAggregateSummaryAsync(DiGi.GIS.WebAPI.Classes.MultivalueAggregateRequestParameter,int,System.Threading.CancellationToken).multivalueAggregateRequestParameter'></a>

`multivalueAggregateRequestParameter` [MultivalueAggregateRequestParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.MultivalueAggregateRequestParameter 'DiGi\.GIS\.WebAPI\.Classes\.MultivalueAggregateRequestParameter')

The parameter containing target column, multi\-value aggregate function, county identifier, and optional separator\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetMultivalueAggregateSummaryAsync(DiGi.GIS.WebAPI.Classes.MultivalueAggregateRequestParameter,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetMultivalueAggregateSummaryAsync(DiGi.GIS.WebAPI.Classes.MultivalueAggregateRequestParameter,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task representing the asynchronous operation, returning the aggregate result as a JSON node\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetSinglevalueAggregateSummaryAsync(DiGi.GIS.WebAPI.Classes.SinglevalueAggregateRequestParameter,int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetSinglevalueAggregateSummaryAsync\(SinglevalueAggregateRequestParameter, int, CancellationToken\) Method

Computes single\-value statistical summaries \(Avg, Sum, Min, Max, Count, DistinctCount\) on a partition column\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetSinglevalueAggregateSummaryAsync(DiGi.GIS.WebAPI.Classes.SinglevalueAggregateRequestParameter singlevalueAggregateRequestParameter, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetSinglevalueAggregateSummaryAsync(DiGi.GIS.WebAPI.Classes.SinglevalueAggregateRequestParameter,int,System.Threading.CancellationToken).singlevalueAggregateRequestParameter'></a>

`singlevalueAggregateRequestParameter` [SinglevalueAggregateRequestParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SinglevalueAggregateRequestParameter 'DiGi\.GIS\.WebAPI\.Classes\.SinglevalueAggregateRequestParameter')

The parameter containing target column, single\-value aggregate function, and county identifier\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetSinglevalueAggregateSummaryAsync(DiGi.GIS.WebAPI.Classes.SinglevalueAggregateRequestParameter,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetSinglevalueAggregateSummaryAsync(DiGi.GIS.WebAPI.Classes.SinglevalueAggregateRequestParameter,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task representing the asynchronous operation, returning the aggregate result as a JSON node\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByBuildingDataByPagingParameterAsync(DiGi.GIS.WebAPI.Classes.BuildingDataByPagingParameter,int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetTableByBuildingDataByPagingParameterAsync\(BuildingDataByPagingParameter, int, CancellationToken\) Method

Retrieves a building data table using keyset\-based paginated cursor streaming\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetTableByBuildingDataByPagingParameterAsync(DiGi.GIS.WebAPI.Classes.BuildingDataByPagingParameter buildingDataByPagingParameter, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByBuildingDataByPagingParameterAsync(DiGi.GIS.WebAPI.Classes.BuildingDataByPagingParameter,int,System.Threading.CancellationToken).buildingDataByPagingParameter'></a>

`buildingDataByPagingParameter` [BuildingDataByPagingParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingDataByPagingParameter 'DiGi\.GIS\.WebAPI\.Classes\.BuildingDataByPagingParameter')

The parameter containing paging options, including column projections, county identifier, cursor, and page size\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByBuildingDataByPagingParameterAsync(DiGi.GIS.WebAPI.Classes.BuildingDataByPagingParameter,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByBuildingDataByPagingParameterAsync(DiGi.GIS.WebAPI.Classes.BuildingDataByPagingParameter,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task representing the asynchronous operation, returning the populated table\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByBuildingDataByReferencesParameterAsync(DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter,int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetTableByBuildingDataByReferencesParameterAsync\(BuildingDataByReferencesParameter, int, CancellationToken\) Method

Retrieves a building data table by building data by references parameter \(column unique ids, county id and references\)\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetTableByBuildingDataByReferencesParameterAsync(DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter buildingDataByReferencesParameter, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByBuildingDataByReferencesParameterAsync(DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter,int,System.Threading.CancellationToken).buildingDataByReferencesParameter'></a>

`buildingDataByReferencesParameter` [BuildingDataByReferencesParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter 'DiGi\.GIS\.WebAPI\.Classes\.BuildingDataByReferencesParameter')

The parameter containing references for querying building data, including column unique identifiers, county identifier, and specific references\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByBuildingDataByReferencesParameterAsync(DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByBuildingDataByReferencesParameterAsync(DiGi.GIS.WebAPI.Classes.BuildingDataByReferencesParameter,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') representing the result of the operation, typically containing a [DiGi\.PostgreSQL\.Table\.Classes\.Table](https://learn.microsoft.com/en-us/dotnet/api/digi.postgresql.table.classes.table 'DiGi\.PostgreSQL\.Table\.Classes\.Table') if found\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByBuildingDataBySubdivisionIdsParameterAsync(DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter,int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetTableByBuildingDataBySubdivisionIdsParameterAsync\(BuildingDataBySubdivisionIdsParameter, int, CancellationToken\) Method

Retrieves a building data table by building data by subdivision ids parameter \(column unique ids, subdivision ids\)\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetTableByBuildingDataBySubdivisionIdsParameterAsync(DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter buildingDataBySubdivisionIdsParameter, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByBuildingDataBySubdivisionIdsParameterAsync(DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter,int,System.Threading.CancellationToken).buildingDataBySubdivisionIdsParameter'></a>

`buildingDataBySubdivisionIdsParameter` [BuildingDataBySubdivisionIdsParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter 'DiGi\.GIS\.WebAPI\.Classes\.BuildingDataBySubdivisionIdsParameter')

The parameter containing the subdivision IDs and optional column unique identifiers for querying building data\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByBuildingDataBySubdivisionIdsParameterAsync(DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByBuildingDataBySubdivisionIdsParameterAsync(DiGi.GIS.WebAPI.Classes.BuildingDataBySubdivisionIdsParameter,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByFilterGroupAsync(DiGi.GIS.WebAPI.Classes.BuildingDataByFilterGroupParameter,int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetTableByFilterGroupAsync\(BuildingDataByFilterGroupParameter, int, CancellationToken\) Method

Retrieves a building data table filtered by the specified dynamic hierarchical filters\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetTableByFilterGroupAsync(DiGi.GIS.WebAPI.Classes.BuildingDataByFilterGroupParameter buildingDataByFilterGroupParameter, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByFilterGroupAsync(DiGi.GIS.WebAPI.Classes.BuildingDataByFilterGroupParameter,int,System.Threading.CancellationToken).buildingDataByFilterGroupParameter'></a>

`buildingDataByFilterGroupParameter` [BuildingDataByFilterGroupParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingDataByFilterGroupParameter 'DiGi\.GIS\.WebAPI\.Classes\.BuildingDataByFilterGroupParameter')

The parameter containing the dynamic filter group and optional column unique identifiers\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByFilterGroupAsync(DiGi.GIS.WebAPI.Classes.BuildingDataByFilterGroupParameter,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByFilterGroupAsync(DiGi.GIS.WebAPI.Classes.BuildingDataByFilterGroupParameter,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task representing the asynchronous operation, returning the populated filtered table\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByReferenceAsync(string,System.Nullable_int_,int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetTableByReferenceAsync\(string, Nullable\<int\>, int, CancellationToken\) Method

Retrieves a building data table for one specific building\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetTableByReferenceAsync(string reference, System.Nullable<int> countyId=null, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByReferenceAsync(string,System.Nullable_int_,int,System.Threading.CancellationToken).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Building reference

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByReferenceAsync(string,System.Nullable_int_,int,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The unique identifier of the county for which building belongs to\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByReferenceAsync(string,System.Nullable_int_,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetTableByReferenceAsync(string,System.Nullable_int_,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task representing the asynchronous operation, returning the populated filtered table with data for sigle building\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetUniqueValuesAsync(string,System.Nullable_int_,int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetUniqueValuesAsync\(string, Nullable\<int\>, int, CancellationToken\) Method

Retrieves unique values for a specified column unique identifier and an optional county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetUniqueValuesAsync(string columnUniqueId, System.Nullable<int> countyId=null, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetUniqueValuesAsync(string,System.Nullable_int_,int,System.Threading.CancellationToken).columnUniqueId'></a>

`columnUniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the column from which to retrieve unique values\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetUniqueValuesAsync(string,System.Nullable_int_,int,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional integer identifier of the county used to filter the results\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetUniqueValuesAsync(string,System.Nullable_int_,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetUniqueValuesAsync(string,System.Nullable_int_,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetUniqueValuesByColumnUniqueIdParameterAsync(DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter,int,System.Threading.CancellationToken)'></a>

## BuildingDataController\.GetUniqueValuesByColumnUniqueIdParameterAsync\(UniqueValuesByColumnUniqueIdParameter, int, CancellationToken\) Method

Retrieves unique values for a given [UniqueValuesByColumnUniqueIdParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter 'DiGi\.GIS\.WebAPI\.Classes\.UniqueValuesByColumnUniqueIdParameter') \(column unique id and optionally county id\), applying optional dynamic filters\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetUniqueValuesByColumnUniqueIdParameterAsync(DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter uniqueValuesByColumnUniqueIdParameter, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetUniqueValuesByColumnUniqueIdParameterAsync(DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter,int,System.Threading.CancellationToken).uniqueValuesByColumnUniqueIdParameter'></a>

`uniqueValuesByColumnUniqueIdParameter` [UniqueValuesByColumnUniqueIdParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter 'DiGi\.GIS\.WebAPI\.Classes\.UniqueValuesByColumnUniqueIdParameter')

The parameter containing the column unique identifier, optional county identifier, and optional dynamic filters\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetUniqueValuesByColumnUniqueIdParameterAsync(DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingDataController.GetUniqueValuesByColumnUniqueIdParameterAsync(DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') representing the result of the operation, typically a list of unique values or a not found status\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController'></a>

## BuildingModelController Class

Web API controller for building model operations, providing endpoints to retrieve building model data\.

```csharp
public class BuildingModelController : DiGi.WebAPI.Classes.WebAPIController
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Microsoft\.AspNetCore\.Mvc\.ControllerBase](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase 'Microsoft\.AspNetCore\.Mvc\.ControllerBase') → [DiGi\.WebAPI\.Classes\.WebAPIController](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.webapicontroller 'DiGi\.WebAPI\.Classes\.WebAPIController') → BuildingModelController
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.BuildingModelController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.BuildingModelPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter)'></a>

## BuildingModelController\(GISWebAPIConfigurationFileWatcher, BuildingModelPostgreSQLConverter, Building2DPostgreSQLConverter, AdministrativeAreal2DPostgreSQLConverter\) Constructor

Initializes a new instance of the [BuildingModelController](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingModelController 'DiGi\.GIS\.WebAPI\.Classes\.BuildingModelController') class\.

```csharp
public BuildingModelController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher GISWebAPIConfigurationFileWatcher, DiGi.GIS.PostgreSQL.Classes.BuildingModelPostgreSQLConverter buildingModelPostgreSQLConverter, DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter building2DPostgreSQLConverter, DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter administrativeAreal2DPostgreSQLConverter);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.BuildingModelController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.BuildingModelPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).GISWebAPIConfigurationFileWatcher'></a>

`GISWebAPIConfigurationFileWatcher` [GISWebAPIConfigurationFileWatcher](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIConfigurationFileWatcher')

The configuration file watcher for the GIS PostgreSQL Web API\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.BuildingModelController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.BuildingModelPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).buildingModelPostgreSQLConverter'></a>

`buildingModelPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.BuildingModelPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.buildingmodelpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.BuildingModelPostgreSQLConverter')

The converter used for building model data operations in PostgreSQL\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.BuildingModelController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.BuildingModelPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).building2DPostgreSQLConverter'></a>

`building2DPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.Building2DPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.building2dpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.Building2DPostgreSQLConverter')

The converter used for Building 2D data operations in PostgreSQL\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.BuildingModelController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.BuildingModelPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).administrativeAreal2DPostgreSQLConverter'></a>

`administrativeAreal2DPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.AdministrativeAreal2DPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.administrativeareal2dpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.AdministrativeAreal2DPostgreSQLConverter')

The converter used to resolve an administrative area code to its county identifier\.
### Methods

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken)'></a>

## BuildingModelController\.GetItemsByCircleAsync\(double, double, Nullable\<double\>, Nullable\<double\>, Nullable\<double\>, CancellationToken\) Method

Retrieves the building models stored in the database for all buildings within a specified circle\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemsByCircleAsync(double x, double y, System.Nullable<double> radius, System.Nullable<double> diameter, System.Nullable<double> tolerance=1E-06, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X\-coordinate of the center point of the search circle\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y\-coordinate of the center point of the search circle\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).radius'></a>

`radius` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The radius of the search circle\. This value can be null\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).diameter'></a>

`diameter` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The diameter of the search circle\. This value can be null\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).tolerance'></a>

`tolerance` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional tolerance value for the spatial query\. If not provided, the default distance tolerance is used\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.GetItemsByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.GetItemsByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,System.Nullable_long_,System.Threading.CancellationToken)'></a>

## BuildingModelController\.GetItemsByReferencesAsync\(IEnumerable\<string\>, Nullable\<int\>, Nullable\<long\>, CancellationToken\) Method

Retrieves building models stored in the database for the specified references\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemsByReferencesAsync(System.Collections.Generic.IEnumerable<string>? references, System.Nullable<int> countyId, System.Nullable<long> limit=null, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.GetItemsByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,System.Nullable_long_,System.Threading.CancellationToken).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The building references identifying the building models to retrieve\. This value can be null\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.GetItemsByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,System.Nullable_long_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional county identifier used to narrow the search\. This value can be null\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.GetItemsByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,System.Nullable_long_,System.Threading.CancellationToken).limit'></a>

`limit` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional maximum number of building models to retrieve\. This value can be null\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.GetItemsByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,System.Nullable_long_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.UpdateAsync(System.Collections.Generic.List_DiGi.Analytical.Building.Classes.BuildingModel_,int)'></a>

## BuildingModelController\.UpdateAsync\(List\<BuildingModel\>, int\) Method

Writes the given building models to the partition of a single county row, replacing whatever those buildings already held there\.

Shared by both update actions so the county row is resolved once, by the action, and this method never has to guess one.

<b>A post replaces rather than adds.</b> A model row is addressed by the identifier of the model it holds, and a model is handed a fresh one whenever it is created, so the write itself always appends - see [DiGi\.GIS\.PostgreSQL\.Classes\.Building2DReferencedObject&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.building2dreferencedobject-1 'DiGi\.GIS\.PostgreSQL\.Classes\.Building2DReferencedObject\`1'). Left at that, regenerating a county would add a model to every building instead of replacing its own, so what the buildings already held is read first and removed once the write has succeeded. A building therefore ends up holding exactly the models this call sent for it.

The identifiers are read before the write and deleted after it, deliberately in that order: an interrupted call then leaves the building holding both its old and its new model, which is recoverable, rather than holding neither.

```csharp
private System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateAsync(System.Collections.Generic.List<DiGi.Analytical.Building.Classes.BuildingModel> buildingModels, int countyId);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.UpdateAsync(System.Collections.Generic.List_DiGi.Analytical.Building.Classes.BuildingModel_,int).buildingModels'></a>

`buildingModels` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The building models to write\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.UpdateAsync(System.Collections.Generic.List_DiGi.Analytical.Building.Classes.BuildingModel_,int).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county row the models belong to\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string)'></a>

## BuildingModelController\.UpdateItemsAsync\(JsonArray, string\) Method

Updates multiple building model items in the database, keyed by administrative area code\.

A county code does not identify a single county row: BDOT10k stores a county whose territory is disconnected as one feature per polygon part, and every part becomes its own row. Every part the code names is passed on, and each model is filed under the part it actually belongs to - see [UpdateItemsByCountyIdsAsync\(JsonArray, int\[\]\)](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingModelController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[]) 'DiGi\.GIS\.WebAPI\.Classes\.BuildingModelController\.UpdateItemsByCountyIdsAsync\(System\.Text\.Json\.Nodes\.JsonArray, int\[\]\)') for how that is decided.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateItemsAsync(System.Text.Json.Nodes.JsonArray? jsonArray, string? code);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The JSON array containing the building models to be updated\. This value can be null\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The administrative area code the building models belong to, resolved server\-side to a county identifier\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[])'></a>

## BuildingModelController\.UpdateItemsByCountyIdsAsync\(JsonArray, int\[\]\) Method

Updates multiple building model items in the database for the given county rows\.

The unambiguous counterpart of [UpdateItemsAsync\(JsonArray, string\)](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingModelController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string) 'DiGi\.GIS\.WebAPI\.Classes\.BuildingModelController\.UpdateItemsAsync\(System\.Text\.Json\.Nodes\.JsonArray, string\)'): it takes county identifiers rather than a code, so the caller states which rows are in play instead of leaving the server to derive them.

A single identifier is taken as stated and every model is filed under it. Several identifiers are the polygon parts of one multi-part county, and each model is then filed under the part already holding the `building_2d` row its reference names, probed lowest part first. That row was filed by geometry when it was imported, so reusing its answer keeps both tables keyed by the same `(county_id, reference)` pair.

A model whose reference no part holds is not written: nothing states where it belongs, and storing it under a guessed part is the state this replaced.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray? jsonArray, int[]? countyIds);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[]).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The JSON array containing the building models to be updated\. This value can be null\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[]).countyIds'></a>

`countyIds` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The identifiers of the county rows the building models belong to\. Normally every polygon part of one county\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask'></a>

## BuildingModelsPostTask Class

Provides functionality to handle the asynchronous posting of [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') collections to the PostgreSQL database\.

```csharp
public class BuildingModelsPostTask : DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask<DiGi.Analytical.Building.Classes.BuildingModel>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.BackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.backgroundtask 'DiGi\.Core\.Classes\.BackgroundTask') → [DiGi\.Core\.Classes\.CancelableBackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cancelablebackgroundtask 'DiGi\.Core\.Classes\.CancelableBackgroundTask') → [DiGi\.Core\.Classes\.ReportableBackgroundTask&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1') → [DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask&lt;](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_ 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[&gt;](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_ 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>') → BuildingModelsPostTask
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask.BuildingModelsPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager)'></a>

## BuildingModelsPostTask\(GISWebAPIManager\) Constructor

Initializes a new instance of the [BuildingModelsPostTask](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask 'DiGi\.GIS\.WebAPI\.Classes\.BuildingModelsPostTask') class\.

```csharp
public BuildingModelsPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager GISWebAPIManager);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask.BuildingModelsPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') instance used to communicate with the server\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask.Code'></a>

## BuildingModelsPostTask\.Code Property

Gets or sets the administrative area code the building models belong to\. It is resolved server\-side to a county identifier\.

A code does not identify a single county row - a multi-part county holds one row per polygon part - so set [CountyId](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask.CountyId 'DiGi\.GIS\.WebAPI\.Classes\.BuildingModelsPostTask\.CountyId') instead wherever the identifier is already known. [CountyId](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask.CountyId 'DiGi\.GIS\.WebAPI\.Classes\.BuildingModelsPostTask\.CountyId') takes precedence when both are set.

```csharp
public string? Code { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask.CountyId'></a>

## BuildingModelsPostTask\.CountyId Property

Gets or sets the identifier of the county row the building models belong to\. When set it is used in preference to [Code](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask.Code 'DiGi\.GIS\.WebAPI\.Classes\.BuildingModelsPostTask\.Code'), which leaves the server to choose between the rows of a multi\-part county\.

```csharp
public System.Nullable<int> CountyId { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')
### Methods

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,int,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken)'></a>

## BuildingModelsPostTask\.ExecuteAsync\(IEnumerable\<BuildingModel\>, int, LongProgressWrapper, CancellationToken\) Method

Asynchronously executes the task of posting building models to the database in memory\-size\-split batches, keyed by county identifier\.

```csharp
protected System.Threading.Tasks.Task<bool> ExecuteAsync(System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Classes.BuildingModel>? buildingModels, int countyId, DiGi.Core.Classes.LongProgressWrapper? longProgressWrapper, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,int,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).buildingModels'></a>

`buildingModels` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') instances to post\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,int,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county row the building models belong to\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,int,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).longProgressWrapper'></a>

`longProgressWrapper` [DiGi\.Core\.Classes\.LongProgressWrapper](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.longprogresswrapper 'DiGi\.Core\.Classes\.LongProgressWrapper')

A [DiGi\.Core\.Classes\.LongProgressWrapper](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.longprogresswrapper 'DiGi\.Core\.Classes\.LongProgressWrapper') tracking the progress of the operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,int,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe for cancellation requests\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result is true if all batches were posted successfully; otherwise, false\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,string,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken)'></a>

## BuildingModelsPostTask\.ExecuteAsync\(IEnumerable\<BuildingModel\>, string, LongProgressWrapper, CancellationToken\) Method

Asynchronously executes the task of posting building models to the database in memory\-size\-split batches\.

```csharp
protected System.Threading.Tasks.Task<bool> ExecuteAsync(System.Collections.Generic.IEnumerable<DiGi.Analytical.Building.Classes.BuildingModel>? buildingModels, string? code, DiGi.Core.Classes.LongProgressWrapper? longProgressWrapper, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,string,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).buildingModels'></a>

`buildingModels` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel') instances to post\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,string,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The administrative area code the building models belong to\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,string,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).longProgressWrapper'></a>

`longProgressWrapper` [DiGi\.Core\.Classes\.LongProgressWrapper](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.longprogresswrapper 'DiGi\.Core\.Classes\.LongProgressWrapper')

A [DiGi\.Core\.Classes\.LongProgressWrapper](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.longprogresswrapper 'DiGi\.Core\.Classes\.LongProgressWrapper') tracking the progress of the operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.Analytical.Building.Classes.BuildingModel_,string,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe for cancellation requests\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result is true if all batches were posted successfully; otherwise, false\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingsPostTask'></a>

## BuildingsPostTask Class

Provides functionality to handle the asynchronous posting of [DiGi\.CityGML\.Classes\.Building](https://learn.microsoft.com/en-us/dotnet/api/digi.citygml.classes.building 'DiGi\.CityGML\.Classes\.Building') collections to the PostgreSQL database\.

```csharp
public class BuildingsPostTask : DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask<DiGi.CityGML.Classes.Building>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.BackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.backgroundtask 'DiGi\.Core\.Classes\.BackgroundTask') → [DiGi\.Core\.Classes\.CancelableBackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cancelablebackgroundtask 'DiGi\.Core\.Classes\.CancelableBackgroundTask') → [DiGi\.Core\.Classes\.ReportableBackgroundTask&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1') → [DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask&lt;](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_ 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>')[DiGi\.CityGML\.Classes\.Building](https://learn.microsoft.com/en-us/dotnet/api/digi.citygml.classes.building 'DiGi\.CityGML\.Classes\.Building')[&gt;](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_ 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>') → BuildingsPostTask
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.BuildingsPostTask.BuildingsPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager)'></a>

## BuildingsPostTask\(GISWebAPIManager\) Constructor

Initializes a new instance of the [BuildingsPostTask](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingsPostTask 'DiGi\.GIS\.WebAPI\.Classes\.BuildingsPostTask') class\.

```csharp
public BuildingsPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager GISWebAPIManager);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingsPostTask.BuildingsPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The GIS PostgreSQL Web API manager used to handle data persistence\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.BuildingsPostTask.Code'></a>

## BuildingsPostTask\.Code Property

Gets or sets the code associated with the buildings post task\.

A code does not identify a single county row - a multi-part county holds one row per polygon part - so set [CountyId](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingsPostTask.CountyId 'DiGi\.GIS\.WebAPI\.Classes\.BuildingsPostTask\.CountyId') instead wherever the identifier is already known. [CountyId](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingsPostTask.CountyId 'DiGi\.GIS\.WebAPI\.Classes\.BuildingsPostTask\.CountyId') takes precedence when both are set.

```csharp
public string? Code { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.WebAPI.Classes.BuildingsPostTask.CountyId'></a>

## BuildingsPostTask\.CountyId Property

Gets or sets the identifier of the county row the buildings belong to\. When set it is used in preference to [Code](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingsPostTask.Code 'DiGi\.GIS\.WebAPI\.Classes\.BuildingsPostTask\.Code'), which leaves the server to choose between the rows of a multi\-part county\.

```csharp
public System.Nullable<int> CountyId { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')
### Methods

<a name='DiGi.GIS.WebAPI.Classes.BuildingsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,int,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken)'></a>

## BuildingsPostTask\.ExecuteAsync\(IEnumerable\<Building\>, int, LongProgressWrapper, CancellationToken\) Method

Asynchronously executes the task of posting building objects to the database, keyed by county identifier\.

```csharp
protected System.Threading.Tasks.Task<bool> ExecuteAsync(System.Collections.Generic.IEnumerable<DiGi.CityGML.Classes.Building>? values, int countyId, DiGi.Core.Classes.LongProgressWrapper? longProgressWrapper, System.Threading.CancellationToken cancellationToken);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,int,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.CityGML\.Classes\.Building](https://learn.microsoft.com/en-us/dotnet/api/digi.citygml.classes.building 'DiGi\.CityGML\.Classes\.Building')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [DiGi\.CityGML\.Classes\.Building](https://learn.microsoft.com/en-us/dotnet/api/digi.citygml.classes.building 'DiGi\.CityGML\.Classes\.Building') instances to post\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,int,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county row the buildings belong to\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,int,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).longProgressWrapper'></a>

`longProgressWrapper` [DiGi\.Core\.Classes\.LongProgressWrapper](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.longprogresswrapper 'DiGi\.Core\.Classes\.LongProgressWrapper')

A [DiGi\.Core\.Classes\.LongProgressWrapper](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.longprogresswrapper 'DiGi\.Core\.Classes\.LongProgressWrapper') tracking the progress of the operation\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,int,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe for cancellation requests\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\. The task result is true if all batches were posted successfully; otherwise, false\.

<a name='DiGi.GIS.WebAPI.Classes.BuildingsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,string,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken)'></a>

## BuildingsPostTask\.ExecuteAsync\(IEnumerable\<Building\>, string, LongProgressWrapper, CancellationToken\) Method

Asynchronously executes the task of posting building objects to the database\.

```csharp
protected System.Threading.Tasks.Task<bool> ExecuteAsync(System.Collections.Generic.IEnumerable<DiGi.CityGML.Classes.Building>? values, string? code, DiGi.Core.Classes.LongProgressWrapper? longProgressWrapper, System.Threading.CancellationToken cancellationToken);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.BuildingsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,string,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.CityGML\.Classes\.Building](https://learn.microsoft.com/en-us/dotnet/api/digi.citygml.classes.building 'DiGi\.CityGML\.Classes\.Building')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.GIS.WebAPI.Classes.BuildingsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,string,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.WebAPI.Classes.BuildingsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,string,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).longProgressWrapper'></a>

`longProgressWrapper` [DiGi\.Core\.Classes\.LongProgressWrapper](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.longprogresswrapper 'DiGi\.Core\.Classes\.LongProgressWrapper')

<a name='DiGi.GIS.WebAPI.Classes.BuildingsPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.CityGML.Classes.Building_,string,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')

<a name='DiGi.GIS.WebAPI.Classes.ColumnsByCategoriesParameter'></a>

## ColumnsByCategoriesParameter Class

Represents a parameter containing categories for querying columns\.

```csharp
public class ColumnsByCategoriesParameter : DiGi.WebAPI.Classes.Parameter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.WebAPI\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.parameter 'DiGi\.WebAPI\.Classes\.Parameter') → ColumnsByCategoriesParameter
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.ColumnsByCategoriesParameter.ColumnsByCategoriesParameter()'></a>

## ColumnsByCategoriesParameter\(\) Constructor

Initializes a new instance of the [ColumnsByCategoriesParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.ColumnsByCategoriesParameter 'DiGi\.GIS\.WebAPI\.Classes\.ColumnsByCategoriesParameter') class\.

```csharp
public ColumnsByCategoriesParameter();
```

<a name='DiGi.GIS.WebAPI.Classes.ColumnsByCategoriesParameter.ColumnsByCategoriesParameter(System.Collections.Generic.IEnumerable_string_)'></a>

## ColumnsByCategoriesParameter\(IEnumerable\<string\>\) Constructor

Initializes a new instance of the [ColumnsByCategoriesParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.ColumnsByCategoriesParameter 'DiGi\.GIS\.WebAPI\.Classes\.ColumnsByCategoriesParameter') class with the specified categories\.

```csharp
public ColumnsByCategoriesParameter(System.Collections.Generic.IEnumerable<string> categories);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.ColumnsByCategoriesParameter.ColumnsByCategoriesParameter(System.Collections.Generic.IEnumerable_string_).categories'></a>

`categories` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of categories for querying columns\.

<a name='DiGi.GIS.WebAPI.Classes.ColumnsByCategoriesParameter.ColumnsByCategoriesParameter(System.Text.Json.Nodes.JsonObject)'></a>

## ColumnsByCategoriesParameter\(JsonObject\) Constructor

Initializes a new instance of the [ColumnsByCategoriesParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.ColumnsByCategoriesParameter 'DiGi\.GIS\.WebAPI\.Classes\.ColumnsByCategoriesParameter') class using an [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') object\.

```csharp
public ColumnsByCategoriesParameter(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.ColumnsByCategoriesParameter.ColumnsByCategoriesParameter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the parameter\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.ColumnsByCategoriesParameter.Categories'></a>

## ColumnsByCategoriesParameter\.Categories Property

Gets or sets the categories for querying columns\. All columns will be returned if the collection is null or empty\.

```csharp
public System.Collections.Generic.IEnumerable<string> Categories { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter'></a>

## CountByAdministrativeAreal2DIdsParameter Class

Represents a parameter object used to perform counting operations based on a collection of administrative areal 2D identifiers\.

```csharp
public class CountByAdministrativeAreal2DIdsParameter : DiGi.WebAPI.Classes.Parameter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.WebAPI\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.parameter 'DiGi\.WebAPI\.Classes\.Parameter') → CountByAdministrativeAreal2DIdsParameter
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter.CountByAdministrativeAreal2DIdsParameter()'></a>

## CountByAdministrativeAreal2DIdsParameter\(\) Constructor

Initializes a new instance of the [CountByAdministrativeAreal2DIdsParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter 'DiGi\.GIS\.WebAPI\.Classes\.CountByAdministrativeAreal2DIdsParameter') class\.

```csharp
public CountByAdministrativeAreal2DIdsParameter();
```

<a name='DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter.CountByAdministrativeAreal2DIdsParameter(DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter)'></a>

## CountByAdministrativeAreal2DIdsParameter\(CountByAdministrativeAreal2DIdsParameter\) Constructor

Initializes a new instance of the [CountByAdministrativeAreal2DIdsParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter 'DiGi\.GIS\.WebAPI\.Classes\.CountByAdministrativeAreal2DIdsParameter') class by copying the values from an existing instance\.

```csharp
public CountByAdministrativeAreal2DIdsParameter(DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter countByAdministrativeAreal2DIdsParameter);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter.CountByAdministrativeAreal2DIdsParameter(DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter).countByAdministrativeAreal2DIdsParameter'></a>

`countByAdministrativeAreal2DIdsParameter` [CountByAdministrativeAreal2DIdsParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter 'DiGi\.GIS\.WebAPI\.Classes\.CountByAdministrativeAreal2DIdsParameter')

The source instance from which to copy the administrative areal 2D identifiers\.

<a name='DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter.CountByAdministrativeAreal2DIdsParameter(System.Text.Json.Nodes.JsonObject)'></a>

## CountByAdministrativeAreal2DIdsParameter\(JsonObject\) Constructor

Initializes a new instance of the [CountByAdministrativeAreal2DIdsParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter 'DiGi\.GIS\.WebAPI\.Classes\.CountByAdministrativeAreal2DIdsParameter') class using the provided JSON object\.

```csharp
public CountByAdministrativeAreal2DIdsParameter(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter.CountByAdministrativeAreal2DIdsParameter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the parameter\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.CountByAdministrativeAreal2DIdsParameter.AdministrativeAreal2DIds'></a>

## CountByAdministrativeAreal2DIdsParameter\.AdministrativeAreal2DIds Property

Gets or sets the collection of administrative areal 2D identifiers used for counting operations\.

```csharp
public System.Collections.Generic.IEnumerable<int> AdministrativeAreal2DIds { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.GIS.WebAPI.Classes.EPWFileController'></a>

## EPWFileController Class

Controller responsible for handling API requests related to EPW files retrieved from or updated in a PostgreSQL database\.

```csharp
public class EPWFileController : DiGi.WebAPI.Classes.WebAPIController
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Microsoft\.AspNetCore\.Mvc\.ControllerBase](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase 'Microsoft\.AspNetCore\.Mvc\.ControllerBase') → [DiGi\.WebAPI\.Classes\.WebAPIController](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.webapicontroller 'DiGi\.WebAPI\.Classes\.WebAPIController') → EPWFileController
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.EPWFileController.EPWFileController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.EPWFilePostgreSQLConverter)'></a>

## EPWFileController\(GISWebAPIConfigurationFileWatcher, EPWFilePostgreSQLConverter\) Constructor

Initializes a new instance of the [EPWFileController](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.EPWFileController 'DiGi\.GIS\.WebAPI\.Classes\.EPWFileController') class\.

```csharp
public EPWFileController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher GISWebAPIConfigurationFileWatcher, DiGi.GIS.PostgreSQL.Classes.EPWFilePostgreSQLConverter ePWFilePostgreSQLConverter);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.EPWFileController.EPWFileController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.EPWFilePostgreSQLConverter).GISWebAPIConfigurationFileWatcher'></a>

`GISWebAPIConfigurationFileWatcher` [GISWebAPIConfigurationFileWatcher](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIConfigurationFileWatcher')

The configuration file watcher used to monitor changes to the GIS PostgreSQL Web API settings\.

<a name='DiGi.GIS.WebAPI.Classes.EPWFileController.EPWFileController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.EPWFilePostgreSQLConverter).ePWFilePostgreSQLConverter'></a>

`ePWFilePostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.EPWFilePostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.epwfilepostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.EPWFilePostgreSQLConverter')

The converter used for handling EPW file operations within the PostgreSQL database\.
### Methods

<a name='DiGi.GIS.WebAPI.Classes.EPWFileController.GetEPWFileAsync(double,double,System.Threading.CancellationToken)'></a>

## EPWFileController\.GetEPWFileAsync\(double, double, CancellationToken\) Method

Asynchronously retrieves the closest EPWFile to the given coordinate \(x, y\)\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetEPWFileAsync(double x, double y, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.EPWFileController.GetEPWFileAsync(double,double,System.Threading.CancellationToken).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate \(longitude\)\.

<a name='DiGi.GIS.WebAPI.Classes.EPWFileController.GetEPWFileAsync(double,double,System.Threading.CancellationToken).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate \(latitude\)\.

<a name='DiGi.GIS.WebAPI.Classes.EPWFileController.GetEPWFileAsync(double,double,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.EPWFileController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,System.Threading.CancellationToken)'></a>

## EPWFileController\.UpdateItemsAsync\(JsonArray, CancellationToken\) Method

Asynchronously updates or inserts a collection of EPW files\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateItemsAsync(System.Text.Json.Nodes.JsonArray? jsonArray, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.EPWFileController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,System.Threading.CancellationToken).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The JSON array containing the EPW files to update or insert\.

<a name='DiGi.GIS.WebAPI.Classes.EPWFileController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.EPWFilesPostTask'></a>

## EPWFilesPostTask Class

Provides functionality to handle the asynchronous posting of multiple [DiGi\.EPW\.Classes\.EPWFile](https://learn.microsoft.com/en-us/dotnet/api/digi.epw.classes.epwfile 'DiGi\.EPW\.Classes\.EPWFile') objects to the GIS PostgreSQL database\.

```csharp
public class EPWFilesPostTask : DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask<DiGi.EPW.Classes.EPWFile>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.BackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.backgroundtask 'DiGi\.Core\.Classes\.BackgroundTask') → [DiGi\.Core\.Classes\.CancelableBackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cancelablebackgroundtask 'DiGi\.Core\.Classes\.CancelableBackgroundTask') → [DiGi\.Core\.Classes\.ReportableBackgroundTask&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1') → [DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask&lt;](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_ 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>')[DiGi\.EPW\.Classes\.EPWFile](https://learn.microsoft.com/en-us/dotnet/api/digi.epw.classes.epwfile 'DiGi\.EPW\.Classes\.EPWFile')[&gt;](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_ 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>') → EPWFilesPostTask
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.EPWFilesPostTask.EPWFilesPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager)'></a>

## EPWFilesPostTask\(GISWebAPIManager\) Constructor

Initializes a new instance of the [EPWFilesPostTask](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.EPWFilesPostTask 'DiGi\.GIS\.WebAPI\.Classes\.EPWFilesPostTask') class\.

```csharp
public EPWFilesPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager GISWebAPIManager);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.EPWFilesPostTask.EPWFilesPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager') used to manage PostgreSQL GIS operations\.
### Methods

<a name='DiGi.GIS.WebAPI.Classes.EPWFilesPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.EPW.Classes.EPWFile_,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken)'></a>

## EPWFilesPostTask\.ExecuteAsync\(IEnumerable\<EPWFile\>, LongProgressWrapper, CancellationToken\) Method

Asynchronously executes the posting of EPW files\.

```csharp
protected System.Threading.Tasks.Task<bool> ExecuteAsync(System.Collections.Generic.IEnumerable<DiGi.EPW.Classes.EPWFile>? ePWFiles, DiGi.Core.Classes.LongProgressWrapper? longProgressWrapper, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.EPWFilesPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.EPW.Classes.EPWFile_,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).ePWFiles'></a>

`ePWFiles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.EPW\.Classes\.EPWFile](https://learn.microsoft.com/en-us/dotnet/api/digi.epw.classes.epwfile 'DiGi\.EPW\.Classes\.EPWFile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of EPW files to post\.

<a name='DiGi.GIS.WebAPI.Classes.EPWFilesPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.EPW.Classes.EPWFile_,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).longProgressWrapper'></a>

`longProgressWrapper` [DiGi\.Core\.Classes\.LongProgressWrapper](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.longprogresswrapper 'DiGi\.Core\.Classes\.LongProgressWrapper')

The progress wrapper to track the number of posted files\.

<a name='DiGi.GIS.WebAPI.Classes.EPWFilesPostTask.ExecuteAsync(System.Collections.Generic.IEnumerable_DiGi.EPW.Classes.EPWFile_,DiGi.Core.Classes.LongProgressWrapper,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to cancel the operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation, returning [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the post succeeded; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.GIS.WebAPI.Classes.EPWFilesPostTask.ExecuteAsync(System.IProgress_long_,System.Threading.CancellationToken)'></a>

## EPWFilesPostTask\.ExecuteAsync\(IProgress\<long\>, CancellationToken\) Method

Asynchronously executes the background task, reporting progress\.

```csharp
protected override System.Threading.Tasks.Task<bool> ExecuteAsync(System.IProgress<long> progress, System.Threading.CancellationToken cancellationToken);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.EPWFilesPostTask.ExecuteAsync(System.IProgress_long_,System.Threading.CancellationToken).progress'></a>

`progress` [System\.IProgress&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1 'System\.IProgress\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1 'System\.IProgress\`1')

The progress reporter for reporting progress updates\.

<a name='DiGi.GIS.WebAPI.Classes.EPWFilesPostTask.ExecuteAsync(System.IProgress_long_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to cancel the operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation, returning [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the operation succeeded; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher'></a>

## GISWebAPIConfigurationFileWatcher Class

Provides functionality to watch and retrieve configuration settings for the GIS PostgreSQL Web API from a specified configuration file\.

```csharp
public class GISWebAPIConfigurationFileWatcher : DiGi.Core.IO.FileWatcher.Classes.ConfigurationFileWatcher
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.IO\.FileWatcher\.Classes\.FileWatcher](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.filewatcher.classes.filewatcher 'DiGi\.Core\.IO\.FileWatcher\.Classes\.FileWatcher') → [DiGi\.Core\.IO\.FileWatcher\.Classes\.ConfigurationFileWatcher](https://learn.microsoft.com/en-us/dotnet/api/digi.core.io.filewatcher.classes.configurationfilewatcher 'DiGi\.Core\.IO\.FileWatcher\.Classes\.ConfigurationFileWatcher') → GISWebAPIConfigurationFileWatcher
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher.GISWebAPIConfigurationFileWatcher(string,double)'></a>

## GISWebAPIConfigurationFileWatcher\(string, double\) Constructor

Initializes a new instance of the GISWebAPIConfigurationFileWatcher class\.

```csharp
public GISWebAPIConfigurationFileWatcher(string path, double interval=5000.0);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher.GISWebAPIConfigurationFileWatcher(string,double).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the configuration file to be watched\.

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher.GISWebAPIConfigurationFileWatcher(string,double).interval'></a>

`interval` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The time interval in milliseconds between checks for changes to the configuration file\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher.AllowUpdateAdministrativeAreal2D'></a>

## GISWebAPIConfigurationFileWatcher\.AllowUpdateAdministrativeAreal2D Property

Gets a value indicating whether updates to administrative areal 2D data are permitted according to the configuration file\.

```csharp
public bool AllowUpdateAdministrativeAreal2D { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher.AllowUpdateBuilding'></a>

## GISWebAPIConfigurationFileWatcher\.AllowUpdateBuilding Property

Gets a value indicating whether updates to buildings are permitted based on the configuration file settings\.

```csharp
public bool AllowUpdateBuilding { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher.AllowUpdateBuilding2D'></a>

## GISWebAPIConfigurationFileWatcher\.AllowUpdateBuilding2D Property

Gets a value indicating whether updates to 2D buildings are permitted based on the configuration file settings\.

```csharp
public bool AllowUpdateBuilding2D { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher.AllowUpdateBuildingModel'></a>

## GISWebAPIConfigurationFileWatcher\.AllowUpdateBuildingModel Property

Gets a value indicating whether updates to building models are permitted based on the configuration file settings\.

```csharp
public bool AllowUpdateBuildingModel { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher.AllowUpdateEPWFile'></a>

## GISWebAPIConfigurationFileWatcher\.AllowUpdateEPWFile Property

Gets a value indicating whether updating EPW file data is enabled in the configuration\.

```csharp
public bool AllowUpdateEPWFile { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher.AllowUpdateOrtoDatas'></a>

## GISWebAPIConfigurationFileWatcher\.AllowUpdateOrtoDatas Property

Gets a value indicating whether updates to orthophoto data are permitted according to the configuration file\.

```csharp
public bool AllowUpdateOrtoDatas { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher.AllowUpdateYearBuiltData'></a>

## GISWebAPIConfigurationFileWatcher\.AllowUpdateYearBuiltData Property

Gets a value indicating whether updating year built data is enabled in the configuration\.

```csharp
public bool AllowUpdateYearBuiltData { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIManager'></a>

## GISWebAPIManager Class

Manages the creation and lifecycle of [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient') instances used to interact with the GIS PostgreSQL Web API\.

```csharp
public class GISWebAPIManager
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → GISWebAPIManager
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIManager.GISWebAPIManager(System.Net.Http.IHttpClientFactory)'></a>

## GISWebAPIManager\(IHttpClientFactory\) Constructor

Initializes a new instance of the GISWebAPIManager class\.

```csharp
public GISWebAPIManager(System.Net.Http.IHttpClientFactory? httpClientFactory);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIManager.GISWebAPIManager(System.Net.Http.IHttpClientFactory).httpClientFactory'></a>

`httpClientFactory` [System\.Net\.Http\.IHttpClientFactory](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.ihttpclientfactory 'System\.Net\.Http\.IHttpClientFactory')

The HTTP client factory used to create and manage [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient') instances\.
### Methods

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIManager.CreateHttpClient(string)'></a>

## GISWebAPIManager\.CreateHttpClient\(string\) Method

Creates an HttpClient instance with the specified name\.

```csharp
public System.Net.Http.HttpClient? CreateHttpClient(string name);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIManager.CreateHttpClient(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier or name of the HTTP client to be created\.

#### Returns
[System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIManager.CreateHttpClient_TControllerBase_(string)'></a>

## GISWebAPIManager\.CreateHttpClient\<TControllerBase\>\(string\) Method

Creates an [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient') instance configured for the Web API, resolving the route associated with the specified controller type\.

```csharp
public System.Net.Http.HttpClient? CreateHttpClient<TControllerBase>(out string? route)
    where TControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase;
```
#### Type parameters

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIManager.CreateHttpClient_TControllerBase_(string).TControllerBase'></a>

`TControllerBase`

The TControllerBase type parameter\.
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIManager.CreateHttpClient_TControllerBase_(string).route'></a>

`route` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The route\.

#### Returns
[System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIManager.CreateHttpClient_TControllerBase_(string,string)'></a>

## GISWebAPIManager\.CreateHttpClient\<TControllerBase\>\(string, string\) Method

Creates an [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient') instance configured for the specified controller's method and retrieves the corresponding API path\.

```csharp
public System.Net.Http.HttpClient? CreateHttpClient<TControllerBase>(string methodName, out string? path)
    where TControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase;
```
#### Type parameters

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIManager.CreateHttpClient_TControllerBase_(string,string).TControllerBase'></a>

`TControllerBase`

The type of the base controller used to resolve the endpoint path\.
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIManager.CreateHttpClient_TControllerBase_(string,string).methodName'></a>

`methodName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the method within the controller to resolve\.

<a name='DiGi.GIS.WebAPI.Classes.GISWebAPIManager.CreateHttpClient_TControllerBase_(string,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path\.

#### Returns
[System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.HeatTransferCoefficientController'></a>

## HeatTransferCoefficientController Class

Controller responsible for handling API requests related to heat transfer coefficients, providing access to regulated heat transfer coefficient data\.

```csharp
public class HeatTransferCoefficientController : DiGi.WebAPI.Classes.WebAPIController
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Microsoft\.AspNetCore\.Mvc\.ControllerBase](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase 'Microsoft\.AspNetCore\.Mvc\.ControllerBase') → [DiGi\.WebAPI\.Classes\.WebAPIController](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.webapicontroller 'DiGi\.WebAPI\.Classes\.WebAPIController') → HeatTransferCoefficientController
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.HeatTransferCoefficientController.HeatTransferCoefficientController()'></a>

## HeatTransferCoefficientController\(\) Constructor

Initializes a new instance of the HeatTransferCoefficientController class\.

```csharp
public HeatTransferCoefficientController();
```
### Methods

<a name='DiGi.GIS.WebAPI.Classes.HeatTransferCoefficientController.GetRegulatedHeatTransferCoefficientsByYearAsync(short,System.Threading.CancellationToken)'></a>

## HeatTransferCoefficientController\.GetRegulatedHeatTransferCoefficientsByYearAsync\(short, CancellationToken\) Method

Retrieves the regulated heat transfer coefficients for a specified year\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetRegulatedHeatTransferCoefficientsByYearAsync(short year, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.HeatTransferCoefficientController.GetRegulatedHeatTransferCoefficientsByYearAsync(short,System.Threading.CancellationToken).year'></a>

`year` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The year used to filter the regulated heat transfer coefficients\.

<a name='DiGi.GIS.WebAPI.Classes.HeatTransferCoefficientController.GetRegulatedHeatTransferCoefficientsByYearAsync(short,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') representing the result of the request, containing the retrieved coefficients or an error status\.

<a name='DiGi.GIS.WebAPI.Classes.HistogramRequestParameter'></a>

## HistogramRequestParameter Class

Parameter class containing options for generating histograms\.

```csharp
public class HistogramRequestParameter : DiGi.WebAPI.Classes.Parameter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.WebAPI\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.parameter 'DiGi\.WebAPI\.Classes\.Parameter') → HistogramRequestParameter
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.HistogramRequestParameter.HistogramRequestParameter()'></a>

## HistogramRequestParameter\(\) Constructor

Initializes a new instance of the [HistogramRequestParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.HistogramRequestParameter 'DiGi\.GIS\.WebAPI\.Classes\.HistogramRequestParameter') class\.

```csharp
public HistogramRequestParameter();
```

<a name='DiGi.GIS.WebAPI.Classes.HistogramRequestParameter.HistogramRequestParameter(System.Text.Json.Nodes.JsonObject)'></a>

## HistogramRequestParameter\(JsonObject\) Constructor

Initializes a new instance of the [HistogramRequestParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.HistogramRequestParameter 'DiGi\.GIS\.WebAPI\.Classes\.HistogramRequestParameter') class using an [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') object\.

```csharp
public HistogramRequestParameter(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.HistogramRequestParameter.HistogramRequestParameter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing data used to initialize the parameter\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.HistogramRequestParameter.BucketCount'></a>

## HistogramRequestParameter\.BucketCount Property

Gets or sets the total number of histogram buckets\. Defaults to 10\.

Capped because the bucket count is width_bucket's divisor rather than a page size: the server builds and returns one row per bucket whatever the table holds, so an unbounded value turns a cheap aggregate into an arbitrarily large response.

```csharp
public int BucketCount { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

### Example
20

<a name='DiGi.GIS.WebAPI.Classes.HistogramRequestParameter.ColumnUniqueId'></a>

## HistogramRequestParameter\.ColumnUniqueId Property

Gets or sets the column unique identifier to calculate value distributions for\.

```csharp
public string ColumnUniqueId { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

### Example
"column\_unique\_id\_123"

<a name='DiGi.GIS.WebAPI.Classes.HistogramRequestParameter.CountyId'></a>

## HistogramRequestParameter\.CountyId Property

Gets or sets the target partition identifier \(County ID\)\. If null, histogram is generated across all partitions\.

```csharp
public System.Nullable<int> CountyId { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

### Example
10365

<a name='DiGi.GIS.WebAPI.Classes.HistogramRequestParameter.FilterGroup'></a>

## HistogramRequestParameter\.FilterGroup Property

Gets or sets the optional dynamic hierarchical filters to apply prior to generating the histogram\.

```csharp
public DiGi.PostgreSQL.Table.Classes.FilterGroup? FilterGroup { get; set; }
```

#### Property Value
[DiGi\.PostgreSQL\.Table\.Classes\.FilterGroup](https://learn.microsoft.com/en-us/dotnet/api/digi.postgresql.table.classes.filtergroup 'DiGi\.PostgreSQL\.Table\.Classes\.FilterGroup')

<a name='DiGi.GIS.WebAPI.Classes.MultivalueAggregateRequestParameter'></a>

## MultivalueAggregateRequestParameter Class

Parameter class containing options for multi\-value database aggregation queries\.

```csharp
public class MultivalueAggregateRequestParameter : DiGi.WebAPI.Classes.Parameter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.WebAPI\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.parameter 'DiGi\.WebAPI\.Classes\.Parameter') → MultivalueAggregateRequestParameter
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.MultivalueAggregateRequestParameter.MultivalueAggregateRequestParameter()'></a>

## MultivalueAggregateRequestParameter\(\) Constructor

Initializes a new instance of the [MultivalueAggregateRequestParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.MultivalueAggregateRequestParameter 'DiGi\.GIS\.WebAPI\.Classes\.MultivalueAggregateRequestParameter') class\.

```csharp
public MultivalueAggregateRequestParameter();
```

<a name='DiGi.GIS.WebAPI.Classes.MultivalueAggregateRequestParameter.MultivalueAggregateRequestParameter(System.Text.Json.Nodes.JsonObject)'></a>

## MultivalueAggregateRequestParameter\(JsonObject\) Constructor

Initializes a new instance of the [MultivalueAggregateRequestParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.MultivalueAggregateRequestParameter 'DiGi\.GIS\.WebAPI\.Classes\.MultivalueAggregateRequestParameter') class using a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') object\.

```csharp
public MultivalueAggregateRequestParameter(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.MultivalueAggregateRequestParameter.MultivalueAggregateRequestParameter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing data used to initialize the parameter\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.MultivalueAggregateRequestParameter.ColumnUniqueId'></a>

## MultivalueAggregateRequestParameter\.ColumnUniqueId Property

Gets or sets the column unique identifier to calculate statistics for\.

```csharp
public string ColumnUniqueId { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

### Example
"col\_unique\_id\_123"

<a name='DiGi.GIS.WebAPI.Classes.MultivalueAggregateRequestParameter.CountyId'></a>

## MultivalueAggregateRequestParameter\.CountyId Property

Gets or sets the target partition identifier \(County ID\)\. If null, aggregation is performed across all partitions\.

```csharp
public System.Nullable<int> CountyId { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

### Example
10365

<a name='DiGi.GIS.WebAPI.Classes.MultivalueAggregateRequestParameter.FilterGroup'></a>

## MultivalueAggregateRequestParameter\.FilterGroup Property

Gets or sets the optional dynamic hierarchical filters to apply prior to aggregation\.

```csharp
public DiGi.PostgreSQL.Table.Classes.FilterGroup? FilterGroup { get; set; }
```

#### Property Value
[DiGi\.PostgreSQL\.Table\.Classes\.FilterGroup](https://learn.microsoft.com/en-us/dotnet/api/digi.postgresql.table.classes.filtergroup 'DiGi\.PostgreSQL\.Table\.Classes\.FilterGroup')

<a name='DiGi.GIS.WebAPI.Classes.MultivalueAggregateRequestParameter.MultivalueAggregateFunction'></a>

## MultivalueAggregateRequestParameter\.MultivalueAggregateFunction Property

Gets or sets the multi\-value aggregation function to perform\.

```csharp
public DiGi.PostgreSQL.Table.Enums.MultivalueAggregateFunction MultivalueAggregateFunction { get; set; }
```

#### Property Value
[DiGi\.PostgreSQL\.Table\.Enums\.MultivalueAggregateFunction](https://learn.microsoft.com/en-us/dotnet/api/digi.postgresql.table.enums.multivalueaggregatefunction 'DiGi\.PostgreSQL\.Table\.Enums\.MultivalueAggregateFunction')

### Example
SplitDistinctCount

<a name='DiGi.GIS.WebAPI.Classes.MultivalueAggregateRequestParameter.Separator'></a>

## MultivalueAggregateRequestParameter\.Separator Property

Gets or sets the optional string separator; defaults to null triggering dynamic auto\-detection\.

```csharp
public string? Separator { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

### Example
","

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController'></a>

## OccupancyDataController Class

Controller responsible for handling requests related to occupancy data within the GIS PostgreSQL Web API\.

```csharp
public class OccupancyDataController : DiGi.WebAPI.Classes.WebAPIController
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Microsoft\.AspNetCore\.Mvc\.ControllerBase](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase 'Microsoft\.AspNetCore\.Mvc\.ControllerBase') → [DiGi\.WebAPI\.Classes\.WebAPIController](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.webapicontroller 'DiGi\.WebAPI\.Classes\.WebAPIController') → OccupancyDataController
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.OccupancyDataController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.Building2DOccupancyDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DOccupancyDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter)'></a>

## OccupancyDataController\(GISWebAPIConfigurationFileWatcher, Building2DOccupancyDataPostgreSQLConverter, AdministrativeAreal2DOccupancyDataPostgreSQLConverter, Building2DPostgreSQLConverter, AdministrativeAreal2DPostgreSQLConverter\) Constructor

Initializes a new instance of the OccupancyDataController class\.

```csharp
public OccupancyDataController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher GISWebAPIConfigurationFileWatcher, DiGi.GIS.PostgreSQL.Classes.Building2DOccupancyDataPostgreSQLConverter building2DOccupancyDataPostgreSQLConverter, DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DOccupancyDataPostgreSQLConverter administrativeAreal2DOccupancyDataPostgreSQLConverter, DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter building2DPostgreSQLConverter, DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter administrativeAreal2DPostgreSQLConverter);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.OccupancyDataController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.Building2DOccupancyDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DOccupancyDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).GISWebAPIConfigurationFileWatcher'></a>

`GISWebAPIConfigurationFileWatcher` [GISWebAPIConfigurationFileWatcher](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIConfigurationFileWatcher')

The configuration file watcher used to monitor settings for the GIS PostgreSQL Web API\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.OccupancyDataController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.Building2DOccupancyDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DOccupancyDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).building2DOccupancyDataPostgreSQLConverter'></a>

`building2DOccupancyDataPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.Building2DOccupancyDataPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.building2doccupancydatapostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.Building2DOccupancyDataPostgreSQLConverter')

The converter used for building 2D occupancy data operations in the PostgreSQL database\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.OccupancyDataController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.Building2DOccupancyDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DOccupancyDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).administrativeAreal2DOccupancyDataPostgreSQLConverter'></a>

`administrativeAreal2DOccupancyDataPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.AdministrativeAreal2DOccupancyDataPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.administrativeareal2doccupancydatapostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.AdministrativeAreal2DOccupancyDataPostgreSQLConverter')

The converter used for administrative areal 2D occupancy data operations in the PostgreSQL database\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.OccupancyDataController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.Building2DOccupancyDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DOccupancyDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).building2DPostgreSQLConverter'></a>

`building2DPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.Building2DPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.building2dpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.Building2DPostgreSQLConverter')

The converter for Building2D objects, used to read which county row a reference is already filed under\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.OccupancyDataController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.Building2DOccupancyDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DOccupancyDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).administrativeAreal2DPostgreSQLConverter'></a>

`administrativeAreal2DPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.AdministrativeAreal2DPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.administrativeareal2dpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.AdministrativeAreal2DPostgreSQLConverter')

The converter used for administrative areal 2D data operations in the PostgreSQL database\.
### Methods

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.AdministrativeAreal2DUpdateItemsAsync(System.Text.Json.Nodes.JsonArray)'></a>

## OccupancyDataController\.AdministrativeAreal2DUpdateItemsAsync\(JsonArray\) Method

Asynchronously updates occupancy data items for administrative areal 2D entities\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> AdministrativeAreal2DUpdateItemsAsync(System.Text.Json.Nodes.JsonArray? jsonArray);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.AdministrativeAreal2DUpdateItemsAsync(System.Text.Json.Nodes.JsonArray).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray') containing the occupancy data items to be updated\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') representing the result of the update operation, returning a bad request if updates are disabled or no content if the input array is null or empty\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.Building2DUpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string)'></a>

## OccupancyDataController\.Building2DUpdateItemsAsync\(JsonArray, string\) Method

Asynchronously updates building 2D items based on the provided JSON data and identification code\.

A county code does not identify a single county row: BDOT10k stores a county whose territory is disconnected as one feature per polygon part, and every part becomes its own row. Every part the code names is passed on, and each datum is filed under the part it actually belongs to - see [Building2DUpdateItemsByCountyIdsAsync\(JsonArray, int\[\]\)](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.OccupancyDataController.Building2DUpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[]) 'DiGi\.GIS\.WebAPI\.Classes\.OccupancyDataController\.Building2DUpdateItemsByCountyIdsAsync\(System\.Text\.Json\.Nodes\.JsonArray, int\[\]\)') for how that is decided.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> Building2DUpdateItemsAsync(System.Text.Json.Nodes.JsonArray? jsonArray, string code);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.Building2DUpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray') containing the item data to be updated\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.Building2DUpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The identification code used to validate or categorize the update request\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.Building2DUpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[])'></a>

## OccupancyDataController\.Building2DUpdateItemsByCountyIdsAsync\(JsonArray, int\[\]\) Method

Asynchronously updates building 2D occupancy items in the database for the given county rows\.

The unambiguous counterpart of [Building2DUpdateItemsAsync\(JsonArray, string\)](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.OccupancyDataController.Building2DUpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string) 'DiGi\.GIS\.WebAPI\.Classes\.OccupancyDataController\.Building2DUpdateItemsAsync\(System\.Text\.Json\.Nodes\.JsonArray, string\)'): it takes county identifiers rather than a code, so the caller states which rows are in play instead of leaving the server to derive them.

A single identifier is taken as stated and every datum is filed under it. Several identifiers are the polygon parts of one multi-part county, and each datum is then filed under the part already holding the `building_2d` row its reference names, probed lowest part first. That row was filed by geometry when it was imported, so reusing its answer keeps both tables keyed by the same `(county_id, reference)` pair.

A datum whose reference no part holds is not written: it carries no geometry of its own, so nothing states where it belongs, and storing it under a guessed part is the state this replaced.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> Building2DUpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray? jsonArray, int[]? countyIds);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.Building2DUpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[]).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray') containing the item data to be updated\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.Building2DUpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[]).countyIds'></a>

`countyIds` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The identifiers of the county rows the occupancy data belong to\. Normally every polygon part of one county\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.GetAdministrativeAreal2DItemsByReferenceAsync(string,System.Threading.CancellationToken)'></a>

## OccupancyDataController\.GetAdministrativeAreal2DItemsByReferenceAsync\(string, CancellationToken\) Method

Retrieves administrative areal 2D items based on the provided reference identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetAdministrativeAreal2DItemsByReferenceAsync(string reference, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.GetAdministrativeAreal2DItemsByReferenceAsync(string,System.Threading.CancellationToken).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique reference string used to identify the administrative areal 2D items\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.GetAdministrativeAreal2DItemsByReferenceAsync(string,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') representing the result of the operation, containing the requested items or an error response\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.GetBuilding2DDuplicateReferencesAsync(System.Nullable_int_,int,int,System.Threading.CancellationToken)'></a>

## OccupancyDataController\.GetBuilding2DDuplicateReferencesAsync\(Nullable\<int\>, int, int, CancellationToken\) Method

Asynchronously retrieves the building references that hold more than one occupancy data record, optionally filtered by county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetBuilding2DDuplicateReferencesAsync(System.Nullable<int> countyId=null, int limit=100, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.GetBuilding2DDuplicateReferencesAsync(System.Nullable_int_,int,int,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional integer identifier of the county to filter by; if null, searches across all counties\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.GetBuilding2DDuplicateReferencesAsync(System.Nullable_int_,int,int,System.Threading.CancellationToken).limit'></a>

`limit` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of duplicate references to return\. Defaults to 100\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.GetBuilding2DDuplicateReferencesAsync(System.Nullable_int_,int,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.GetBuilding2DDuplicateReferencesAsync(System.Nullable_int_,int,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token used to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') containing the list of duplicate references, or 404 if none are found\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.GetBuilding2DDuplicatesCountAsync(System.Nullable_int_,int,System.Threading.CancellationToken)'></a>

## OccupancyDataController\.GetBuilding2DDuplicatesCountAsync\(Nullable\<int\>, int, CancellationToken\) Method

Asynchronously retrieves the total count of building references that hold more than one occupancy data record, optionally filtered by county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetBuilding2DDuplicatesCountAsync(System.Nullable<int> countyId=null, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.GetBuilding2DDuplicatesCountAsync(System.Nullable_int_,int,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional integer identifier of the county to filter by; if null, counts across all counties\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.GetBuilding2DDuplicatesCountAsync(System.Nullable_int_,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.GetBuilding2DDuplicatesCountAsync(System.Nullable_int_,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token used to observe while waiting for the task to complete\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') carrying the duplicates count, or 404 if the partition does not exist or count is negative\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.GetBuilding2DItemsByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken)'></a>

## OccupancyDataController\.GetBuilding2DItemsByReferenceAsync\(string, Nullable\<int\>, CancellationToken\) Method

Retrieves Building 2D occupancy data items based on a specified reference and an optional county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetBuilding2DItemsByReferenceAsync(string reference, System.Nullable<int> countyId, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.GetBuilding2DItemsByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique reference string used to identify the building 2D items\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.GetBuilding2DItemsByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional identifier of the county associated with the building data\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDataController.GetBuilding2DItemsByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') containing the requested building 2D items, or a [Microsoft\.AspNetCore\.Mvc\.BadRequestResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.badrequestresult 'Microsoft\.AspNetCore\.Mvc\.BadRequestResult') if the reference is null or whitespace\.

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDatasPostTask'></a>

## OccupancyDatasPostTask Class

Represents a task for posting occupancy data to the GIS PostgreSQL Web API\.

```csharp
public class OccupancyDatasPostTask : DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask<DiGi.GIS.Classes.OccupancyData>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.BackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.backgroundtask 'DiGi\.Core\.Classes\.BackgroundTask') → [DiGi\.Core\.Classes\.CancelableBackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cancelablebackgroundtask 'DiGi\.Core\.Classes\.CancelableBackgroundTask') → [DiGi\.Core\.Classes\.ReportableBackgroundTask&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1') → [DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask&lt;](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_ 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>')[DiGi\.GIS\.Classes\.OccupancyData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.occupancydata 'DiGi\.GIS\.Classes\.OccupancyData')[&gt;](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_ 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>') → OccupancyDatasPostTask
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDatasPostTask.OccupancyDatasPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager)'></a>

## OccupancyDatasPostTask\(GISWebAPIManager\) Constructor

Initializes a new instance of the OccupancyDatasPostTask class\.

```csharp
public OccupancyDatasPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager GISWebAPIManager);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDatasPostTask.OccupancyDatasPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The manager used to handle GIS PostgreSQL Web API operations\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDatasPostTask.Code'></a>

## OccupancyDatasPostTask\.Code Property

Gets or sets the code associated with the occupancy data post task\.

A code does not identify a single county row - a multi-part county holds one row per polygon part - so set [CountyId](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.OccupancyDatasPostTask.CountyId 'DiGi\.GIS\.WebAPI\.Classes\.OccupancyDatasPostTask\.CountyId') instead wherever the identifier is already known. [CountyId](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.OccupancyDatasPostTask.CountyId 'DiGi\.GIS\.WebAPI\.Classes\.OccupancyDatasPostTask\.CountyId') takes precedence when both are set.

```csharp
public string? Code { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDatasPostTask.CountyId'></a>

## OccupancyDatasPostTask\.CountyId Property

Gets or sets the identifier of the county row the building 2D occupancy data belong to\. When set it is used in preference to [Code](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.OccupancyDatasPostTask.Code 'DiGi\.GIS\.WebAPI\.Classes\.OccupancyDatasPostTask\.Code'), which leaves the server to choose between the rows of a multi\-part county\. It does not affect [Values\_AdministrativeAreal2D](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.OccupancyDatasPostTask.Values_AdministrativeAreal2D 'DiGi\.GIS\.WebAPI\.Classes\.OccupancyDatasPostTask\.Values\_AdministrativeAreal2D'), which is not county\-keyed\.

```csharp
public System.Nullable<int> CountyId { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.GIS.WebAPI.Classes.OccupancyDatasPostTask.Values_AdministrativeAreal2D'></a>

## OccupancyDatasPostTask\.Values\_AdministrativeAreal2D Property

Gets or sets the collection of [DiGi\.GIS\.Classes\.OccupancyData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.occupancydata 'DiGi\.GIS\.Classes\.OccupancyData') values for administrative areal 2D\.

```csharp
public System.Collections.Generic.IEnumerable<DiGi.GIS.Classes.OccupancyData>? Values_AdministrativeAreal2D { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.Classes\.OccupancyData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.occupancydata 'DiGi\.GIS\.Classes\.OccupancyData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController'></a>

## OrtoDatasController Class

Controller providing API endpoints for managing and accessing orthophoto data and related GIS spatial information via a PostgreSQL database\.

```csharp
public class OrtoDatasController : DiGi.WebAPI.Classes.WebAPIController
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Microsoft\.AspNetCore\.Mvc\.ControllerBase](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase 'Microsoft\.AspNetCore\.Mvc\.ControllerBase') → [DiGi\.WebAPI\.Classes\.WebAPIController](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.webapicontroller 'DiGi\.WebAPI\.Classes\.WebAPIController') → OrtoDatasController
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.OrtoDatasController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.OrtoDatasPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter)'></a>

## OrtoDatasController\(GISWebAPIConfigurationFileWatcher, OrtoDatasPostgreSQLConverter, Building2DPostgreSQLConverter, AdministrativeAreal2DPostgreSQLConverter\) Constructor

Initializes a new instance of the OrtoDatasController class\.

```csharp
public OrtoDatasController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher GISWebAPIConfigurationFileWatcher, DiGi.GIS.PostgreSQL.Classes.OrtoDatasPostgreSQLConverter ortoDatasPostgreSQLConverter, DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter building2DPostgreSQLConverter, DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter administrativeAreal2DPostgreSQLConverter);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.OrtoDatasController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.OrtoDatasPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).GISWebAPIConfigurationFileWatcher'></a>

`GISWebAPIConfigurationFileWatcher` [GISWebAPIConfigurationFileWatcher](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIConfigurationFileWatcher')

The configuration file watcher used to monitor changes to the GIS PostgreSQL Web API settings\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.OrtoDatasController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.OrtoDatasPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).ortoDatasPostgreSQLConverter'></a>

`ortoDatasPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.OrtoDatasPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.ortodataspostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.OrtoDatasPostgreSQLConverter')

The converter used for handling OrtoDatas data operations within the PostgreSQL database\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.OrtoDatasController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.OrtoDatasPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).building2DPostgreSQLConverter'></a>

`building2DPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.Building2DPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.building2dpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.Building2DPostgreSQLConverter')

The converter used for handling Building 2D data operations within the PostgreSQL database\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.OrtoDatasController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.OrtoDatasPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).administrativeAreal2DPostgreSQLConverter'></a>

`administrativeAreal2DPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.AdministrativeAreal2DPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.administrativeareal2dpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.AdministrativeAreal2DPostgreSQLConverter')

The converter used for handling Administrative Areal 2D data operations within the PostgreSQL database\.
### Methods

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.AcknowledgeBuilding2DReferencesAsync(System.Collections.Generic.IEnumerable_long_,System.Threading.CancellationToken)'></a>

## OrtoDatasController\.AcknowledgeBuilding2DReferencesAsync\(IEnumerable\<long\>, CancellationToken\) Method

Acknowledges and deletes completed building 2D reference objects from the update queue\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> AcknowledgeBuilding2DReferencesAsync(System.Collections.Generic.IEnumerable<long>? ids, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.AcknowledgeBuilding2DReferencesAsync(System.Collections.Generic.IEnumerable_long_,System.Threading.CancellationToken).ids'></a>

`ids` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of queue entry identifiers to acknowledge and remove from the queue\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.AcknowledgeBuilding2DReferencesAsync(System.Collections.Generic.IEnumerable_long_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.ContainsByReferencesAsync(System.Collections.Generic.List_string_,System.Nullable_int_,System.Nullable_bool_,System.Threading.CancellationToken)'></a>

## OrtoDatasController\.ContainsByReferencesAsync\(List\<string\>, Nullable\<int\>, Nullable\<bool\>, CancellationToken\) Method

Asynchronously checks for the existence of a collection of references, optionally filtered by a county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> ContainsByReferencesAsync(System.Collections.Generic.List<string>? references, System.Nullable<int> countyId, System.Nullable<bool> inverted, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.ContainsByReferencesAsync(System.Collections.Generic.List_string_,System.Nullable_int_,System.Nullable_bool_,System.Threading.CancellationToken).references'></a>

`references` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

A list of strings representing the references to be checked\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.ContainsByReferencesAsync(System.Collections.Generic.List_string_,System.Nullable_int_,System.Nullable_bool_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The identifier of the county partition to confine the check to\. Omit to search every partition\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.ContainsByReferencesAsync(System.Collections.Generic.List_string_,System.Nullable_int_,System.Nullable_bool_,System.Threading.CancellationToken).inverted'></a>

`inverted` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

Returns the references that are absent rather than the ones present\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.ContainsByReferencesAsync(System.Collections.Generic.List_string_,System.Nullable_int_,System.Nullable_bool_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetCountByCountyIdAsync(int,bool,bool,int,System.Threading.CancellationToken)'></a>

## OrtoDatasController\.GetCountByCountyIdAsync\(int, bool, bool, int, CancellationToken\) Method

Asynchronously retrieves the number of orthophoto rows stored for one county partition\.

The cheapest question that can be asked of the store, and the one that separates a county nothing was ever downloaded for from one that was downloaded and holds nothing.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetCountByCountyIdAsync(int countyId, bool estimated=false, bool analyze=false, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetCountByCountyIdAsync(int,bool,bool,int,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county partition to count\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetCountByCountyIdAsync(int,bool,bool,int,System.Threading.CancellationToken).estimated'></a>

`estimated` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Reads the planner's row estimate instead of counting the rows\. Far faster on a large partition and accurate to a few percent, but it reflects the last time the partition was analysed rather than this moment\. An unanalysed partition returns 204 NoContent\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetCountByCountyIdAsync(int,bool,bool,int,System.Threading.CancellationToken).analyze'></a>

`analyze` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A boolean value indicating whether to perform an ANALYZE operation before reading the estimate to ensure statistics are current\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetCountByCountyIdAsync(int,bool,bool,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetCountByCountyIdAsync(int,bool,bool,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') carrying the count, 204 NoContent when the partition exists but is unanalysed, or 404 NotFound when the county has no partition\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetEstimatedCoverageFactorAsync(int,int,System.Threading.CancellationToken)'></a>

## OrtoDatasController\.GetEstimatedCoverageFactorAsync\(int, int, CancellationToken\) Method

Retrieves the orthophoto coverage factor for a specified administrative area 2D identifier\.

Below county level the figure is counted rather than estimated. A subdivision and a municipality have no partition of their own - both tables are partitioned by `county_id` - so the coverage is measured over that area's own buildings, by reading its county once per side and matching the references in memory. County and above keep the planner's row estimate, which is what makes a voivodeship or a country affordable at all, so an exact sub-county figure and its county's estimate can differ by a few percent and both be right.

A coverage that cannot be measured answers 204 NoContent, never zero. A county nothing has ever been downloaded for and a county that was downloaded and holds nothing are different facts, and reporting both as 0.0 hid the first behind a plausible number.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetEstimatedCoverageFactorAsync(int administrativeAreal2DId, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetEstimatedCoverageFactorAsync(int,int,System.Threading.CancellationToken).administrativeAreal2DId'></a>

`administrativeAreal2DId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The unique identifier of the administrative area 2D\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetEstimatedCoverageFactorAsync(int,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of each command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetEstimatedCoverageFactorAsync(int,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') carrying the coverage factor, 204 NoContent when it could not be measured, or an error status code\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetEstimatedCoverageFactorsAsync(System.Collections.Generic.IEnumerable_int_,System.Nullable_bool_,int,System.Threading.CancellationToken)'></a>

## OrtoDatasController\.GetEstimatedCoverageFactorsAsync\(IEnumerable\<int\>, Nullable\<bool\>, int, CancellationToken\) Method

Retrieves the orthophoto coverage factors for the specified administrative area identifiers\.

The values come back in the order the identifiers were given, one per identifier, so a caller can update one row per value without matching anything up. A value is `null` where the coverage could not be measured, which is never the same thing as zero.

A county, a voivodeship and a country are answered from the two tables row estimates - every identifier is resolved to the counties it stands for and both estimates are read for the whole set in one query per table. A subdivision and a municipality have no partition of their own and are instead counted, over their own buildings, by reading their county once per side; every subdivision and municipality of one county is served from that single pass.

Because counting reads a whole county, at most [MaximumCoverageCountyCount](DiGi.GIS.WebAPI.Constants.md#DiGi.GIS.WebAPI.Constants.OrtoDatas.MaximumCoverageCountyCount 'DiGi\.GIS\.WebAPI\.Constants\.OrtoDatas\.MaximumCoverageCountyCount') distinct counties are counted per request, taken in the order the identifiers were given. Identifiers sitting in counties beyond that are answered `null` rather than given their county figure or failing the request.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetEstimatedCoverageFactorsAsync(System.Collections.Generic.IEnumerable<int> administrativeAreal2DIds, System.Nullable<bool> analyze, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetEstimatedCoverageFactorsAsync(System.Collections.Generic.IEnumerable_int_,System.Nullable_bool_,int,System.Threading.CancellationToken).administrativeAreal2DIds'></a>

`administrativeAreal2DIds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of administrative area 2D identifiers to be processed\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetEstimatedCoverageFactorsAsync(System.Collections.Generic.IEnumerable_int_,System.Nullable_bool_,int,System.Threading.CancellationToken).analyze'></a>

`analyze` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

Refreshes the statistics before reading them\. This applies only to the estimated county\-and\-above path and does nothing for a subdivision or a municipality, which are counted\. It costs one `VACUUM ANALYZE` per resolved county partition on each of the two tables \- for a country identifier that is several hundred maintenance statements against live partitions, so raise `commandtimeout` to match or leave the flag off\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetEstimatedCoverageFactorsAsync(System.Collections.Generic.IEnumerable_int_,System.Nullable_bool_,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of each command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetEstimatedCoverageFactorsAsync(System.Collections.Generic.IEnumerable_int_,System.Nullable_bool_,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetImageByReferenceAsync(string,short,System.Nullable_int_,System.Threading.CancellationToken)'></a>

## OrtoDatasController\.GetImageByReferenceAsync\(string, short, Nullable\<int\>, CancellationToken\) Method

Retrieves orthophoto image data based on the provided reference, year, and optional county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetImageByReferenceAsync(string reference, short year, System.Nullable<int> countyId=null, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetImageByReferenceAsync(string,short,System.Nullable_int_,System.Threading.CancellationToken).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique reference string of the orthophoto image\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetImageByReferenceAsync(string,short,System.Nullable_int_,System.Threading.CancellationToken).year'></a>

`year` [System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

The production or capture year of the orthophoto image\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetImageByReferenceAsync(string,short,System.Nullable_int_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional identifier of the county associated with the orthophoto data\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetImageByReferenceAsync(string,short,System.Nullable_int_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetItemByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken)'></a>

## OrtoDatasController\.GetItemByReferenceAsync\(string, Nullable\<int\>, CancellationToken\) Method

Asynchronously retrieves an orthodata item based on the specified reference and optional county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemByReferenceAsync(string reference, System.Nullable<int> countyId=null, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetItemByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique reference string used to locate the orthodata item\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetItemByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional identifier of the county associated with the orthodata item\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetItemByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetOrtoDatasReferenceByReferenceAsync(string,System.Nullable_int_,bool,System.Threading.CancellationToken)'></a>

## OrtoDatasController\.GetOrtoDatasReferenceByReferenceAsync\(string, Nullable\<int\>, bool, CancellationToken\) Method

Retrieves an orthodata reference by its unique reference code and an optional county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetOrtoDatasReferenceByReferenceAsync(string reference, System.Nullable<int> countyId=null, bool fallbackByReference=false, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetOrtoDatasReferenceByReferenceAsync(string,System.Nullable_int_,bool,System.Threading.CancellationToken).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique reference string of the building to retrieve orthodata metadata for\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetOrtoDatasReferenceByReferenceAsync(string,System.Nullable_int_,bool,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional integer identifier of the county used to filter the search\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetOrtoDatasReferenceByReferenceAsync(string,System.Nullable_int_,bool,System.Threading.CancellationToken).fallbackByReference'></a>

`fallbackByReference` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A boolean value indicating whether to perform a fallback search across all partitions if not matched by county\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetOrtoDatasReferenceByReferenceAsync(string,System.Nullable_int_,bool,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetOrtoDatasReferencesByBuilding2DReferencesAsync(System.Collections.Generic.IEnumerable_DiGi.GIS.PostgreSQL.Classes.Building2DReference_,bool,System.Threading.CancellationToken)'></a>

## OrtoDatasController\.GetOrtoDatasReferencesByBuilding2DReferencesAsync\(IEnumerable\<Building2DReference\>, bool, CancellationToken\) Method

Retrieves a list of orthodata references for the specified building 2D reference objects\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetOrtoDatasReferencesByBuilding2DReferencesAsync(System.Collections.Generic.IEnumerable<DiGi.GIS.PostgreSQL.Classes.Building2DReference> building2DReferences, bool fallbackByReference=false, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetOrtoDatasReferencesByBuilding2DReferencesAsync(System.Collections.Generic.IEnumerable_DiGi.GIS.PostgreSQL.Classes.Building2DReference_,bool,System.Threading.CancellationToken).building2DReferences'></a>

`building2DReferences` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.GIS\.PostgreSQL\.Classes\.Building2DReference](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.building2dreference 'DiGi\.GIS\.PostgreSQL\.Classes\.Building2DReference')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of [DiGi\.GIS\.PostgreSQL\.Classes\.Building2DReference](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.building2dreference 'DiGi\.GIS\.PostgreSQL\.Classes\.Building2DReference') objects to query\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetOrtoDatasReferencesByBuilding2DReferencesAsync(System.Collections.Generic.IEnumerable_DiGi.GIS.PostgreSQL.Classes.Building2DReference_,bool,System.Threading.CancellationToken).fallbackByReference'></a>

`fallbackByReference` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A boolean value indicating whether to perform a fallback search across all partitions if not matched by county\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetOrtoDatasReferencesByBuilding2DReferencesAsync(System.Collections.Generic.IEnumerable_DiGi.GIS.PostgreSQL.Classes.Building2DReference_,bool,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetOrtoDatasReferencesByCountyIdAsync(int,int[],System.Threading.CancellationToken)'></a>

## OrtoDatasController\.GetOrtoDatasReferencesByCountyIdAsync\(int, int\[\], CancellationToken\) Method

Retrieves a list of orthodata references for a specified county, with optional subdivision filtering\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetOrtoDatasReferencesByCountyIdAsync(int countyId, int[]? subdivisionIds=null, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetOrtoDatasReferencesByCountyIdAsync(int,int[],System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer identifier of the county\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetOrtoDatasReferencesByCountyIdAsync(int,int[],System.Threading.CancellationToken).subdivisionIds'></a>

`subdivisionIds` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

An optional array of subdivision identifiers to filter by\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetOrtoDatasReferencesByCountyIdAsync(int,int[],System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetOrtoDatasReferencesByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,bool,System.Threading.CancellationToken)'></a>

## OrtoDatasController\.GetOrtoDatasReferencesByReferencesAsync\(IEnumerable\<string\>, Nullable\<int\>, bool, CancellationToken\) Method

Retrieves a list of orthodata references for the specified building reference codes and optional county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetOrtoDatasReferencesByReferencesAsync(System.Collections.Generic.IEnumerable<string> references, System.Nullable<int> countyId=null, bool fallbackByReference=false, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetOrtoDatasReferencesByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,bool,System.Threading.CancellationToken).references'></a>

`references` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of unique reference strings to query\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetOrtoDatasReferencesByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,bool,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional integer identifier of the county used to filter the search\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetOrtoDatasReferencesByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,bool,System.Threading.CancellationToken).fallbackByReference'></a>

`fallbackByReference` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A boolean value indicating whether to perform a fallback search across all partitions if not matched by county\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetOrtoDatasReferencesByReferencesAsync(System.Collections.Generic.IEnumerable_string_,System.Nullable_int_,bool,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The cancellation token to observe\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetQueueSummariesByCountyIdsAsync(System.Collections.Generic.List_int_,int,System.Threading.CancellationToken)'></a>

## OrtoDatasController\.GetQueueSummariesByCountyIdsAsync\(List\<int\>, int, CancellationToken\) Method

Asynchronously reports what each of the named counties still has waiting in the orthophoto download queue\.

Reads the queue without claiming anything from it, unlike [NextBuilding2DReferencesAsync\(int, int, int, CancellationToken\)](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.OrtoDatasController.NextBuilding2DReferencesAsync(int,int,int,System.Threading.CancellationToken) 'DiGi\.GIS\.WebAPI\.Classes\.OrtoDatasController\.NextBuilding2DReferencesAsync\(int, int, int, System\.Threading\.CancellationToken\)'), which claims the rows it returns. It is the only way to see what a refresh queued, and the way to watch the refresh and the download move against each other.

Naming no county reports every one. Counties with nothing waiting are absent from the result rather than present with a zero, so an empty result means the queue is drained.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetQueueSummariesByCountyIdsAsync(System.Collections.Generic.List<int>? countyIds, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetQueueSummariesByCountyIdsAsync(System.Collections.Generic.List_int_,int,System.Threading.CancellationToken).countyIds'></a>

`countyIds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The identifiers of the counties to report on, repeated once per county\. Omit to report every one\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetQueueSummariesByCountyIdsAsync(System.Collections.Generic.List_int_,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetQueueSummariesByCountyIdsAsync(System.Collections.Generic.List_int_,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') carrying the queue depths as JSON, or an error status\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetSubdivisionLinksByCountyIdAsync(int,int,int,System.Threading.CancellationToken)'></a>

## OrtoDatasController\.GetSubdivisionLinksByCountyIdAsync\(int, int, int, CancellationToken\) Method

Asynchronously compares, for one county, the subdivision each building is filed under against the one its orthophoto row carries\.

The two tables live in different databases, so nothing keeps them in step on its own and no query can join them - each side is read once and matched in memory. This is the only place the two can be seen together.

Read the result across a run rather than on its own. `OrtoDatasOnlyCount` counts rows whose orthophoto knows a subdivision the building no longer does, and nothing legitimate removes one, so a refresh that lowers it is doing damage. `Building2DOnlyCount` counts what a refresh exists to fix: it should fall to near zero and stay there, and climbing again once the download drains the queue is issue #36.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetSubdivisionLinksByCountyIdAsync(int countyId, int sampleCount=20, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetSubdivisionLinksByCountyIdAsync(int,int,int,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county to compare\. One polygon part, not a code \- a multi\-part county is compared a part at a time\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetSubdivisionLinksByCountyIdAsync(int,int,int,System.Threading.CancellationToken).sampleCount'></a>

`sampleCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

How many references to name back per disagreeing category\. The counts are exact whatever this is; the samples are what make a disagreement actionable\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetSubdivisionLinksByCountyIdAsync(int,int,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of each command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetSubdivisionLinksByCountyIdAsync(int,int,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') carrying the comparison as JSON, or an error status\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetSummariesByCountyIdsAsync(System.Collections.Generic.List_int_,int,System.Threading.CancellationToken)'></a>

## OrtoDatasController\.GetSummariesByCountyIdsAsync\(List\<int\>, int, CancellationToken\) Method

Asynchronously summarises what each of the named county partitions holds: how many rows, how many name a subdivision, how many distinct subdivisions they are spread across, and when they were written\.

The measurement to take either side of a refresh. A building's subdivision is resolved in another database and pushed across, so [DiGi\.GIS\.PostgreSQL\.Classes\.OrtoDatasCountyResult\.WithSubdivisionIdCount](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.ortodatascountyresult.withsubdivisionidcount 'DiGi\.GIS\.PostgreSQL\.Classes\.OrtoDatasCountyResult\.WithSubdivisionIdCount') can only ever be gained - a run that lowers it is clearing subdivisions rather than filling them in, which is the defect of issues #23, #31 and #36.

Naming no county summarises every partition, in one grouped statement. Counties holding no row are absent from the result rather than present with a zero.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetSummariesByCountyIdsAsync(System.Collections.Generic.List<int>? countyIds, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetSummariesByCountyIdsAsync(System.Collections.Generic.List_int_,int,System.Threading.CancellationToken).countyIds'></a>

`countyIds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The identifiers of the county partitions to summarise, repeated once per county\. Omit to summarise every one\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetSummariesByCountyIdsAsync(System.Collections.Generic.List_int_,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.GetSummariesByCountyIdsAsync(System.Collections.Generic.List_int_,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') carrying the summaries as JSON, or an error status\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.NextBuilding2DReferencesAsync(int,int,int,System.Threading.CancellationToken)'></a>

## OrtoDatasController\.NextBuilding2DReferencesAsync\(int, int, int, CancellationToken\) Method

Retrieves and claims the next batch of building 2D reference objects from the update queue\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> NextBuilding2DReferencesAsync(int count=100, int claimTimeoutMinutes=30, int commandTimeout=60, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.NextBuilding2DReferencesAsync(int,int,int,System.Threading.CancellationToken).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The maximum number of building 2D reference objects to retrieve\. Defaults to 100\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.NextBuilding2DReferencesAsync(int,int,int,System.Threading.CancellationToken).claimTimeoutMinutes'></a>

`claimTimeoutMinutes` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The duration in minutes before an unacknowledged claim expires and returns to the queue\. Defaults to 30\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.NextBuilding2DReferencesAsync(int,int,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\. Defaults to 60 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.NextBuilding2DReferencesAsync(int,int,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.UpdateItemsByCodeAsync(System.Text.Json.Nodes.JsonArray,string)'></a>

## OrtoDatasController\.UpdateItemsByCodeAsync\(JsonArray, string\) Method

Updates items identified by a specific code using the provided JSON array\.

A county code does not identify a single county row: BDOT10k stores a county whose territory is disconnected as one feature per polygon part, and every part becomes its own row. Every part the code names is passed on, and each entry is filed under the part it actually belongs to - see [UpdateItemsByCountyIdsAsync\(JsonArray, int\[\]\)](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.OrtoDatasController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[]) 'DiGi\.GIS\.WebAPI\.Classes\.OrtoDatasController\.UpdateItemsByCountyIdsAsync\(System\.Text\.Json\.Nodes\.JsonArray, int\[\]\)') for how that is decided.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateItemsByCodeAsync(System.Text.Json.Nodes.JsonArray? jsonArray, string code);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.UpdateItemsByCodeAsync(System.Text.Json.Nodes.JsonArray,string).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The JSON array containing the updated item data\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.UpdateItemsByCodeAsync(System.Text.Json.Nodes.JsonArray,string).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier or code used to identify the items for update\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[])'></a>

## OrtoDatasController\.UpdateItemsByCountyIdsAsync\(JsonArray, int\[\]\) Method

Updates orthodata items associated with the given county rows\.

A single identifier is taken as stated and every entry is filed under it. Several identifiers are the polygon parts of one multi-part county, and each entry is then filed under the part it belongs to, decided in two steps:

1. the part already holding the entry's `building_2d` row, probed lowest part first. That row was filed by geometry when it was imported, and reusing its answer keeps both tables keyed by the same `(county_id, reference)` pair - orthodata filed under a part its building is not stored in reads back as missing.

2. geometry, for an entry no part holds a 2D row for: the part containing its bounding box, else the nearest part, else the part it overlaps most. Done by the converter, which drops an entry it cannot place rather than filing it under a guess.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray? jsonArray, int[]? countyIds);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[]).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The JSON array containing the orthodata items to be updated\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[]).countyIds'></a>

`countyIds` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The identifiers of the county rows the entries belong to\. Normally every polygon part of one county\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasFromDatabasePostTask'></a>

## OrtoDatasFromDatabasePostTask Class

Handles the process of posting orthodata retrieved from the database\.

```csharp
public class OrtoDatasFromDatabasePostTask : DiGi.GIS.WebAPI.Classes.OrtoDatasPostTask
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.BackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.backgroundtask 'DiGi\.Core\.Classes\.BackgroundTask') → [DiGi\.Core\.Classes\.CancelableBackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cancelablebackgroundtask 'DiGi\.Core\.Classes\.CancelableBackgroundTask') → [DiGi\.Core\.Classes\.ReportableBackgroundTask&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1') → [DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask&lt;](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_ 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>')[DiGi\.GIS\.Classes\.OrtoDatas](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.ortodatas 'DiGi\.GIS\.Classes\.OrtoDatas')[&gt;](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_ 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>') → [OrtoDatasPostTask](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.OrtoDatasPostTask 'DiGi\.GIS\.WebAPI\.Classes\.OrtoDatasPostTask') → OrtoDatasFromDatabasePostTask
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasFromDatabasePostTask.OrtoDatasFromDatabasePostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager)'></a>

## OrtoDatasFromDatabasePostTask\(GISWebAPIManager\) Constructor

Handles the process of posting orthodata retrieved from the database\.

```csharp
public OrtoDatasFromDatabasePostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager GISWebAPIManager);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasFromDatabasePostTask.OrtoDatasFromDatabasePostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The manager responsible for handling GIS PostgreSQL Web API communications\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasPostTask'></a>

## OrtoDatasPostTask Class

Handles the posting of OrtoDatas objects to the PostgreSQL web API\.

```csharp
public class OrtoDatasPostTask : DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask<DiGi.GIS.Classes.OrtoDatas>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.BackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.backgroundtask 'DiGi\.Core\.Classes\.BackgroundTask') → [DiGi\.Core\.Classes\.CancelableBackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cancelablebackgroundtask 'DiGi\.Core\.Classes\.CancelableBackgroundTask') → [DiGi\.Core\.Classes\.ReportableBackgroundTask&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1') → [DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask&lt;](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_ 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>')[DiGi\.GIS\.Classes\.OrtoDatas](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.ortodatas 'DiGi\.GIS\.Classes\.OrtoDatas')[&gt;](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_ 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>') → OrtoDatasPostTask

Derived  
↳ [OrtoDatasFromDatabasePostTask](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.OrtoDatasFromDatabasePostTask 'DiGi\.GIS\.WebAPI\.Classes\.OrtoDatasFromDatabasePostTask')
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasPostTask.OrtoDatasPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager)'></a>

## OrtoDatasPostTask\(GISWebAPIManager\) Constructor

Handles the posting of OrtoDatas objects to the PostgreSQL web API\.

```csharp
public OrtoDatasPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager GISWebAPIManager);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasPostTask.OrtoDatasPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The manager instance used to handle PostgreSQL web API operations\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasPostTask.Code'></a>

## OrtoDatasPostTask\.Code Property

Gets or sets the code associated with the OrtoDatas post task\.

A code does not identify a single county row - a multi-part county holds one row per polygon part - so set [CountyId](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.OrtoDatasPostTask.CountyId 'DiGi\.GIS\.WebAPI\.Classes\.OrtoDatasPostTask\.CountyId') instead wherever the identifier is already known. [CountyId](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.OrtoDatasPostTask.CountyId 'DiGi\.GIS\.WebAPI\.Classes\.OrtoDatasPostTask\.CountyId') takes precedence when both are set.

```csharp
public string? Code { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasPostTask.CountyId'></a>

## OrtoDatasPostTask\.CountyId Property

Gets or sets the identifier of the county row the OrtoDatas belong to\. When set it is used in preference to [Code](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.OrtoDatasPostTask.Code 'DiGi\.GIS\.WebAPI\.Classes\.OrtoDatasPostTask\.Code'), which leaves the server to choose between the rows of a multi\-part county\.

```csharp
public System.Nullable<int> CountyId { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasTask'></a>

## OrtoDatasTask Class

Handles the background processing of orthophoto data within the GIS PostgreSQL context\.

```csharp
public class OrtoDatasTask : DiGi.Core.Classes.ReportableBackgroundTask<long>, DiGi.GIS.PostgreSQL.Interfaces.IGISPostgreSQLObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.BackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.backgroundtask 'DiGi\.Core\.Classes\.BackgroundTask') → [DiGi\.Core\.Classes\.CancelableBackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cancelablebackgroundtask 'DiGi\.Core\.Classes\.CancelableBackgroundTask') → [DiGi\.Core\.Classes\.ReportableBackgroundTask&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1') → OrtoDatasTask

Implements [DiGi\.GIS\.PostgreSQL\.Interfaces\.IGISPostgreSQLObject](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.interfaces.igispostgresqlobject 'DiGi\.GIS\.PostgreSQL\.Interfaces\.IGISPostgreSQLObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasTask.OrtoDatasTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager,DiGi.GIS.PostgreSQL.Classes.GISPostgreSQLConverterManager)'></a>

## OrtoDatasTask\(GISWebAPIManager, GISPostgreSQLConverterManager\) Constructor

Initializes a new instance of the OrtoDatasTask class\.

```csharp
public OrtoDatasTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager? GISWebAPIManager, DiGi.GIS.PostgreSQL.Classes.GISPostgreSQLConverterManager? gISPostgreSQLConverterManager);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasTask.OrtoDatasTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager,DiGi.GIS.PostgreSQL.Classes.GISPostgreSQLConverterManager).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The manager responsible for handling GIS PostgreSQL Web API operations\.

<a name='DiGi.GIS.WebAPI.Classes.OrtoDatasTask.OrtoDatasTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager,DiGi.GIS.PostgreSQL.Classes.GISPostgreSQLConverterManager).gISPostgreSQLConverterManager'></a>

`gISPostgreSQLConverterManager` [DiGi\.GIS\.PostgreSQL\.Classes\.GISPostgreSQLConverterManager](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.gispostgresqlconvertermanager 'DiGi\.GIS\.PostgreSQL\.Classes\.GISPostgreSQLConverterManager')

The manager that handles conversion processes for GIS data within a PostgreSQL database context\.

<a name='DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions'></a>

## SerializableObjectsPostOptions Class

Represents the configuration options for posting serializable objects, extending the base post options functionality\.

```csharp
public class SerializableObjectsPostOptions : DiGi.WebAPI.Classes.PostOptions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableoptions 'DiGi\.Core\.Classes\.SerializableOptions') → [DiGi\.WebAPI\.Classes\.PostOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.postoptions 'DiGi\.WebAPI\.Classes\.PostOptions') → SerializableObjectsPostOptions
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions.SerializableObjectsPostOptions()'></a>

## SerializableObjectsPostOptions\(\) Constructor

Initializes a new instance of the SerializableObjectsPostOptions class\.

```csharp
public SerializableObjectsPostOptions();
```

<a name='DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions.SerializableObjectsPostOptions(DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions)'></a>

## SerializableObjectsPostOptions\(SerializableObjectsPostOptions\) Constructor

Initializes a new instance of the SerializableObjectsPostOptions class using values from an existing instance\.

```csharp
public SerializableObjectsPostOptions(DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions? serializableObjectsPostOptions);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions.SerializableObjectsPostOptions(DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions).serializableObjectsPostOptions'></a>

`serializableObjectsPostOptions` [SerializableObjectsPostOptions](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostOptions')

The source options instance to copy values from, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') to use default settings\.

<a name='DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions.SerializableObjectsPostOptions(System.Text.Json.Nodes.JsonObject)'></a>

## SerializableObjectsPostOptions\(JsonObject\) Constructor

Initializes a new instance of the SerializableObjectsPostOptions class using the specified JSON object\.

```csharp
public SerializableObjectsPostOptions(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions.SerializableObjectsPostOptions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the options\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions.BatchMemorySize'></a>

## SerializableObjectsPostOptions\.BatchMemorySize Property

Gets or sets the memory size threshold in bytes used for processing batches of serializable objects\.

This bounds the uncompressed JSON of one request. The receiving controller materializes a batch several times over - request DOM, domain objects with full geometry, database rows each re-serialized to JSONB, then one batch command per row - so the server's peak allocation is a large multiple of this value. Kept small deliberately; raising it trades server memory for fewer requests.

```csharp
public int BatchMemorySize { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_'></a>

## SerializableObjectsPostTask\<T\> Class

Represents a base class for background tasks that handle the posting of serializable GIS objects to the PostgreSQL database\.

```csharp
public abstract class SerializableObjectsPostTask<T> : DiGi.Core.Classes.ReportableBackgroundTask<long>, DiGi.GIS.WebAPI.Interfaces.IGISWebAPIObject, DiGi.Core.Interfaces.IObject
    where T : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_.T'></a>

`T`

The type of serializable object being posted, which must implement [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.BackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.backgroundtask 'DiGi\.Core\.Classes\.BackgroundTask') → [DiGi\.Core\.Classes\.CancelableBackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cancelablebackgroundtask 'DiGi\.Core\.Classes\.CancelableBackgroundTask') → [DiGi\.Core\.Classes\.ReportableBackgroundTask&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1') → SerializableObjectsPostTask\<T\>

Derived  
↳ [AdministrativeAreal2DsPostTask](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.AdministrativeAreal2DsPostTask 'DiGi\.GIS\.WebAPI\.Classes\.AdministrativeAreal2DsPostTask')  
↳ [Building2DsPostTask](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.Building2DsPostTask 'DiGi\.GIS\.WebAPI\.Classes\.Building2DsPostTask')  
↳ [BuildingModelsPostTask](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingModelsPostTask 'DiGi\.GIS\.WebAPI\.Classes\.BuildingModelsPostTask')  
↳ [BuildingsPostTask](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.BuildingsPostTask 'DiGi\.GIS\.WebAPI\.Classes\.BuildingsPostTask')  
↳ [EPWFilesPostTask](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.EPWFilesPostTask 'DiGi\.GIS\.WebAPI\.Classes\.EPWFilesPostTask')  
↳ [OccupancyDatasPostTask](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.OccupancyDatasPostTask 'DiGi\.GIS\.WebAPI\.Classes\.OccupancyDatasPostTask')  
↳ [OrtoDatasPostTask](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.OrtoDatasPostTask 'DiGi\.GIS\.WebAPI\.Classes\.OrtoDatasPostTask')  
↳ [YearBuiltDatasPostTask](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.YearBuiltDatasPostTask 'DiGi\.GIS\.WebAPI\.Classes\.YearBuiltDatasPostTask')

Implements [DiGi\.GIS\.WebAPI\.Interfaces\.IGISWebAPIObject](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.webapi.interfaces.igiswebapiobject 'DiGi\.GIS\.WebAPI\.Interfaces\.IGISWebAPIObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_.SerializableObjectsPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager)'></a>

## SerializableObjectsPostTask\(GISWebAPIManager\) Constructor

Initializes a new instance of the SerializableObjectsPostTask class\.

```csharp
public SerializableObjectsPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager gISWebAPIManager);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_.SerializableObjectsPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager).gISWebAPIManager'></a>

`gISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The GIS PostgreSQL Web API manager used to perform database operations\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_.SerializableObjectsPostOptions'></a>

## SerializableObjectsPostTask\<T\>\.SerializableObjectsPostOptions Property

Gets or sets the options used for posting serializable objects\.

```csharp
public DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions SerializableObjectsPostOptions { get; set; }
```

#### Property Value
[SerializableObjectsPostOptions](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostOptions 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostOptions')

<a name='DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_.Values'></a>

## SerializableObjectsPostTask\<T\>\.Values Property

Gets or sets the collection of serializable objects to be posted\.

```csharp
public System.Collections.Generic.IEnumerable<T>? Values { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_.T 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

<a name='DiGi.GIS.WebAPI.Classes.SinglevalueAggregateRequestParameter'></a>

## SinglevalueAggregateRequestParameter Class

Parameter class containing options for single\-value database aggregation queries\.

```csharp
public class SinglevalueAggregateRequestParameter : DiGi.WebAPI.Classes.Parameter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.WebAPI\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.parameter 'DiGi\.WebAPI\.Classes\.Parameter') → SinglevalueAggregateRequestParameter
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.SinglevalueAggregateRequestParameter.SinglevalueAggregateRequestParameter()'></a>

## SinglevalueAggregateRequestParameter\(\) Constructor

Initializes a new instance of the [SinglevalueAggregateRequestParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SinglevalueAggregateRequestParameter 'DiGi\.GIS\.WebAPI\.Classes\.SinglevalueAggregateRequestParameter') class\.

```csharp
public SinglevalueAggregateRequestParameter();
```

<a name='DiGi.GIS.WebAPI.Classes.SinglevalueAggregateRequestParameter.SinglevalueAggregateRequestParameter(System.Text.Json.Nodes.JsonObject)'></a>

## SinglevalueAggregateRequestParameter\(JsonObject\) Constructor

Initializes a new instance of the [SinglevalueAggregateRequestParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SinglevalueAggregateRequestParameter 'DiGi\.GIS\.WebAPI\.Classes\.SinglevalueAggregateRequestParameter') class using a [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') object\.

```csharp
public SinglevalueAggregateRequestParameter(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.SinglevalueAggregateRequestParameter.SinglevalueAggregateRequestParameter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing data used to initialize the parameter\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.SinglevalueAggregateRequestParameter.ColumnUniqueId'></a>

## SinglevalueAggregateRequestParameter\.ColumnUniqueId Property

Gets or sets the column unique identifier to calculate statistics for\.

```csharp
public string ColumnUniqueId { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

### Example
"col\_unique\_id\_123"

<a name='DiGi.GIS.WebAPI.Classes.SinglevalueAggregateRequestParameter.CountyId'></a>

## SinglevalueAggregateRequestParameter\.CountyId Property

Gets or sets the target partition identifier \(County ID\)\. If null, aggregation is performed across all partitions\.

```csharp
public System.Nullable<int> CountyId { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

### Example
10365

<a name='DiGi.GIS.WebAPI.Classes.SinglevalueAggregateRequestParameter.FilterGroup'></a>

## SinglevalueAggregateRequestParameter\.FilterGroup Property

Gets or sets the optional dynamic hierarchical filters to apply prior to aggregation\.

```csharp
public DiGi.PostgreSQL.Table.Classes.FilterGroup? FilterGroup { get; set; }
```

#### Property Value
[DiGi\.PostgreSQL\.Table\.Classes\.FilterGroup](https://learn.microsoft.com/en-us/dotnet/api/digi.postgresql.table.classes.filtergroup 'DiGi\.PostgreSQL\.Table\.Classes\.FilterGroup')

<a name='DiGi.GIS.WebAPI.Classes.SinglevalueAggregateRequestParameter.SinglevalueAggregateFunction'></a>

## SinglevalueAggregateRequestParameter\.SinglevalueAggregateFunction Property

Gets or sets the single\-value aggregation function to perform\.

```csharp
public DiGi.PostgreSQL.Table.Enums.SinglevalueAggregateFunction SinglevalueAggregateFunction { get; set; }
```

#### Property Value
[DiGi\.PostgreSQL\.Table\.Enums\.SinglevalueAggregateFunction](https://learn.microsoft.com/en-us/dotnet/api/digi.postgresql.table.enums.singlevalueaggregatefunction 'DiGi\.PostgreSQL\.Table\.Enums\.SinglevalueAggregateFunction')

### Example
Sum

<a name='DiGi.GIS.WebAPI.Classes.TerrainController'></a>

## TerrainController Class

Controller responsible for handling API requests related to terrain, reconstructing a ground surface mesh from the stored elevation points of the counties a request covers\.

Every mesh returned here is a two-and-a-half dimensional height field: exactly one elevation per plan position. It models ground, and cannot express a vertical face, an overhang or a canopy.

```csharp
public class TerrainController : DiGi.WebAPI.Classes.WebAPIController
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Microsoft\.AspNetCore\.Mvc\.ControllerBase](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase 'Microsoft\.AspNetCore\.Mvc\.ControllerBase') → [DiGi\.WebAPI\.Classes\.WebAPIController](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.webapicontroller 'DiGi\.WebAPI\.Classes\.WebAPIController') → TerrainController
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.TerrainController(DiGi.GIS.PostgreSQL.Classes.TerrainPointPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter)'></a>

## TerrainController\(TerrainPointPostgreSQLConverter, AdministrativeAreal2DPostgreSQLConverter\) Constructor

Initializes a new instance of the [TerrainController](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.TerrainController 'DiGi\.GIS\.WebAPI\.Classes\.TerrainController') class\.

```csharp
public TerrainController(DiGi.GIS.PostgreSQL.Classes.TerrainPointPostgreSQLConverter terrainPointPostgreSQLConverter, DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter administrativeAreal2DPostgreSQLConverter);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.TerrainController(DiGi.GIS.PostgreSQL.Classes.TerrainPointPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).terrainPointPostgreSQLConverter'></a>

`terrainPointPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.TerrainPointPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.terrainpointpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.TerrainPointPostgreSQLConverter')

The converter used for reading terrain points from the PostgreSQL database\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.TerrainController(DiGi.GIS.PostgreSQL.Classes.TerrainPointPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).administrativeAreal2DPostgreSQLConverter'></a>

`administrativeAreal2DPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.AdministrativeAreal2DPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.administrativeareal2dpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.AdministrativeAreal2DPostgreSQLConverter')

The converter used for resolving which counties an area covers\.
### Fields

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.tileSize'></a>

## TerrainController\.tileSize Field

The edge of one work tile of a coverage walk, counted in lattice steps\.

The default the sampling task writes with, so a coverage tile lines up with a sampled tile and a shortfall is reported against the same batches the run worked in.

```csharp
private const int tileSize = 128;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')
### Methods

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.CountyIdsAsync(DiGi.Geometry.Planar.Classes.BoundingBox2D,double,System.Threading.CancellationToken)'></a>

## TerrainController\.CountyIdsAsync\(BoundingBox2D, double, CancellationToken\) Method

Resolves which county partitions an area covers\.

This has to happen here rather than inside the terrain converter. The terrain points live in the Storage database and the administrative geometry in Main, and a PostgreSQL connection cannot reach across databases - so the only place both are available is the host, where each converter carries its own connection. The write side has always worked this way; see `PostgreSQLTerrainPointCreateTableTask`.

```csharp
private System.Threading.Tasks.Task<System.Collections.Generic.HashSet<int>?> CountyIdsAsync(DiGi.Geometry.Planar.Classes.BoundingBox2D boundingBox2D, double tolerance, System.Threading.CancellationToken cancellationToken);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.CountyIdsAsync(DiGi.Geometry.Planar.Classes.BoundingBox2D,double,System.Threading.CancellationToken).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The area to resolve\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.CountyIdsAsync(DiGi.Geometry.Planar.Classes.BoundingBox2D,double,System.Threading.CancellationToken).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance the search area is expanded by, in metres\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.CountyIdsAsync(DiGi.Geometry.Planar.Classes.BoundingBox2D,double,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Collections\.Generic\.HashSet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1 'System\.Collections\.Generic\.HashSet\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The identifiers of the counties the area meets, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') when it meets none\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetCountByCountyIdAsync(int,bool,bool,int,System.Threading.CancellationToken)'></a>

## TerrainController\.GetCountByCountyIdAsync\(int, bool, bool, int, CancellationToken\) Method

Asynchronously retrieves the number of terrain points stored for one county partition\.

The cheapest question that can be asked of the store, and the one that separates a county that was never sampled from one that was sampled and holds nothing.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetCountByCountyIdAsync(int countyId, bool estimated=false, bool analyze=false, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetCountByCountyIdAsync(int,bool,bool,int,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county partition to count\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetCountByCountyIdAsync(int,bool,bool,int,System.Threading.CancellationToken).estimated'></a>

`estimated` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Reads the planner's row estimate instead of counting the rows\. Far faster on a partition of millions and accurate to a few percent, but it reflects the last time the partition was analysed rather than this moment\. An unanalysed partition returns 204 NoContent\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetCountByCountyIdAsync(int,bool,bool,int,System.Threading.CancellationToken).analyze'></a>

`analyze` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A boolean value indicating whether to perform an ANALYZE operation before reading the estimate to ensure statistics are current\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetCountByCountyIdAsync(int,bool,bool,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetCountByCountyIdAsync(int,bool,bool,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') carrying the count, 204 NoContent when the partition exists but is unanalysed, or 404 NotFound when the county has no partition\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetCoverageByCountyIdAsync(int,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken)'></a>

## TerrainController\.GetCoverageByCountyIdAsync\(int, double, double, double, Nullable\<double\>, int, int, CancellationToken\) Method

Asynchronously compares what one county partition holds against what a sampling run on the given lattice should have put there\.

The question a density cannot answer. A density says how much of a county is missing; this says which nodes, so a run that stepped over a batch can be sent back for exactly those.

The expected nodes are derived from the same subdivision outlines and the same lattice the sampling run itself decides against, so the two agree by construction. Nodes of the county's bounding rectangle that fall outside its land are not expected and not counted.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetCoverageByCountyIdAsync(int countyId, double gridSize, double originX, double originY, System.Nullable<double> tolerance, int limit=1000, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetCoverageByCountyIdAsync(int,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county partition to measure\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetCoverageByCountyIdAsync(int,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).gridSize'></a>

`gridSize` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The lattice spacing, in metres\. Not finer than [MinimumGridSize](DiGi.GIS.WebAPI.Constants.md#DiGi.GIS.WebAPI.Constants.Terrain.MinimumGridSize 'DiGi\.GIS\.WebAPI\.Constants\.Terrain\.MinimumGridSize')\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetCoverageByCountyIdAsync(int,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).originX'></a>

`originX` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate the lattice is anchored at\. Leave at zero unless a run used something else\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetCoverageByCountyIdAsync(int,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).originY'></a>

`originY` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate the lattice is anchored at\. Leave at zero unless a run used something else\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetCoverageByCountyIdAsync(int,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).tolerance'></a>

`tolerance` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The distance a stored point may lie from a node and still be counted as that node, in metres\. Capped at half a step\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetCoverageByCountyIdAsync(int,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).limit'></a>

`limit` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The largest number of missing coordinates returned\. The count itself is reported in full regardless\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetCoverageByCountyIdAsync(int,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetCoverageByCountyIdAsync(int,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') carrying the [DiGi\.GIS\.PostgreSQL\.Classes\.TerrainPointCoverageResult](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.terrainpointcoverageresult 'DiGi\.GIS\.PostgreSQL\.Classes\.TerrainPointCoverageResult') as JSON, or an error status\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetDensitiesByCountyIdsAsync(System.Collections.Generic.List_int_,System.Nullable_double_,int,System.Threading.CancellationToken)'></a>

## TerrainController\.GetDensitiesByCountyIdsAsync\(List\<int\>, Nullable\<double\>, int, CancellationToken\) Method

Asynchronously reports how densely each of the named county partitions is sampled: the points it holds divided by the area of its subdivisions\.

The cheap sweep. It costs one aggregate per partition and the outlines of the counties named, where deciding the same question node by node costs the generating and the looking up of the whole lattice - so this is what narrows a country down to the few counties worth [GetCoverageByCountyIdAsync\(int, double, double, double, Nullable&lt;double&gt;, int, int, CancellationToken\)](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.TerrainController.GetCoverageByCountyIdAsync(int,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken) 'DiGi\.GIS\.WebAPI\.Classes\.TerrainController\.GetCoverageByCountyIdAsync\(int, double, double, double, System\.Nullable\<double\>, int, int, System\.Threading\.CancellationToken\)').

Supplying [gridSize](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.TerrainController.GetDensitiesByCountyIdsAsync(System.Collections.Generic.List_int_,System.Nullable_double_,int,System.Threading.CancellationToken).gridSize 'DiGi\.GIS\.WebAPI\.Classes\.TerrainController\.GetDensitiesByCountyIdsAsync\(System\.Collections\.Generic\.List\<int\>, System\.Nullable\<double\>, int, System\.Threading\.CancellationToken\)\.gridSize') is what turns the density into a completeness. Without it the figure to read is the spacing, which needs no knowledge of what a run was asked for.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetDensitiesByCountyIdsAsync(System.Collections.Generic.List<int>? countyIds, System.Nullable<double> gridSize, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetDensitiesByCountyIdsAsync(System.Collections.Generic.List_int_,System.Nullable_double_,int,System.Threading.CancellationToken).countyIds'></a>

`countyIds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The identifiers of the county partitions to measure, repeated once per county\. At least one and at most [MaximumDensityCountyCount](DiGi.GIS.WebAPI.Constants.md#DiGi.GIS.WebAPI.Constants.Terrain.MaximumDensityCountyCount 'DiGi\.GIS\.WebAPI\.Constants\.Terrain\.MaximumDensityCountyCount')\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetDensitiesByCountyIdsAsync(System.Collections.Generic.List_int_,System.Nullable_double_,int,System.Threading.CancellationToken).gridSize'></a>

`gridSize` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The lattice spacing a sampling run used, in metres, when it is known\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetDensitiesByCountyIdsAsync(System.Collections.Generic.List_int_,System.Nullable_double_,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetDensitiesByCountyIdsAsync(System.Collections.Generic.List_int_,System.Nullable_double_,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') carrying the densities as JSON, or an error status\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetGapsByBoundingBoxAsync(double,double,double,double,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken)'></a>

## TerrainController\.GetGapsByBoundingBoxAsync\(double, double, double, double, double, double, double, Nullable\<double\>, int, int, CancellationToken\) Method

Asynchronously retrieves the lattice nodes inside a rectangle that lie on a county's land and that the terrain point table holds no point for\.

Where [GetCoverageByCountyIdAsync\(int, double, double, double, Nullable&lt;double&gt;, int, int, CancellationToken\)](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.TerrainController.GetCoverageByCountyIdAsync(int,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken) 'DiGi\.GIS\.WebAPI\.Classes\.TerrainController\.GetCoverageByCountyIdAsync\(int, double, double, double, System\.Nullable\<double\>, int, int, System\.Threading\.CancellationToken\)') answers for a whole county, this answers for an area - which is what a coverage reporting a shortfall is followed by. Every county the rectangle meets is measured, so a hole spanning a county boundary is reported once and whole.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetGapsByBoundingBoxAsync(double x_1, double y_1, double x_2, double y_2, double gridSize, double originX, double originY, System.Nullable<double> tolerance, int limit=1000, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetGapsByBoundingBoxAsync(double,double,double,double,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).x_1'></a>

`x_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the first corner, in PL\-1992 \(EPSG:2180\) metres\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetGapsByBoundingBoxAsync(double,double,double,double,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).y_1'></a>

`y_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the first corner, in PL\-1992 \(EPSG:2180\) metres\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetGapsByBoundingBoxAsync(double,double,double,double,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).x_2'></a>

`x_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the second corner, in PL\-1992 \(EPSG:2180\) metres\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetGapsByBoundingBoxAsync(double,double,double,double,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).y_2'></a>

`y_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the second corner, in PL\-1992 \(EPSG:2180\) metres\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetGapsByBoundingBoxAsync(double,double,double,double,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).gridSize'></a>

`gridSize` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The lattice spacing, in metres\. Not finer than [MinimumGridSize](DiGi.GIS.WebAPI.Constants.md#DiGi.GIS.WebAPI.Constants.Terrain.MinimumGridSize 'DiGi\.GIS\.WebAPI\.Constants\.Terrain\.MinimumGridSize')\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetGapsByBoundingBoxAsync(double,double,double,double,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).originX'></a>

`originX` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate the lattice is anchored at\. Leave at zero unless a run used something else\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetGapsByBoundingBoxAsync(double,double,double,double,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).originY'></a>

`originY` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate the lattice is anchored at\. Leave at zero unless a run used something else\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetGapsByBoundingBoxAsync(double,double,double,double,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).tolerance'></a>

`tolerance` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The distance a stored point may lie from a node and still be counted as that node, in metres\. Capped at half a step\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetGapsByBoundingBoxAsync(double,double,double,double,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).limit'></a>

`limit` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The largest number of missing coordinates returned\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetGapsByBoundingBoxAsync(double,double,double,double,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetGapsByBoundingBoxAsync(double,double,double,double,double,double,double,System.Nullable_double_,int,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') carrying the missing coordinates as JSON, or an error status\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Threading.CancellationToken)'></a>

## TerrainController\.GetMesh3DByBoundingBoxAsync\(double, double, double, double, Nullable\<double\>, CancellationToken\) Method

Asynchronously retrieves the terrain surface inside an axis aligned bounding box given by two opposite corners\.

Corner order does not matter. Each side of the box is capped at twice [MaximumRadius](DiGi.GIS.WebAPI.Constants.md#DiGi.GIS.WebAPI.Constants.Terrain.MaximumRadius 'DiGi\.GIS\.WebAPI\.Constants\.Terrain\.MaximumRadius'), so this endpoint and the circle admit the same largest area.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetMesh3DByBoundingBoxAsync(double x_1, double y_1, double x_2, double y_2, System.Nullable<double> tolerance, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Threading.CancellationToken).x_1'></a>

`x_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the first corner, in PL\-1992 \(EPSG:2180\) metres\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Threading.CancellationToken).y_1'></a>

`y_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the first corner, in PL\-1992 \(EPSG:2180\) metres\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Threading.CancellationToken).x_2'></a>

`x_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the second corner, in PL\-1992 \(EPSG:2180\) metres\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Threading.CancellationToken).y_2'></a>

`y_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the second corner, in PL\-1992 \(EPSG:2180\) metres\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Threading.CancellationToken).tolerance'></a>

`tolerance` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional tolerance for the spatial query, in metres\. If not provided or NaN, a default macro distance is used\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByBoundingBoxAsync(double,double,double,double,System.Nullable_double_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') carrying the [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') as JSON, or an error status\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken)'></a>

## TerrainController\.GetMesh3DByCircleAsync\(double, double, Nullable\<double\>, Nullable\<double\>, Nullable\<double\>, CancellationToken\) Method

Asynchronously retrieves the terrain surface inside a circle centred on the given plan coordinate\.

The circle is honoured: the points outside it are excluded by the database, not trimmed afterwards, so no part of the returned mesh lies further from the centre than the radius.

Either [radius](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).radius 'DiGi\.GIS\.WebAPI\.Classes\.TerrainController\.GetMesh3DByCircleAsync\(double, double, System\.Nullable\<double\>, System\.Nullable\<double\>, System\.Nullable\<double\>, System\.Threading\.CancellationToken\)\.radius') or [diameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).diameter 'DiGi\.GIS\.WebAPI\.Classes\.TerrainController\.GetMesh3DByCircleAsync\(double, double, System\.Nullable\<double\>, System\.Nullable\<double\>, System\.Nullable\<double\>, System\.Threading\.CancellationToken\)\.diameter') must be supplied; [radius](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).radius 'DiGi\.GIS\.WebAPI\.Classes\.TerrainController\.GetMesh3DByCircleAsync\(double, double, System\.Nullable\<double\>, System\.Nullable\<double\>, System\.Nullable\<double\>, System\.Threading\.CancellationToken\)\.radius') wins when both are. The radius is capped by [MaximumRadius](DiGi.GIS.WebAPI.Constants.md#DiGi.GIS.WebAPI.Constants.Terrain.MaximumRadius 'DiGi\.GIS\.WebAPI\.Constants\.Terrain\.MaximumRadius').

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetMesh3DByCircleAsync(double x, double y, System.Nullable<double> radius, System.Nullable<double> diameter, System.Nullable<double> tolerance, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the centre, in PL\-1992 \(EPSG:2180\) metres, matching the coordinates the terrain points are stored in\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the centre, in PL\-1992 \(EPSG:2180\) metres, matching the coordinates the terrain points are stored in\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).radius'></a>

`radius` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The search radius in metres\. Optional when [diameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).diameter 'DiGi\.GIS\.WebAPI\.Classes\.TerrainController\.GetMesh3DByCircleAsync\(double, double, System\.Nullable\<double\>, System\.Nullable\<double\>, System\.Nullable\<double\>, System\.Threading\.CancellationToken\)\.diameter') is supplied\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).diameter'></a>

`diameter` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The search diameter in metres, used only when [radius](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).radius 'DiGi\.GIS\.WebAPI\.Classes\.TerrainController\.GetMesh3DByCircleAsync\(double, double, System\.Nullable\<double\>, System\.Nullable\<double\>, System\.Nullable\<double\>, System\.Threading\.CancellationToken\)\.radius') is absent\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).tolerance'></a>

`tolerance` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional tolerance for the spatial query, in metres\. If not provided or NaN, a default macro distance is used\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetMesh3DByCircleAsync(double,double,System.Nullable_double_,System.Nullable_double_,System.Nullable_double_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') carrying the [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') as JSON, or an error status\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetSummariesByCountyIdsAsync(System.Collections.Generic.List_int_,int,System.Threading.CancellationToken)'></a>

## TerrainController\.GetSummariesByCountyIdsAsync\(List\<int\>, int, CancellationToken\) Method

Asynchronously summarises what each of the named county partitions holds: how many points, over what extent, at what elevations, filed under how many subdivisions, and when they were written\.

The account a sampling run leaves behind. The run keeps its tallies in memory and discards them when it ends, so this is what remains to read afterwards - and ordering the result by [DiGi\.GIS\.PostgreSQL\.Classes\.TerrainPointCountyResult\.CreatedAt\_First](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.terrainpointcountyresult.createdat_first 'DiGi\.GIS\.PostgreSQL\.Classes\.TerrainPointCountyResult\.CreatedAt\_First') reconstructs how far a run got, because a run walks the counties in ascending identifier order.

Naming no county summarises every partition. Counties holding no point are absent from the result rather than present with a zero.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetSummariesByCountyIdsAsync(System.Collections.Generic.List<int>? countyIds, int commandTimeout=600, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetSummariesByCountyIdsAsync(System.Collections.Generic.List_int_,int,System.Threading.CancellationToken).countyIds'></a>

`countyIds` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

The identifiers of the county partitions to summarise, repeated once per county\. Omit to summarise every one\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetSummariesByCountyIdsAsync(System.Collections.Generic.List_int_,int,System.Threading.CancellationToken).commandTimeout'></a>

`commandTimeout` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The timeout in seconds for the execution of the command\. A value of 0 disables the timeout\. Defaults to 600 seconds\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.GetSummariesByCountyIdsAsync(System.Collections.Generic.List_int_,int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') carrying the summaries as JSON, or an error status\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.IsFinite(double)'></a>

## TerrainController\.IsFinite\(double\) Method

Determines whether a bound query string value is a usable coordinate or distance\.

Model binding accepts the literals NaN and Infinity for a double, so neither is a value the caller could only have reached by mistake.

```csharp
private static bool IsFinite(double value);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.IsFinite(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The value to test\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') when the value is neither NaN nor infinite; otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.Mesh3DResult(DiGi.Geometry.PointCloud.Spatial.Classes.PointCloud3D)'></a>

## TerrainController\.Mesh3DResult\(PointCloud3D\) Method

Reconstructs the ground surface from the gathered terrain points and renders it as the JSON response body\.

The three failure paths are reported separately, because "nothing stored here" and "too little stored here to triangulate" are answered by different fixes and both used to arrive as a bare 404.

```csharp
private Microsoft.AspNetCore.Mvc.IActionResult Mesh3DResult(DiGi.Geometry.PointCloud.Spatial.Classes.PointCloud3D? pointCloud3D);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.Mesh3DResult(DiGi.Geometry.PointCloud.Spatial.Classes.PointCloud3D).pointCloud3D'></a>

`pointCloud3D` [DiGi\.Geometry\.PointCloud\.Spatial\.Classes\.PointCloud3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.pointcloud.spatial.classes.pointcloud3d 'DiGi\.Geometry\.PointCloud\.Spatial\.Classes\.PointCloud3D')

The terrain points gathered for the requested area\.

#### Returns
[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') carrying the [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D') as JSON, or a not found status\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.PolygonalFace2DsByIdAsync(int,System.Threading.CancellationToken)'></a>

## TerrainController\.PolygonalFace2DsByIdAsync\(int, CancellationToken\) Method

Reads the outlines of a county's subdivisions, keyed by subdivision identifier\.

Read from the administrative database rather than the terrain one, and derived through the same helper the sampling task uses, so an area measured here is the area a run would have sampled.

```csharp
private System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int,DiGi.Geometry.Planar.Classes.PolygonalFace2D>?> PolygonalFace2DsByIdAsync(int countyId, System.Threading.CancellationToken cancellationToken);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.PolygonalFace2DsByIdAsync(int,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The identifier of the county whose subdivisions are wanted\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.PolygonalFace2DsByIdAsync(int,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

A cancellation token that can be used by the caller to cancel the asynchronous operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The outlines keyed by subdivision identifier, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') when the county has none\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.TerrainPointTableExistsAsync()'></a>

## TerrainController\.TerrainPointTableExistsAsync\(\) Method

Reports whether anything has ever been written to the terrain point store\.

Asked once per request, before a walk that would otherwise send a query per tile against a table
            that does not exist. An undefined relation reaches a caller as a server fault, where the plain fact is
            that nothing has been sampled yet - which is an answer, and one a fresh deployment gives.

```csharp
private System.Threading.Tasks.Task<bool> TerrainPointTableExistsAsync();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') when the terrain point table exists; otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.TryGetLatticeParameters(double,double,double,System.Nullable_double_,int,DiGi.Geometry.Planar.Classes.Point2D,double)'></a>

## TerrainController\.TryGetLatticeParameters\(double, double, double, Nullable\<double\>, int, Point2D, double\) Method

Resolves and checks the lattice a coverage or gap request asked to be measured against\.

```csharp
private static bool TryGetLatticeParameters(double gridSize, double originX, double originY, System.Nullable<double> tolerance, int limit, out DiGi.Geometry.Planar.Classes.Point2D? origin, out double tolerance_Temp);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.TryGetLatticeParameters(double,double,double,System.Nullable_double_,int,DiGi.Geometry.Planar.Classes.Point2D,double).gridSize'></a>

`gridSize` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The lattice spacing as bound from the query string\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.TryGetLatticeParameters(double,double,double,System.Nullable_double_,int,DiGi.Geometry.Planar.Classes.Point2D,double).originX'></a>

`originX` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate the lattice is anchored at\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.TryGetLatticeParameters(double,double,double,System.Nullable_double_,int,DiGi.Geometry.Planar.Classes.Point2D,double).originY'></a>

`originY` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate the lattice is anchored at\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.TryGetLatticeParameters(double,double,double,System.Nullable_double_,int,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance'></a>

`tolerance` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The tolerance as bound from the query string\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.TryGetLatticeParameters(double,double,double,System.Nullable_double_,int,DiGi.Geometry.Planar.Classes.Point2D,double).limit'></a>

`limit` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The largest number of coordinates the request asked to be returned\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.TryGetLatticeParameters(double,double,double,System.Nullable_double_,int,DiGi.Geometry.Planar.Classes.Point2D,double).origin'></a>

`origin` [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')

The resolved anchor of the lattice\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.TryGetLatticeParameters(double,double,double,System.Nullable_double_,int,DiGi.Geometry.Planar.Classes.Point2D,double).tolerance_Temp'></a>

`tolerance_Temp` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The resolved tolerance, capped at half a step so that a point can never be taken for a node of the neighbouring cell\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') when the lattice is usable; otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.TryGetTolerance(System.Nullable_double_,double)'></a>

## TerrainController\.TryGetTolerance\(Nullable\<double\>, double\) Method

Resolves the tolerance a request asked for, falling back to the default when it was not supplied\.

```csharp
private static bool TryGetTolerance(System.Nullable<double> tolerance, out double tolerance_Temp);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.TryGetTolerance(System.Nullable_double_,double).tolerance'></a>

`tolerance` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The tolerance as bound from the query string\.

<a name='DiGi.GIS.WebAPI.Classes.TerrainController.TryGetTolerance(System.Nullable_double_,double).tolerance_Temp'></a>

`tolerance_Temp` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The resolved tolerance, in metres\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') when the tolerance is usable; otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter'></a>

## UniqueValuesByColumnUniqueIdParameter Class

Represents a parameter containing column unique id for querying unique values\.

```csharp
public class UniqueValuesByColumnUniqueIdParameter : DiGi.WebAPI.Classes.Parameter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.WebAPI\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.parameter 'DiGi\.WebAPI\.Classes\.Parameter') → UniqueValuesByColumnUniqueIdParameter
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter.UniqueValuesByColumnUniqueIdParameter()'></a>

## UniqueValuesByColumnUniqueIdParameter\(\) Constructor

Initializes a new instance of the [UniqueValuesByColumnUniqueIdParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter 'DiGi\.GIS\.WebAPI\.Classes\.UniqueValuesByColumnUniqueIdParameter') class\.

```csharp
public UniqueValuesByColumnUniqueIdParameter();
```

<a name='DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter.UniqueValuesByColumnUniqueIdParameter(string,System.Nullable_int_)'></a>

## UniqueValuesByColumnUniqueIdParameter\(string, Nullable\<int\>\) Constructor

Initializes a new instance of the [UniqueValuesByColumnUniqueIdParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter 'DiGi\.GIS\.WebAPI\.Classes\.UniqueValuesByColumnUniqueIdParameter') class with the specified column unique id and county id\.

```csharp
public UniqueValuesByColumnUniqueIdParameter(string columnUniqueId, System.Nullable<int> countyId);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter.UniqueValuesByColumnUniqueIdParameter(string,System.Nullable_int_).columnUniqueId'></a>

`columnUniqueId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the column\.

<a name='DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter.UniqueValuesByColumnUniqueIdParameter(string,System.Nullable_int_).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The optional unique identifier of the county\.

<a name='DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter.UniqueValuesByColumnUniqueIdParameter(System.Text.Json.Nodes.JsonObject)'></a>

## UniqueValuesByColumnUniqueIdParameter\(JsonObject\) Constructor

Initializes a new instance of the [UniqueValuesByColumnUniqueIdParameter](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter 'DiGi\.GIS\.WebAPI\.Classes\.UniqueValuesByColumnUniqueIdParameter') class using an [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') object\.

```csharp
public UniqueValuesByColumnUniqueIdParameter(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter.UniqueValuesByColumnUniqueIdParameter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the parameter\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter.ColumnUniqueId'></a>

## UniqueValuesByColumnUniqueIdParameter\.ColumnUniqueId Property

Gets or sets the unique identifier of the column \(Column\.UniqueId\)\.

```csharp
public string ColumnUniqueId { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter.CountyId'></a>

## UniqueValuesByColumnUniqueIdParameter\.CountyId Property

Gets or sets the county identifier\.

```csharp
public System.Nullable<int> CountyId { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.GIS.WebAPI.Classes.UniqueValuesByColumnUniqueIdParameter.FilterGroup'></a>

## UniqueValuesByColumnUniqueIdParameter\.FilterGroup Property

Gets or sets the optional dynamic hierarchical filters to apply prior to retrieving unique values\.

```csharp
public DiGi.PostgreSQL.Table.Classes.FilterGroup? FilterGroup { get; set; }
```

#### Property Value
[DiGi\.PostgreSQL\.Table\.Classes\.FilterGroup](https://learn.microsoft.com/en-us/dotnet/api/digi.postgresql.table.classes.filtergroup 'DiGi\.PostgreSQL\.Table\.Classes\.FilterGroup')

<a name='DiGi.GIS.WebAPI.Classes.UpdateItemsResult'></a>

## UpdateItemsResult Class

The outcome of a write endpoint: how much was stored, and which rows were not\.

A partial write still answers 200 - the rows that resolved really were stored, and failing the whole batch would discard them - but it is no longer silent. [Rejected](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.UpdateItemsResult.Rejected 'DiGi\.GIS\.WebAPI\.Classes\.UpdateItemsResult\.Rejected') names what did not reach the database so the caller can correct and repost it, or report it onwards.

```csharp
public class UpdateItemsResult
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → UpdateItemsResult
### Properties

<a name='DiGi.GIS.WebAPI.Classes.UpdateItemsResult.Rejected'></a>

## UpdateItemsResult\.Rejected Property

Gets or sets the rows dropped before the database, each named with the reason it was dropped\.

```csharp
public System.Collections.Generic.List<DiGi.GIS.WebAPI.Classes.UpdateItemsResult.Rejection> Rejected { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Rejection](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.UpdateItemsResult.Rejection 'DiGi\.GIS\.WebAPI\.Classes\.UpdateItemsResult\.Rejection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.GIS.WebAPI.Classes.UpdateItemsResult.Sent'></a>

## UpdateItemsResult\.Sent Property

Gets or sets the number of rows handed to the database\.

```csharp
public int Sent { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

### Example
5000

<a name='DiGi.GIS.WebAPI.Classes.UpdateItemsResult.Updated'></a>

## UpdateItemsResult\.Updated Property

Gets or sets the number of distinct identifiers the database returned\.

Not a row count. Identifiers arrive as a set, and rows of one batch colliding on the conflict key return the same identifier, so this can be lower than the number stored. [Rejected](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.UpdateItemsResult.Rejected 'DiGi\.GIS\.WebAPI\.Classes\.UpdateItemsResult\.Rejected') is the exact account of what was lost.

```csharp
public int Updated { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

### Example
4987

<a name='DiGi.GIS.WebAPI.Classes.UpdateItemsResult.Rejection'></a>

## UpdateItemsResult\.Rejection Class

One row that was dropped before the database, and why\.

```csharp
public class UpdateItemsResult.Rejection
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Rejection
### Properties

<a name='DiGi.GIS.WebAPI.Classes.UpdateItemsResult.Rejection.Reason'></a>

## UpdateItemsResult\.Rejection\.Reason Property

Gets or sets the reason the row was dropped\. It decides whether reposting is worth anything: a payload defect is worth correcting, a footprint outside every candidate county part is not\.

```csharp
public DiGi.GIS.PostgreSQL.Enums.UpdateRejectionReason Reason { get; set; }
```

#### Property Value
[DiGi\.GIS\.PostgreSQL\.Enums\.UpdateRejectionReason](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.enums.updaterejectionreason 'DiGi\.GIS\.PostgreSQL\.Enums\.UpdateRejectionReason')

### Example
CountyUnresolved

<a name='DiGi.GIS.WebAPI.Classes.UpdateItemsResult.Rejection.Reference'></a>

## UpdateItemsResult\.Rejection\.Reference Property

Gets or sets the reference of the dropped row\. Null when the row carried none\.

The host omits null properties, so a rejection with nothing to name arrives as `{"reason":"Undefined"}` - an absent `reference` is the null, not a serialization fault.

```csharp
public string? Reference { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

### Example
1234\.5678\.AB\_12

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDataController'></a>

## YearBuiltDataController Class

Provides API endpoints for managing and updating year built data stored in a PostgreSQL database\.

```csharp
public class YearBuiltDataController : DiGi.WebAPI.Classes.WebAPIController
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [Microsoft\.AspNetCore\.Mvc\.ControllerBase](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase 'Microsoft\.AspNetCore\.Mvc\.ControllerBase') → [DiGi\.WebAPI\.Classes\.WebAPIController](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.webapicontroller 'DiGi\.WebAPI\.Classes\.WebAPIController') → YearBuiltDataController
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDataController.YearBuiltDataController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.YearBuiltDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter)'></a>

## YearBuiltDataController\(GISWebAPIConfigurationFileWatcher, YearBuiltDataPostgreSQLConverter, Building2DPostgreSQLConverter, AdministrativeAreal2DPostgreSQLConverter\) Constructor

Initializes a new instance of the YearBuiltDataController class\.

```csharp
public YearBuiltDataController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher GISWebAPIConfigurationFileWatcher, DiGi.GIS.PostgreSQL.Classes.YearBuiltDataPostgreSQLConverter yearBuiltDataPostgreSQLConverter, DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter building2DPostgreSQLConverter, DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter administrativeAreal2DPostgreSQLConverter);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDataController.YearBuiltDataController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.YearBuiltDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).GISWebAPIConfigurationFileWatcher'></a>

`GISWebAPIConfigurationFileWatcher` [GISWebAPIConfigurationFileWatcher](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIConfigurationFileWatcher')

The configuration file watcher used to monitor changes to the PostgreSQL Web API configuration\.

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDataController.YearBuiltDataController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.YearBuiltDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).yearBuiltDataPostgreSQLConverter'></a>

`yearBuiltDataPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.YearBuiltDataPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.yearbuiltdatapostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.YearBuiltDataPostgreSQLConverter')

The converter for YearBuiltData objects when interacting with a PostgreSQL database\.

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDataController.YearBuiltDataController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.YearBuiltDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).building2DPostgreSQLConverter'></a>

`building2DPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.Building2DPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.building2dpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.Building2DPostgreSQLConverter')

The converter for Building2D objects, used to read which county row a reference is already filed under\.

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDataController.YearBuiltDataController(DiGi.GIS.WebAPI.Classes.GISWebAPIConfigurationFileWatcher,DiGi.GIS.PostgreSQL.Classes.YearBuiltDataPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.Building2DPostgreSQLConverter,DiGi.GIS.PostgreSQL.Classes.AdministrativeAreal2DPostgreSQLConverter).administrativeAreal2DPostgreSQLConverter'></a>

`administrativeAreal2DPostgreSQLConverter` [DiGi\.GIS\.PostgreSQL\.Classes\.AdministrativeAreal2DPostgreSQLConverter](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.postgresql.classes.administrativeareal2dpostgresqlconverter 'DiGi\.GIS\.PostgreSQL\.Classes\.AdministrativeAreal2DPostgreSQLConverter')

The converter for administrative areal 2D data when interacting with a PostgreSQL database\.
### Methods

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDataController.GetItemsByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken)'></a>

## YearBuiltDataController\.GetItemsByReferenceAsync\(string, Nullable\<int\>, CancellationToken\) Method

Asynchronously retrieves items based on a provided reference and an optional county identifier\.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> GetItemsByReferenceAsync(string reference, System.Nullable<int> countyId, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDataController.GetItemsByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken).reference'></a>

`reference` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique reference string used to identify the year built data items\.

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDataController.GetItemsByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken).countyId'></a>

`countyId` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional integer representing the county ID to filter the results\.

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDataController.GetItemsByReferenceAsync(string,System.Nullable_int_,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken') to observe for cancellation requests\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
A task that represents the asynchronous operation\.

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDataController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string)'></a>

## YearBuiltDataController\.UpdateItemsAsync\(JsonArray, string\) Method

Updates multiple year built data items based on the provided JSON array and identification code\.

A county code does not identify a single county row: BDOT10k stores a county whose territory is disconnected as one feature per polygon part, and every part becomes its own row. Every part the code names is passed on, and each datum is filed under the part it actually belongs to - see [UpdateItemsByCountyIdsAsync\(JsonArray, int\[\]\)](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.YearBuiltDataController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[]) 'DiGi\.GIS\.WebAPI\.Classes\.YearBuiltDataController\.UpdateItemsByCountyIdsAsync\(System\.Text\.Json\.Nodes\.JsonArray, int\[\]\)') for how that is decided.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateItemsAsync(System.Text.Json.Nodes.JsonArray? jsonArray, string code);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDataController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The JSON array containing the data items to be updated\.

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDataController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string).code'></a>

`code` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The identification code required for the update operation\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') representing the result of the update operation\.

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDataController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[])'></a>

## YearBuiltDataController\.UpdateItemsByCountyIdsAsync\(JsonArray, int\[\]\) Method

Updates multiple year built data items in the database for the given county rows\.

The unambiguous counterpart of [UpdateItemsAsync\(JsonArray, string\)](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.YearBuiltDataController.UpdateItemsAsync(System.Text.Json.Nodes.JsonArray,string) 'DiGi\.GIS\.WebAPI\.Classes\.YearBuiltDataController\.UpdateItemsAsync\(System\.Text\.Json\.Nodes\.JsonArray, string\)'): it takes county identifiers rather than a code, so the caller states which rows are in play instead of leaving the server to derive them.

A single identifier is taken as stated and every datum is filed under it. Several identifiers are the polygon parts of one multi-part county, and each datum is then filed under the part already holding the `building_2d` row its reference names, probed lowest part first. That row was filed by geometry when it was imported, so reusing its answer keeps both tables keyed by the same `(county_id, reference)` pair.

A datum whose reference no part holds is not written: it carries no geometry of its own, so nothing states where it belongs, and storing it under a guessed part is the state this replaced.

```csharp
public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray? jsonArray, int[]? countyIds);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDataController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[]).jsonArray'></a>

`jsonArray` [System\.Text\.Json\.Nodes\.JsonArray](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonarray 'System\.Text\.Json\.Nodes\.JsonArray')

The JSON array containing the data items to be updated\.

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDataController.UpdateItemsByCountyIdsAsync(System.Text.Json.Nodes.JsonArray,int[]).countyIds'></a>

`countyIds` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The identifiers of the county rows the year built data belong to\. Normally every polygon part of one county\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
An [Microsoft\.AspNetCore\.Mvc\.IActionResult](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.iactionresult 'Microsoft\.AspNetCore\.Mvc\.IActionResult') representing the result of the update operation\.

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDatasPostTask'></a>

## YearBuiltDatasPostTask Class

Provides functionality to handle the asynchronous posting of [DiGi\.GIS\.Classes\.YearBuiltData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.yearbuiltdata 'DiGi\.GIS\.Classes\.YearBuiltData') collections to the PostgreSQL database\.

```csharp
public class YearBuiltDatasPostTask : DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask<DiGi.GIS.Classes.YearBuiltData>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.BackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.backgroundtask 'DiGi\.Core\.Classes\.BackgroundTask') → [DiGi\.Core\.Classes\.CancelableBackgroundTask](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.cancelablebackgroundtask 'DiGi\.Core\.Classes\.CancelableBackgroundTask') → [DiGi\.Core\.Classes\.ReportableBackgroundTask&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1')[System\.Int64](https://learn.microsoft.com/en-us/dotnet/api/system.int64 'System\.Int64')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.reportablebackgroundtask-1 'DiGi\.Core\.Classes\.ReportableBackgroundTask\`1') → [DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask&lt;](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_ 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>')[DiGi\.GIS\.Classes\.YearBuiltData](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.yearbuiltdata 'DiGi\.GIS\.Classes\.YearBuiltData')[&gt;](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.SerializableObjectsPostTask_T_ 'DiGi\.GIS\.WebAPI\.Classes\.SerializableObjectsPostTask\<T\>') → YearBuiltDatasPostTask
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDatasPostTask.YearBuiltDatasPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager)'></a>

## YearBuiltDatasPostTask\(GISWebAPIManager\) Constructor

Initializes a new instance of the YearBuiltDatasPostTask class\.

```csharp
public YearBuiltDatasPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager GISWebAPIManager);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDatasPostTask.YearBuiltDatasPostTask(DiGi.GIS.WebAPI.Classes.GISWebAPIManager).GISWebAPIManager'></a>

`GISWebAPIManager` [GISWebAPIManager](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.GISWebAPIManager 'DiGi\.GIS\.WebAPI\.Classes\.GISWebAPIManager')

The GIS PostgreSQL Web API manager used to handle data persistence\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDatasPostTask.Code'></a>

## YearBuiltDatasPostTask\.Code Property

Gets or sets the code associated with the year built data post task\.

A code does not identify a single county row - a multi-part county holds one row per polygon part - so set [CountyId](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.YearBuiltDatasPostTask.CountyId 'DiGi\.GIS\.WebAPI\.Classes\.YearBuiltDatasPostTask\.CountyId') instead wherever the identifier is already known. [CountyId](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.YearBuiltDatasPostTask.CountyId 'DiGi\.GIS\.WebAPI\.Classes\.YearBuiltDatasPostTask\.CountyId') takes precedence when both are set.

```csharp
public string? Code { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.WebAPI.Classes.YearBuiltDatasPostTask.CountyId'></a>

## YearBuiltDatasPostTask\.CountyId Property

Gets or sets the identifier of the county row the year built data belong to\. When set it is used in preference to [Code](DiGi.GIS.WebAPI.Classes.md#DiGi.GIS.WebAPI.Classes.YearBuiltDatasPostTask.Code 'DiGi\.GIS\.WebAPI\.Classes\.YearBuiltDatasPostTask\.Code'), which leaves the server to choose between the rows of a multi\-part county\.

```csharp
public System.Nullable<int> CountyId { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')