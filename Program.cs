using System.Threading.Tasks;
using Discord.WebSocket;

namespace DiabloESBot
{
  internal class Program
  {
    public DiscordSocketClient BotClient;
    public CommandHandler CHandler;
    static void Main(string[] args) => new Program().Start().GetAwaiter().GetResult();

    public async Task Start()
    {
      BotClient = new DiscordSocketClient();
      CHandler = new CommandHandler();
      await BotClient.LoginAsync(Discord.TokenType.Bot, "ODI2MjY2NzIxOTkyMTc5NzEz.YGJ-2Q.p1yLVMDL5UHkSDUGH0mTn8YzMhI", true);
      await BotClient.StartAsync();
      await CHandler.Install(BotClient);
      await Task.Delay(-1);
    }
  }
}