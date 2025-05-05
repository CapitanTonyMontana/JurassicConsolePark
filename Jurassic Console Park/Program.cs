using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("WITAJ W PARKU JURAJSKIM!");
        Console.WriteLine();
        Console.WriteLine("Ile dinozaurów roślinożernych dodać?");

        string input = Console.ReadLine();
        int liczba = int.Parse(input);
       
        Console.WriteLine("Dinozarów roślinożernych jest: " + input);
        Console.WriteLine();
        List<string> dinozauryr = new List<string>();
        dinozauryr.Add("Triceratops");
        dinozauryr.Add("Diplodok");
        dinozauryr.Add("Stegozaury");
        for (int i = 0; i < dinozauryr.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {dinozauryr[i]}");
        }

        Console.Write("\nWybierz jeden z powyższych gatunków dinozaura: ");

        string input4 = Console.ReadLine();

        if (int.TryParse(input4, out int wybor1) && wybor1 >= 1 && wybor1 <= dinozauryr.Count)
        {
            Console.WriteLine("Wybrałeś: " + dinozauryr[wybor1 - 1]);
        }
        else
        {
            Console.WriteLine("Niepoprawny wybór.");
        }
        Console.WriteLine();
        Console.WriteLine("Ile dinozaurów mięsożernych dodać?");

        string input2 = Console.ReadLine();
        int liczba2 = int.Parse(input2);

        Console.WriteLine();
        Console.WriteLine("Dinozarów mięsożernych jest: " + input2);
        Console.WriteLine();

        Console.WriteLine("Wybierz jeden z poniższych gatunków dinozaurów mięsożernych:");

        List<string> dinozaurym = new List<string>();
        dinozaurym.Add("Tyrannosaurus rex (T. rex)");
        dinozaurym.Add("Giganotosaurus");
        dinozaurym.Add("Spinosaurus");

        for (int i = 0; i < dinozaurym.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {dinozaurym[i]}");
        }

        Console.Write("\nWybierz jeden z powyższych gatunków dinozaura: ");

        string input3 = Console.ReadLine();

        if (int.TryParse(input3, out int wybor2) && wybor2 >= 1 && wybor2 <= dinozaurym.Count)
        {
            Console.WriteLine("Wybrałeś: " + dinozaurym[wybor2 - 1]);
        }
        else
        {
            Console.WriteLine("Niepoprawny wybór.");
        }
    }
}