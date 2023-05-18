using CFKA.Health.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace CFKA.Health.Infrastructure.Context;

public class CFKATrainDbContext : DbContext
{
    public CFKATrainDbContext(DbContextOptions<CFKATrainDbContext> options) : base(options)
    {
    }

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

        modelBuilder.Entity<Muscle>().HasData(new List<Muscle>
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

        modelBuilder.Entity<Exercise>().HasData(new List<Exercise>
        {
            #region Exercises

            #region Chest

            #region Upper Chest

            new()
            {
                Name = "Incline Bench Press",
                MuscleId = upperChest.Id
            },
            new()
            {
                Name = "Incline Bench Press with Dumbbells",
                MuscleId = upperChest.Id
            },
            new()
            {
                Name = "Low Pulley Crossover",
                MuscleId = upperChest.Id
            },
            new()
            {
                Name = "Incline Dumbbell Flyes",
                MuscleId = upperChest.Id
            },
            new()
            {
                Name = "Incline Push-Ups",
                MuscleId = upperChest.Id
            },

            #endregion

            #region Middle Chest

            new()
            {
                Name = "Bench Press",
                MuscleId = middleChest.Id
            },
            new()
            {
                Name = "Bench Press with Dumbbells",
                MuscleId = middleChest.Id
            },
            new()
            {
                Name = "Pulley Crossover",
                MuscleId = middleChest.Id
            },
            new()
            {
                Name = "Machine Crossover",
                MuscleId = middleChest.Id
            },
            new()
            {
                Name = "Push-Up",
                MuscleId = middleChest.Id
            },
            new()
            {
                Name = "Dumbbell Bench Press",
                MuscleId = middleChest.Id
            },
            new()
            {
                Name = "Chest Press Machine",
                MuscleId = middleChest.Id
            },
            new()
            {
                Name = "Dips",
                MuscleId = middleChest.Id
            },
            new()
            {
                Name = "Cable Chest Press",
                MuscleId = middleChest.Id
            },

            #endregion

            #region Lower Chest

            new()
            {
                Name = "Decline Bench Press",
                MuscleId = lowerChest.Id
            },
            new()
            {
                Name = "Decline Bench Press with Dumbbells",
                MuscleId = lowerChest.Id
            },
            new()
            {
                Name = "High Pulley Crossover",
                MuscleId = lowerChest.Id
            },
            new()
            {
                Name = "Decline Dumbbell Flyes",
                MuscleId = lowerChest.Id
            },
            new()
            {
                Name = "Decline Push-Ups",
                MuscleId = lowerChest.Id
            },

            #endregion

            #endregion

            #region Back

            #region Trapezius

            new()
            {
                Name = "Barbell high row",
                MuscleId = trapezius.Id
            },
            new()
            {
                Name = "Dumbbells high row",
                MuscleId = trapezius.Id
            },
            new()
            {
                Name = "Shoulder shrugs",
                MuscleId = trapezius.Id
            },
            new()
            {
                Name = "Trapeze raises",
                MuscleId = trapezius.Id
            },
            new()
            {
                Name = "Face pulls",
                MuscleId = trapezius.Id
            },
            new()
            {
                Name = "Upright rows",
                MuscleId = trapezius.Id
            },
            new()
            {
                Name = "Power cleans",
                MuscleId = trapezius.Id
            },
            new()
            {
                Name = "T-bar rows",
                MuscleId = trapezius.Id
            },
            new()
            {
                Name = "Pull-ups",
                MuscleId = trapezius.Id
            },
            new()
            {
                Name = "Lat pulldowns",
                MuscleId = trapezius.Id
            },
            new()
            {
                Name = "Dumbbell Shrugs",
                MuscleId = trapezius.Id
            },
            new()
            {
                Name = "Bent-Over Lateral Raises",
                MuscleId = trapezius.Id
            },
            new()
            {
                Name = "Kettlebell Swings",
                MuscleId = trapezius.Id
            },
            new()
            {
                Name = "Arnold Press",
                MuscleId = trapezius.Id
            },
            new()
            {
                Name = "Prone Y Raises",
                MuscleId = trapezius.Id
            },

            #endregion

            #region Lats

            new()
            {
                Name = "Front Pulley",
                MuscleId = lats.Id
            },
            new()
            {
                Name = "Back Pulley",
                MuscleId = lats.Id
            },
            new()
            {
                Name = "Bent-over row",
                MuscleId = lats.Id
            },
            new()
            {
                Name = "Pull-ups",
                MuscleId = lats.Id
            },
            new()
            {
                Name = "Lat pulldowns",
                MuscleId = lats.Id
            },
            new()
            {
                Name = "Seated cable rows",
                MuscleId = lats.Id
            },
            new()
            {
                Name = "Wide grip pull-ups",
                MuscleId = lats.Id
            },
            new()
            {
                Name = "Inverted rows",
                MuscleId = lats.Id
            },
            new()
            {
                Name = "Straight arm pulldowns",
                MuscleId = lats.Id
            },
            new()
            {
                Name = "Single-arm dumbbell rows",
                MuscleId = lats.Id
            },
            new()
            {
                Name = "Barbell Rows",
                MuscleId = lats.Id
            },
            new()
            {
                Name = "Close-grip Pulldowns",
                MuscleId = lats.Id
            },
            new()
            {
                Name = "Underhand Cable Pulldowns",
                MuscleId = lats.Id
            },
            new()
            {
                Name = "Seated Row Machine",
                MuscleId = lats.Id
            },
            new()
            {
                Name = "Wide Grip Cable Rows",
                MuscleId = lats.Id
            },

            #endregion

            #region Low Back

            new()
            {
                Name = "Hyperextensions",
                MuscleId = lowBack.Id
            },
            new()
            {
                Name = "Deadlifts",
                MuscleId = lowBack.Id
            },
            new()
            {
                Name = "Good mornings",
                MuscleId = lowBack.Id
            },
            new()
            {
                Name = "Supermans",
                MuscleId = lowBack.Id
            },
            new()
            {
                Name = "Back extensions",
                MuscleId = lowBack.Id
            },
            new()
            {
                Name = "Romanian deadlifts",
                MuscleId = lowBack.Id
            },
            new()
            {
                Name = "Reverse hypers",
                MuscleId = lowBack.Id
            },
            new()
            {
                Name = "Bird dogs",
                MuscleId = lowBack.Id
            },
            new()
            {
                Name = "Russian twists",
                MuscleId = lowBack.Id
            },
            new()
            {
                Name = "Plank variations",
                MuscleId = lowBack.Id
            },
            new()
            {
                Name = "Seated Good Mornings",
                MuscleId = lowBack.Id
            },
            new()
            {
                Name = "Prone Back Extensions",
                MuscleId = lowBack.Id
            },
            new()
            {
                Name = "Seated Cable Hyperextensions",
                MuscleId = lowBack.Id
            },
            new()
            {
                Name = "Kettlebell Swings",
                MuscleId = lowBack.Id
            },
            new()
            {
                Name = "Reverse Hyper Machine",
                MuscleId = lowBack.Id
            },

            #endregion

            #endregion

            #region Biceps

    #region Brachialis

    new()
    {
        Name = "Barbell curls",
        MuscleId = brachialis.Id
    },
    new()
    {
        Name = "Dumbbell Hammer curls",
        MuscleId = brachialis.Id
    },
    new()
    {
        Name = "Preacher Hammer curls",
        MuscleId = brachialis.Id
    },
    new()
    {
        Name = "Cable Hammer curls",
        MuscleId = brachialis.Id
    },
    new()
    {
        Name = "Incline Hammer curls",
        MuscleId = brachialis.Id
    },

    #endregion

    #region Brachioradialis

    new()
    {
        Name = "Hammer curls",
        MuscleId = brachioradialis.Id
    },
    new()
    {
        Name = "Reverse curls",
        MuscleId = brachioradialis.Id
    },
    new()
    {
        Name = "Wrist curls",
        MuscleId = brachioradialis.Id
    },
    new()
    {
        Name = "Zottman curls",
        MuscleId = brachioradialis.Id
    },
    new()
    {
        Name = "EZ bar reverse curls",
        MuscleId = brachioradialis.Id
    },

    #endregion

    #region BicepsBrachii

    new()
    {
        Name = "Dumbbell curls",
        MuscleId = bicepsBrachii.Id
    },
    new()
    {
        Name = "Preacher curls",
        MuscleId = bicepsBrachii.Id
    },
    new()
    {
        Name = "Concentration curls",
        MuscleId = bicepsBrachii.Id
    },
    new()
    {
        Name = "EZ bar curls",
        MuscleId = bicepsBrachii.Id
    },
    new()
    {
        Name = "Incline dumbbell curls",
        MuscleId = bicepsBrachii.Id
    },
    new()
    {
        Name = "Cable curls",
        MuscleId = bicepsBrachii.Id
    },
    new()
    {
        Name = "Spider curls",
        MuscleId = bicepsBrachii.Id
    },
    new()
    {
        Name = "Chin-ups",
        MuscleId = bicepsBrachii.Id
    },
    new()
    {
        Name = "Seated Dumbbell curls",
        MuscleId = bicepsBrachii.Id
    },
    new()
    {
        Name = "Hammer Strength curls",
        MuscleId = bicepsBrachii.Id
    },
    new()
    {
        Name = "Machine curls",
        MuscleId = bicepsBrachii.Id
    },
    new()
    {
        Name = "Close-grip Chin-ups",
        MuscleId = bicepsBrachii.Id
    },
    new()
    {
        Name = "Preacher Hammer curls",
        MuscleId = bicepsBrachii.Id
    },

    #endregion

            #endregion

            #region Triceps

            #region Long Head of Triceps

            new()
            {
                Name = "Close grip bench press",
                MuscleId = longHeadOfTriceps.Id
            },
            new()
            {
                Name = "Dips",
                MuscleId = longHeadOfTriceps.Id
            },
            new()
            {
                Name = "Diamond push-ups",
                MuscleId = longHeadOfTriceps.Id
            },
            new()
            {
                Name = "Overhead dumbbell extension",
                MuscleId = longHeadOfTriceps.Id
            },
            new()
            {
                Name = "Reverse grip triceps pushdown",
                MuscleId = longHeadOfTriceps.Id
            },

            #endregion

            #region Medial Head Of Triceps

            new()
            {
                Name = "Triceps pushdown",
                MuscleId = medialHeadOfTriceps.Id
            },
            new()
            {
                Name = "Triceps kickbacks",
                MuscleId = medialHeadOfTriceps.Id
            },
            new()
            {
                Name = "Triceps rope pushdown",
                MuscleId = medialHeadOfTriceps.Id
            },
            new()
            {
                Name = "Close grip push-ups",
                MuscleId = medialHeadOfTriceps.Id
            },
            new()
            {
                Name = "Bench dips",
                MuscleId = medialHeadOfTriceps.Id
            },

            #endregion

            #region Lateral Head of Triceps

            new()
            {
                Name = "Overhead triceps extension",
                MuscleId = lateralHeadOfTriceps.Id
            },
            new()
            {
                Name = "Skull crushers",
                MuscleId = lateralHeadOfTriceps.Id
            },
            new()
            {
                Name = "Bench dips",
                MuscleId = lateralHeadOfTriceps.Id
            },
            new()
            {
                Name = "Overhead cable triceps extension",
                MuscleId = lateralHeadOfTriceps.Id
            },
            new()
            {
                Name = "Dumbbell triceps kickbacks",
                MuscleId = lateralHeadOfTriceps.Id
            },

            #endregion

            #endregion

            #region Abs

            #region Upper Abs

            new()
            {
                Name = "Crunches",
                MuscleId = upperAbs.Id
            },
            new()
            {
                Name = "Plank",
                MuscleId = upperAbs.Id
            },
            new()
            {
                Name = "Sit-ups",
                MuscleId = upperAbs.Id
            },
            new()
            {
                Name = "Mountain climbers",
                MuscleId = upperAbs.Id
            },
            new()
            {
                Name = "Ab wheel rollouts",
                MuscleId = upperAbs.Id
            },

            #endregion

            #region Lower Abs

            new()
            {
                Name = "Leg raises",
                MuscleId = lowerAbs.Id
            },
            new()
            {
                Name = "Hanging knee raises",
                MuscleId = lowerAbs.Id
            },
            new()
            {
                Name = "Reverse crunches",
                MuscleId = lowerAbs.Id
            },
            new()
            {
                Name = "Scissor kicks",
                MuscleId = lowerAbs.Id
            },
            new()
            {
                Name = "Captain's chair leg raises",
                MuscleId = lowerAbs.Id
            },

            #endregion

            #region Obliques

            new()
            {
                Name = "Russian twists",
                MuscleId = obliques.Id
            },
            new()
            {
                Name = "Side plank",
                MuscleId = obliques.Id
            },
            new()
            {
                Name = "Bicycle crunches",
                MuscleId = obliques.Id
            },
            new()
            {
                Name = "Woodchoppers",
                MuscleId = obliques.Id
            },
            new()
            {
                Name = "Standing oblique crunches",
                MuscleId = obliques.Id
            },

            #endregion

            #endregion

            #region Calves

            #region Upper Calf

            new()
            {
                Name = "Standing calf raises",
                MuscleId = upperCalf.Id
            },
            new()
            {
                Name = "Donkey calf raises",
                MuscleId = upperCalf.Id
            },
            new()
            {
                Name = "Calf press on leg press machine",
                MuscleId = upperCalf.Id
            },
            new()
            {
                Name = "Skipping rope",
                MuscleId = upperCalf.Id
            },
            new()
            {
                Name = "Jump rope calf jumps",
                MuscleId = upperCalf.Id
            },

            #endregion

            #region Lower Calf

            new()
            {
                Name = "Seated calf raises",
                MuscleId = lowerCalf.Id
            },
            new()
            {
                Name = "Single-leg calf raises",
                MuscleId = lowerCalf.Id
            },
            new()
            {
                Name = "Calf raises on a step",
                MuscleId = lowerCalf.Id
            },
            new()
            {
                Name = "Sled pushes",
                MuscleId = lowerCalf.Id
            },
            new()
            {
                Name = "Calf raises with resistance bands",
                MuscleId = lowerCalf.Id
            },

            #endregion

            #region Tibialis Anterior

            new()
            {
                Name = "Toe raises",
                MuscleId = tibialisAnterior.Id
            },
            new()
            {
                Name = "Box jumps",
                MuscleId = tibialisAnterior.Id
            },
            new()
            {
                Name = "Ankle dorsiflexion with resistance band",
                MuscleId = tibialisAnterior.Id
            },
            new()
            {
                Name = "Treadmill incline walks",
                MuscleId = tibialisAnterior.Id
            },

            #endregion

            #endregion

            #region Quadriceps

            #region Vastus Lateralis

            new()
            {
                Name = "Squats",
                MuscleId = vastusLateralis.Id
            },
            new()
            {
                Name = "Step-ups",
                MuscleId = vastusLateralis.Id
            },
            new()
            {
                Name = "Front squats",
                MuscleId = vastusLateralis.Id
            },
            new()
            {
                Name = "Wall sits",
                MuscleId = vastusLateralis.Id
            },
            new()
            {
                Name = "Leg press",
                MuscleId = vastusLateralis.Id
            },

            #endregion

            #region Vastus Medialis

            new()
            {
                Name = "Lunges",
                MuscleId = vastusMedialis.Id
            },
            new()
            {
                Name = "Hack squats",
                MuscleId = vastusMedialis.Id
            },
            new()
            {
                Name = "Leg extensions",
                MuscleId = vastusMedialis.Id
            },
            new()
            {
                Name = "Leg press",
                MuscleId = vastusMedialis.Id
            },
            new()
            {
                Name = "Leg press with feet high",
                MuscleId = vastusMedialis.Id
            },

            #endregion

            #region Rectus Femoris

            new()
            {
                Name = "Leg press",
                MuscleId = rectusFemoris.Id
            },
            new()
            {
                Name = "Bulgarian split squats",
                MuscleId = rectusFemoris.Id
            },
            new()
            {
                Name = "Pistol squats",
                MuscleId = rectusFemoris.Id
            },
            new()
            {
                Name = "Lunges",
                MuscleId = rectusFemoris.Id
            },
            new()
            {
                Name = "Leg extensions",
                MuscleId = rectusFemoris.Id
            },

            #endregion

            #endregion

            #region Glutes

            #region Gluteus Maximus

            new()
            {
                Name = "Hip thrusts",
                MuscleId = gluteusMaximus.Id
            },
            new()
            {
                Name = "Donkey kicks",
                MuscleId = gluteusMaximus.Id
            },
            new()
            {
                Name = "Sumo squats",
                MuscleId = gluteusMaximus.Id
            },
            new()
            {
                Name = "Kickbacks",
                MuscleId = gluteusMaximus.Id
            },
            new()
            {
                Name = "Bulgarian split squats",
                MuscleId = gluteusMaximus.Id
            },

            #endregion

            #region Gluteus Medius

            new()
            {
                Name = "Clamshell exercises",
                MuscleId = gluteusMedius.Id
            },
            new()
            {
                Name = "Fire hydrants",
                MuscleId = gluteusMedius.Id
            },
            new()
            {
                Name = "Side-lying leg lifts",
                MuscleId = gluteusMedius.Id
            },
            new()
            {
                Name = "Lateral band walks",
                MuscleId = gluteusMedius.Id
            },

            #endregion

            #region Gluteus Minimus

            new()
            {
                Name = "Glute bridges",
                MuscleId = gluteusMinimus.Id
            },
            new()
            {
                Name = "Single-leg hip thrusts",
                MuscleId = gluteusMinimus.Id
            },
            new()
            {
                Name = "Banded crab walks",
                MuscleId = gluteusMinimus.Id
            },
            new()
            {
                Name = "Reverse lunges",
                MuscleId = gluteusMinimus.Id
            },

            #endregion

            #endregion

            #region Forearms

            #region Wrist Flexors

            new()
            {
                Name = "Wrist curls",
                MuscleId = wristFlexors.Id
            },
            new()
            {
                Name = "Plate curls",
                MuscleId = wristFlexors.Id
            },
            new()
            {
                Name = "Pinch grip holds",
                MuscleId = wristFlexors.Id
            },
            new()
            {
                Name = "Finger curls",
                MuscleId = wristFlexors.Id
            },
            new()
            {
                Name = "Dumbbell wrist pronation/supination",
                MuscleId = wristFlexors.Id
            },

            #endregion

            #region Wrist Extensors

            new()
            {
                Name = "Reverse wrist curls",
                MuscleId = wristExtensors.Id
            },
            new()
            {
                Name = "Hammer grip curls",
                MuscleId = wristExtensors.Id
            },
            new()
            {
                Name = "Bar hangs",
                MuscleId = wristExtensors.Id
            },
            new()
            {
                Name = "Wrist roller",
                MuscleId = wristExtensors.Id
            },

            #endregion

            #region Grip

            new()
            {
                Name = "Grip strengthener exercises",
                MuscleId = grip.Id
            },
            new()
            {
                Name = "Towel hangs",
                MuscleId = grip.Id
            },
            new()
            {
                Name = "Farmer's walks",
                MuscleId = grip.Id
            },
            new()
            {
                Name = "Plate pinches",
                MuscleId = grip.Id
            },

            #endregion

            #endregion

            #endregion
        });
    }

    #region Db Sets

    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<Muscle> Muscles { get; set; }

    #endregion
}