using Microsoft.EntityFrameworkCore;

namespace CFKA.Health.Infrastructure.Context
{
    public class CFKATrainDbContext : DbContext
    {
        public CFKATrainDbContext(DbContextOptions<CFKATrainDbContext> options) : base(options) { }

        #region Db Sets

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Muscle> Muscles { get; set; }

        #endregion
    }

}
