using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cipher.Extensions
{
    public static class Utility
    {
        public static Dictionary<T, T> MapToDictionary<T>(this List<T> source, List<T> list)
        {
            if (source == null || list == null)
                throw new ArgumentNullException();
            if (source.Count != list.Count)
                throw new ArgumentException();
            return Enumerable.Range(0, source.Count).ToDictionary(i => source[i], i => list[i]);
        }

        public static List<string> MapToList(this string source)
        {
            return source.Select(c => c.ToString()).ToList();
        }

        public static string SpawnString(this string source, int count)
        {
            var temp = new StringBuilder();
            while (temp.Length < count)
                temp.Append(source);
            return temp.ToString().Substring(0, count);
        }
    }
}