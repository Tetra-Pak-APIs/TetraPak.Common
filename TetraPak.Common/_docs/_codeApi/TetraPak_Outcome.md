#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## Outcome Class
Carries the outcome of an operation as well as any requested data, or an exception.  
This class is `abstract`.  
```csharp
public abstract class Outcome
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Outcome  

Derived  
&#8627; [Outcome&lt;T&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')  
### Constructors
<a name='TetraPak_Outcome_Outcome(bool_System_Exception_)'></a>
## Outcome.Outcome(bool, Exception?) Constructor
Initializes the [Outcome](TetraPak_Outcome.md 'TetraPak.Outcome') (for use by derived classes only).  
```csharp
protected Outcome(bool result, System.Exception? exception=null);
```
#### Parameters
<a name='TetraPak_Outcome_Outcome(bool_System_Exception_)_result'></a>
`result` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Assigns the internal [Result](TetraPak_Outcome.md#TetraPak_Outcome_Result 'TetraPak.Outcome.Result') (success/failure).  
  
<a name='TetraPak_Outcome_Outcome(bool_System_Exception_)_exception'></a>
`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
(optional)<br/>  
Assigns the [Exception](TetraPak_Outcome.md#TetraPak_Outcome_Exception 'TetraPak.Outcome.Exception').  
  
  
### Properties
<a name='TetraPak_Outcome_Exception'></a>
## Outcome.Exception Property
Gets an exception that is relevant to the (failed) outcome.  
```csharp
public System.Exception Exception { get; }
```
#### Property Value
[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')
  
<a name='TetraPak_Outcome_IsSuccess'></a>
## Outcome.IsSuccess Property
Gets a value to indicate whether the outcome is successful.  
This is mainly intended for "clear coding" as an alternative to implicitly casting  
the output to a [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') value when testing outcome.  
```csharp
public bool IsSuccess { get; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
  
<a name='TetraPak_Outcome_Result'></a>
## Outcome.Result Property
Gets or value to indicate success/failure.  
This property is intended for use by derived implementations only.  
```csharp
protected bool Result { get; set; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
#### See Also
- [SetResult(bool)](TetraPak_Outcome.md#TetraPak_Outcome_SetResult(bool) 'TetraPak.Outcome.SetResult(bool)')
  
### Methods
<a name='TetraPak_Outcome_SetResult(bool)'></a>
## Outcome.SetResult(bool) Method
Assigns the [Result](TetraPak_Outcome.md#TetraPak_Outcome_Result 'TetraPak.Outcome.Result').  
This method is intended for internal use by derived classes only.  
```csharp
protected void SetResult(bool value);
```
#### Parameters
<a name='TetraPak_Outcome_SetResult(bool)_value'></a>
`value` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value to be assigned.  
  
  
<a name='TetraPak_Outcome_ToString()'></a>
## Outcome.ToString() Method
Returns a string that represents the current object.
```csharp
public override string ToString();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string that represents the current object.
  
### Operators
<a name='TetraPak_Outcome_op_Implicitbool(TetraPak_Outcome)'></a>
## Outcome.implicit operator bool(Outcome) Operator
Implicitly casts the outcome to a [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') value.  
This is mainly intended for "clear coding" as an alternative to using the [IsSuccess](TetraPak_Outcome.md#TetraPak_Outcome_IsSuccess 'TetraPak.Outcome.IsSuccess')  
property for testing outcome.  
```csharp
public static bool implicit operator bool(TetraPak.Outcome outcome);
```
#### Parameters
<a name='TetraPak_Outcome_op_Implicitbool(TetraPak_Outcome)_outcome'></a>
`outcome` [Outcome](TetraPak_Outcome.md 'TetraPak.Outcome')  
The outcome to be implicitly cast to its [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') result.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the outcome is successful; otherwise `false`.  
            
  
