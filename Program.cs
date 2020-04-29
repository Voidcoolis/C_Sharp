using System;

namespace BenutzerEingabe
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Bitte trage dein Namen ein ! ");
            // BenutzerEingabe wird in einer Variablen vom Typen string gespeichert
            //string input = Console.ReadLine();     // input steht für Eingabe
            //Console.WriteLine("Benutzereingabe war : {0} ", input);

           
            Console.WriteLine(Calculate());
            Console.ReadKey();
        }
        public static int Calculate()
        {
            Console.WriteLine("Bitte trage die erste Zahl ein.");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Bitte trage die zweite Zahl ein.");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;
            return result;
        }
    }
}
