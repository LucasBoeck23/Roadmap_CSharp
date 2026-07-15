namespace Fundamentos;

/// <summary>
/// Structs, enums, classes e a diferença entre value types e reference types.
/// </summary>
public static class Estruturas
{
    // Enum — conjunto fixo de valores nomeados
    public enum Cor { Vermelho, Verde, Azul }

    // Struct — value type (cópia por valor, vive na stack)
    public struct Ponto
    {
        public double X;
        public double Y;

        public Ponto(double x, double y) { X = x; Y = y; }

        public double DistanciaOrigem() => Math.Sqrt(X * X + Y * Y);

        public override string ToString() => $"({X}, {Y})";
    }

    // Classe — reference type (cópia por referência, vive na heap)
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString() => $"{Nome} ({Idade} anos)";
    }

    public static void Executar()
    {
        Console.WriteLine("\n=== ESTRUTURAS (Struct, Enum, Classe) ===\n");

        // Enum
        Cor minhaCor = Cor.Azul;
        Console.WriteLine($"Enum: {minhaCor} = {(int)minhaCor}");

        // Struct (value type) — cópia cria um CLONE independente
        var p1 = new Ponto(3, 4);
        var p2 = p1;        // p2 é uma CÓPIA — alterar p2 não afeta p1
        p2.X = 99;
        Console.WriteLine($"\nStruct (value type):");
        Console.WriteLine($"  p1 = {p1}  (não mudou)");
        Console.WriteLine($"  p2 = {p2}  (mudou independente)");
        Console.WriteLine($"  p1.DistanciaOrigem() = {p1.DistanciaOrigem():F2}");

        // Classe (reference type) — cópia aponta pro MESMO objeto
        var pessoa1 = new Pessoa("Lucas", 25);
        var pessoa2 = pessoa1;  // pessoa2 APONTA pro mesmo objeto
        pessoa2.Idade = 30;
        Console.WriteLine($"\nClasse (reference type):");
        Console.WriteLine($"  pessoa1 = {pessoa1}  (MUDOU junto!)");
        Console.WriteLine($"  pessoa2 = {pessoa2}  (mesmo objeto)");
        Console.WriteLine($"  São o mesmo? {ReferenceEquals(pessoa1, pessoa2)}");

        // Resumo
        Console.WriteLine("\n  [!] Struct: cópia por VALOR (independente)");
        Console.WriteLine("  [!] Classe: cópia por REFERÊNCIA (mesmo objeto)");
    }
}
