// Gelieve je voornaam, achternaam, studentnummer en klas in te vullen in onderstaande variabele
string studentVoornaam = "Jonas";
string studentAchternaam = "Trap";
string studentNummer = "r0335225";
string studentKlas = "GTI GPR a1.1";


// Titel van programma
Console.Title = $"f-starwars - {studentVoornaam} {studentAchternaam} ({studentNummer} - {studentKlas})";

// Start vanaf hier met programmeren
string[] hoofdmenu = ["Afsluiten,", "Jedi Bekijken", "Jedi Toevoegen", "Jedi Verwijderen", "Jedi Editeren"];
int keuzeHoofdmenu;
List<string> jedi = new List<string> { };

//Tonen van Hoofdmenu;
keuzeHoofdmenu = keuzeMenu(hoofdmenu);

//herhalen indien keuze != 1
while (keuzeHoofdmenu != 1)
{
    switch (keuzeHoofdmenu)
    {
        case 2:
            PrintJedi(jedi);
            break;
    }
}
Console.ReadLine();


//
void PrintJedi(List<string> jedi)
{
    if (jedi is not null)
    {
        foreach (string naam in jedi)
        {
            Console.WriteLine(naam);
        }
    }
    else
    {
        Console.WriteLine("Er zijn geen Jedi!");
    }
}
//toon keuzemenu: 
int keuzeMenu(string[] menu)
{
    for (int i = 0; i < menu.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {menu[i]}");
    }
    return LeesGetalMinMax("Kies een optie uit het menu: ", 1, menu.Length);
}

//Bepalen van de min en max waarden in de menu
int LeesGetalMinMax(string vraag, int min, int max)
{
    int getal;
    do
    {
        getal = LeesGetal(vraag);
    } while (getal < min || getal > max);
    return getal;
}

//checken of input een getal is
int LeesGetal(string vraag)
{
    string output;
    int getal;
    do
    {
        output = LeesStringNietLeeg(vraag);
    } while (!int.TryParse(output, out getal));
    return getal;
}


//checken of string leeg is: 
string LeesStringNietLeeg(string vraag)
{
    string output;
    do
    {
        Console.Write(vraag);
        output = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(output));
    return output;
}
