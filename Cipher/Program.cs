using System;
using Cipher.Algorithms;

namespace Cipher
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var context = new Context();
            context.SetEncryptor(new Assigment1());
            Console.WriteLine("Result: {0}\n", context.Encrypt("STEPANENKO"));

            context.SetEncryptor(new Assigment2());
            Console.WriteLine("Result: {0}\n", context.Encrypt("STEPANENKO"));

            context.SetEncryptor(new Assigment3());
            Console.WriteLine("Result: {0}\n", context.Encrypt("STEPANENKO"));

            context.SetEncryptor(new Assigment4());
            Console.WriteLine("Result: {0}\n", context.Encrypt("STEPANENKO"));

            context.SetEncryptor(new Assigment5());
            Console.WriteLine("Result: {0}\n", context.Encrypt("STEPANENKO"));

            context.SetEncryptor(new Assigment6());
            Console.WriteLine("Result: {0}\n", context.Encrypt("STEPANENKO EVGENIY GENADIYOVICH"));
        }
    }
}