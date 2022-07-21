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
                    Logger.Log($"Player {player.PlayerId}, Starting Turn.");
                    var diceRoll = player.RollDice();
                    Logger.Log($"Player {player.PlayerId} rolled {diceRoll}");
                    var newPosition = player.CurrentBoardTile.Position + diceRoll;
                    var newBoardTile = BoardTiles.First(x => x.Position == newPosition);
                    player.MovePlayer(BoardArray, newBoardTile);









                }
            }
            
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
                playerList.Add(player);
            }
            PlayerList = playerList;
        }

    }
}
