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
Console.WriteLine("Coloque o 6 numero");
double f = double.Parse(Console.ReadLine());

if (a > 0)
{
    a = 1;
}
else
{
    a = 0;
}
if (b > 0)
{
    b = 1;
}
else
{
    b = 0;
}
if (c > 0)
{
    c = 1;
}
else
{
    c = 0;
}
if (d > 0)
{
    d = 1;
}
else
{
    d = 0;
}
if (e  > 0)
{
    e = 1;
}
else
{
    e = 0;
}
if (f > 0)
{
    f = 1;
}
else
{
    f = 0;
}

double soma = a + b + c + d + e + f;
Console.WriteLine(soma + " valores inteiros");