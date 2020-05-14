using System;

namespace ErsteKlasse
{           // nese perdorim this.firstname... atehere duhet ta deklarojme edhe tek
            //  human jovi = new human ( ktu ne kllapa e deklarojm)
            // masi e deklarojm nuk na hyn me ne pun as Zeile 13-14 e as ta deklarojme String public tek Klassa human .dmth e fshijm
    class Program
    {
        static void Main(string[] args)
        {
            // Erstellen eines Objektes meiner Human Klasse
            human jovi = new human( "Jovi" , "Hima" ,"Hazel", 26);
            //jovi.firstname = "Jovi";  // spuno pa public para string tek Klasse
            //jovi.lastname = "Hima";
            jovi.IntroduceMyself();

            

            human Naldi = new human("Naldi", "Hima","grün", 24);
            Naldi.IntroduceMyself();


            human alivah = new human("Alivah" , "Hima" , "blau" , 1);
            alivah.IntroduceMyself();

            human Ambrose = new human("Ambrose", "Hima", "braun");
            Ambrose.IntroduceMyself();

            human frank = new human("Frank", "Martinez", 13);
            frank.IntroduceMyself();

            human Sissy = new human("Sissy", "DieMissy");
            Sissy.IntroduceMyself();

            human unbekannterMensch = new human();
            unbekannterMensch.IntroduceMyself();
            Console.ReadKey();


        }
    }
}
