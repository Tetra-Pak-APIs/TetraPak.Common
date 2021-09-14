#### [TetraPak.Common](index.md 'index')
### [TetraPak](TetraPak.md 'TetraPak')
## Outcome&lt;T&gt; Class
Carries the outcome of an operation as well as any requested data, or an exception.  
The class derives from the `abstract`[Outcome](TetraPak_Outcome.md 'TetraPak.Outcome') class.  
```csharp
public class Outcome<T> : TetraPak.Outcome
```
#### Type parameters
<a name='TetraPak_Outcome_T__T'></a>
`T`  
The [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') of data requested.  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Outcome](TetraPak_Outcome.md 'TetraPak.Outcome') &#129106; Outcome&lt;T&gt;  

Derived  
&#8627; [EnumOutcome&lt;T&gt;](TetraPak_EnumOutcome_T_.md 'TetraPak.EnumOutcome&lt;T&gt;')  
### Remarks
The .NET try-convention when writing methods, such as  
[System.Enum.TryParse(System.Type,System.String,System.Boolean,System.Object@)](https://docs.microsoft.com/en-us/dotnet/api/System.Enum.TryParse#System_Enum_TryParse_System_Type,System_String,System_Boolean,System_Object@_ 'System.Enum.TryParse(System.Type,System.String,System.Boolean,System.Object@)') relies on returning a [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
value to reflect the outcome of the operation and, when successful, the requested value as an `out`  
parameter. This is great for synchronous coding but doesn't fit the asynchronous paradigm as `out`  
parameters are not allowed with `async` methods in C#.  




  
The [Outcome&lt;T&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;') is a simple solution to this problem, as it will return both the  
outcome, the requested value (on success) or an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') if the operation failed.   




<b>Implicit type casting</b>



  
An [Outcome&lt;T&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;') value can be used to implicitly to test the outcome  
(eg. `if (outcome)`) ...) or to get the expected value, when successful (eg. `Car car = outcome`).  
Of course, if the expected value itself is a [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') then you should avoid implicitly  
type casting the value, as you would always get the "outcome", not the value.  


<example>  
  
This example shows an <c>async</c> method that fetches an object from a json file and returns  
the outcome:  
</para>  
  
public async Task&lt;Outcome&lt;T&gt;&gt; GetFromFileAsync&lt;T&gt;(string path)  
{  
    try  
    {  
        var json = await File.ReadAllTextAsync(path);  
        var item = JsonSerializer.Deserialize&lt;T&gt;(json);  
        return Outcome&lt;T&gt;.Success(item);  
    }  
    catch (Exception ex)  
    {  
        return Outcome&lt;T&gt;.Fail(ex);  
    }  
}  
</code>  
  
This example shows some client code that consumes an <see cref="T:TetraPak.Outcome`1"/> to fetch a <c>Car</c>  
from the file system:  
</para>  
  
 public async Task&lt;Car&gt; GetCarAsync(string registrationNumber)  
 {  
    var filePath = getFilePathForCarWithRegistrationNumber(registrationNumber);  
    var outcome = await GetFromFileAsync&lt;Car&gt;(filePath);  
    if (!outcome)  
    {  
        _logger.Error(outcome.Exception, $"Failed when reading car: {registrationNumber}");  
        throw outcome.Exception;  
    }  
  
    return outcome;  
}  
</code>  
### Constructors
<a name='TetraPak_Outcome_T__Outcome(bool_T_System_Exception_)'></a>
## Outcome&lt;T&gt;.Outcome(bool, T, Exception?) Constructor
Initializes the [Outcome&lt;T&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;').  
```csharp
protected Outcome(bool result, T value, System.Exception? exception=null);
```
#### Parameters
<a name='TetraPak_Outcome_T__Outcome(bool_T_System_Exception_)_result'></a>
`result` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Initializes the outcome result (success/failure).  
  
<a name='TetraPak_Outcome_T__Outcome(bool_T_System_Exception_)_value'></a>
`value` [T](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__T 'TetraPak.Outcome&lt;T&gt;.T')  
Initializes the [Value](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__Value 'TetraPak.Outcome&lt;T&gt;.Value').  
  
<a name='TetraPak_Outcome_T__Outcome(bool_T_System_Exception_)_exception'></a>
`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
Initializes the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').  
  
  
### Properties
<a name='TetraPak_Outcome_T__Value'></a>
## Outcome&lt;T&gt;.Value Property
Gets the expected outcome value, when successful.   
```csharp
public T Value { get; set; }
```
#### Property Value
[T](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__T 'TetraPak.Outcome&lt;T&gt;.T')
#### See Also
- [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')
  
### Methods
<a name='TetraPak_Outcome_T__Fail()'></a>
## Outcome&lt;T&gt;.Fail() Method
Creates and returns a failed outcome.  
```csharp
public static TetraPak.Outcome<T> Fail();
```
#### Returns
[TetraPak.Outcome&lt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[T](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__T 'TetraPak.Outcome&lt;T&gt;.T')[&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')  
An [Outcome&lt;T&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;') to indicate failure and also carry a default  
value of type [T](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__T 'TetraPak.Outcome&lt;T&gt;.T').  
  
<a name='TetraPak_Outcome_T__Fail(System_Exception)'></a>
## Outcome&lt;T&gt;.Fail(Exception) Method
Creates and returns a failed outcome that also carries an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').  
```csharp
public static TetraPak.Outcome<T> Fail(System.Exception exception);
```
#### Parameters
<a name='TetraPak_Outcome_T__Fail(System_Exception)_exception'></a>
`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
Assigns the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').  
  
#### Returns
[TetraPak.Outcome&lt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[T](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__T 'TetraPak.Outcome&lt;T&gt;.T')[&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')  
An [Outcome&lt;T&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;') to indicate failure and also carry the causing [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception').  
  
<a name='TetraPak_Outcome_T__Fail(T)'></a>
## Outcome&lt;T&gt;.Fail(T) Method
Creates and returns a failed outcome that also carries a specified value of type  
[T](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__T 'TetraPak.Outcome&lt;T&gt;.T').  
```csharp
public static TetraPak.Outcome<T> Fail(T value);
```
#### Parameters
<a name='TetraPak_Outcome_T__Fail(T)_value'></a>
`value` [T](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__T 'TetraPak.Outcome&lt;T&gt;.T')  
  
#### Returns
[TetraPak.Outcome&lt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[T](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__T 'TetraPak.Outcome&lt;T&gt;.T')[&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')  
An [Outcome&lt;T&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;') to indicate failure and also carry a default  
value of type [T](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__T 'TetraPak.Outcome&lt;T&gt;.T').  
  
<a name='TetraPak_Outcome_T__Success(T)'></a>
## Outcome&lt;T&gt;.Success(T) Method
Creates and returns a successful outcome with a requested value.  
```csharp
public static TetraPak.Outcome<T> Success(T value);
```
#### Parameters
<a name='TetraPak_Outcome_T__Success(T)_value'></a>
`value` [T](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__T 'TetraPak.Outcome&lt;T&gt;.T')  
The value to be carried by the outcome.  
  
#### Returns
[TetraPak.Outcome&lt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[T](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__T 'TetraPak.Outcome&lt;T&gt;.T')[&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')  
An [Outcome&lt;T&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;') to indicate success and also carry  
a value of type [T](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__T 'TetraPak.Outcome&lt;T&gt;.T').  
  
<a name='TetraPak_Outcome_T__ToString()'></a>
## Outcome&lt;T&gt;.ToString() Method
Returns a string that represents the current object.
```csharp
public override string ToString();
```
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string that represents the current object.
  
<a name='TetraPak_Outcome_T__WithValue(T)'></a>
## Outcome&lt;T&gt;.WithValue(T) Method
Fluid code API to assign the [Value](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__Value 'TetraPak.Outcome&lt;T&gt;.Value') and return the outcome object.   
```csharp
public TetraPak.Outcome<T> WithValue(T value);
```
#### Parameters
<a name='TetraPak_Outcome_T__WithValue(T)_value'></a>
`value` [T](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__T 'TetraPak.Outcome&lt;T&gt;.T')  
Assigns the [Value](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__Value 'TetraPak.Outcome&lt;T&gt;.Value').  
  
#### Returns
[TetraPak.Outcome&lt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[T](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__T 'TetraPak.Outcome&lt;T&gt;.T')[&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')  
`this` outcome object.  
            
  
### Operators
<a name='TetraPak_Outcome_T__op_ImplicitT(TetraPak_Outcome_T_)'></a>
## Outcome&lt;T&gt;.implicit operator T(Outcome&lt;T&gt;) Operator
Implicitly converts the outcome to the expected value.  
```csharp
public static T implicit operator T(TetraPak.Outcome<T> outcome);
```
#### Parameters
<a name='TetraPak_Outcome_T__op_ImplicitT(TetraPak_Outcome_T_)_outcome'></a>
`outcome` [TetraPak.Outcome&lt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')[T](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__T 'TetraPak.Outcome&lt;T&gt;.T')[&gt;](TetraPak_Outcome_T_.md 'TetraPak.Outcome&lt;T&gt;')  
The outcome.  
  
#### Returns
[T](TetraPak_Outcome_T_.md#TetraPak_Outcome_T__T 'TetraPak.Outcome&lt;T&gt;.T')  
The expected (successful) outcome value.  
  
