using System;
using System.Data.Common;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {       // wichtig . Wiederholen
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Bitte trage den Namen eines Freundes aus ");
                string nameOfAFriend = Console.ReadLine();
                int currentLenght = nameOfAFriend.Length;
                lengthOfText += currentLenght;
                wholeText += nameOfAFriend;
            } while (lengthOfText < 20);   // nese numri i shkronjave kur shkruan emrin esht me i madh se 20 atehere del mesazhi i CW 
            Console.WriteLine("Danke das reicht! Deine Freund sind {0}", wholeText);

            //  1. Zählervariable
            int counter = 0;
            do
            {
                Console.WriteLine(counter);
                // 3. Dafür sorgen , dass die Bedingung irgendwann nicht mehr erfüllt ist
                // Inkrementieren damit wir keine endlose Schleife kriege
                counter++;
                // 2.Bedingung einfügen
            } while (counter < 5);     // while = solange wie 
            //In Klammern ist die Bedingung --> sorgen dass die Bedingung nicht erfüllt ist, ansonsten endlose Schleife
            
            
            
            
            
            Console.ReadKey();
        }
    }
}
