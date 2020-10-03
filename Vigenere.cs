using System;

namespace CryptoLib
{

    class Vigenere
    {
        static string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public void SolveVigenere(string SourceString, string Key)
        {

            GetDigitalEquivalentForKey("dog", SourceString.Length);
        }
        private string GetStringEquivalentOf
        private string GetDigitalEquivalentForKey(string RawKey, int SourceStringLength)
        {

            RawKey.ToUpper();
            string ComputedKey = "";

            while (RawKey.Length < SourceStringLength)
            {

                RawKey += RawKey;
            }
            RawKey = RawKey.Substring(0, SourceStringLength).ToUpper();

            
            return ComputedKey;
        }
        private string GetEncodedValue(string ComputedKey,) {

            string EncodedValue = "";
            
            //парфёнов--------------------------------------------------------------------------------------
            //парфёнов--------------------------------------------------------------------------------------
            //парфёнов--------------------------------------------------------------------------------------
            //парфёнов--------------------------------------------------------------------------------------
            //парфёнов--------------------------------------------------------------------------------------
            //парфёнов--------------------------------------------------------------------------------------
            //парфёнов--------------------------------------------------------------------------------------
        }
    }
}
