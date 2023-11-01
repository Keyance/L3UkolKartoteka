using System.IO;
using System;

string cesta = @"e:\text\czechitas\kartoteka.txt";

if (File.Exists(cesta))
{
    Console.WriteLine("soubor existuje.");

}
else
{
    Console.WriteLine("soubor neexistuje.");
}

Console.WriteLine("Toto je kartotéka knih, prosím vyberte, zda chcete zobrazit existující záznamy (z), nebo přidat nové (n).\nPokud chcete vymazat stávající záznamy v souboru stskněte q.");
string rozhodnuti = Console.ReadLine();

if (string.Equals(rozhodnuti, "n", StringComparison.OrdinalIgnoreCase))
{

    while (true)
    {
        Console.WriteLine("Nyní můžete vepisovat nové záznamy do archivu:");

        Console.WriteLine("Prosím, napiště název knihy:");
        string nazev = Console.ReadLine();

        Console.WriteLine("Prosím, napiště jméno autora:");
        string autor = Console.ReadLine();

        Console.WriteLine("Prosím, napiště rok vydání knihy:");
        string rok = Console.ReadLine();

        string text = nazev + ", " + autor + ", " + rok + "\n";

        File.AppendAllText(cesta, text);

        Console.WriteLine("Pokud chcete ukončit vkládání textu, stiskněte enter.");
        string kontrola = Console.ReadLine();
        if (string.IsNullOrEmpty(kontrola))
        {
            break;

        }
    }
}
else if (string.Equals(rozhodnuti, "z", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Tady je obsah textového souboru:");
    Console.WriteLine(File.ReadAllText(cesta));
}
else if (string.Equals(rozhodnuti, "q", StringComparison.OrdinalIgnoreCase))
{
    File.WriteAllText(cesta, "");

}

Console.ReadLine();
