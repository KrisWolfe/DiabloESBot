using System.IO;
using Discord.Commands;

namespace DiabloESBot
{
    public class Commands : ModuleBase
    {
        [Command("ping")]
        public void test()
        {
            ReplyAsync("pong");
        }

        [Command("fileNames")]
        public void FileNames()
        {
            string contents = "```";
            
            foreach(string file in Directory.EnumerateFiles("C:/Users/donotfearjazz/AppData/Local/VirtualStore/Program Files (x86)/PvPGN/var/charsave", "*.sav"))
            {
                contents += File.ReadAllText(file) + "\n";
            }

            ReplyAsync(contents + "```");
        }
    }
}