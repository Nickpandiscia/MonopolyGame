using Monopoly.Engine;
using Monopoly.Engine.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(var card in GameManager.Instance.Cards)
            {
                Console.WriteLine(card.ToString());
            }
            foreach(var tile in GameManager.Instance.BoardTiles)
            {
                Console.WriteLine(tile.ToString());
            }
            Console.ReadLine();
        }
    }
}
