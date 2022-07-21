using Monopoly.Models.Models;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Monopoly.Core;

namespace Monopoly.Engine
{
    public class GameEngine : GameEngineBase
    {
        public GameSettings Settings;
        public List<Player> PlayerList;

        public GameEngine(GameSettings settings)
            : base()
        {
            Settings = settings;
            BuildPlayers();
        }

        public void RunGame()
        {
            while (PlayerList.Count > 1)
            {
                foreach (var player in PlayerList)
                {
                    // Roll Dice
                    Wait();
                    Logger.Log($"Player {player.PlayerId}, Starting Turn.");
                    var diceRoll = player.RollDice();
                    Wait();
                    Logger.Log($"Player {player.PlayerId}, rolled {diceRoll}");

                    // Get new position
                    var newPosition = player.CurrentBoardTile.Position + diceRoll;
                    if (newPosition > 35)
                        newPosition = newPosition - 35;

                    // Move player
                    Wait();
                    var newBoardTile = BoardTiles.First(x => x.Position == newPosition);
                    player.MovePlayer(BoardArray, newBoardTile);


                    // Remove player from game when they have no money left
                    if (player.Balance <= 0)
                    {
                        PlayerList.Remove(player);
                    }
                }
            }
            
        }

        private static void Wait()
        {
            Task.Delay(150).Wait();
        }

        public void BuildPlayers()
        {
            var playerList = new List<Player>();
            for (int i = 0; i < Settings.PlayerCount; i++)
            {
                Player player = new Player();
                player.Balance = Settings.StartingPlayerBalance;
                player.CurrentBoardTile = BoardTiles.First(x => x.Position == 0);
                player.PlayerId = i + 1;
                player.RandomSeed = int.MaxValue / (i + 1);
                playerList.Add(player);
            }
            PlayerList = playerList;
        }

    }
}
