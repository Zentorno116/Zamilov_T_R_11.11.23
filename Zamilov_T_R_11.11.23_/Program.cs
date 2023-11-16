using System;
using System.Collections.Generic;
using Zamilov_T_R_11._11._23_;
namespace Zamilov_T_R_11._11._23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>() {
                new Team("Россия"),
                new Team("Франция"),
                new Team("Китай"),
                new Team("Казахстан")
        };

            teams[0].AddGames(new Games.Mousetrap());
            teams[0].AddGames(new Games.Fishing());
            teams[0].AddGames(new Games.Sea());
            teams[0].AddGames(new CustomGame(new Games.Beach(), "Новая пляжная игра"));
            teams[0].AddGames(new CustomGame(new Games.Slide(), "Новая игра в горки"));
            teams[0].AddGames(new CustomGame(new Games.Postmen(), "Новая игра почтальонов"));

            teams[1].AddGames(new Games.Beach());
            teams[1].AddGames(new Games.Fishing());
            teams[1].AddGames(new Games.Sea());
            teams[1].AddGames(new Games.Postmen());
            teams[1].AddGames(new Games.Slide());
            teams[1].AddGames(new Games.Mousetrap());

            teams[2].AddGames(new Games.Fishing());
            teams[2].AddGames(new Games.Slide());
            teams[2].AddGames(new Games.Mousetrap());
            teams[2].AddGames(new Games.Beach());
            teams[2].AddGames(new CustomGame(new Games.Sea(), "Новая морская игра"));
            teams[2].AddGames(new CustomGame(new Games.Postmen(), "Новая игра почтальонов"));

            teams[3].AddGames(new Games.Fishing());
            teams[3].AddGames(new Games.Slide());
            teams[3].AddGames(new Games.Mousetrap());
            teams[3].AddGames(new Games.Beach());
            teams[3].AddGames(new CustomGame(new Games.Fishing(), "Новая рыбалка"));
            teams[3].AddGames(new CustomGame(new Games.Postmen(), "Новая игра почтальонов"));

            BigRace bigRace = new BigRace();
            bigRace.AddTeam(teams[0]);
            bigRace.AddTeam(teams[1]);
            bigRace.AddTeam(teams[2]);
            bigRace.AddTeam(teams[3]);
            bigRace.TeamPlayGames();
        }
    }
}