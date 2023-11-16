using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamilov_T_R_11._11._23_
{
    class CustomGame : IGame
    {
        private readonly string customGameName;
        private IGame customGame;

        public CustomGame(IGame customGame, string customGameName)
        {
            this.customGame = customGame;
            this.customGameName = customGameName;
        }

        public void PlayGame()
        {
            Console.WriteLine($"{customGameName}");
        }
    }
}
