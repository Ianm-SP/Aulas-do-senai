Console.WriteLine("Coloque o 1 lado");
double A = double.Parse(Console.ReadLine());
Console.WriteLine("Coloque o 2 lado");
double B = double.Parse(Console.ReadLine());
Console.WriteLine("Coloque o 3 lado");
double C = double.Parse(Console.ReadLine());

if (A + B > C && A + C > B && B + C > A)
{
    double perimetro = A + B + C;
    Console.WriteLine("Perímetro = {0:F1}", perimetro);
}
else
{
    double area = ((A + B) * C) / 2;
    Console.WriteLine("Área = {0:F1}", area);
}
