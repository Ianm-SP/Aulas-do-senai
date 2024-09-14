Console.WriteLine("Digite o salário:");
double salario = Console.ReadLine();

double imposto = 0.0;

if (salario <= 2000.00)
{
    Console.WriteLine("Isento");
}
else if (salario <= 3000.00)
{
    imposto = (salario - 2000.00) * 0.08;
    Console.WriteLine("R$ " + imposto("0.00");
}
else if (salario <= 4500.00)
{
    imposto = (1000.00 * 0.08) + (salario - 3000.00) * 0.18;
    Console.WriteLine("R$ " + imposto("0.00");
}
else
{
    imposto = (1000.00 * 0.08) + (1500.00 * 0.18) + (salario - 4500.00) * 0.28;
    Console.WriteLine("R$ " + imposto("0.00");
}
