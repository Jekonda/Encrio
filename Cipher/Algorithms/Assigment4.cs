using System;
using System.Linq;
using Cipher.Extensions;

namespace Cipher.Algorithms
{
    public class Assigment4 : IEncryptor
    {
        /// <summary>
        /// Зашифрувати відкритий текст: KOZHUKHOVSKY над
        /// латинським алфавітом за допомогою шифру Віженера з
        /// довільно вибраним разовим ключем.
        /// </summary>
        public string EncryptData(string input)
        {
            var byInput = input.MapToList()
                .Select(c => DataSource.EncTable.First(z => z.Letter == c).Position)
                .ToList();
            var byKey = DataSource.TASK4KEY
                .SpawnString(input.Length)
                .Select(c => DataSource.EncTable.First(z => z.Letter == c.ToString()).Position).ToList();
            return string.Join(" ", byInput.Select((k, i) =>
            {
                var res = k + byKey[i];
                return res >= DataSource.EncTable.Count ? Math.Abs(res - DataSource.EncTable.Count) : res;
            }).Select(c => DataSource.EncTable.First(z => z.Position == c).Letter));
        }
    }
}
