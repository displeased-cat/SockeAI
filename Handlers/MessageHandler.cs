using Discord;
using Discord.WebSocket;

namespace SockeAI.Handler
{
    public class MessageHandler
    {
        public async Task HandleMessageReceived(SocketMessage message)
        {
            if (!message.Author.IsBot && message.Content.Contains("test message"))
            {
                var userMessage = message as IUserMessage;

                await userMessage.AddReactionAsync(new Emoji("👋"));
                await message.Channel.SendMessageAsync("test received");
            }
        }
    }
}
