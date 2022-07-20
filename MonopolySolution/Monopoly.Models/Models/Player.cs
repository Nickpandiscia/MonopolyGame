using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Models.Models
{
    public class Player
    {
        public int Balance { get; set; }
        public List<BoardTile> OwnedTiles { get; set;}

        public void BuyProperty(BoardTile boardTile)
        {
            Balance -= boardTile.Price;
            OwnedTiles.Add(boardTile);
        }
        public int BankAmount()
        {
            return Balance;
        }

    }
}
