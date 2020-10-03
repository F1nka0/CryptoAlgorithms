using System;

namespace CryptoLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Vigenere vig = new Vigenere();
            vig.SolveVigenere("program","dog");
        }
    }
}
