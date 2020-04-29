using System;

namespace DatenTypen
{
    class Program
    {
        static void Main(string[] args)
        {
            int wert1 = 25;  // deklarieren und initialisieren der Variable wert1
            //Deklarieren
            int wert2;
            // initialisieren
            wert2 = 15;
            int summe = wert1 + wert2;
            // deklariere mehrere Variablen in einer Zeile
            //int wert3, wert4, wert5;

            Console.WriteLine("Summe ist  " + summe);

            Console.ForegroundColor = ConsoleColor.Red; // die Schriftfarbe nur von double
            // Verwendung von Gleitkommazahlen mit Double
            double d1 = 3.5;
            double d2 = 1.337;
            double ergebnis = d1 / d2;   //     / ist durch 

            Console.WriteLine("Ergebnis ist " + ergebnis);

            // Verwendung von Gleitkommazahlen mit Float
            float f1 = 1.337f;    // float braucht weniger Speicher

            
            Console.ReadKey();
        }
    }
}
