Console.WriteLine("Digite o valor do lado A:");
double A = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor do lado B:");
double B = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor do lado C:");
double C = Convert.ToDouble(Console.ReadLine());

double[] lados = { A, B, C };
Array.Sort(lados);
Array.Reverse(lados);

A = lados[0];
B = lados[1];
C = lados[2];


if (A >= B + C)
{
    Console.WriteLine("NÃO FORMA TRIANGULO");
}
else
{
    if (A * A == B * B + C * C)
    {
        Console.WriteLine("TRIANGULO RETÂNGULO");
    }
    else if (A * A > B * B + C * C)
    {
        Console.WriteLine("TRIANGULO OBTUSÂNGULO");
    }
    else if (A * A < B * B + C * C)
    {
        Console.WriteLine("TRIANGULO ACUTÂNGULO");
    }

    if (A == B && B == C)
    {
        Console.WriteLine("TRIANGULO EQUILÁTERO");
    }
    else if (A == B || B == C || A == C)
    {
        Console.WriteLine("TRIANGULO ISÓSCELES");
    }
}