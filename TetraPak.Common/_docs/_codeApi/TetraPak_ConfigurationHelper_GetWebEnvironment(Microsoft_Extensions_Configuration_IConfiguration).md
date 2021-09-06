#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak').[ConfigurationHelper](TetraPak_ConfigurationHelper.md 'TetraPak.ConfigurationHelper')
## ConfigurationHelper.GetWebEnvironment(IConfiguration) Method
Gets the name of the running ASP.NET Core environment  
("`ASPNETCORE_ENVIRONMENT`" environment variable).   
```csharp
public static string GetWebEnvironment(this Microsoft.Extensions.Configuration.IConfiguration _);
```
#### Parameters
<a name='TetraPak_ConfigurationHelper_GetWebEnvironment(Microsoft_Extensions_Configuration_IConfiguration)__'></a>
`_` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the running ASP.NET Core web environment.  
