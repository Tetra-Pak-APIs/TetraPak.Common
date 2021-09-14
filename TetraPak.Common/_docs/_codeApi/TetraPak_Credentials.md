#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## Credentials Class
Represents a generic credentials value, typically used for authentication use purposes.  
```csharp
public class Credentials : TetraPak.DynamicEntities.DynamicIdentifiableEntity<string>,
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [DynamicEntity](TetraPak_DynamicEntities_DynamicEntity.md 'TetraPak.DynamicEntities.DynamicEntity') &#129106; [TetraPak.DynamicEntities.DynamicIdentifiableEntity&lt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.DynamicEntities.DynamicIdentifiableEntity-1 'TetraPak.DynamicEntities.DynamicIdentifiableEntity`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/TetraPak.DynamicEntities.DynamicIdentifiableEntity-1 'TetraPak.DynamicEntities.DynamicIdentifiableEntity`1') &#129106; Credentials  

Derived  
&#8627; [ActorToken](TetraPak_ActorToken.md 'TetraPak.ActorToken')  

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  
### Constructors
<a name='TetraPak_Credentials_Credentials()'></a>
## Credentials.Credentials() Constructor
Initializes the [Credentials](TetraPak_Credentials.md 'TetraPak.Credentials') value.  
```csharp
public Credentials();
```
  
<a name='TetraPak_Credentials_Credentials(string_string_string)'></a>
## Credentials.Credentials(string, string, string) Constructor
Initializes the [Credentials](TetraPak_Credentials.md 'TetraPak.Credentials') value.  
```csharp
public Credentials(string identity, string secret, string newSecret=null);
```
#### Parameters
<a name='TetraPak_Credentials_Credentials(string_string_string)_identity'></a>
`identity` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Initializes the [Identity](TetraPak_Credentials.md#TetraPak_Credentials_Identity 'TetraPak.Credentials.Identity') property.  
  
<a name='TetraPak_Credentials_Credentials(string_string_string)_secret'></a>
`secret` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Initializes the [Secret](TetraPak_Credentials.md#TetraPak_Credentials_Secret 'TetraPak.Credentials.Secret') property.  
  
<a name='TetraPak_Credentials_Credentials(string_string_string)_newSecret'></a>
`newSecret` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
(optional)<br/>  
Initializes the [NewSecret](TetraPak_Credentials.md#TetraPak_Credentials_NewSecret 'TetraPak.Credentials.NewSecret') property.  
  
  
### Properties
<a name='TetraPak_Credentials_Identity'></a>
## Credentials.Identity Property
Gets or sets the credentials identity element.  
```csharp
public string Identity { get; set; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
<a name='TetraPak_Credentials_IsAssigned'></a>
## Credentials.IsAssigned Property
Gets a value indicating whether the credentials are assigned.  
```csharp
public virtual bool IsAssigned { get; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
  
<a name='TetraPak_Credentials_NewSecret'></a>
## Credentials.NewSecret Property
Gets or sets a new credentials secret/password element.  
```csharp
public string NewSecret { get; set; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
<a name='TetraPak_Credentials_Secret'></a>
## Credentials.Secret Property
Gets or sets the credentials secret/password element.  
```csharp
public string Secret { get; set; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
### Methods
<a name='TetraPak_Credentials_CloneWithoutSecrets()'></a>
## Credentials.CloneWithoutSecrets() Method
Clones the entity without any secrets, to support scenarios where secrets are not necessary.  
```csharp
public TetraPak.Credentials CloneWithoutSecrets();
```
#### Returns
[Credentials](TetraPak_Credentials.md 'TetraPak.Credentials')  
A cloned [Credentials](TetraPak_Credentials.md 'TetraPak.Credentials').  
  
<a name='TetraPak_Credentials_Dispose()'></a>
## Credentials.Dispose() Method
Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
```csharp
public void Dispose();
```

Implements [Dispose()](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable.Dispose 'System.IDisposable.Dispose')  
  
