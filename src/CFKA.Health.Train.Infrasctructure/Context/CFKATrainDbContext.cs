using CFKA.Health.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace CFKA.Health.Infrastructure.Context
{
    public class CFKATrainDbContext : DbContext
    {
        public CFKATrainDbContext(DbContextOptions<CFKATrainDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Muscle>().HasData(new List<Muscle>()
            {
                #region Chest

                new()
                {
                    Name = "Upper Chest",
                    MainMuscle = EMuscle.Chest
                },
                new()
                {
                    Name = "Lower Chest",
                    MainMuscle = EMuscle.Chest
                }

                #endregion
            });
        }

        #region Db Sets

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Muscle> Muscles { get; set; }

        #endregion
    }

}
