using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int counter = 0;
            
            while (counter <10)    
            {
                Console.WriteLine(counter);   // shkon nga 0 deri ne 9 
                counter++;  // damit nicht endlos wird

            }
            */


            int counter = 0;
            string enteredText = "";
            // hier wird überprüft ob enteredText leerer String ist
            while (enteredText.Equals("") )    
            {
                Console.WriteLine("Bitte drücke Enter um eins hochzuzählen, oder gib was anderes ein, um die Zählung zu beenden");
                // Benutzereingabe
                enteredText = Console.ReadLine();
                Console.WriteLine("Aktuelle Anzahl der Schüler im bus {0}", counter);
                // zählen hich
                counter++;
            }
            Console.WriteLine("{0} Anzahl Schüler sind im Bus.Es kann losgehen.Drücke Enter um loszufahren",counter);

            Console.ReadKey();
        }
    }
}
                // Das ist ein Program um Schüler oder was anderes zu zählen