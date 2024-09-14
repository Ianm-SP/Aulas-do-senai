Console.WriteLine("escreva o 1 numero");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("escreva o 2 numero");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("escreva o 3 numero");
int c = int.Parse(Console.ReadLine());

int menor, meio, maior;

if (a <= b && a <= c)
{
    menor = a;
    if (b <= c)
    {
        meio = b;
        maior = c;
    }
    else
    {
        meio = c;
        maior = b;
    }
}
else if (b <= a && b <= c)
{
    menor = b;
    if (a <= c)
    {
        meio = a;
        maior = c;
    }
    else
    {
        meio = c;
        maior = a;
    }
}
else
{
    menor = c;
    if (a <= b)
    {
        meio = a;
        maior = b;
    }
    else
    {
        meio = b;
        maior = a;
    }
}
Console.Write("Em ordem fica: ");

Console.Write(menor);
Console.Write(meio);
Console.Write(maior);

Console.Write();

Console.Write(" Do jeito que foi colocado: ");

Console.Write(a);
Console.Write(b);
Console.Write(c);
