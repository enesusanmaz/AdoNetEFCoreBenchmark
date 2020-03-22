using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNetEFCoreBenchmark.DataAccess
{
    public interface ITestSignature
    {
        long GetPlayerByID(int id);
        long GetPlayersForTeam(int teamID);
        long GetTeamsForSport(int sportID);
    }
}
