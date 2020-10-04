using System;

namespace CryptoLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Vigenere vig = new Vigenere();
            Console.WriteLine(vig.Encode("program", "dog"));
        }
    }
}
