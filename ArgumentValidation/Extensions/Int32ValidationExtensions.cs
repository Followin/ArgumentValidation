using System;

namespace ArgumentValidation.Extensions
{
    public static class Int32ValidationExtensions
    {
        public static IValidation<Int32> LessThan(
            this IValidation<Int32> item, Int32 limit)
        {
            if(item.Value >= limit)
                throw new ArgumentOutOfRangeException(item.ArgName, String.Format("Argument {0} must be" +
                                                                    "less than {1}",
                                                                    item.ArgName, limit));
            return item;
        }

        public static IValidation<Int32> GreaterThan(
            this IValidation<Int32> item, Int32 limit)
        {
            if (item.Value <= limit)
                throw new ArgumentOutOfRangeException(item.ArgName, String.Format("Argument {0} must be" +
                                                                    "greater than {1}",
                                                                    item.ArgName, limit));
            return item;
        }

        public static IValidation<Int32> NotZero(
            this IValidation<Int32> item)
        {
            if(item.Value == 0)
                throw new ArgumentOutOfRangeException(item.ArgName, String.Format("Argument {0} can't be" +
                                                                    "0", item.ArgName));
            return item;
        }
    }
}
