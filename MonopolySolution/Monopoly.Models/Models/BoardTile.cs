using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Models.Models
{
    public class BoardTile
    {
        public string Name { get; set; }
        public string Space { get; set; }
        public string Color { get; set; }
        public int Position { get; set; }
        public int Price { get; set; }
        public int PriceBuild { get; set; }
        public int Rent { get; set; }
        public int RentBuild1 { get; set; }
        public int RentBuild2 { get; set; }
        public int RentBuild3 { get; set; }
        public int RentBuild4 { get; set; }
        public int RentBuild5 { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return $"{Name} {Space} {Color} {Position} {Price} {PriceBuild} {Rent} {RentBuild1} {RentBuild2} {RentBuild3} {RentBuild4} {RentBuild5} {Number}";
        }
    }
}
