using Discord;

namespace SockeAI.Handler
{
    public class LogHandler
    {
        public Task Log(LogMessage msg)
        {
            Console.WriteLine(msg);
            return Task.CompletedTask;
        }
    }
}
