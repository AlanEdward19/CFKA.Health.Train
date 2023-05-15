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

            #region Chest

            Muscle upperChest = new()
            {
                Name = "Upper Chest",
                MainMuscle = EMuscle.Chest
            };

            Muscle middleChest = new()
            {
                Name = "Middle Chest",
                MainMuscle = EMuscle.Chest
            };

            Muscle lowerChest = new()
            {
                Name = "Lower Chest",
                MainMuscle = EMuscle.Chest
            };

            #endregion

            #region Back

            Muscle trapezius = new()
            {
                Name = "Trapezius",
                MainMuscle = EMuscle.Back
            };

            Muscle lats = new()
            {
                Name = "Lats",
                MainMuscle = EMuscle.Back
            };

            Muscle lowBack = new()
            {
                Name = "Low Back",
                MainMuscle = EMuscle.Back
            };

            #endregion

            #region Biceps

            Muscle brachialis = new()
            {
                Name = "Brachialis",
                MainMuscle = EMuscle.Biceps
            };

            Muscle brachioradialis = new()
            {
                Name = "Brachioradialis",
                MainMuscle = EMuscle.Biceps
            };

            Muscle bicepsBrachii = new()
            {
                Name = "Biceps Brachii",
                MainMuscle = EMuscle.Biceps
            };

            #endregion

            #region Triceps

            Muscle longHeadOfTriceps = new()
            {
                Name = "Long Head of Triceps",
                MainMuscle = EMuscle.Triceps
            };

            Muscle medialHeadOfTriceps = new()
            {
                Name = "Medial Head of Triceps",
                MainMuscle = EMuscle.Triceps
            };

            Muscle lateralHeadOfTriceps = new()
            {
                Name = "Lateral Head of Triceps",
                MainMuscle = EMuscle.Triceps
            };

            #endregion

            #region Abs

            Muscle upperAbs = new()
            {
                Name = "Upper Abs",
                MainMuscle = EMuscle.Abs
            };

            Muscle lowerAbs = new()
            {
                Name = "Lower Abs",
                MainMuscle = EMuscle.Abs
            };

            Muscle obliques = new()
            {
                Name = "Obliques",
                MainMuscle = EMuscle.Abs
            };

            #endregion

            #region Calves

            Muscle upperCalf = new()
            {
                Name = "Gastrocnemius (Upper Calf)",
                MainMuscle = EMuscle.Calves
            };

            Muscle lowerCalf = new()
            {
                Name = "Soleus (Lower Calf)",
                MainMuscle = EMuscle.Calves
            };

            Muscle tibialisAnterior = new()
            {
                Name = "Tibialis Anterior",
                MainMuscle = EMuscle.Calves
            };

            #endregion

            #region Quadriceps

            Muscle vastusLateralis = new()
            {
                Name = "Vastus Lateralis",
                MainMuscle = EMuscle.Quadriceps
            };


            Muscle vastusMedialis = new()
            {
                Name = "Vastus Medialis",
                MainMuscle = EMuscle.Quadriceps
            };

            Muscle rectusFemoris = new()
            {
                Name = "Rectus Femoris",
                MainMuscle = EMuscle.Quadriceps
            };

            #endregion

            #region Glutes

            Muscle gluteusMaximus = new()
            {
                Name = "Gluteus Maximus",
                MainMuscle = EMuscle.Glutes
            };

            Muscle gluteusMedius = new()
            {
                Name = "Gluteus Medius",
                MainMuscle = EMuscle.Glutes
            };

            Muscle gluteusMinimus = new()
            {
                Name = "Gluteus Minimus",
                MainMuscle = EMuscle.Glutes
            };

            #endregion

            #region Forearms

            Muscle wristFlexors = new()
            {
                Name = "Wrist Flexors",
                MainMuscle = EMuscle.Forearms
            };

            Muscle wristExtensors = new()
            {
                Name = "Wrist Extensors",
                MainMuscle = EMuscle.Forearms
            };

            Muscle grip = new()
            {
                Name = "Grip",
                MainMuscle = EMuscle.Forearms
            };

            #endregion

            modelBuilder.Entity<Muscle>().HasData(new List<Muscle>()
            {
                #region Muscles

                upperChest, middleChest, lowerChest,

                trapezius, lats, lowBack,

                brachialis, brachioradialis, bicepsBrachii,

                longHeadOfTriceps, medialHeadOfTriceps, lateralHeadOfTriceps,

                upperAbs, lowerAbs, obliques,

                upperCalf, lowerCalf, tibialisAnterior,

                vastusLateralis, vastusMedialis, rectusFemoris,

                gluteusMaximus, gluteusMedius, gluteusMinimus,

                wristFlexors, wristExtensors, grip

                #endregion
            });

            modelBuilder.Entity<Exercise>().HasData(new List<Exercise>()
            {
                #region Exercises

                #region Chest

                new()
                {
                    Name = "Incline Bench Press",
                    Muscle = upperChest
                },
                new()
                {
                    Name = "Incline Bench Press with Dumbbells",
                    Muscle = upperChest
                },
                new()
                {
                    Name = "Low Pulley Crossover",
                    Muscle = upperChest
                },


                new()
                {
                    Name = "Bench Press",
                    Muscle = middleChest
                },
                new()
                {
                    Name = "Bench Press with Dumbbells",
                    Muscle = middleChest
                },
                new()
                {
                    Name = "Pulley Crossover",
                    Muscle = middleChest
                },
                new()
                {
                    Name = "Machine Crossover",
                    Muscle = middleChest
                },
                new()
                {
                    Name = "Push-Up",
                    Muscle = middleChest
                },


                new()
                {
                    Name = "Decline Bench Press",
                    Muscle = lowerChest
                },
                new()
                {
                    Name = "Decline Bench Press with Dumbbells",
                    Muscle = lowerChest
                },
                new()
                {
                    Name = "High Pulley Crossover",
                    Muscle = lowerChest
                },

                #endregion

                #region Back

                new()
                {
                    Name = "",
                    Muscle = trapezius
                },

                new()
                {
                    Name = "",
                    Muscle = lats
                },

                new()
                {
                    Name = "",
                    Muscle = lowBack
                },

                #endregion

                #region Biceps

                new()
                {
                    Name = "",
                    Muscle = brachialis
                },

                new()
                {
                    Name = "",
                    Muscle = brachioradialis
                },

                new()
                {
                    Name = "",
                    Muscle = bicepsBrachii
                },

                #endregion

                #region Triceps

                new()
                {
                    Name = "",
                    Muscle = longHeadOfTriceps
                },

                new()
                {
                    Name = "",
                    Muscle = medialHeadOfTriceps
                },

                new()
                {
                    Name = "",
                    Muscle = lateralHeadOfTriceps
                },

                #endregion

                #region Abs

                new()
                {
                    Name = "",
                    Muscle = upperAbs
                },

                new()
                {
                    Name = "",
                    Muscle = lowerAbs
                },

                new()
                {
                    Name = "",
                    Muscle = obliques
                },

                #endregion

                #region Calves

                new()
                {
                    Name = "",
                    Muscle = upperCalf
                },

                new()
                {
                    Name = "",
                    Muscle = lowerCalf
                },

                new()
                {
                    Name = "",
                    Muscle = tibialisAnterior
                },

                #endregion

                #region Quadriceps

                new()
                {
                    Name = "",
                    Muscle = vastusLateralis
                },

                new()
                {
                    Name = "",
                    Muscle = vastusMedialis
                },

                new()
                {
                    Name = "",
                    Muscle = rectusFemoris
                },

                #endregion

                #region Glutes

                new()
                {
                    Name = "",
                    Muscle = gluteusMaximus
                },

                new()
                {
                    Name = "",
                    Muscle = gluteusMedius
                },

                new()
                {
                    Name = "",
                    Muscle = gluteusMinimus
                },

                #endregion

                #region Forearms

                new()
                {
                    Name = "",
                    Muscle = wristFlexors
                },

                new()
                {
                    Name = "",
                    Muscle = wristExtensors
                },

                new()
                {
                    Name = "",
                    Muscle = grip
                },

                #endregion

                #endregion
            });
        }

        #region Db Sets

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Muscle> Muscles { get; set; }

        #endregion
    }

}
