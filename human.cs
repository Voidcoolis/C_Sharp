using System;
using System.Collections.Generic;
using System.Text;

namespace ErsteKlasse
{
    // Mensch Klasse
    // Eine Klasse ist eine Blaupause für ein Datentyp


    class human
    {
        // MemberVariable Vorname       firstname ist ein Mitgleidvariable von human
        string firstname;
        // Membervariable Nachname
        string lastname;
        // MemberVariable eyeColora
        string eyeColor;
        //  MemberVariable age
        int age;


        // Default Konstruktor
        public human()
        {
            Console.WriteLine("Default Konstruktor aufgerufen");
            age = 0;
            eyeColor = "braun";    //festgelegt , 
            firstname = "Unbekannt";
            lastname = "Unbekannt";
        }


        //Parameterisierte Konstruktor
        public human(string firstname, string lastname, string eyeColor, int age)
        {
            //firstname = myfirstname;    -> nese ke strings esht myfi..& mylast..
            //lastname = mylastname;
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.eyeColor = eyeColor;

            Console.WriteLine("Objekt von human erstellt");  // wird 2 mal aufgerufen 
        }

        public human(string firstname, string lastname, string eyeColor)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.eyeColor = eyeColor;
        }
        public human(string firstname, string lastname, int age)
        {

            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        public human(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        } 


            // Member Methode
            public void IntroduceMyself()    // das ist eine Methode in einer Klasse
        {
            if (age != 0 && lastname != null && eyeColor != null && firstname != null)
            {
                Console.WriteLine("Hi, ich bin {0} {1} ,meine Augenfarbe ist {2} " +
                    " und ich bin {3} Jahr alt", firstname, lastname, eyeColor, age);
            }
            else if(lastname != null && eyeColor != null && firstname != null) 
            {
                Console.WriteLine("Hi, ich bin {0} {1} ,meine Augenfarbe ist {2} ", firstname, lastname, eyeColor);
            }
            else if (age != 0 && lastname != null && firstname != null)
            {
                Console.WriteLine("Hi, ich bin {0} {1} und ich bin {2} Jahr alt  ", firstname, lastname, age);
            }
            else if (lastname != null && firstname != null) {
                Console.WriteLine("Hi, ich bin {0} {1}  " , firstname, lastname);
            }


            /*if (age == 1)
            {
                Console.WriteLine("Hi, ich bin {0} {1} ,meine Augenfarbe ist {2} +" +
                    " und ich bin {3} Jahr alt", firstname, lastname, eyeColor, age);
            }
            
            else
            {
                Console.WriteLine("Hi, ich bin {0} {1} ,meine Augenfarbe ist {2} " +
                " und ich bin {3} Jahre alt", firstname, lastname, eyeColor, age);
            }
            */
        }



    }
}
