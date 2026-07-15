namespace Fundamentos;

/// <summary>
/// Estruturas de repetição: for, foreach, while, do-while.
/// </summary>
public static class Loops
{
    public static void Executar()
    {
        Console.WriteLine("\n=== LOOPS ===\n");

        // for — quando sabe quantas vezes vai iterar
        Console.Write("for: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        // foreach — itera sobre coleções (o mais usado no dia a dia)
        var frutas = new[] { "Maçã", "Banana", "Uva", "Manga" };
        Console.Write("foreach: ");
        foreach (var fruta in frutas)
        {
            Console.Write($"{fruta} ");
        }
        Console.WriteLine();

        // while — quando não sabe quantas vezes vai iterar
        Console.Write("while: ");
        int contador = 10;
        while (contador > 0)
        {
            Console.Write($"{contador} ");
            contador -= 3;
        }
        Console.WriteLine();

        // do-while — executa pelo menos uma vez
        Console.Write("do-while: ");
        int tentativa = 0;
        do
        {
            Console.Write($"tentativa-{tentativa} ");
            tentativa++;
        } while (tentativa < 3);
        Console.WriteLine();

        // break e continue
        Console.Write("break/continue (pula pares, para no 7): ");
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0) continue; // pula pares
            if (i > 7) break;          // para quando passar de 7
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }
}
