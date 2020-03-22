using System.Data.Entity;

namespace AdoNetEFCoreBenchmark.Models
{
    public class SportContext : DbContext
    {
        public SportContext()
            : base("Data Source=.;Initial Catalog=Sports;Integrated Security=True;")
        {
        }

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Sport> Sports { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sport>()
                .HasMany(e => e.Teams)
                .WithRequired(e => e.Sport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Players)
                .WithRequired(e => e.Team)
                .WillCascadeOnDelete(false);
        }
    }
}
