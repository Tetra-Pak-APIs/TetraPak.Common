#### [TetraPak.Common](index.md 'index')
### [TetraPak.Serialization](TetraPak_Serialization.md 'TetraPak.Serialization')
## DynamicEntitySafeJsonConverter&lt;T&gt; Class
A slower but more flexible JSON converter. This might come in handy when dealing with  
an inconsistent api that can't be relied on to serialize the same data type consistently  
at all times (such as `true` or sometimes `"True"` for booleans).  
```csharp
public class DynamicEntitySafeJsonConverter<T> : TetraPak.Serialization.DynamicEntityJsonConverter<T>
    where T : TetraPak.DynamicEntities.DynamicEntity
```
#### Type parameters
<a name='TetraPak_Serialization_DynamicEntitySafeJsonConverter_T__T'></a>
`T`  
The type of ([DynamicEntity](TetraPak_DynamicEntities_DynamicEntity.md 'TetraPak.DynamicEntities.DynamicEntity')) type to be converted.  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Text.Json.Serialization.JsonConverter](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.Serialization.JsonConverter 'System.Text.Json.Serialization.JsonConverter') &#129106; [System.Text.Json.Serialization.JsonConverter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.Serialization.JsonConverter-1 'System.Text.Json.Serialization.JsonConverter`1')[T](TetraPak_Serialization_DynamicEntitySafeJsonConverter_T_.md#TetraPak_Serialization_DynamicEntitySafeJsonConverter_T__T 'TetraPak.Serialization.DynamicEntitySafeJsonConverter&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.Serialization.JsonConverter-1 'System.Text.Json.Serialization.JsonConverter`1') &#129106; [TetraPak.Serialization.DynamicEntityJsonConverter&lt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Serialization.DynamicEntityJsonConverter-1 'TetraPak.Serialization.DynamicEntityJsonConverter`1')[T](TetraPak_Serialization_DynamicEntitySafeJsonConverter_T_.md#TetraPak_Serialization_DynamicEntitySafeJsonConverter_T__T 'TetraPak.Serialization.DynamicEntitySafeJsonConverter&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Serialization.DynamicEntityJsonConverter-1 'TetraPak.Serialization.DynamicEntityJsonConverter`1') &#129106; DynamicEntitySafeJsonConverter&lt;T&gt;  
