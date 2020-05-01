// Selbst- Herausforderung . Beje qe mund te japesh dhe numra me presje
 
// Herausforderung

/*Stelle Dir vor, Du seist ein Entwickler und bekommst einen Job, in dem Du ein Programm für einen Lehrer erstellen musst.
 * Er braucht ein in c# geschriebenes Programm, das die durchschnittliche Punktzahl seiner Schüler berechnet. Er möchte also 
 * jede Punktzahl einzeln eingeben können und dann nach Eingabe von -1 die endgültige Durchschnittspunktzahl erhalten.

Das Tool sollte also prüfen, ob der Eintrag eine Zahl ist und diese zur Summe addieren. Schließlich, wenn er fertig ist, 
sollte das Programm auf die Konsole schreiben, was die durchschnittliche Punktzahl ist.
Die eingegebenen Zahlen sollten nur zwischen 1 und 6 liegen. Stellen Sie sicher, dass das Programm nicht abstürzt, 
wenn der Lehrer einen falschen Wert eingibt.
Teste Dein Programm gründlich.
 */


using System;

namespace HerausforderungSchleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable die den Inhalt der Eingabe speichert
            string input = "0";
            // Zähler für die Anzahl der Einträge
            int count = 0;
            // Gesamtwert der Noten miteinander addiert
            int total = 0;
            // Aktuelle eingegeben Zahl als Integer
            int currentNumber = 0;

            while (input != "-1")   // wenn der Nutzer -1 angibt soll der Auftrag erledigt sein und die Schleife beendet
            {
                Console.WriteLine("Letzer Zahl war {0}", currentNumber);
                Console.WriteLine("Bitte trage die nächste Note ein !");
                Console.WriteLine("Anzahl der bisherigen Anträge ist {0}", count);
                Console.WriteLine("Bitte gib -1 ein, sobald du den Durchschnit ermitteln lassen möchtest");

                //Benutzereingabe auslesen
                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    Console.WriteLine("-----------------------------------------------");
                    // TO-DO : Berechne den Durchschnit und lasse es den Nutzer wissen
                    double average = (double)total / (double)count;   // perdorim double se variablet jan ne int
                    // quhet carsting -- (double)Total
                    Console.WriteLine("Der Durchshnit deiner Schuler ist {0}", average);
                }
                if (int.TryParse(input,out currentNumber) && currentNumber >0 && currentNumber<7)  //notat ne gjermani deri ne 6
                {
                    total += currentNumber; 
                }
                else
                {
                    if (!(input.Equals("-1")))
                    {
                        Console.WriteLine("Bitte trage einen Wert zwischen 1 und 6 ein !");

                    }
                    continue;
                }
                // Gesamtwert geteilt duch Anzahl der Werte   
                count++;
            }
            Console.ReadKey();

        }
    }
}
