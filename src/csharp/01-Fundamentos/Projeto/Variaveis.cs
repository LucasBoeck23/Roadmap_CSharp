namespace Fundamentos;

/// <summary>
/// Tipos de variáveis, constantes e nullable em C#.
/// </summary>
public static class Variaveis
{
    public static void Executar()
    {
        Console.WriteLine("=== VARIÁVEIS E TIPOS ===\n");

        // Tipos primitivos
        int idade = 25;
        double salario = 4500.50;
        bool ativo = true;
        char inicial = 'L';
        string nome = "Lucas";

        Console.WriteLine($"Nome: {nome}, Idade: {idade}, Salário: {salario:C}");
        Console.WriteLine($"Ativo: {ativo}, Inicial: {inicial}");

        // var — tipo inferido pelo compilador (NÃO é dinâmico)
        var cidade = "Curitiba"; // compilador sabe que é string
        var numero = 42;         // compilador sabe que é int

        Console.WriteLine($"\nvar cidade = \"{cidade}\" → tipo: {cidade.GetType().Name}");
        Console.WriteLine($"var numero = {numero} → tipo: {numero.GetType().Name}");

        // const — valor imutável definido em tempo de compilação
        const double PI = 3.14159;
        const string VERSAO = "1.0.0";
        Console.WriteLine($"\nconst PI = {PI}, VERSAO = {VERSAO}");

        // Nullable — tipos de valor que podem ser null
        int? temperaturaExterna = null; // pode ser null
        int temperaturaInterna = 22;    // nunca pode ser null

        Console.WriteLine($"\nTemperatura externa: {temperaturaExterna ?? -999} (null = -999)");
        Console.WriteLine($"Temperatura interna: {temperaturaInterna}");

        // Null-coalescing e null-conditional
        string? endereco = null;
        int tamanho = endereco?.Length ?? 0; // se null, retorna 0
        Console.WriteLine($"Tamanho do endereço: {tamanho}");
    }
}
