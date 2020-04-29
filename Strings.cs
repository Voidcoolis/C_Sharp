using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarieren und Initiliarisieren der Variablen mein Name 
            string meinName = "Jovi";
            string myname = "BoNjOv HiMa";
            string nachricht = "Mein Name ist " + myname;
            int LengthOfString = nachricht.Length;

            string allesKlein = nachricht.ToLower();
            Console.WriteLine(allesKlein);
           string allesGross = nachricht.ToUpper();  // alles groß geschrieben
            Console.WriteLine(allesGross);
            Console.WriteLine(nachricht + " - ist {0} Zeichen lang", LengthOfString);
            /*Console.WriteLine( nachricht + " ist {0} Zeichen {1} lang", LengthOfString, meinName);  
             * {0} = LengthOfString  {1} = meinName
            *  oder     Console.WriteLine( nachricht + " ist so viele Zeichen lang", LengthOfString);
             */



            Console.ReadKey();
        }
    }
}
