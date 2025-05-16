using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurassic_Console_Park
{
    public class CarnivorousDino : Dinozaur
    {
        public override void WypiszInformacje()
        {
            Console.WriteLine($"\nMięsożerne dinozaury: {Gatunek} (ilość: {Liczba})");
            Console.WriteLine("Imiona:");
            foreach (var imie in Imiona)
            {
                Console.WriteLine($"- {imie}");
            }
        }

        public override void GetSound()
        {
            Console.WriteLine("Raaaawr! ");
        }
    }
}
    

