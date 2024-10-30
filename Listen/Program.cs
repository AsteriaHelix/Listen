
/*
List<string> liste = new List<string>();

liste.Add("Batman");
liste.Add("Ironman");
liste.Add("Spiderman");
liste.Add("Capten America");

//liste.Remove("Spiderman");
liste.Sort();
foreach(var x in liste)
{
    Console.WriteLine(x);
}
Console.WriteLine($"\nDie Liste beinhält {liste.Count} Einträge");
*/



List<string> liste_schüler = new List<string>();

while (true)
{
    Console.Write("Mit j/J Weiter und mit n/N Ende  ");
    string str = Console.ReadLine();
    if (str == "n" || str == "N")
    {
        Console.WriteLine("\nListe der Schüler");
        break;
    }
    else if (str == "j" || str == "J")
    {
        Console.WriteLine("\nGeben sie den Namen ein : ");
        string name= Console.ReadLine();
        liste_schüler.Add(name);
    }
    else
    {
        Console.WriteLine("Falsche Eingabe ");
    }
    
}

int k = 1;
foreach (var s in liste_schüler)
{
    Console.WriteLine($"{k++}ter Schüler  : {s}");
}

Console.Write("\nWelchen Schüler möchten sie entfernen  :");
String wahl = Console.ReadLine();

for(int i =0; i< liste_schüler.Count; i++)
{
    if (liste_schüler[i].Equals(wahl))
    {
        liste_schüler.RemoveAt(i);
        Console.WriteLine($"{wahl} ist gelöscht !!!!!");
        break;
    }
    else if (i == liste_schüler.Count - 1)
    {
        Console.WriteLine("Der Schüler befindet sich nicht in der Liste !!!");
    }
}
k = 1;
foreach (var s in liste_schüler)
{
    Console.WriteLine($"{k++}ter Schüler  : {s}");
}

Console.WriteLine("\nCiao amigoooooooos");
Console.ReadKey();
