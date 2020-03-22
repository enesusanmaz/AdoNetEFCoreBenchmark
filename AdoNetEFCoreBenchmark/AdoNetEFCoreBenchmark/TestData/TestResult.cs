using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNetEFCoreBenchmark.TestData
{
    public class TestResult
    {
        public double PlayerByIDMilliseconds { get; set; }
        public double PlayersForTeamMilliseconds { get; set; }
        public double TeamsForSportMilliseconds { get; set; }
        public Framework Framework { get; set; }
        public int Run { get; set; }
    }

    public enum Framework
    {
        ADONET,
        EntityFrameworkCore,
        ADONetDr
    }
}
