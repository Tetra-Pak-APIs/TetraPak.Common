using System;

namespace TetraPak
{
    public class Outcome<T> : Outcome
    {
        public T Value { get; protected set; }

        public static Outcome<T> Success(T value) => new Outcome<T>(true, value);

        public static Outcome<T> Fail() => new Outcome<T>(false, default);

        public static Outcome<T> Fail(T value) => new Outcome<T>(false, value);

        public static Outcome<T> Fail(Exception exception) => new Outcome<T>(false, default, exception);

        public static Outcome<T> Fail(T value, Exception exception) => new Outcome<T>(false, value, exception);

        public override string ToString()
        {
            return IsSuccess ? $"success : {value()}" : $"fail{errorMessage()}";

            string value() => ReferenceEquals(default, Value) ? "(null)" : Value.ToString();

            string errorMessage()
            {
                if (Exception is null)
                    return "";

                return $" ({Exception.Message})";
            }
        }

        public static implicit operator T(Outcome<T> br) => br.Value;

        public Outcome<T> WithValue(T value)
        {
            Value = value;
            return this;
        }

        protected Outcome(bool result, T value, Exception exception = null) : base(result, exception)
        {
            Value = value;
        }
    }

    public abstract class Outcome
    {
        bool Result { get; set; }
        
        public Exception Exception { get; }


        protected void SetResult(bool value) => Result = value;

        public bool IsSuccess => Result;

        public static implicit operator bool(Outcome br) => br.Result;

        public override string ToString()
        {
            return IsSuccess ? "success" : "fail";
        }
        
        protected Outcome(bool result, Exception exception = null)
        {
            Result = result;
            Exception = exception;
        }
    }
}