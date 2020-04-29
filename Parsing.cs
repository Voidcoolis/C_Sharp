using System;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";

            int num1 = int.Parse(myString);
            int num2 = int.Parse(mySecondString);

            int resultInt = num1 + num2;

            string result = myString + mySecondString;  // ergebnis : 1513 
            Console.WriteLine(resultInt);
            Console.ReadKey();
        }
    }
}
