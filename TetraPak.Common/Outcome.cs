using System;

#nullable enable

namespace TetraPak
{
    /// <summary>
    ///   Carries the outcome of an operation as well as any requested data, or an exception.
    ///   The class derives from the <c>abstract</c> <see cref="Outcome"/> class.
    /// </summary>
    /// <typeparam name="T">
    ///   The <see cref="Type"/> of data requested.
    /// </typeparam>
    /// <remarks>
    ///   <para>
    ///   The .NET try-convention when writing methods, such as
    ///   <see cref="Enum.TryParse(System.Type,string?,bool,out object?)"/> relies on returning a <see cref="bool"/>
    ///   value to reflect the outcome of the operation and, when successful, the requested value as an <c>out</c>
    ///   parameter. This is great for synchronous coding but doesn't fit the asynchronous paradigm as <c>out</c>
    ///   parameters are not allowed with <c>async</c> methods in C#.
    ///   </para>
    ///   <para>
    ///   The <see cref="Outcome{T}"/> is a simple solution to this problem, as it will return both the
    ///   outcome, the requested value (on success) or an <see cref="Exception"/> if the operation failed. 
    ///   </para>
    ///   <para>
    ///   <b>Implicit type casting</b>
    ///   </para>
    ///   <para>
    ///   An <see cref="Outcome{T}"/> value can be used to implicitly to test the outcome
    ///   (eg. <c>if (outcome)</c>) ...) or to get the expected value, when successful (eg. <c>Car car = outcome</c>).
    ///   Of course, if the expected value itself is a <see cref="bool"/> then you should avoid implicitly
    ///   type casting the value, as you would always get the "outcome", not the value.
    ///   </para>
    ///   <example>
    ///   <para>
    ///   This example shows an <c>async</c> method that fetches an object from a json file and returns
    ///   the outcome:
    ///   </para>
    ///   <code>
    /// 
    ///   public async Task&lt;Outcome&lt;T&gt;&gt; GetFromFileAsync&lt;T&gt;(string path)
    ///   {
    ///       try
    ///       {
    ///           var json = await File.ReadAllTextAsync(path);
    ///           var item = JsonSerializer.Deserialize&lt;T&gt;(json);
    ///           return Outcome&lt;T&gt;.Success(item);
    ///       }
    ///       catch (Exception ex)
    ///       {
    ///           return Outcome&lt;T&gt;.Fail(ex);
    ///       }
    ///   }
    /// 
    ///   </code>
    ///   <para>
    ///   This example shows some client code that consumes an <see cref="Outcome{T}"/> to fetch a <c>Car</c>
    ///   from the file system:
    ///   </para>
    ///   <code>
    ///    public async Task&lt;Car&gt; GetCarAsync(string registrationNumber)
    ///    {
    ///       var filePath = getFilePathForCarWithRegistrationNumber(registrationNumber);
    ///       var outcome = await GetFromFileAsync&lt;Car&gt;(filePath);
    ///       if (!outcome)
    ///       {
    ///           _logger.Error(outcome.Exception, $"Failed when reading car: {registrationNumber}");
    ///           throw outcome.Exception;
    ///       }
    ///   
    ///       return outcome;
    ///   }
    ///   </code>
    ///   </example>
    /// </remarks>
    public class Outcome<T> : Outcome
    {
        /// <summary>
        ///   Gets the expected outcome value, when successful. 
        /// </summary>
        /// <seealso cref="Exception"/>
        public T Value { get; protected set; }

        /// <summary>
        ///   Creates and returns a successful outcome with a requested value.
        /// </summary>
        /// <param name="value">
        ///   The value to be carried by the outcome.
        /// </param>
        /// <returns>
        ///   An <see cref="Outcome{T}"/> to indicate success and also carry
        ///   a value of type <typeparamref name="T"/>.
        /// </returns>
        public static Outcome<T> Success(T value) => new Outcome<T>(true, value);

        /// <summary>
        ///   Creates and returns a failed outcome.
        /// </summary>
        /// <returns>
        ///   An <see cref="Outcome{T}"/> to indicate failure and also carry a default
        ///   value of type <typeparamref name="T"/>.
        /// </returns>
        public static Outcome<T> Fail() => new Outcome<T>(false, default!);

        /// <summary>
        ///   Creates and returns a failed outcome that also carries a specified value of type
        ///   <typeparamref name="T"/>.
        /// </summary>
        /// <returns>
        ///   An <see cref="Outcome{T}"/> to indicate failure and also carry a default
        ///   value of type <typeparamref name="T"/>.
        /// </returns>
        public static Outcome<T> Fail(T value) => new Outcome<T>(false, value);

