using System;

namespace SwitchUndCase  // Switch steht für Schalter und Case für Fall
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 19;

            switch (age)  
            {
                case 15:      // keto case 15,16,17 nese bo i bo Run programit del gjith zu jung zum feiern
                case 16:        // tek If bedingung e bojm me age >=
                case 17:
                    Console.WriteLine("Zu jung zumm Feiern");     
                    break;

                case 25:    // ne fund duhet te perdoresh gjithmone break ose del fehler
                    Console.WriteLine("Alles klar , abgets");
                    break;  
                    // default ist wie Else bei einer If Bedingung
                    

                default:
                    Console.WriteLine("Wie alt bist du eigentlich");
                    break;
            }
               
               
            // Alternative zu SWITCH Methode
            if (age == 15)
            {
                Console.WriteLine("Zu jung zumm Feiern");
            }
            else if (age > 18)
            {
                Console.WriteLine("Alles klar , abgets");
            }
            else
            {
                Console.WriteLine("Wie alt bist du eigentlich");
            }


            string userName = "Hima";
            switch (userName)
            {
                case "Hima":
                    Console.WriteLine("Sie stehen auf der Liste. Kommen Sie rein Herr Hima");
                    break;
                case "root":     // kur i bo RUN kjo nuk del sepse string userName esht Hima
                    Console.WriteLine("Sie stehen auf der Liste"); 
                    break;
                default:
                    Console.WriteLine("Sie stehen nicht auf der Liste. Tut mir Leid");
                    break;

            }



            Console.ReadKey();  // oder Readline
        }
    }
}
