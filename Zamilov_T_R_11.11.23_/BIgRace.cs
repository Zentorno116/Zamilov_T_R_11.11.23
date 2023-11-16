using System.Collections.Generic;

namespace Homework_9
{
    class BigRace
    {
        private List<Team> teams;

        public BigRace()
        {
            teams = new List<Team>();
        }

        public void AddTeam(Team team)
        {
            teams.Add(team);
        }

        public void TeamPlayGames()
        {
            foreach (var team in teams)
            {
                team.PlayGame();
            }
        }
    }
}