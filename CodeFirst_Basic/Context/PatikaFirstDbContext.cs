using Microsoft.EntityFrameworkCore;
using CodeFirst_Basic.Entities; 

namespace CodeFirst_Basic.Context
{
    public class PatikaFirstDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=localhost; database=PatikaCodeFirstDb1; Trusted_Connection=true; TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<MovieEntity> Movies => Set<MovieEntity>();

        public DbSet<GameEntity> Games => Set<GameEntity>(); 
    }
}
