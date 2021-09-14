#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## TypeHelper Class
```csharp
public static class TypeHelper
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TypeHelper  
### Methods
<a name='TetraPak_TypeHelper_GetOverloadingImplicitOperator(System_Type_System_Type)'></a>
## TypeHelper.GetOverloadingImplicitOperator(Type, Type) Method
Attempts getting an implicit overload operator type method.  
```csharp
public static System.Reflection.MethodInfo GetOverloadingImplicitOperator(this System.Type self, System.Type type);
```
#### Parameters
<a name='TetraPak_TypeHelper_GetOverloadingImplicitOperator(System_Type_System_Type)_self'></a>
`self` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') declaring the requested implicit overloaded type method.  
  
<a name='TetraPak_TypeHelper_GetOverloadingImplicitOperator(System_Type_System_Type)_type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The overloaded [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type').  
  
#### Returns
[System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo')  
The [System.Reflection.MethodInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.MethodInfo 'System.Reflection.MethodInfo') if the requested implicit overloaded type method exists; otherwise `null`.  
#### See Also
- [IsOverloadingImplicitOperator&lt;T&gt;(Type)](TetraPak_TypeHelper.md#TetraPak_TypeHelper_IsOverloadingImplicitOperator_T_(System_Type) 'TetraPak.TypeHelper.IsOverloadingImplicitOperator&lt;T&gt;(System.Type)')
- [IsOverloadingImplicitOperator&lt;T&gt;(Type)](TetraPak_TypeHelper.md#TetraPak_TypeHelper_IsOverloadingImplicitOperator_T_(System_Type) 'TetraPak.TypeHelper.IsOverloadingImplicitOperator&lt;T&gt;(System.Type)')
  
<a name='TetraPak_TypeHelper_IsCollection(object_System_Type_System_Collections_IEnumerable_int_bool_bool)'></a>
## TypeHelper.IsCollection(object, Type, IEnumerable, int, bool, bool) Method
Examine an object and returns information on whether it is a collection.   
```csharp
public static bool IsCollection(this object self, out System.Type itemType, out System.Collections.IEnumerable items, out int count, bool alwaysResolveCount=false, bool treatStringAsUnary=true);
```
#### Parameters
<a name='TetraPak_TypeHelper_IsCollection(object_System_Type_System_Collections_IEnumerable_int_bool_bool)_self'></a>
`self` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The examined object.   
  
<a name='TetraPak_TypeHelper_IsCollection(object_System_Type_System_Collections_IEnumerable_int_bool_bool)_itemType'></a>
`itemType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
Passes back the collection item type on success; otherwise a `null` value.  
  
<a name='TetraPak_TypeHelper_IsCollection(object_System_Type_System_Collections_IEnumerable_int_bool_bool)_items'></a>
`items` [System.Collections.IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable 'System.Collections.IEnumerable')  
Passes back the collection items on success; otherwise a `null` value.  
  
<a name='TetraPak_TypeHelper_IsCollection(object_System_Type_System_Collections_IEnumerable_int_bool_bool)_count'></a>
`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
On success; passes back the number of items found in the collection, or -1  
(if too expensive to resolve and [alwaysResolveCount](TetraPak_TypeHelper.md#TetraPak_TypeHelper_IsCollection(object_System_Type_System_Collections_IEnumerable_int_bool_bool)_alwaysResolveCount 'TetraPak.TypeHelper.IsCollection(object, System.Type, System.Collections.IEnumerable, int, bool, bool).alwaysResolveCount') is not set).  
On failure a value of zero (0) is passed back.   
  
<a name='TetraPak_TypeHelper_IsCollection(object_System_Type_System_Collections_IEnumerable_int_bool_bool)_alwaysResolveCount'></a>
`alwaysResolveCount` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
(optional; default=`false`)<br/>  
When set, and the object is considered a collection, the number of items found will always be resolved,  
even when performance might be negatively impacted. When not set the [count](TetraPak_TypeHelper.md#TetraPak_TypeHelper_IsCollection(object_System_Type_System_Collections_IEnumerable_int_bool_bool)_count 'TetraPak.TypeHelper.IsCollection(object, System.Type, System.Collections.IEnumerable, int, bool, bool).count') might  
be passed back as a negative value to indicate the value was not resolved.  
  
<a name='TetraPak_TypeHelper_IsCollection(object_System_Type_System_Collections_IEnumerable_int_bool_bool)_treatStringAsUnary'></a>
`treatStringAsUnary` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
(optional; default=`true`)<br/>  
When set [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')s will be treated as unary values, and not as collections.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if [self](TetraPak_TypeHelper.md#TetraPak_TypeHelper_IsCollection(object_System_Type_System_Collections_IEnumerable_int_bool_bool)_self 'TetraPak.TypeHelper.IsCollection(object, System.Type, System.Collections.IEnumerable, int, bool, bool).self') is a collection; otherwise `false`.  
            
  
<a name='TetraPak_TypeHelper_IsOverloadingImplicitOperator_T_(System_Type)'></a>
## TypeHelper.IsOverloadingImplicitOperator&lt;T&gt;(Type) Method
Gets a value specifying whether the  declares an  
overloaded implicit type method.  
```csharp
public static bool IsOverloadingImplicitOperator<T>(this System.Type self);
```
#### Type parameters
<a name='TetraPak_TypeHelper_IsOverloadingImplicitOperator_T_(System_Type)_T'></a>
`T`  
The overloaded .  
#### See Also
- [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')
  
#### Parameters
<a name='TetraPak_TypeHelper_IsOverloadingImplicitOperator_T_(System_Type)_self'></a>
`self` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') declaring the requested implicit overloaded type method.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the type declares an implicit overloaded type method; otherwise `false`.  
            
#### See Also
- [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')
- [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')
- [GetOverloadingImplicitOperator(Type, Type)](TetraPak_TypeHelper.md#TetraPak_TypeHelper_GetOverloadingImplicitOperator(System_Type_System_Type) 'TetraPak.TypeHelper.GetOverloadingImplicitOperator(System.Type, System.Type)')
  
