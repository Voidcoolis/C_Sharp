using System;

namespace ImpliziteUndExpliziteKonvertierung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implizite Konvertierung
            int num = 1232346;
            long bigNum = num;
            //long veryBigNum = 12346859403932;
            //int num2 = veryBigNum;
            
            float myFloat = 13.37f;
            double myDouble = myFloat;

            // Explizite Konvertierung
            int myInt;
            double myNewDouble = 13.37;
            myInt = (int)myNewDouble;

            string myString = myNewDouble.ToString();  // "13.37"
            string myString2 = myString + "12";
            bool SunIsShining = true;

            string myBoolString = SunIsShining.ToString();

            Console.WriteLine(myBoolString);
            Console.ReadKey();
        }
    }
}
