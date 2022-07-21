using CsvHelper;
using CsvHelper.Configuration;
using Monopoly.Core;
using Monopoly.Models.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Engine.Tools
{
    public class CsvParser
    {
        private CsvConfiguration _CsvConfig = new CsvConfiguration(CultureInfo.CurrentCulture) { HasHeaderRecord = false };



        public List<Card> ParseCards()
        {
            // C:\Users\Steven\Desktop\Monopoly\MonopolyGame\MonopolySolution\Monopoly.Models\DataFiles\BoardTiles.csv

            TextReader reader = new StreamReader(Constants.CardPath);
            var csvReader = new CsvReader(reader, _CsvConfig);
            var records = csvReader.GetRecords<Card>();

            return records.ToList();
        }

        public List<BoardTile> ParseBoardTiles()
        {
            TextReader reader = new StreamReader(Constants.BoardTilePath);
            var csvReader = new CsvReader(reader, _CsvConfig);
            var records = csvReader.GetRecords<BoardTile>();

            return records.ToList();
        }

    }
}
