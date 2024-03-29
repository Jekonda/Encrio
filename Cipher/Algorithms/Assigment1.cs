using System.Linq;
using Cipher.Extensions;

namespace Cipher.Algorithms
{
    public sealed class Assigment1 : IEncryptor
    {
        /// <summary>
        /// Зашифрувати відкритий текст: KOZHUKHOVSKY над латинським алфавітом
        /// за допомогою шифру однобуквеної заміни.
        /// </summary>
        public string EncryptData(string input)
            => string.Join("", input.MapToList()
                .Select(c => DataSource.EncTable.First(t => t.Letter == c).EncPosition)
                .Select(c => DataSource.EncTable.First(t => t.Position == c).Letter));
    }
}