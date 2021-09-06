#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[TypeHelper](TetraPak_TypeHelper.md 'TetraPak.TypeHelper')
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
- [IsOverloadingImplicitOperator&lt;T&gt;(Type)](TetraPak_TypeHelper_IsOverloadingImplicitOperator_T_(System_Type).md 'TetraPak.TypeHelper.IsOverloadingImplicitOperator&lt;T&gt;(System.Type)')
- [IsOverloadingImplicitOperator&lt;T&gt;(Type)](TetraPak_TypeHelper_IsOverloadingImplicitOperator_T_(System_Type).md 'TetraPak.TypeHelper.IsOverloadingImplicitOperator&lt;T&gt;(System.Type)')
