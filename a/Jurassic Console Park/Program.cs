using Jurassic_Console_Park;
using System;
using System.Text.RegularExpressions;


enum Herbivorous
{
    Triceratops,
    Brachiosaurus,
    Stegosaurus
}

enum Carnivorous
{
    Tyrannosaurus,
    Velociraptor,
    Allosaurus
}



class Program
{
    static void Main()
    {
        Console.WriteLine("WITAJ W PARKU JURAJSKIM!\n");

       
        char wyborRodzaju = ' ';

        
        while (true)
        {
            Console.WriteLine("Wybierz rodzaj dinozaurów wpisując 'M' (Mięsożerne) lub 'R' (Roślinożerne):");
            string inputRodzaju = Console.ReadLine().ToUpper();

            if (inputRodzaju == "M" || inputRodzaju == "R")
            {
                wyborRodzaju = inputRodzaju[0];
                break;
            }
            else
            {
                Console.WriteLine("Niepoprawny wybór. Wpisz tylko 'M' lub 'R'.\n");
            }
        }

       
        if (wyborRodzaju == 'R')
        {
            Console.WriteLine("\nDostępne gatunki roślinożerne:");
            foreach (var name in Enum.GetNames(typeof(Herbivorous)))
            {
                Console.WriteLine("- " + name);
            }

            Herbivorous wybranyGatunek;
            while (true)
            {
                Console.WriteLine("\nWpisz nazwę gatunku:");
                string gatunekInput = Console.ReadLine();

                if (Enum.TryParse(gatunekInput, true, out wybranyGatunek) &&
                    Enum.IsDefined(typeof(Herbivorous), wybranyGatunek))
                {
                    Console.WriteLine("Wybrano gatunek: " + wybranyGatunek);

                    Console.WriteLine("\nIle dinozaurów tego gatunku chcesz dodać?");
                    int liczbaDino;
                    while (!int.TryParse(Console.ReadLine(), out liczbaDino) || liczbaDino < 1)
                    {
                        Console.WriteLine("Podaj poprawną liczbę większą od 0:");
                    }

                    Dinozaur nowyDino = new HerbivorousDino
                    {
                        Rodzaj = 'R',
                        Gatunek = wybranyGatunek.ToString(),
                        Liczba = liczbaDino
                    };
                    for (int i = 1; i <= liczbaDino; i++)
                    {
                        while (true)
                        {
                            Console.Write($"Podaj imię dla dinozaura #{i}: ");
                            string imie = Console.ReadLine();
                            if (Regex.IsMatch(imie, @"^[a-zA-Z]+$"))
                            {
                                nowyDino.Imiona.Add(imie);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Imię może zawierać tylko litery. Spróbuj ponownie.");
                            }
                        }
                    }
                    nowyDino.PrzypiszKolorLisci();
                    nowyDino.WypiszInformacje();
                    nowyDino.PokazKolorLisci();
                    nowyDino.GetSound();
                    break;
                }
                else
                {
                    Console.WriteLine("Niepoprawna nazwa gatunku. Spróbuj ponownie.");
                }
            }
        }

        
        else if (wyborRodzaju == 'M')
        {
            Console.WriteLine("\nDostępne gatunki mięsożerne:");
            foreach (var name in Enum.GetNames(typeof(Carnivorous)))
            {
                Console.WriteLine("- " + name);
            }

            Carnivorous wybranyGatunek;
            while (true)
            {
                Console.WriteLine("\nWpisz nazwę gatunku:");
                string gatunekInput = Console.ReadLine();

                if (Enum.TryParse(gatunekInput, true, out wybranyGatunek) &&
                    Enum.IsDefined(typeof(Carnivorous), wybranyGatunek))
                {
                    Console.WriteLine("Wybrano gatunek: " + wybranyGatunek);

                    Console.WriteLine("\nIle dinozaurów tego gatunku chcesz dodać?");
                    int liczbaDino;
                    while (!int.TryParse(Console.ReadLine(), out liczbaDino) || liczbaDino < 1)
                    {
                        Console.WriteLine("Podaj poprawną liczbę większą od 0:");
                    }

                    Dinozaur nowyDino = new CarnivorousDino
                    {
                        Rodzaj = 'M',
                        Gatunek = wybranyGatunek.ToString(),
                        Liczba = liczbaDino
                    };

                    for (int i = 1; i <= liczbaDino; i++)
                    {
                        while (true)
                        {
                            Console.Write($"Podaj imię dla dinozaura #{i}: ");
                            string imie = Console.ReadLine();
                            if (Regex.IsMatch(imie, @"^[a-zA-Z]+$"))
                            {
                                nowyDino.Imiona.Add(imie);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Imię może zawierać tylko litery. Spróbuj ponownie.");
                            }
                        }
                    }


                            nowyDino.WypiszInformacje();
                            nowyDino.GetSound();
                    break;
                }
                else
                {
                    Console.WriteLine("Niepoprawna nazwa gatunku. Spróbuj ponownie.");
                }
            }
        }
    }
}


