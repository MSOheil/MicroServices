

namespace PlatFormService.InterFaces.Services.SyncData;
public class CommandDataClientService : ICommandDataClientService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public CommandDataClientService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    public async Task SendPlatformToCommand(PlatformCreateDto platform)
    
    {
        var httpContent = new StringContent(
            JsonSerializer.Serialize(platform),
            Encoding.UTF8,
            "appication/json");
        var response = await _httpClient.PostAsync($"{_configuration["CommandService"]}/api/c/platforms/TestConnection",
            httpContent);
        string message = response.IsSuccessStatusCode ? "Sync post to command service was ok"
            : "Sync post to command service not ok";
        Console.WriteLine(message);
    }
}
