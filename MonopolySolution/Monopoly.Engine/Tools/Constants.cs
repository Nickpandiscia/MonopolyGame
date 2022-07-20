using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Engine.Tools
{
    public static class Constants
    {
        // C:\Users\Steven\Desktop\Monopoly\MonopolyGame\MonopolySolution
        public readonly static string RelativePath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        // C:\Users\Steven\Desktop\Monopoly\MonopolyGame\MonopolySolution\Monopoly.Models\DataFiles\BoardTiles.csv
        public readonly static string BoardTilePath = $"{RelativePath}\\Monopoly.Models\\DataFiles\\BoardTiles.csv";
        
        // C:\Users\Steven\Desktop\Monopoly\MonopolyGame\MonopolySolution\Monopoly.Models\DataFiles\Cards.csv
        public readonly static string CardPath = $"{RelativePath}\\Monopoly.Models\\DataFiles\\Cards.csv";

        // D:\Monopoly\MonopolySolution\Monopoly.Engine\Logs\Logs.txt
        public readonly static string LogPath = $"{RelativePath}\\Monopoly.Engine\\Logs\\Logs.txt";


    }
}
