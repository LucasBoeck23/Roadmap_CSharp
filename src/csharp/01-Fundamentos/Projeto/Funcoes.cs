namespace Fundamentos;

/// <summary>
/// Métodos: parâmetros, retorno, ref, out, params, expressão.
/// </summary>
public static class Funcoes
{
    public static void Executar()
    {
        Console.WriteLine("\n=== FUNÇÕES / MÉTODOS ===\n");

        // Chamada simples
        var saudacao = Saudar("Lucas");
        Console.WriteLine(saudacao);

        // Parâmetros com valor padrão
        Apresentar("João", idade: 30);
        Apresentar("Maria"); // usa padrão

        // ref — passa a referência da variável (altera o original)
        int valor = 10;
        Dobrar(ref valor);
        Console.WriteLine($"\nref: valor após Dobrar = {valor}");

        // out — o método DEVE atribuir valor (usado pra retornos múltiplos)
        if (TentarDividir(10, 3, out double resultado))
        {
            Console.WriteLine($"out: 10 / 3 = {resultado:F2}");
        }

        // params — aceita número variável de argumentos
        var soma = Somar(1, 2, 3, 4, 5);
        Console.WriteLine($"\nparams: Somar(1,2,3,4,5) = {soma}");

        // Expression body (método em uma linha)
        Console.WriteLine($"Expression body: Quadrado(5) = {Quadrado(5)}");
    }

    // Método com retorno
    static string Saudar(string nome) => $"Olá, {nome}!";

    // Parâmetros opcionais
    static void Apresentar(string nome, int idade = 25)
    {
        Console.WriteLine($"  {nome}, {idade} anos");
    }

    // ref — altera a variável original
    static void Dobrar(ref int numero)
    {
        numero *= 2;
    }

    // out — retorno múltiplo
    static bool TentarDividir(int a, int b, out double resultado)
    {
        if (b == 0)
        {
            resultado = 0;
            return false;
        }
        resultado = (double)a / b;
        return true;
    }

    // params — aceita array variável
    static int Somar(params int[] numeros)
    {
        int total = 0;
        foreach (var n in numeros) total += n;
        return total;
    }

    // Expression body — método curto
    static int Quadrado(int x) => x * x;
}
