using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opvarmning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar;
            do
            {
                Console.WriteLine("Skriv dit navn");
                string navn = Console.ReadLine();

                Console.WriteLine("Skriv dit efternavn");
                string efternavn = Console.ReadLine();
                
                Console.WriteLine("Skriv din alder");
                string alder = Console.ReadLine();
                

                Console.WriteLine("Dit navn er " + navn + " " + efternavn + " og du er " + alder + " år gammel");


                Console.WriteLine("vil du prøve igen J/N");
                svar = Console.ReadLine();
            } while (svar == "J" || svar == "j") ;
        }
    }
}
