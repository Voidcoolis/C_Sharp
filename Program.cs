using System;

namespace MethodenMitRueckgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Division(20, 30));
            Console.WriteLine(Multiply(10, 30));
            int result = Add(15, 23); // oder die Ziele hier brauchen wir nicht 
            // anstatt schreiben wir : Console.WriteLine(Add(15, 23));
            Console.WriteLine(Add(Add(1, 2), Add(3, 4)));
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiply(int num1 , int num2)
        {
           // oder     int result = num1 * num2    und unten return result ;
            return num1 * num2;
        }
        public static double Division ( double num1 , double num2)
        {
            return num1 / num2;
        }
        

    }
}
