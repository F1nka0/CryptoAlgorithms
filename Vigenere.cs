using System;
using System.Linq;
namespace CryptoLib
{

    class Vigenere
    {
        static string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string Encode(string SourceString, string Key)
        {
            string DataNeedetToGetEncodedValue = GetDigitalEquivalentForKey("dog", SourceString.Length);
            return(GetStringRepresentationOfNumericValue(GetEncodedValue(DataNeedetToGetEncodedValue, GetNumericEquivalentOfString(SourceString))));
            
        }
        private string GetNumericEquivalentOfString(string InputString)
        {

            string StringToReturn = "";
            InputString= InputString.ToUpper();
            foreach (char letter in InputString)
            {

                StringToReturn += Alphabet.IndexOf(letter) < 10 ? "0" + Alphabet.IndexOf(letter) : Alphabet.IndexOf(letter).ToString();
            }
            return StringToReturn;
        }
        private string GetDigitalEquivalentForKey(string RawKey, int SourceStringLength)
        {
            RawKey.ToUpper();
            while (RawKey.Length < SourceStringLength)
            {
                RawKey += RawKey;
            }
            RawKey = RawKey.Substring(0, SourceStringLength).ToUpper();
            return GetNumericEquivalentOfString(RawKey);
        }
        private string GetEncodedValue(string ComputedKey, string EncodedString)
        {

            string EncodedValue = "";
            //-26
            for (int a = 0; a < ComputedKey.Length; a += 2)
            {

                if (((int.Parse(ComputedKey.Substring(a, 2)) + int.Parse(EncodedString.Substring(a, 2))) )< 10)
                {

                    EncodedValue += "0" + (int.Parse(ComputedKey.Substring(a, 2)) + int.Parse(EncodedString.Substring(a, 2)));
                }
                else if ((int.Parse(ComputedKey.Substring(a, 2)) + int.Parse(EncodedString.Substring(a, 2)) >= 26) && (int.Parse(ComputedKey.Substring(a, 2)) - int.Parse(EncodedString.Substring(a, 2)) < 10))
                {

                    EncodedValue += "0" + (int.Parse(ComputedKey.Substring(a, 2)) + int.Parse(EncodedString.Substring(a, 2)) - 26);
                }
                else if ((int.Parse(ComputedKey.Substring(a, 2)) + int.Parse(EncodedString.Substring(a, 2)) >= 26) && (int.Parse(ComputedKey.Substring(a, 2)) - int.Parse(EncodedString.Substring(a, 2)) >= 10))
                {

                    EncodedValue += (int.Parse(ComputedKey.Substring(a, 2)) + int.Parse(EncodedString.Substring(a, 2)) - 26);
                }
                else
                {
                    EncodedValue += (int.Parse(ComputedKey.Substring(a, 2)) + int.Parse(EncodedString.Substring(a, 2))).ToString();
                }

            }
            return EncodedValue;
        }
        private string GetStringRepresentationOfNumericValue(string NumericValue) {
            string FinalEncodedValue="";
            for (int a=0;a<NumericValue.Length;a+=2) {

                FinalEncodedValue += Alphabet[int.Parse(NumericValue.Substring(a, 2))];
            }
            return FinalEncodedValue;
        }
    }
}
