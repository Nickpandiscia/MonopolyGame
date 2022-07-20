using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Models.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Effect { get; set; }

        public override string ToString()
        {
            return $"{Name} {Tag} {Type} {Description} {Effect} {Category} {Id}";
        }
    }
}
