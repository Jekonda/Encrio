using System;
using System.ComponentModel;
using Cipher.Algorithms;

namespace Cipher
{
    public class Context
    {
        private IEncryptor _encryptor;

        public void SetEncryptor(IEncryptor encryptor)
        {
            if(encryptor == null)
                throw new ArgumentNullException();
            _encryptor = encryptor;
        }
        
        public string Encrypt(string data)
        {
            if(_encryptor == null)
                throw new ArgumentNullException();
            if(string.IsNullOrEmpty(data))
                throw new InvalidEnumArgumentException();
            Console.WriteLine("Input data: " + data);
            return _encryptor.EncryptData(data);
        }
    }
}