#### [TetraPak.Common](index.md 'index')
### [TetraPak.Serialization](TetraPak_Serialization.md 'TetraPak.Serialization')
## ISerializationKeyMapProvider Interface
Dynamic (see [DynamicEntity](TetraPak_DynamicEntities_DynamicEntity.md 'TetraPak.DynamicEntities.DynamicEntity')) entities implementing this interface allows for  
automatic renaming of properties during serialization by the [TetraPak.Serialization.DynamicEntityJsonConverter&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.Serialization.DynamicEntityJsonConverter-1 'TetraPak.Serialization.DynamicEntityJsonConverter`1').   
```csharp
public interface ISerializationKeyMapProvider
```
### Remarks
Implementing this interface is a cheap and efficient means to allow your app service to force a  
naming convention (such as camel case, Pascal case, snake case etc.) without having to declare  
additional classes for output.  
### Methods
<a name='TetraPak_Serialization_ISerializationKeyMapProvider_GetKeyMap()'></a>
## ISerializationKeyMapProvider.GetKeyMap() Method
Returns a [KeyMapInfo](TetraPak_Serialization_KeyMapInfo.md 'TetraPak.Serialization.KeyMapInfo') object with a key map and other mapping settings.  
```csharp
TetraPak.Serialization.KeyMapInfo GetKeyMap();
```
#### Returns
[KeyMapInfo](TetraPak_Serialization_KeyMapInfo.md 'TetraPak.Serialization.KeyMapInfo')  
  
