using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Engine
{
    public class GameSettings
    {
        public int PlayerCount { get; set; } = 2;
        public int StartingPlayerBalance { get; set; } = 1500;
        public int StartingProperties { get; set; } = 0;
        
    }
}
