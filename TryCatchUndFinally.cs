using System;

namespace TryCatchUndFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte trage eine Zahl ein");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
                int result = userInputAsInt / 0;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Durch null teilen ist nicht erlaubt");
            }
            catch (Exception)
            {
                Console.WriteLine("Grundlegender Fehler");
            }
            




          try
            {
                //  userInput = null;   -- das Argument wird immer leer
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format war inkorrekt. Du hättest eine Nummer eintrager sollen");
                
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, der Wert war leer (null)");
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException, der eingegebene Wert , war zu lang");
            }

            finally
            {
                // Verbindung oder Datei schließen
                Console.WriteLine("Ich werde sowieso ausgeführt");
            }
            Console.ReadKey();
            
        }
    }
}
