#### [TetraPak.Common](index.md 'index')
## TetraPak.Serialization Namespace

| Classes | |
| :--- | :--- |
| [ArrayBufferWriter&lt;T&gt;](TetraPak_Serialization_ArrayBufferWriter_T_.md 'TetraPak.Serialization.ArrayBufferWriter&lt;T&gt;') |  |
| [DynamicEntitySafeJsonConverter&lt;T&gt;](TetraPak_Serialization_DynamicEntitySafeJsonConverter_T_.md 'TetraPak.Serialization.DynamicEntitySafeJsonConverter&lt;T&gt;') | A slower but more flexible JSON converter. This might come in handy when dealing with<br/>an inconsistent api that can't be relied on to serialize the same data type consistently<br/>at all times (such as `true` or sometimes `"True"` for booleans).<br/> |
| [JsonKeyFormatter](TetraPak_Serialization_JsonKeyFormatter.md 'TetraPak.Serialization.JsonKeyFormatter') |  |
| [KeyMapInfo](TetraPak_Serialization_KeyMapInfo.md 'TetraPak.Serialization.KeyMapInfo') | Contains a key map and other mapping settings.<br/> |

| Interfaces | |
| :--- | :--- |
| [IFlexibleEntity](TetraPak_Serialization_IFlexibleEntity.md 'TetraPak.Serialization.IFlexibleEntity') | Used by the [DynamicEntitySafeJsonConverter&lt;T&gt;](TetraPak_Serialization_DynamicEntitySafeJsonConverter_T_.md 'TetraPak.Serialization.DynamicEntitySafeJsonConverter&lt;T&gt;') to deal with inconsistent api that<br/>sometimes return objects/arrays as value types (such as a string).<br/> |
| [ISerializationKeyMapProvider](TetraPak_Serialization_ISerializationKeyMapProvider.md 'TetraPak.Serialization.ISerializationKeyMapProvider') | Dynamic (see [DynamicEntity](TetraPak_DynamicEntities_DynamicEntity.md 'TetraPak.DynamicEntities.DynamicEntity')) entities implementing this interface allows for<br/>automatic renaming of properties during serialization by the [TetraPak.Serialization.DynamicEntityJsonConverter&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Serialization.DynamicEntityJsonConverter-1 'TetraPak.Serialization.DynamicEntityJsonConverter`1'). <br/> |
