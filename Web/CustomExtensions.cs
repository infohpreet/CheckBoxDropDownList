
using System;
using System.Collections.Generic;
using System.Linq;

namespace Web
{
    public static class CustomExtensions
    {
        public static List<string> FromCsvToStringList(this string value)
        {
            return value.FromCsvToStringList(',');
        }

        public static List<string> FromCsvToStringList(this string value, char separator)
        {
            var list = new List<string>();

            if (!string.IsNullOrWhiteSpace(value))
            {
                foreach (var item in value.Split(separator))
                {
                    list.Add(item);
                }
            }

            return list;
        }
    }
}