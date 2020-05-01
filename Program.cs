using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {      
            // wenn du jeden dritten zählen möchtest schreibst du einfach , schreibe  'zaehler -=3  oder +=3 ' 
            //
            for (int zaehler = 0; zaehler < 10; zaehler++) // zaehler = 0 Anfangswert  
                // zaehler < 10  ist die Bedingung
            {
                Console.WriteLine("Zählerwert ist {0}", zaehler); // bis 9 weil zaehler < 10 ist
            }


            /*     Wir können auch von !0 runterzählen 
             *      
            for (int zaehler = 10; zaehler > 0; zaehler--) 
            {
                Console.WriteLine("Zählerwert ist {0}", zaehler); 
            }
               */


            for (int Zahl = 1; Zahl < 20; Zahl+=2)    // Ungerade Zahlen  -- Ergebnis 1,3,5,7,9 usw
            {
                Console.WriteLine("Die ungeraden Zahlen sind {0} ", Zahl);
            }    
            
            Console.ReadKey();  // um die Konsole offen zu lassen
        }
    }
}
