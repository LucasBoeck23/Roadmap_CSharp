using System.Net.Http.Json;
using RoadmapApp.Models;

namespace RoadmapApp.Services;

public class TopicService
{
    private readonly HttpClient _http;
    private Dictionary<string, List<Topic>>? _cache;

    public TopicService(HttpClient http)
    {
        _http = http;
    }

    public async Task<Dictionary<string, List<Topic>>> GetAllTracksAsync()
    {
        if (_cache is not null) return _cache;
        _cache = await _http.GetFromJsonAsync<Dictionary<string, List<Topic>>>("data/topics.json");
        return _cache ?? new Dictionary<string, List<Topic>>();
    }

    public async Task<List<TrackInfo>> GetTrackListAsync()
    {
        var tracks = await GetAllTracksAsync();
        return tracks.Select(kvp => TrackInfo.FromId(kvp.Key, kvp.Value.Count)).ToList();
    }

    public async Task<List<Topic>> GetTopicsByTrackAsync(string trackId)
    {
        var tracks = await GetAllTracksAsync();
        return tracks.TryGetValue(trackId, out var topics) ? topics : new List<Topic>();
    }

    public async Task<string?> GetReadmeAsync(string pasta)
    {
        try
        {
            return await _http.GetStringAsync($"{pasta}/README.md");
        }
        catch
        {
            return null;
        }
    }

    public async Task<string?> GetFileAsync(string pasta, string filePath)
    {
        try
        {
            return await _http.GetStringAsync($"{pasta}/{filePath}");
        }
        catch
        {
            return null;
        }
    }
}
