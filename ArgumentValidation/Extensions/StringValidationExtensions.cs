using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ArgumentValidation;

namespace ArgumentValidation.Extensions
{
    public static class StringIValidationExtensions
    {
        public static IValidation<String> ShorterThan
            (this IValidation<String> item, int limit)
        {
            if(item.Value != null && item.Value.Length >= limit)
                throw new ArgumentException(String.Format("Argument {0} must be" +
                                                          " shorter than {1} chars",
                                                          item.ArgName, limit), item.ArgName);
            return item;
        } 

        public static IValidation<String> LongerThan
            (this IValidation<String> item, int limit)
        {
            if (item.Value != null && item.Value.Length <= limit)
                throw new ArgumentException(String.Format("Argument {0} must be" +
                                                          " longer than {1} chars",
                                                          item.ArgName, limit), item.ArgName);
            return item;
        }

        public static IValidation<String> StartsWith
            (this IValidation<String> item, String pattern)
        {
            if (item.Value != null && !item.Value.StartsWith(pattern))
                throw new ArgumentException(String.Format("Argument {0} must start" +
                                                          "with {1}",
                                                          item.ArgName, pattern), item.ArgName);
            return item;
        }

        public static IValidation<String> MatchesRegex
            (this IValidation<String> item, Regex pattern)
        {
            if (item.Value != null && !pattern.IsMatch(item.Value))
                throw new ArgumentException(String.Format("Argument {0} must match " +
                                                          "following pattern: {1}",
                                                          item.ArgName, pattern), item.ArgName);
            return item;
        }

        public static IValidation<String> NotWhiteSpace
            (this IValidation<String> item)
        {
            if(item.Value != null && String.IsNullOrWhiteSpace(item.Value))
                throw new ArgumentException(String.Format("Argument {0} can not be " +
                                                          "empty/consist solely of spaces",
                                                          item.ArgName), item.ArgName);
            return item;
        }
    }
}
