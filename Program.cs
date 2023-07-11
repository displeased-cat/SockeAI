using Discord;
using SockeAI;

public class Program
{
    public static Task Main(string[] args) => new Program().MainAsync();

    private Socke _bot;

    public async Task MainAsync()
    {
        _bot = new Socke();
        await _bot.SartAsync();
    }
}