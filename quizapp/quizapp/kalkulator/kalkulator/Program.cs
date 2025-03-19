using System.Numerics;

Console.WriteLine("Unesi dva broja");
bool try1 = int.TryParse(Console.ReadLine(), out int num1);
bool try2 = int.TryParse(Console.ReadLine(), out int num2);
while (!try2 || !try1)
{
   Console.WriteLine("Buraz moras brojeve unjet");
   try1 = int.TryParse(Console.ReadLine(), out  num1);
   try2 = int.TryParse(Console.ReadLine(), out  num2);

}
Console.WriteLine("unesi operator (+, -, *, /)");
char operat = char.Parse(Console.ReadLine());
if (operat != '+' && operat != '-' && operat != '*' && operat != '/')
{
    Console.WriteLine("Sta radis Buraz sta neznas citat");
}
int res;
if (operat == '+')
{
    res = num1 + num2;
    Console.WriteLine($"Odabrao si {operat} pa {num1} {operat} {num2} je {res}");
}
else if (operat == '-')
{
    res = num1 - num2;
    Console.WriteLine($"Odabrao si {operat} pa {num1} {operat} {num2} je {res}");
}
else if (operat == '*')
{
    res = num1 * num2;
    Console.WriteLine($"Odabrao si {operat} pa {num1} {operat} {num2} je {res}");
}
else if (operat == '/')
{
    if (num1 == 0 || num2 == 0)
    {
        Console.WriteLine("Buraz nemozes djelit s nulom");
    }
    else
    {
        double ResHole = (double)num1 / num2;
        Console.WriteLine($"Odabrao si {operat} pa {num1} {operat} {num2} je {ResHole}");
    }
   
}

Console.ReadKey();
