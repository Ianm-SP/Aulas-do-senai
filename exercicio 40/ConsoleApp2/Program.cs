
Console.WriteLine("Digite a primeira nota (N1):");
double N1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota (N2):");
double N2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota (N3):");
double N3 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quarta nota (N4):");
double N4 = double.Parse(Console.ReadLine());


double peso1 = 2.0;
double peso2 = 3.0;
double peso3 = 4.0;
double peso4 = 1.0;


double media = (N1 * peso1 + N2 * peso2 + N3 * peso3 + N4 * peso4) / (peso1 + peso2 + peso3 + peso4);


Console.WriteLine($"Media: {media:F1}");

        
        if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");

            
            Console.WriteLine("Digite a nota do exame:");
            double notaExame = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota do exame: {notaExame:F1}");

            
            double mediaFinal = (media + notaExame) / 2.0;

            
            if (mediaFinal >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.WriteLine("Media final: {mediaFinal:F1}");
