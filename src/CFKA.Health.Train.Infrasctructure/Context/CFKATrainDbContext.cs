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
                #region Muscles

                #region Chest

                new()
                {
                    Name = "Upper Chest",
                    MainMuscle = EMuscle.Chest
                },
                new()
                {
                    Name = "Middle Chest",
                    MainMuscle = EMuscle.Chest
                },
                new()
                {
                    Name = "Lower Chest",
                    MainMuscle = EMuscle.Chest
                },

                #endregion

                #region Back

                new()
                {
                    Name = "Trapezius",
                    MainMuscle = EMuscle.Back
                },
                new()
                {
                    Name = "Lats",
                    MainMuscle = EMuscle.Back
                },
                new()
                {
                    Name = "Low Back",
                    MainMuscle = EMuscle.Back
                },

                #endregion

                #region Biceps

                new()
                {
                    Name = "Brachialis",
                    MainMuscle = EMuscle.Biceps
                },
                new()
                {
                    Name = "Brachioradialis",
                    MainMuscle = EMuscle.Biceps
                },
                new()
                {
                    Name = "Biceps Brachii",
                    MainMuscle = EMuscle.Biceps
                },

                #endregion

                #region Triceps

                new()
                {
                    Name = "Long Head of Triceps",
                    MainMuscle = EMuscle.Triceps
                },
                new()
                {
                    Name = "Medial Head of Triceps",
                    MainMuscle = EMuscle.Triceps
                },
                new()
                {
                    Name = "Lateral Head of Triceps",
                    MainMuscle = EMuscle.Triceps
                },

                #endregion

                #region Abs

                new()
                {
                    Name = "Upper Abs",
                    MainMuscle = EMuscle.Abs
                },
                new()
                {
                    Name = "Lower Abs",
                    MainMuscle = EMuscle.Abs
                },
                new()
                {
                    Name = "Obliques",
                    MainMuscle = EMuscle.Abs
                },

                #endregion

                #region Calves

                new()
                {
                    Name = "Gastrocnemius (Upper Calf)",
                    MainMuscle = EMuscle.Calves
                },
                new()
                {
                    Name = "Soleus (Lower Calf)",
                    MainMuscle = EMuscle.Calves
                },
                new()
                {
                    Name = "Tibialis Anterior",
                    MainMuscle = EMuscle.Calves
                },

                #endregion

                #region Quadriceps

                new()
                {
                    Name = "Vastus Lateralis",
                    MainMuscle = EMuscle.Quadriceps
                },
                new()
                {
                    Name = "Vastus Medialis",
                    MainMuscle = EMuscle.Quadriceps
                },
                new()
                {
                    Name = "Rectus Femoris",
                    MainMuscle = EMuscle.Quadriceps
                },

                #endregion

                #region Glutes

                new()
                {
                    Name = "Gluteus Maximus",
                    MainMuscle = EMuscle.Glutes
                },
                new()
                {
                    Name = "Gluteus Medius",
                    MainMuscle = EMuscle.Glutes
                },
                new()
                {
                    Name = "Gluteus Minimus",
                    MainMuscle = EMuscle.Glutes
                },

                #endregion

                #region Forearms

                new()
                {
                    Name = "Wrist Flexors",
                    MainMuscle = EMuscle.Forearms
                },
                new()
                {
                    Name = "Wrist Extensors",
                    MainMuscle = EMuscle.Forearms
                },
                new()
                {
                    Name = "Grip",
                    MainMuscle = EMuscle.Forearms
                }

                #endregion

                #endregion

                #region Exercises

                

                #endregion
            });
        }

        #region Db Sets

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Muscle> Muscles { get; set; }

        #endregion
    }

}
