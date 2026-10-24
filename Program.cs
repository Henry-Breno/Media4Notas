Console.WriteLine("Calculador de Média");

Console.Write("Nota 1: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 2: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 3: ");
double nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 4: ");
double nota4 = Convert.ToDouble(Console.ReadLine());

if (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10 || nota3 < 0 || nota3 > 10 || nota4 < 0 || nota4 > 10)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("Digite somente notas entre 0 e 10.");
    
}
else
{
    double media = (nota1 + nota2 + nota3 +nota4) / 4;

    Console.WriteLine($"Você ficou com média {media:N2}.");

    if (media >= 7)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Resultado: Aprovado");
    }
    else
    {
        if (media >= 5)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Resultado: Recuperação!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Resultado: Reprovado!");
        }
    }
}

Console.ResetColor();
Console.WriteLine("Obrigado por usar nosso calculador!");

