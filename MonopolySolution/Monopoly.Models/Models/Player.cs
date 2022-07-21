using Monopoly.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Models.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        Dictionary<int, (int x, int y)> BoardTilePosition = new Dictionary<int, (int, int)>();
        public BoardTile CurrentBoardTile { get; set; }
        public List<BoardTile> OwnedTiles { get; set;}
        public int Balance { get; set; }
        public Random Random { get; set; }
        public int RandomSeed { get; set; }

        public Player()
        {
            BuildTileToBaordPositionDictionary();
        }

        public void BuyProperty(BoardTile boardTile)
        {
            Balance -= boardTile.Price;
            OwnedTiles.Add(boardTile);
        }

        public void MovePlayer(string[,] boardArray, BoardTile newBoardTile)
        {
            Logger.Log($"Player {PlayerId}, Moving from {CurrentBoardTile.Name}:{CurrentBoardTile.Position} to {newBoardTile.Name}:{newBoardTile.Position}");

            string resetTile = "[ ]";

            var currentBoardPosition = BoardTilePosition[CurrentBoardTile.Position];
            boardArray[currentBoardPosition.x, currentBoardPosition.y] = resetTile;
            
            var newBoardPosition = BoardTilePosition[newBoardTile.Position];
            boardArray[newBoardPosition.x, newBoardPosition.y] = "[x]";

            CurrentBoardTile = newBoardTile;
        }

        public int RollDice()
        {
            if (Random == null)
                Random = new Random(RandomSeed);

            var rollOne = Random.Next(1,6);
            var rollTwo = Random.Next(1,6);
            return rollOne + rollTwo;
        }

        private void BuildTileToBaordPositionDictionary()
        {
            BoardTilePosition.Add(0,  (9, 9));
            BoardTilePosition.Add(1,  (9, 8));
            BoardTilePosition.Add(2,  (9, 7));
            BoardTilePosition.Add(3,  (9, 6));
            BoardTilePosition.Add(4,  (9, 5));
            BoardTilePosition.Add(5,  (9, 4));
            BoardTilePosition.Add(6,  (9, 3));
            BoardTilePosition.Add(7,  (9, 2));
            BoardTilePosition.Add(8,  (9, 1));
            BoardTilePosition.Add(9,  (9, 0));
            BoardTilePosition.Add(10, (8, 0));
            BoardTilePosition.Add(11, (7, 0));
            BoardTilePosition.Add(12, (6, 0));
            BoardTilePosition.Add(13, (5, 0));
            BoardTilePosition.Add(14, (4, 0));
            BoardTilePosition.Add(15, (3, 0));
            BoardTilePosition.Add(16, (2, 0));
            BoardTilePosition.Add(17, (1, 0));
            BoardTilePosition.Add(18, (0, 0));
            BoardTilePosition.Add(19, (0, 1));
            BoardTilePosition.Add(20, (0, 2));
            BoardTilePosition.Add(21, (0, 3));
            BoardTilePosition.Add(22, (0, 4));
            BoardTilePosition.Add(23, (0, 5));
            BoardTilePosition.Add(24, (0, 6));
            BoardTilePosition.Add(25, (0, 7));
            BoardTilePosition.Add(26, (0, 8));
            BoardTilePosition.Add(27, (0, 9));
            BoardTilePosition.Add(28, (1, 9));
            BoardTilePosition.Add(29, (2, 9));
            BoardTilePosition.Add(30, (3, 9));
            BoardTilePosition.Add(31, (4, 9));
            BoardTilePosition.Add(32, (5, 9));
            BoardTilePosition.Add(33, (6, 9));
            BoardTilePosition.Add(34, (7, 9));
            BoardTilePosition.Add(35, (8, 9));
        }

    }
}
