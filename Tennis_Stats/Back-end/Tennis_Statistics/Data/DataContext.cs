using Microsoft.EntityFrameworkCore;
using Tennis_Statistics.Model;

namespace Tennis_Statistics.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Level> Levels { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<MatchDetail> MatchesDetail { get; set; }
        public DbSet<MatchDetailOther> MatchesDetailOther { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Surface> Surfaces { get; set; }
        public DbSet<Tournaments> Tournaments { get; set; }
        public DbSet<Week> Weeks { get; set; }

    }
}
