Console.WriteLine("Escreva o numero da altura e largura para exibir o retangulo (digite qualquer tecla para prosseguir) ");
Console.ReadKey();

Console.Write("Escreva o numero da altura: ");
int altura = int.Parse(Console.ReadLine()!);

Console.Write("Escreva o numero da largura: ");
int largura = int.Parse(Console.ReadLine()!);

for (int i = 0; i < altura; i++)
{
    for (int j = 0; j < largura; j++)
    {
        if (i == 0 || i == altura - 1 || j == 0 || j == largura - 1)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();

}

Console.WriteLine("Retangulo exibido com sucesso!");
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();