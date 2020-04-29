using System;

namespace VerschachtelteIfBedingungen
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = ""; //leer
            Console.WriteLine("Bitte trage deinen Benutzernamen ein");
            userName = Console.ReadLine();


            /*if (isRegistered)
            *{
            *   Console.WriteLine("Hallo registrierter Nutzer");
            *  if (userName != "")
            * {
            *     Console.WriteLine("Hi {0}", userName);
            *     if(userName == "Admin")  //oder userName.Equals("Admin")
            *     {
            *         Console.WriteLine("Hallo Admin !");
            *         
            *     }
            * }
            *}
            */


                // eine andere Alternative zu Zeile 16-28  vereinfacht

                if (isRegistered && userName != ""  && userName == "Admin")
            {
                Console.WriteLine("Hallo registrierter Nutzer");
                Console.WriteLine("Hi {0}", userName);
                Console.WriteLine("Hallo Admin !");

            }
           /* else
            * {
            *   Console.WriteLine("Hallo unregistrierter Mensch");   // hier sollte bool isRegistered = false ;
            *   if (!isAdmin)
            *   {
            *       Console.WriteLine("Hallo nicht Admin");
            *   }
            }
            */
            
            if (isAdmin || isRegistered)      //   || = ODER
            {
                Console.WriteLine("Du bist eingeloggt " );
            }

            Console.ReadKey();


        }
    }
}
