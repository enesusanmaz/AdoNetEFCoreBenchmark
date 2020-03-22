using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace AdoNetEFCoreBenchmark.Models
{
    public partial class SportContextEfCore : DbContext
    {
        private static readonly string ConnectionString = "Data Source=.;Initial Catalog=Sports;Integrated Security=True;";
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Sport> Sports { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sport>()
                .HasMany(e => e.Teams);


            modelBuilder.Entity<Team>()
                .HasMany(e => e.Players);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
