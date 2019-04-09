using System.Linq;
using Cipher.Extensions;

namespace Cipher.Algorithms
{
    public class Assigment2 : IEncryptor
    {
        /// <summary>
        /// Зашифрувати відкритий текст KOZHUKHOVSKY над латинським алфавітом за допомогою гаслового шифру.
        /// </summary>
        public string EncryptData(string input)
        {
            var gaslo = DataSource.GASLO.MapToList();
            var normalized = DataSource.EncTable.Select(c => c.Letter).ToList();
            var list = normalized.Except(gaslo).ToList();
            list.InsertRange(0, gaslo);
            var dictionary = normalized.MapToDictionary(list);
            return string.Join("", input.MapToList().Select(c => dictionary[c]));
        }
    }
}