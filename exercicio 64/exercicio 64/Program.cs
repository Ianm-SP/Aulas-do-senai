Console.WriteLine("Coloque o 1 numero");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Coloque o 2 numero");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Coloque o 3 numero");
double c = double.Parse(Console.ReadLine());
Console.WriteLine("Coloque o 4 numero");
double d = double.Parse(Console.ReadLine());
Console.WriteLine("Coloque o 5 numero");
double e = double.Parse(Console.ReadLine());

if ( a % 2 == 0 )
{
    a = 1;
}
else
{
    a = 0;
}
if (b % 2 == 0)
{
    b = 1;
}
else
{
    b = 0;
}
if (c % 2 == 0)
{
    c = 1;
}
else
{
    c = 0;
}
if (d % 2 == 0)
{
    d = 1;
}
else
{
    d = 0;
}
if (e % 2 == 0)
{
    e = 1;
}
else
{
    e = 0;
}
double valor = a + b + c + d + e;

Console.WriteLine(valor + " valores pares");

