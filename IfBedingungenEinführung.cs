using System;

namespace IfBedingungenEinführung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie warm ist es gerade ? Trage den Wert als Zahl ein " );
            // Benutzereingabe
            string temperatureInput = Console.ReadLine();
            // int temperature = int.Parse(temperatureInput);
            int temperature;
            int number;
            if (int.TryParse(temperatureInput, out number))  // out = output (Ausgabe)
              // oder bool userEnter = int.TryParse(temperatureInput, out number); & dann if (userEnter)
            {
                temperature = number; 
            }
            else
            {
                temperature = 0;
            }

            if(temperature < 20)
            {
                Console.WriteLine("Ziehe deine Jacke an ");
            }

            else if (temperature == 20) 
            {
               
                Console.WriteLine("Es ist genau 20° C warm");
            }
            else if(temperature > 30)
            {
                Console.WriteLine("es ist eine Bullenhitze");
            }
            else  // ( else = ansonsten )
            {
                Console.WriteLine( "Zwischen 21 und 30 Grad - T-shirt und kurze Hose reicht ! ");
            }
            
            Console.ReadKey();
        }
    }
}
