using CsvHelper;
using Monopoly.Models.Models;
using System;
using System.Collections.Generic;

namespace Monopoly.Engine
{
    public class GameEngineBase
    {
        public Tools.CsvParser CsvParser { get; set; }
        public List<Card> Cards { get; set; }
        public List<BoardTile> BoardTiles { get; set; }

        public string[,] BoardArray = new string[10, 10] {
                                            {"[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"} ,
                                            {"[ ]", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "[ ]"} ,
                                            {"[ ]", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "[ ]"} ,
                                            {"[ ]", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "[ ]"} ,
                                            {"[ ]", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "[ ]"} ,
                                            {"[ ]", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "[ ]"} ,
                                            {"[ ]", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "[ ]"} ,
                                            {"[ ]", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "[ ]"} ,
                                            {"[ ]", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "[ ]"} ,
                                            {"[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"}
                                            };

        public GameEngineBase()
        {
            CsvParser = new Tools.CsvParser();
            PopulateCards();
            PopulateBoardTiles();
        }

        private void PrintBoard()
        {
            for (int i = 0; i < 10; i++)
            {
                string line = "";
                for (int j = 0; j < 10; j++)
                {
                    line += this.BoardArray[i, j] + " ";
                }
                Console.WriteLine(line);
                Console.WriteLine(" ");
            }
        }

        public void PopulateCards()
        {
            Cards = CsvParser.ParseCards();
        }

        public void PopulateBoardTiles()
        {
            BoardTiles = CsvParser.ParseBoardTiles();
        }
    }
}
