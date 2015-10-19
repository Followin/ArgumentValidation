using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ArgumentValidation.Extensions
{
    public static class EnumerableValidationExtensions
    {
        public static IValidation<IEnumerable<T>> NotEmpty<T>(this IValidation<IEnumerable<T>> item)
        {
            if(item.Value != null && !item.Value.Any())
                throw new ArgumentException(String.Format("Argument {0} must be not empty", item.ArgName), item.ArgName);
            return item;
        }

        public static IValidation<IEnumerable<T>> AllMatch<T>
            (this IValidation<IEnumerable<T>> item, Expression<Func<T, Boolean>> predicate,
            String errorMessage = null)
        {
            if(item.Value != null && !item.Value.All(predicate.Compile()))
                throw new ArgumentException(errorMessage ?? String.Format("All the items of {0} must match following pattern: {1}",
                    item.ArgName, predicate), item.ArgName);
            return item;
        }
    }
}
