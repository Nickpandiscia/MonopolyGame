using Monopoly.Models.Models;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

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
            foreach(var player in PlayerList)
            {
                System.Console.WriteLine($"{player}");
                
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
                playerList.Add(player);

            }
            PlayerList = playerList;
        }

    }
}
