using Monopoly.Engine.Tools;
using Monopoly.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Engine
{
    public class GameManager
    {
        private static GameManager _Instance = null;
        public static GameManager Instance
            
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new GameManager();
                }
                return _Instance;
            }
        }
        public CsvParser CsvParser { get; set; }
        public List<Card> Cards { get; set; }
        public List<BoardTile> BoardTiles { get; set; }
        public GameEngine GameEngine { get; set; } 

        private GameManager() 
        {
            GameEngine = new GameEngine();
            CsvParser = new CsvParser();
            PopulateCards();
            PopulateBoardTiles();
        }

        public void PopulateCards()
        {
           Cards = CsvParser.ParseCards();
        }

        public void PopulateBoardTiles()
        {
            BoardTiles = CsvParser.ParseBoardTiles();
        }
        public void SetGameSettings(GameSettings gameSettings)
        {
            GameEngine.Settings = gameSettings;
        }

    }
}
