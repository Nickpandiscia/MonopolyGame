using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Engine
{
    public class GameEngine : GameEngineBase
    {
        public GameSettings Settings;

        public GameEngine(GameSettings settings)
            : base()
        {
            Settings = settings;
        }

        public void RunGame()
        {

        }

    }
}
