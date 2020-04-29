using System;

namespace VoidMethode
{
    class Program
    {
        // Startpunkt des Programms

        static void Main(string[] args)
        {
            WriteSomething();  //aufrufen um die Methode unten (Zeile 15-19) auszuführen
            WriteSomething();
            WriteSomething();
            string myArgument = "Hallo ich bin super Text";
            WriteSomethingSpecific(myArgument);

            Console.ReadKey();
        }
        // wie eine Methode aufgebaut ist : 
        // Zugriffmodifizierer (static) Rückgabetyp Methodenname(parameter1, parameter2) 
        public static void WriteSomething()
        {
            Console.WriteLine("Ich bin eine Methode");

        }

        public static void WriteSomethingSpecific(string myText)  // "string myText" ist ein Parameter
        {
        
           Console.WriteLine(myText);
        }
    }

}

