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
            Console.WriteLine(Constants.RelativePath);
            Console.WriteLine(Constants.BoardTilePath);
            Console.WriteLine(Constants.CardPath);

            Console.ReadLine();
        }
    }
}
