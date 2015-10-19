using System;

namespace ArgumentValidation
{
    public interface IValidation<out T>
    {
        T Value { get; }
        String ArgName { get; }
    }
    public class Validation<T> : IValidation<T>
    {
        public T Value { get; set; }
        public String ArgName { get; set; }

        public Validation(T value, string argName)
        {
            Value = value;
            ArgName = argName;
        }
    }

    public static class ValidationExtension
    {
        public static IValidation<T> Argument<T>(this T item, string argName)
        {
            return new Validation<T>(item, argName);
        }
    }
}
