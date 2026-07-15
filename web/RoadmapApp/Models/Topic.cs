using System.Text.Json.Serialization;

namespace RoadmapApp.Models;

public class Topic
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("nome")]
    public string Nome { get; set; } = string.Empty;

    [JsonPropertyName("nivel")]
    public string Nivel { get; set; } = string.Empty;

    [JsonPropertyName("pasta")]
    public string Pasta { get; set; } = string.Empty;

    [JsonPropertyName("temReadme")]
    public bool TemReadme { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; } = "nao-iniciado";

    [JsonPropertyName("arquivos")]
    public List<string> Arquivos { get; set; } = new();

    public string NivelLabel => Nivel switch
    {
        "trainee" => "🟢 Trainee",
        "junior" => "🔵 Júnior",
        "pleno" => "🟡 Pleno",
        "senior" => "🔴 Sênior",
        _ => "⚪ Outro"
    };

    public string StatusLabel => Status switch
    {
        "concluido" => "✅ Concluído",
        "em-progresso" => "🔄 Estudando",
        _ => "⬜ Não iniciado"
    };
}

public class TrackInfo
{
    public string Id { get; set; } = string.Empty;
    public string Nome { get; set; } = string.Empty;
    public string Icone { get; set; } = "📦";
    public string Cor { get; set; } = "#58a6ff";
    public int TotalTopicos { get; set; }

    public static TrackInfo FromId(string id, int totalTopicos) => id switch
    {
        "csharp" => new TrackInfo { Id = id, Nome = "C# / .NET", Icone = "img/csharp.svg", Cor = "#512bd4", TotalTopicos = totalTopicos },
        "flutter" => new TrackInfo { Id = id, Nome = "Flutter / Dart", Icone = "img/flutter.svg", Cor = "#02569B", TotalTopicos = totalTopicos },
        _ => new TrackInfo { Id = id, Nome = id, Icone = "", Cor = "#58a6ff", TotalTopicos = totalTopicos }
    };
}
