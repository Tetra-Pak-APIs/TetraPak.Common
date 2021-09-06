#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## RuntimeEnvironment Enum
This enum value can be used to identity a runtime environment.  
```csharp
public enum RuntimeEnvironment

```
#### Fields
<a name='TetraPak_RuntimeEnvironment_Development'></a>
`Development` 20  
Represents a runtime environment that changes very frequently, to be used for development  
purposes only.   
This type of environment must be completely isolated from a production environment.  
  
<a name='TetraPak_RuntimeEnvironment_Migration'></a>
`Migration` 30  
Represents a runtime environment that emulates a [Production](TetraPak_RuntimeEnvironment.md#TetraPak_RuntimeEnvironment_Production 'TetraPak.RuntimeEnvironment.Production') environment very closely,  
to test quality and ensure a solution's function before being deployed for production use.  
  
<a name='TetraPak_RuntimeEnvironment_Production'></a>
`Production` 40  
Represents a runtime environment that is fully operational, with access to production level  
services and data. Solutions running in this runtime environment should have been carefully  
tested to ensure stability and functionality.  
  
<a name='TetraPak_RuntimeEnvironment_Sandbox'></a>
`Sandbox` 10  
Represents a runtime environment used for very early development and/or proof of concept.  
This type of environment must be completely isolated from a production environment.  
  
<a name='TetraPak_RuntimeEnvironment_Staging'></a>
`Staging` 30  
Equivalent to [Migration](TetraPak_RuntimeEnvironment.md#TetraPak_RuntimeEnvironment_Migration 'TetraPak.RuntimeEnvironment.Migration').   
  
<a name='TetraPak_RuntimeEnvironment_Test'></a>
`Test` 30  
Equivalent to [Migration](TetraPak_RuntimeEnvironment.md#TetraPak_RuntimeEnvironment_Migration 'TetraPak.RuntimeEnvironment.Migration').   
  
<a name='TetraPak_RuntimeEnvironment_Testing'></a>
`Testing` 30  
Equivalent to [Migration](TetraPak_RuntimeEnvironment.md#TetraPak_RuntimeEnvironment_Migration 'TetraPak.RuntimeEnvironment.Migration').   
  
<a name='TetraPak_RuntimeEnvironment_Unknown'></a>
`Unknown` 0  
Runtime environment is unknown/unresolved.  
  
