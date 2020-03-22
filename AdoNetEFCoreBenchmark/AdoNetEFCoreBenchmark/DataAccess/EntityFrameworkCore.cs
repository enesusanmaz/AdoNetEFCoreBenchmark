using AdoNetEFCoreBenchmark.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace AdoNetEFCoreBenchmark.DataAccess
{
    public class EntityFrameworkCore : ITestSignature
    {
        public long GetPlayerByID(int id)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            using (SportContextEfCore context = new SportContextEfCore())
            {
                var player = context.Players.Find(id);
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        public long GetPlayersForTeam(int teamId)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            using (SportContextEfCore context = new SportContextEfCore())
            {
                var players = context.Players.AsNoTracking().Where(x => x.TeamId == teamId).ToList();
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        public long GetTeamsForSport(int sportId)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            using (SportContextEfCore context = new SportContextEfCore())
            {
                var players = context.Teams.AsNoTracking().Include(x => x.Players).Where(x => x.SportId == sportId).ToList();
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
    }
}
