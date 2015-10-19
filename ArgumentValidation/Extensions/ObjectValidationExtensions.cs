using System;
using System.Diagnostics;

namespace ArgumentValidation.Extensions
{
    public static class ObjectValidationExtensions
    {
        [DebuggerHidden]
        public static IValidation<T> NotNull<T>(this IValidation<T> item) where T : class
        {
            if (item.Value == null)
                throw new ArgumentNullException(item.ArgName);
            return item;
        } 
    }
}
