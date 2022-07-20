using Monopoly.Core;
using Monopoly.Engine;
using Monopoly.Engine.Tools;
using System;
using System.Collections.Generic;
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
            //foreach(var card in GameManager.Instance.Cards)
            //{
            //    Console.WriteLine(card.ToString());
            //}
            //foreach(var tile in GameManager.Instance.BoardTiles)
            //{
            //    Console.WriteLine(tile.ToString());
            //}
            //Console.ReadLine();
            var settings = new GameSettings();
            Console.WriteLine("Hit any button to continue, or type exit to quit the game.");
            var exitAnswer = Console.ReadLine();
            do
            {
                Console.WriteLine("Do you want to configure the settings? (Type t to enter settings). If not, type f. Type exit to quit.");
                var settingsAnswer = Console.ReadLine();
                if(exitAnswer == "exit")
                {
                    break;
                }
                if (settingsAnswer == "t")
                {
                    Console.WriteLine($"How many players are there?");
                    var playerCount = int.Parse(Console.ReadLine());

                    Console.WriteLine($"How much currency do you want to start with?");
                    var currencyCount = int.Parse(Console.ReadLine());

                    settings.PlayerCount = playerCount;
                    settings.StartingPlayerBalance = currencyCount;
                    settings.StartingProperties = 0;
                }
                else
                {
                    // Logger.Log("Player chose not to configure");
                }
                // GameManager.Instance.SetGameSettings(settings);


                using (SpeechSynthesizer synth = new SpeechSynthesizer())
                {

                    // Configure the audio output.   
                    synth.SetOutputToDefaultAudioDevice();
                    // Speak the contents of the prompt synchronously.  
                    synth.Speak("Wake up. The game settings have been set bitch.");

                    synth.Speak("Welcome to Monopoly! Lets begin.");




                }
            }while (exitAnswer != "exit");
            



            Console.ReadLine();
        }
    }
}
