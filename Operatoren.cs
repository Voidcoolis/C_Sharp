using System;

namespace Operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unäre Operatoren
            num3 = -num1;
            Console.WriteLine("num3 ist {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is es sonnig ? {0} ", !isSunny);

            // inkrementoperatoren
            int num = 0;
            num++;

            Console.WriteLine("num ist {0}", num);
            Console.WriteLine("num ist {0}", num++);  

            //pre increment
            Console.WriteLine("num ist {0}", ++num);
            // Ergebnis wird 3  da Zeile 24 schon num++ gibt


            // decrement Operator
            num--;
            Console.WriteLine("num ist {0}", num);  // Ergebnis wird 2 , da wir von oben reduzieren
            Console.WriteLine("num ist {0}", num--);

            // pre decrement
            Console.WriteLine("num ist {0}", --num); // ergebnis 0

            int result;
            // Addition
            result = num1 + num2;

            Console.WriteLine("Ergebnis von num1({0}) + num2({1}) ist {2}", num1, num2, result);
            // = 8 wird aber auch num1 und num2 gezeigt
            // oder     Console.WriteLine("Ergebnis von num1 + num2 ist {0}", result);  // =8

            // Subtraktion
            result = num1 - num2;
            Console.WriteLine("Ergebnis von num1({0}) - num2({1}) ist {2}", num1, num2, result);

            /* result = num2 - num1;
             *Console.WriteLine("Ergebnis von num2({0}) - num1({1}) ist {2}", num1, num2, result);
             *               Ergebnis = -2
             */



            // Multiplikation

            result = num1 * num2;
            Console.WriteLine("Ergebnis von num1({0}) * num2({1}) ist {2}" , num1, num2, result );

            // Division
            result = num1 / num2 ;
            Console.WriteLine("Ergebnis von num1({0}) / num2({1}) ist {2}", num1, num2, result);
            // Ergbenis von 5 durch 3 = 1        wieso ?   bei Modulo gucken

            // Modulo  (%)
            result = num1 % num2;
            Console.WriteLine("Ergebnis von num1({0}) % num2({1}) ist {2}", num1, num2, result);

            //Relationale und Typoperatoren
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("Ergebnis von num1({0}) < num2({1}) ist {2}", num1, num2, isLower); // Ergebnis false

            // Gleicheheit 
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("Ergebnis von num1({0}) ist gleich mit num2({1}) ist {2}", num1, num2, isEqual); // false

            // Ungleichheit
            isEqual = num1 != num2;
            Console.WriteLine("Ergebnis von num1({0}) ist ungleich num2({1}) ist {2}", num1, num2, isEqual); //true

            // Konditionele Operatoren
            bool isLowerAndSunny;
            // Kondition1 und Kondition2
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("Ergebnis von num1({0}) && num2({1}) ist {2}", num1, num2, isLowerAndSunny);  // false . siehe oben

            //Kondition1 ODER Kondition2
            isLowerAndSunny = isLower || isSunny;    //     || = oder
            Console.WriteLine("Ergebnis von num1({0}) || num2({1}) ist {2}", num1, num2, isLowerAndSunny);
            // true   da isSunny ist true ( oben deklariert ) 


            Console.ReadKey();
        }
    }
}
