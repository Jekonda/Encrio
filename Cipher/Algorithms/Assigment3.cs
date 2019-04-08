using System;
using System.Collections.Generic;
using System.Linq;
using Cipher.Extensions;

namespace Cipher.Algorithms
{
    
    /// <summary>
    /// Виходячи з розподілу ймовірностей знаків англійської мови,
    /// скласти шифрант і дешифрант шифру пропорційної
    /// багатозначної заміни (на 100 цифрових шифропозначень).
    /// Зашифрувати довільний відкритий текст за допомогою побудованого ключа.
    /// </summary>
    public class Assigment3 : IEncryptor
    {
        public string EncryptData(string input)
        {
            var dataSet = Generate();
            Beautify(dataSet);
            var rng = new Random();
            return string.Join(" ", input.MapToList().Select(l =>
            {
                var index = rng.Next(0, dataSet[l].Count - 1);
                return dataSet[l][index];
            }));
        }

        private void Beautify(Dictionary<string, List<int>> data)
        {
            Console.WriteLine("<----------Дешифрант---------->");
            foreach (var keyValuePair in data)
            {
                Console.WriteLine("Key: {0}, Values: [{1}]", keyValuePair.Key, string.Join(",", keyValuePair.Value));
            }
        }

        private Dictionary<string, List<int>> Generate()
        {
            var letters = DataSource.EncTable.Select(c => c.Letter).ToList();
            var numbers = Enumerable.Range(0, 100).ToList();
            var dict = new Dictionary<string, List<int>>();
            var rng = new Random();
            while (true)
            {
                foreach (var letter in letters)
                {
                    if (!dict.ContainsKey(letter))
                        dict.Add(letter, new List<int>());
                    for (var i = 0; i < rng.Next(1, 4); i++)
                    {
                        if (numbers.Count - 1 < 0) return dict;
                        var index = rng.Next(0, numbers.Count - 1);
                        dict[letter].Add(numbers[index]);
                        numbers.RemoveAt(index);
                    }
                }
            }
        }
    }
}