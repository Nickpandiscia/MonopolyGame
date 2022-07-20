using Monopoly.Core;
using Monopoly.Engine;
using Monopoly.Engine.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string thisDir = Directory.GetCurrentDirectory();
            Console.WriteLine(thisDir);
            DirectoryInfo di = new DirectoryInfo(thisDir);
            Console.WriteLine($"{di.LastWriteTime} {di.Attributes}");

            var settings = new GameSettings();

            Console.WriteLine("Do you want to configure the settings? (Type y to enter settings). If not, type n.");
            var settingsAnswer = Console.ReadLine();

            if (settingsAnswer == "y")
            {
                Console.WriteLine($"How many players are there?");
                var playerCount = int.Parse(Console.ReadLine());
                Logger.Log($"User set player count to {playerCount}");

                Console.WriteLine($"How much currency do you want to start with?");
                var currencyCount = int.Parse(Console.ReadLine());
                Logger.Log($"User set player balance to {currencyCount}");

                settings.PlayerCount = playerCount;
                settings.StartingPlayerBalance = currencyCount;
                settings.StartingProperties = 0;
            }
            else
            {
                Logger.Log("User chose not to configure");
            }
            
            
            GameEngine gameEngine = new GameEngine(settings);
            gameEngine.RunGame();

            Logger.Log("Game Finished");
            Console.ReadLine();
        }
    }
}
