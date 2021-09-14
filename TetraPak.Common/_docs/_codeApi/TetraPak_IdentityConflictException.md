#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## IdentityConflictException Class
To be thrown when there is a conflict of identities.  
```csharp
public class IdentityConflictException : System.Exception
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; IdentityConflictException  
### Constructors
<a name='TetraPak_IdentityConflictException_IdentityConflictException(string_string_System_Exception)'></a>
## IdentityConflictException.IdentityConflictException(string, string, Exception) Constructor
Initializes the [IdentityConflictException](TetraPak_IdentityConflictException.md 'TetraPak.IdentityConflictException').  
```csharp
public IdentityConflictException(string identity, string message=null, System.Exception innerException=null);
```
#### Parameters
<a name='TetraPak_IdentityConflictException_IdentityConflictException(string_string_System_Exception)_identity'></a>
`identity` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Assigns the [Identity](TetraPak_IdentityConflictException.md#TetraPak_IdentityConflictException_Identity 'TetraPak.IdentityConflictException.Identity')
  
<a name='TetraPak_IdentityConflictException_IdentityConflictException(string_string_System_Exception)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The error message that explains the reason for the exception.  
  
<a name='TetraPak_IdentityConflictException_IdentityConflictException(string_string_System_Exception)_innerException'></a>
`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
The exception that is the cause of the current exception, or a `null` reference  
(`Nothing` in Visual Basic) if no inner exception is specified.  
  
  
### Properties
<a name='TetraPak_IdentityConflictException_Identity'></a>
## IdentityConflictException.Identity Property
Gets the conflicting identity.  
```csharp
public string Identity { get; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
