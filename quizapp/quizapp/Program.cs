/*
string Pitanjej1="glavni grad Švabije";
string Odgovor1 = "Berlin";
string pitanje2 = "Koliko ću piva popit danas";
int odgovor2 = 0;
string pitanje3 = "Zašto necu pit pive danas";
string odgovor3 = "Jer idem kod cure";
int bodovi = 0;

Console.WriteLine(Pitanjej1);
string pokušaj1=Console.ReadLine();
if (pokušaj1.Trim().ToLower()== Odgovor1.ToLower())
{
    Console.WriteLine("Svaka čast legendo");
    bodovi++;
}
else
{
    Console.WriteLine("Žao mi je nisi pogodio");
    if (bodovi > 0)
        bodovi--;
}
Console.WriteLine(pitanje2);
int pokušaj2=int.Parse(Console.ReadLine());
if (pokušaj2== odgovor2)
{
    Console.WriteLine("Svaka čast legendo");
    bodovi++;
}
else
{
    Console.WriteLine("Žao mi je nisi pogodio");
    if (bodovi > 0)
        bodovi--;
}
Console.WriteLine(pitanje3);
string pokušaj3=Console.ReadLine();

if (pokušaj3.Trim().ToLower() == odgovor3.ToLower())
{
    Console.WriteLine("Svaka čast legendo");
    bodovi++;
}
else
{
    Console.WriteLine("Žao mi je nisi pogodio");

    if (bodovi < 0)
        bodovi--;
}
Console.WriteLine($"Završio si sa {bodovi} bodova");
Console.ReadKey();  

*/
Random random = new Random();
int RandomNumber = random.Next(1, 11);
Console.WriteLine("Pokušaj pogodit broj, budem ti reko jesi blizu ili ne");
bool check = int.TryParse(Console.ReadLine(), out int pokušaj);

while (pokušaj != RandomNumber)
{
    int Indikator = pokušaj - RandomNumber;
    Indikator = Math.Abs(Indikator);
    if (Indikator >= 3)
    {
        Console.WriteLine($"hladno, pokušaj ponovno, indikator = {Indikator}");
        check = int.TryParse(Console.ReadLine(), out pokušaj);
        Indikator = 0;


    }
    else if (Indikator <= 3)
    {
        Console.WriteLine($"toplo bliže si pokušaj ponovo, indikator = {Indikator}");
        check = int.TryParse(Console.ReadLine(), out pokušaj);
        Indikator = 0;
    }
}
Console.WriteLine($"Svaka cast pogodio si random broj koji je bio {RandomNumber}");
Console.ReadKey();