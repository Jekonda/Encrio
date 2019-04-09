using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Cipher.Algorithms
{
    public class Assigment5 : IEncryptor
    {
        /// <summary>
        /// Зашифрувати відкритий текст: KOZHUKHOVSKY над
        /// латинським алфавітом за допомогою шифру Плейфера.
        /// Для створення ключа скористатись ключем, отриманим в завданні 1
        /// </summary>
        public string EncryptData(string input)
            => string.Join(" ", GetBigrams(input).Select(FindEncrypted));

        private IEnumerable<string> GetBigrams(string word)
            => Regex.Matches(word.Replace(" ", string.Empty).ToUpper(), @"\w{1,2}").Select(x => x.ToString());

        private string FindEncrypted(string code)
        {
            var positions = code.Select(GetPosition).ToList();
            var temp = positions[0].Row;
            positions[0].Row = positions[1].Row;
            positions[1].Row = temp;
            var result = new StringBuilder();
            for (var i = positions.Count - 1; i >= 0; i--)
                result.Append(DataSource.Matrix[positions[i].Row, positions[i].Column]);
            return result.ToString();
        }


        private Element GetPosition(char elem)
        {
            for (var i = 0; i < DataSource.Matrix.GetLength(0); i++)
            {
                for (var j = 0; j < DataSource.Matrix.GetLength(1); j++)
                {
                    if (elem.ToString() == DataSource.Matrix[i, j])
                    {
                        return new Element {Row = i, Column = j};
                    }
                }
            }
            return null;
        }

        class Element
        {
            public int Row { get; set; }
            public int Column { get; set; }
        }
    }
}