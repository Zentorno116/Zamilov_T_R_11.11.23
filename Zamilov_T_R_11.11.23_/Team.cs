using System;
using System.Collections.Generic;
using Zamilov_T_R_11._11._23_;

namespace Zamilov_T_R_11._11._23_
{
    class Team
    {
        private string country;
        private List<IGame> games;

        public Team(string country)
        {
            this.country = country;
            games = new List<IGame>();
        }

        public void AddGames(IGame game)
        {
            games.Add(game);
        }
        public void PlayGame()
        {
            Console.WriteLine($"{country} играет в игру: ");
            foreach (var game in games)
            {
                game.PlayGame();
            }
            Console.WriteLine();
        }
    }
}