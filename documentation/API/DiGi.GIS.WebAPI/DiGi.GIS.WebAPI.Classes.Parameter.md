#### [DiGi\.GIS\.WebAPI](DiGi.GIS.WebAPI.Overview.md 'DiGi\.GIS\.WebAPI\.Overview')

## DiGi\.GIS\.WebAPI\.Classes\.Parameter Namespace
### Classes

<a name='DiGi.GIS.WebAPI.Classes.Parameter.UserYearBuiltParameter'></a>

## UserYearBuiltParameter Class

The body of the `setuseryearbuilt` write: one user\-supplied year built entry for a single building\.

Every member is bound nullable so an omitted field is representable and can be rejected explicitly - a non-nullable binding cannot tell an omitted value from a legitimate one, and `Relation` must be checked against the `YearBuiltRelation` members rather than compared to a sentinel.

```csharp
public class UserYearBuiltParameter : DiGi.WebAPI.Classes.Parameter
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.WebAPI\.Classes\.Parameter](https://learn.microsoft.com/en-us/dotnet/api/digi.webapi.classes.parameter 'DiGi\.WebAPI\.Classes\.Parameter') → UserYearBuiltParameter
### Constructors

<a name='DiGi.GIS.WebAPI.Classes.Parameter.UserYearBuiltParameter.UserYearBuiltParameter()'></a>

## UserYearBuiltParameter\(\) Constructor

Initializes a new instance of the [UserYearBuiltParameter](DiGi.GIS.WebAPI.Classes.Parameter.md#DiGi.GIS.WebAPI.Classes.Parameter.UserYearBuiltParameter 'DiGi\.GIS\.WebAPI\.Classes\.Parameter\.UserYearBuiltParameter') class\.

```csharp
public UserYearBuiltParameter();
```

<a name='DiGi.GIS.WebAPI.Classes.Parameter.UserYearBuiltParameter.UserYearBuiltParameter(DiGi.GIS.WebAPI.Classes.Parameter.UserYearBuiltParameter)'></a>

## UserYearBuiltParameter\(UserYearBuiltParameter\) Constructor

Initializes a new instance of the [UserYearBuiltParameter](DiGi.GIS.WebAPI.Classes.Parameter.md#DiGi.GIS.WebAPI.Classes.Parameter.UserYearBuiltParameter 'DiGi\.GIS\.WebAPI\.Classes\.Parameter\.UserYearBuiltParameter') class by copying the values from an existing instance\.

```csharp
public UserYearBuiltParameter(DiGi.GIS.WebAPI.Classes.Parameter.UserYearBuiltParameter userYearBuiltParameter);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Parameter.UserYearBuiltParameter.UserYearBuiltParameter(DiGi.GIS.WebAPI.Classes.Parameter.UserYearBuiltParameter).userYearBuiltParameter'></a>

`userYearBuiltParameter` [UserYearBuiltParameter](DiGi.GIS.WebAPI.Classes.Parameter.md#DiGi.GIS.WebAPI.Classes.Parameter.UserYearBuiltParameter 'DiGi\.GIS\.WebAPI\.Classes\.Parameter\.UserYearBuiltParameter')

The source instance from which to copy the values\.

<a name='DiGi.GIS.WebAPI.Classes.Parameter.UserYearBuiltParameter.UserYearBuiltParameter(System.Text.Json.Nodes.JsonObject)'></a>

## UserYearBuiltParameter\(JsonObject\) Constructor

Initializes a new instance of the [UserYearBuiltParameter](DiGi.GIS.WebAPI.Classes.Parameter.md#DiGi.GIS.WebAPI.Classes.Parameter.UserYearBuiltParameter 'DiGi\.GIS\.WebAPI\.Classes\.Parameter\.UserYearBuiltParameter') class using the provided JSON object\.

```csharp
public UserYearBuiltParameter(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.WebAPI.Classes.Parameter.UserYearBuiltParameter.UserYearBuiltParameter(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the data used to initialize the parameter\.
### Properties

<a name='DiGi.GIS.WebAPI.Classes.Parameter.UserYearBuiltParameter.CountyId'></a>

## UserYearBuiltParameter\.CountyId Property

Gets or sets the identifier of the county part the building is filed under\. A hint passed to the converter, which resolves the part itself; `null` is rejected\.

```csharp
public System.Nullable<int> CountyId { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.GIS.WebAPI.Classes.Parameter.UserYearBuiltParameter.Reference'></a>

## UserYearBuiltParameter\.Reference Property

Gets or sets the reference of the building the entry belongs to; blank is rejected\.

```csharp
public string? Reference { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.WebAPI.Classes.Parameter.UserYearBuiltParameter.Relation'></a>

## UserYearBuiltParameter\.Relation Property

Gets or sets how the stored year relates to the true construction year, as a [DiGi\.GIS\.Enums\.YearBuiltRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.enums.yearbuiltrelation 'DiGi\.GIS\.Enums\.YearBuiltRelation') member\. `null` means `Exact`; a value that is not a [DiGi\.GIS\.Enums\.YearBuiltRelation](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.enums.yearbuiltrelation 'DiGi\.GIS\.Enums\.YearBuiltRelation') member is rejected\.

```csharp
public System.Nullable<int> Relation { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.GIS.WebAPI.Classes.Parameter.UserYearBuiltParameter.Year'></a>

## UserYearBuiltParameter\.Year Property

Gets or sets the year built the user is asserting; `null` \(an omitted selection\) is rejected\.

```csharp
public System.Nullable<short> Year { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')