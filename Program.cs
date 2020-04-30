using System;

namespace ErweiterteIfStatements       //      ? = ERFÜLLT      : = dann
{
    class Program
    {
        // Bedingung ?  erster_Ausdruck : zwiter_Ausdruck ;
        // Bedingung mus entweder wahr oder falsch sein (true/false)
        //Der konditionalle Operator ist rechtassociativ --rechtassoziatziv bedeutet wenn a erfüllt ist dann b . wenn b auch dann c usw.
        // Der Ausdruck  a ? b :  c ? d : e
        // wird so evaluliert a ? b : ( c ? d :e )  und nicht als (a ? b : c ) ? d : e.
        // Die konditionelle Operator kann nicht überschrieben werden
        static void Main(string[] args)
        {
            // Temperatur des Wassers
            int temperature = -5;
            
            // Aggregatszustand   dmth gjendja 
            string stateOfMatter;

            if (temperature < 0)
            {
                stateOfMatter = "fest(Eis)";
            }
            else
            {
                stateOfMatter = "flüssig";
            }
            Console.WriteLine("Aggregatzustand ist {0}", stateOfMatter);


            temperature += 30;
            // in Kurzversion  also Erweiterte if statement
            stateOfMatter = temperature < 0 ? "fest" : "flüssig" ;    // Zeile 15-28 hier zusammengefasst  *******
            Console.WriteLine("Aggregatzustand ist {0}", stateOfMatter);
            // Ergebnis : ist flüssig ..   da wir temperatur +=30 haben oder -5 +30 = 25°C --- flüssig
            
            temperature += 100;
            stateOfMatter = temperature > 100 ? "gasförmig" : (temperature <0 )? "fest" : "Flüssig";
            Console.WriteLine("Aggregatzustand ist {0}", stateOfMatter);  // Ergebnis = gas


            Console.ReadKey();  // hier bei Main um die Konsole offen zu halten
        }
    }
}
