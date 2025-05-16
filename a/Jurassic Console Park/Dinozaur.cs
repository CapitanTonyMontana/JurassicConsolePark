using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Jurassic_Console_Park
{

    public abstract class Dinozaur
    {
        public char Rodzaj { get; set; }
        public string Gatunek { get; set; }
        public int Liczba { get; set; }

    

        public List<string> Imiona { get; set; } = new List<string>();

        public abstract void WypiszInformacje()
        {
            Console.WriteLine("\nPodsumowanie:");
            Console.WriteLine($"Rodzaj: {(Rodzaj == 'R' ? "Roślinożerny" : "Mięsożerny")}");
            Console.WriteLine($"Gatunek: {Gatunek}");
            Console.WriteLine($"Liczba: {Liczba}");
            Console.WriteLine("Imiona:");

            foreach (var imie in Imiona)
                Console.WriteLine("- " + imie);
        }

        public abstract void GetSound()
        {
            Console.WriteLine("\n --- Odgłosy dinozaurów ---");
            foreach (var imie in Imiona)

            {
                Console.WriteLine($"{imie} Raaawr!");
            }
        }
        
            
        
    }
}




    




