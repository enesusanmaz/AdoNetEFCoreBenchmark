﻿using System;
using System.Collections.Generic;

namespace AdoNetEFCoreBenchmark.DTOs
{
    public class TeamDTO
    {
        public int Id { get; set; }
        public int SportId { get; set; }
        public string Name { get; set; }
        public DateTime FoundingDate { get; set; }

        public List<PlayerDTO> Players { get; set; }
    }
}
