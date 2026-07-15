namespace Fundamentos;

/// <summary>
/// Estruturas condicionais: if/else, switch, ternário, pattern matching.
/// </summary>
public static class Condicoes
{
    public static void Executar()
    {
        Console.WriteLine("\n=== CONDIÇÕES ===\n");

        int nota = 7;

        // if / else if / else
        if (nota >= 9)
            Console.WriteLine("Excelente");
        else if (nota >= 7)
            Console.WriteLine("Aprovado");
        else if (nota >= 5)
            Console.WriteLine("Recuperação");
        else
            Console.WriteLine("Reprovado");

        // Operador ternário
        string resultado = nota >= 7 ? "Passou" : "Não passou";
        Console.WriteLine($"Nota {nota}: {resultado}");

        // Switch clássico
        var diaSemana = DayOfWeek.Wednesday;
        switch (diaSemana)
        {
            case DayOfWeek.Monday:
            case DayOfWeek.Tuesday:
            case DayOfWeek.Wednesday:
            case DayOfWeek.Thursday:
            case DayOfWeek.Friday:
                Console.WriteLine($"\n{diaSemana} → Dia útil");
                break;
            default:
                Console.WriteLine($"\n{diaSemana} → Fim de semana");
                break;
        }

        // Switch expression (C# moderno — muito mais limpo)
        string tipo = nota switch
        {
            >= 9 => "A",
            >= 7 => "B",
            >= 5 => "C",
            _ => "D"
        };
        Console.WriteLine($"Nota {nota} = Conceito {tipo}");

        // Pattern matching com tipos
        object valor = 3.14;
        string descricao = valor switch
        {
            int i => $"Inteiro: {i}",
            double d => $"Decimal: {d}",
            string s => $"Texto: {s}",
            null => "Nulo",
            _ => "Tipo desconhecido"
        };
        Console.WriteLine($"\nPattern matching: {descricao}");
    }
}
