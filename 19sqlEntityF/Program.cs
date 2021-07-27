using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19sqlEntityF
{
    class Program
    {
        static void Main(string[] args)
        {

            using (MyDbContext context = new MyDbContext())
            {


                Sport sport = new Sport()
                {

                    Name = "Football",
                    MinPlayersQuantity = 11,


                };

                context.Sports.Add(sport);
                context.SaveChanges();

                List<Team> teams = new List<Team>()
                {
                    new Team() {  Name = "FirstT", PlayersQuantity = 10, SportID = sport.ID },
                    new Team() {  Name = "SecondT", PlayersQuantity = 11, SportID = sport.ID },
                    new Team() {  Name = "ThirdT", PlayersQuantity = 12, SportID = sport.ID }

                };

                context.Teams.AddRange(teams);
                context.SaveChanges();



                foreach (var team in teams)
                {
                    Console.WriteLine($"Sport name: {team.Sport.Name}, Team name: {team.Name}, Player in the team: {team.PlayersQuantity}, Minimal players needed: {team.Sport.MinPlayersQuantity}.");
                }

                var s = context.Teams.Where(x => x.PlayersQuantity < sport.MinPlayersQuantity);
                foreach (var ss in s)
                {
                    ss.PlayersQuantity = 666;
                }
                context.SaveChanges();

                Console.WriteLine("Changed ...");
                foreach (var team in teams)
                {
                    Console.WriteLine($"Sport name: {team.Sport.Name}, Team name: {team.Name}, Player in the team: {team.PlayersQuantity}, Minimal players needed: {team.Sport.MinPlayersQuantity}.");
                }



                var lastN = context.Teams
                       .OrderByDescending(g => g.ID)
                       .Take(2);

                context.Teams.RemoveRange(lastN);

                context.SaveChanges();

                Console.WriteLine("Last 2 removed");

                foreach (var team in teams)
                {
                    Console.WriteLine($"Sport name: {team.Sport?.Name}, Team name: {team.Name}, Player in the team: {team.PlayersQuantity}, Minimal players needed: {team.Sport?.MinPlayersQuantity}.");
                }


                Console.ReadLine();


            }

        }
    }
}
