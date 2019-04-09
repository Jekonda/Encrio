using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Cipher.Algorithms
{
    public class Assigment6 : IEncryptor
    {
        /// <summary>
        /// Зашифрувати шифром вертикальної перестановки з ключем довжини 7
        /// довільний відкритий текст довжиною не менше 50-и символів на будь-якій європейській мові.
        /// </summary>
        public string EncryptData(string input)
        {
            var words = DataSource.TASK6KEY
                .Select(x => new {Letter = x.ToString(), Values = new List<char>()})
                .ToList();
            Regex.Matches(input.Replace(" ", "").ToUpper(), @"\w{0,7}", RegexOptions.Multiline)
                .ToList().ForEach(item =>
                {
                    var list = item.ToString().ToList();
                    for (var i = 0; i < list.Count; i++)
                    {
                        words[i].Values.Add(list[i]);
                    }
                });
            return string.Join("  ", words.OrderBy(x => x.Letter).Select(x => string.Join("", x.Values)));
        }
    }
}