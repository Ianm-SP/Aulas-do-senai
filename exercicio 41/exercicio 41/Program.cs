Console.WriteLine("Digite a coordenada x:");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a coordenada y:");
double y = Convert.ToDouble(Console.ReadLine());


if (x == 0 && y == 0)
{
    Console.WriteLine("Origem");
}
else if (x == 0)
{
    Console.WriteLine("Eixo Y");
}
else if (y == 0)
{
    Console.WriteLine("Eixo X");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("Q1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Q2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Q3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Q4");
}
