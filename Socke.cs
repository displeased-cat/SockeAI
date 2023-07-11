using Discord;
using Discord.WebSocket;
using SockeAI.Handler;

namespace SockeAI
{
    public class Socke
    {
        private readonly string _token = "Nzc0NjU4NTc1OTgwMTY3MjA4.GBWoKn.DAg8iDol3L8AO9ULjHw6r8eMRrd11KOr1Ln1XQ";
        private readonly DiscordSocketClient _client;
        private MessageHandler _messageHandler;
        private LogHandler _logHandler;

        public Socke()
        {
            _client = new DiscordSocketClient();
            _messageHandler = new MessageHandler();
            _logHandler = new LogHandler();
            clientSetup();
        }

        private void clientSetup() {
            _client.MessageReceived += _messageHandler.HandleMessageReceived;
            _client.Log += _logHandler.Log;
        }
        public async Task SartAsync()
        {
            Console.WriteLine("Logging in...");
            await _client.LoginAsync(TokenType.Bot, _token);
            await _client.StartAsync();
            Console.WriteLine("Logged in.");
            await Task.Delay(-1);
        }
    }
}
