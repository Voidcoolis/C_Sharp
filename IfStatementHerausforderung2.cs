using System;

namespace IfStatementHerausforderung2
{
    class Program
    {
        // Höchste Punkzahl
        static int highscore = 300;
        // Rekordhälter
        static string highscorePlayer = "Jovi";
        static void Main(string[] args)
        {
            CheckHighscore(255, "Frank"); // Der Alte Highscore wurde nicht gebrochen und ist immer noch von Jovi gehalten
            CheckHighscore(340, "Naldi"); // Neuer Highscore ist 340. neuer Rekordhälter ist Naldi
            CheckHighscore(270, "Hima");   // ergebnis Rekord wurde nicht gebrochen . wird immernoch von Naldi erhalten
            Console.ReadKey();
        }
        public static void CheckHighscore(int score , string playerName)
        {
            
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("Nuer Highscore ist {0}",score);  // oder highscore egal 
                Console.WriteLine("Neuer Rekordhälter ist {0}",playerName);
            }
            else
            {
            Console.WriteLine("Der alte Highscore von {0} könnte nicht gebrochen werden & wird immer noch von {1} gehalten +" +
                " ",highscore,highscorePlayer);

            }
           
        }
    }
}
