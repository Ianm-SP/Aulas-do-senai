// começo
Console.WriteLine("Digite a hora inicial:");
int horaInicial = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o minuto inicial:");
int minutoInicial = Convert.ToInt32(Console.ReadLine());

// cabou
Console.WriteLine("Digite a hora final:");
int horaFinal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o minuto final:");
int minutoFinal = Convert.ToInt32(Console.ReadLine());

// Converter tudo
int inicioEmMinutos = horaInicial * 60 + minutoInicial;
int fimEmMinutos = horaFinal * 60 + minutoFinal;

if (fimEmMinutos <= inicioEmMinutos)
{
    fimEmMinutos += 24 * 60; 
}

// Calcular a duração total em minutos
int duracaoTotalEmMinutos = fimEmMinutos - inicioEmMinutos;

// Converter a duração total de minutos para horas e minutos
int horasDuracao = duracaoTotalEmMinutos / 60;
int minutosDuracao = duracaoTotalEmMinutos % 60;

// Exibir o resultado
Console.WriteLine("O JOGO DUROU " + horasDuracao + " HORA(S) E " + minutosDuracao + " MINUTO(S)");
