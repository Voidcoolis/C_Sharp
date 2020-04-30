/*Erstelle eine Anwendung mit einem Score, Highscore und einem HighscorePlayer.

Erstelle eine Methode, die zwei Parameter hat, einen für die Punktzahl und einen für den Spielernamen.
Wann immer diese Methode aufgerufen wird, sollte überprüft werden, ob die Punktzahl des Spielers höher ist als die des Highscores, wenn ja, "Neuer highscore ist + " score" und in einer anderen Zeile "Neuer Rekordhalter ist " + playerName - auf die Konsole geschrieben werden, falls nicht "Der alte highscore von " + highscore + " konnte nicht gebrochen werden und wird immer noch gehalten von " + highscorePlayer.
Überlege auch, welche Variablen außerhalb der Methoden und welche innerhalb der Methoden benötigt werden.
*/


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