        /// <summary>
        ///   Creates and returns a failed outcome that also carries an <see cref="Exception"/>.
        /// </summary>
        /// <param name="exception">
        ///   Assigns the <see cref="Exception"/>.
        /// </param>
        /// <returns>
        ///   An <see cref="Outcome{T}"/> to indicate failure and also carry the causing <see cref="Exception"/>.
        /// </returns>
        public static Outcome<T> Fail(Exception exception) => new Outcome<T>(false, default!, exception);

        // public static Outcome<T> Fail(T value, Exception exception) => new Outcome<T>(false, value, exception); obsolete

        /// <inheritdoc />
        public override string ToString()
        {
            return IsSuccess ? $"success : {value()}" : $"fail{errorMessage()}";

            string value() => (ReferenceEquals(default, Value) ? "(null)" : Value.ToString())!;

            string errorMessage()
            {
                // if (Exception is null) obsolete
                //     return "";

                return $" ({Exception.Message})";
            }
        }

        /// <summary>
        ///   Implicitly converts the outcome to the expected value.
        /// </summary>
        /// <param name="outcome">
        ///   The outcome.
        /// </param>
        /// <returns>
        ///   The expected (successful) outcome value.
        /// </returns>
        public static implicit operator T(Outcome<T> outcome) => outcome.Value;

        /// <summary>
        ///   Fluid code API to assign the <see cref="Value"/> and return the outcome object. 
        /// </summary>
        /// <param name="value">
        ///   Assigns the <see cref="Value"/>.
        /// </param>
        /// <returns>
        ///   <c>this</c> outcome object.
        /// </returns>
        public Outcome<T> WithValue(T value)
        {
            Value = value;
            return this;
        }

        /// <summary>
        ///   Initializes the <see cref="Outcome{T}"/>.
        /// </summary>
        /// <param name="result">
        ///   Initializes the outcome result (success/failure).
        /// </param>
        /// <param name="value">
        ///   Initializes the <see cref="Value"/>.
        /// </param>
        /// <param name="exception">
        ///   Initializes the <see cref="Exception"/>.
        /// </param>
        protected Outcome(bool result, T value, Exception? exception = null) : base(result, exception)
        {
            Value = value;
        }
    }

    /// <summary>
    ///   Carries the outcome of an operation as well as any requested data, or an exception.
    ///   This class is <c>abstract</c>.
    /// </summary>
    public abstract class Outcome
    {
        readonly Exception? _exception;
        
        /// <summary>
        ///   Gets or value to indicate success/failure.
        ///   This property is intended for use by derived implementations only.
        /// </summary>
        /// <seealso cref="SetResult"/>
        protected bool Result { get; private set; }

        /// <summary>
        ///   Gets an exception that is relevant to the (failed) outcome.
        /// </summary>
        public Exception Exception => _exception ?? new Exception("(no error message)");


        /// <summary>
        ///   Assigns the <see cref="Result"/>.
        ///   This method is intended for internal use by derived classes only.
        /// </summary>
        /// <param name="value">
        ///   The value to be assigned.
        /// </param>
        protected void SetResult(bool value) => Result = value;

        /// <summary>
        ///   Gets a value to indicate whether the outcome is successful.
        ///   This is mainly intended for "clear coding" as an alternative to implicitly casting
        ///   the output to a <see cref="bool"/> value when testing outcome.
        /// </summary>
        public bool IsSuccess => Result;

        /// <summary>
        ///   Implicitly casts the outcome to a <see cref="bool"/> value.
        ///   This is mainly intended for "clear coding" as an alternative to using the <see cref="IsSuccess"/>
        ///   property for testing outcome.
        /// </summary>
        /// <param name="outcome">
        ///   The outcome to be implicitly cast to its <see cref="bool"/> result.
        /// </param>
        /// <returns>
        ///   <c>true</c> if the outcome is successful; otherwise <c>false</c>.
        /// </returns>
        public static implicit operator bool(Outcome outcome) => outcome.Result;

        /// <inheritdoc />
        public override string ToString()
        {
            return IsSuccess ? "success" : "fail";
        }
        
        /// <summary>
        ///   Initializes the <see cref="Outcome"/> (for use by derived classes only).
        /// </summary>
        /// <param name="result">
        ///   Assigns the internal <see cref="Result"/> (success/failure).
        /// </param>
        /// <param name="exception">
        ///   (optional)<br/>
        ///   Assigns the <see cref="Exception"/>.
        /// </param>
        protected Outcome(bool result, Exception? exception = null)
        {
            Result = result;
            _exception = exception;
        }
    }
}