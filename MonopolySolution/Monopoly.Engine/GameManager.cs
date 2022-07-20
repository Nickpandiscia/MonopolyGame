using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Engine
{
    public class GameManager
    {
        private static GameManager _Instance = null;
        public static GameManager Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new GameManager();
                }
                return _Instance;
            }
        }


        private GameManager() 
        {

        }

        public void LoadData()
        {

        }

    }
}
