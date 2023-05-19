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
            Id = 1,
            Name = "Upper Chest",
            MainMuscle = EMuscle.Chest
        };

        Muscle middleChest = new()
        {
            Id = 2,
            Name = "Middle Chest",
            MainMuscle = EMuscle.Chest
        };

        Muscle lowerChest = new()
        {
            Id = 3,
            Name = "Lower Chest",
            MainMuscle = EMuscle.Chest
        };

        #endregion

        #region Back

        Muscle trapezius = new()
        {
            Id = 4,
            Name = "Trapezius",
            MainMuscle = EMuscle.Back
        };

        Muscle lats = new()
        {
            Id = 5,
            Name = "Lats",
            MainMuscle = EMuscle.Back
        };

        Muscle lowBack = new()
        {
            Id = 6,
            Name = "Low Back",
            MainMuscle = EMuscle.Back
        };

        #endregion

        #region Biceps

        Muscle brachialis = new()
        {
            Id = 7,
            Name = "Brachialis",
            MainMuscle = EMuscle.Biceps
        };

        Muscle brachioradialis = new()
        {
            Id = 8,
            Name = "Brachioradialis",
            MainMuscle = EMuscle.Biceps
        };

        Muscle bicepsBrachii = new()
        {
            Id = 9,
            Name = "Biceps Brachii",
            MainMuscle = EMuscle.Biceps
        };

        #endregion

        #region Triceps

        Muscle longHeadOfTriceps = new()
        {
            Id = 10,
            Name = "Long Head of Triceps",
            MainMuscle = EMuscle.Triceps
        };

        Muscle medialHeadOfTriceps = new()
        {
            Id = 11,
            Name = "Medial Head of Triceps",
            MainMuscle = EMuscle.Triceps
        };

        Muscle lateralHeadOfTriceps = new()
        {
            Id = 12,
            Name = "Lateral Head of Triceps",
            MainMuscle = EMuscle.Triceps
        };

        #endregion

        #region Abs

        Muscle upperAbs = new()
        {
            Id = 13,
            Name = "Upper Abs",
            MainMuscle = EMuscle.Abs
        };

        Muscle lowerAbs = new()
        {
            Id = 14,
            Name = "Lower Abs",
            MainMuscle = EMuscle.Abs
        };

        Muscle obliques = new()
        {
            Id = 15,
            Name = "Obliques",
            MainMuscle = EMuscle.Abs
        };

        #endregion

        #region Calves

        Muscle upperCalf = new()
        {
            Id = 16,
            Name = "Gastrocnemius (Upper Calf)",
            MainMuscle = EMuscle.Calves
        };

        Muscle lowerCalf = new()
        {
            Id = 17,
            Name = "Soleus (Lower Calf)",
            MainMuscle = EMuscle.Calves
        };

        Muscle tibialisAnterior = new()
        {
            Id = 18,
            Name = "Tibialis Anterior",
            MainMuscle = EMuscle.Calves
        };

        #endregion

        #region Quadriceps

        Muscle vastusLateralis = new()
        {
            Id = 19,
            Name = "Vastus Lateralis",
            MainMuscle = EMuscle.Quadriceps
        };


        Muscle vastusMedialis = new()
        {
            Id = 20,
            Name = "Vastus Medialis",
            MainMuscle = EMuscle.Quadriceps
        };

        Muscle rectusFemoris = new()
        {
            Id = 21,
            Name = "Rectus Femoris",
            MainMuscle = EMuscle.Quadriceps
        };

        #endregion

        #region Glutes

        Muscle gluteusMaximus = new()
        {
            Id = 22,
            Name = "Gluteus Maximus",
            MainMuscle = EMuscle.Glutes
        };

        Muscle gluteusMedius = new()
        {
            Id = 23,
            Name = "Gluteus Medius",
            MainMuscle = EMuscle.Glutes
        };

        Muscle gluteusMinimus = new()
        {
            Id = 24,
            Name = "Gluteus Minimus",
            MainMuscle = EMuscle.Glutes
        };

        #endregion

        #region Forearms

        Muscle wristFlexors = new()
        {
            Id = 25,
            Name = "Wrist Flexors",
            MainMuscle = EMuscle.Forearms
        };

        Muscle wristExtensors = new()
        {
            Id = 26,
            Name = "Wrist Extensors",
            MainMuscle = EMuscle.Forearms
        };

        Muscle grip = new()
        {
            Id = 27,
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
                Id = 1,
                Name = "Incline Bench Press",
                MuscleId = upperChest.Id
            },
            new()
            {
                Id = 2,
                Name = "Incline Bench Press with Dumbbells",
                MuscleId = upperChest.Id
            },
            new()
            {
                Id = 3,
                Name = "Low Pulley Crossover",
                MuscleId = upperChest.Id
            },
            new()
            {
                Id = 4,
                Name = "Incline Dumbbell Flyes",
                MuscleId = upperChest.Id
            },
            new()
            {
                Id = 5,
                Name = "Incline Push-Ups",
                MuscleId = upperChest.Id
            },

            #endregion

            #region Middle Chest

            new()
            {
                Id = 6,
                Name = "Bench Press",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 7,
                Name = "Bench Press with Dumbbells",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 8,
                Name = "Pulley Crossover",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 9,
                Name = "Machine Crossover",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 10,
                Name = "Push-Up",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 11,
                Name = "Dumbbell Bench Press",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 12,
                Name = "Chest Press Machine",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 13,
                Name = "Dips",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 14,
                Name = "Cable Chest Press",
                MuscleId = middleChest.Id
            },

            #endregion

            #region Lower Chest

            new()
            {
                Id = 15,
                Name = "Decline Bench Press",
                MuscleId = lowerChest.Id
            },
            new()
            {
                Id = 16,
                Name = "Decline Bench Press with Dumbbells",
                MuscleId = lowerChest.Id
            },
            new()
            {
                Id = 17,
                Name = "High Pulley Crossover",
                MuscleId = lowerChest.Id
            },
            new()
            {
                Id = 18,
                Name = "Decline Dumbbell Flyes",
                MuscleId = lowerChest.Id
            },
            new()
            {
                Id = 19,
                Name = "Decline Push-Ups",
                MuscleId = lowerChest.Id
            },

            #endregion

            #endregion

            #region Back

            #region Trapezius

            new()
            {
                Id = 20,
                Name = "Barbell high row",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 21,
                Name = "Dumbbells high row",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 22,
                Name = "Shoulder shrugs",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 23,
                Name = "Trapeze raises",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 24,
                Name = "Face pulls",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 25,
                Name = "Upright rows",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 26,
                Name = "Power cleans",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 27,
                Name = "T-bar rows",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 28,
                Name = "Pull-ups",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 29,
                Name = "Lat pulldowns",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 30,
                Name = "Dumbbell Shrugs",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 31,
                Name = "Bent-Over Lateral Raises",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 32,
                Name = "Kettlebell Swings",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 33,
                Name = "Arnold Press",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 34,
                Name = "Prone Y Raises",
                MuscleId = trapezius.Id
            },

            #endregion

            #region Lats

            new()
            {
                Id = 35,
                Name = "Front Pulley",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 36,
                Name = "Back Pulley",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 37,
                Name = "Bent-over row",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 38,
                Name = "Pull-ups",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 39,
                Name = "Lat pulldowns",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 40,
                Name = "Seated cable rows",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 41,
                Name = "Wide grip pull-ups",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 42,
                Name = "Inverted rows",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 43,
                Name = "Straight arm pulldowns",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 44,
                Name = "Single-arm dumbbell rows",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 45,
                Name = "Barbell Rows",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 46,
                Name = "Close-grip Pulldowns",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 47,
                Name = "Underhand Cable Pulldowns",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 48,
                Name = "Seated Row Machine",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 49,
                Name = "Wide Grip Cable Rows",
                MuscleId = lats.Id
            },

            #endregion

            #region Low Back

            new()
            {
                Id = 50,
                Name = "Hyperextensions",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 51,
                Name = "Deadlifts",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 52,
                Name = "Good mornings",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 53,
                Name = "Supermans",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 54,
                Name = "Back extensions",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 55,
                Name = "Romanian deadlifts",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 56,
                Name = "Reverse hypers",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 57,
                Name = "Bird dogs",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 58,
                Name = "Russian twists",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 59,
                Name = "Plank variations",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 60,
                Name = "Seated Good Mornings",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 61,
                Name = "Prone Back Extensions",
                MuscleId = lowBack.Id
            },
            new()
            {

                Id = 62,
                Name = "Seated Cable Hyperextensions",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 63,
                Name = "Kettlebell Swings",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 64,
                Name = "Reverse Hyper Machine",
                MuscleId = lowBack.Id
            },

            #endregion

            #endregion

            #region Biceps

            #region Brachialis

            new()
            {
                Id = 65,
                Name = "Barbell curls",
                MuscleId = brachialis.Id
            },
            new()
            {

                Id = 66,
                Name = "Dumbbell Hammer curls",
                MuscleId = brachialis.Id
            },
            new()
            {
                Id = 67,
                Name = "Preacher Hammer curls",
                MuscleId = brachialis.Id
            },
            new()
            {
                Id = 68,
                Name = "Cable Hammer curls",
                MuscleId = brachialis.Id
            },
            new()
            {
                Id = 69,
                Name = "Incline Hammer curls",
                MuscleId = brachialis.Id
            },

            #endregion

            #region Brachioradialis

            new()
            {
                Id = 70,
                Name = "Hammer curls",
                MuscleId = brachioradialis.Id
            },
            new()
            {
                Id = 71,
                Name = "Reverse curls",
                MuscleId = brachioradialis.Id
            },
            new()
            {
                Id = 72,
                Name = "Wrist curls",
                MuscleId = brachioradialis.Id
            },
            new()
            {
                Id = 73,
                Name = "Zottman curls",
                MuscleId = brachioradialis.Id
            },
            new()
            {
                Id = 74,
                Name = "EZ bar reverse curls",
                MuscleId = brachioradialis.Id
            },

            #endregion

            #region BicepsBrachii

            new()
            {
                Id = 75,
                Name = "Dumbbell curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 76,
                Name = "Preacher curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 77,
                Name = "Concentration curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 78,
                Name = "EZ bar curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 79,
                Name = "Incline dumbbell curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 80,
                Name = "Cable curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 81,
                Name = "Spider curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 82,
                Name = "Chin-ups",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 83,
                Name = "Seated Dumbbell curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 84,
                Name = "Hammer Strength curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 85,
                Name = "Machine curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 86,
                Name = "Close-grip Chin-ups",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 87,
                Name = "Preacher Hammer curls",
                MuscleId = bicepsBrachii.Id
            },

            #endregion

            #endregion

            #region Triceps

            #region Long Head of Triceps

            new()
            {
                Id = 88,
                Name = "Close grip bench press",
                MuscleId = longHeadOfTriceps.Id
            },
            new()
            {
                Id = 89,
                Name = "Dips",
                MuscleId = longHeadOfTriceps.Id
            },
            new()
            {
                Id = 90,
                Name = "Diamond push-ups",
                MuscleId = longHeadOfTriceps.Id
            },
            new()
            {
                Id = 91,
                Name = "Overhead dumbbell extension",
                MuscleId = longHeadOfTriceps.Id
            },
            new()
            {
                Id = 92,
                Name = "Reverse grip triceps pushdown",
                MuscleId = longHeadOfTriceps.Id
            },

            #endregion

            #region Medial Head Of Triceps

            new()
            {
                Id = 93,
                Name = "Triceps pushdown",
                MuscleId = medialHeadOfTriceps.Id
            },
            new()
            {
                Id = 94,
                Name = "Triceps kickbacks",
                MuscleId = medialHeadOfTriceps.Id
            },
            new()
            {
                Id = 95,
                Name = "Triceps rope pushdown",
                MuscleId = medialHeadOfTriceps.Id
            },
            new()
            {
                Id = 96,
                Name = "Close grip push-ups",
                MuscleId = medialHeadOfTriceps.Id
            },
            new()
            {
                Id = 97,
                Name = "Bench dips",
                MuscleId = medialHeadOfTriceps.Id
            },

            #endregion

            #region Lateral Head of Triceps

            new()
            {

                Id = 98,
                Name = "Overhead triceps extension",
                MuscleId = lateralHeadOfTriceps.Id
            },
            new()
            {
                Id = 99,
                Name = "Skull crushers",
                MuscleId = lateralHeadOfTriceps.Id
            },
            new()
            {
                Id = 100,
                Name = "Bench dips",
                MuscleId = lateralHeadOfTriceps.Id
            },
            new()
            {
                Id = 101,
                Name = "Overhead cable triceps extension",
                MuscleId = lateralHeadOfTriceps.Id
            },
            new()
            {
                Id = 102,
                Name = "Dumbbell triceps kickbacks",
                MuscleId = lateralHeadOfTriceps.Id
            },

            #endregion

            #endregion

            #region Abs

            #region Upper Abs

            new()
            {
                Id = 103,
                Name = "Crunches",
                MuscleId = upperAbs.Id
            },
            new()
            {
                Id = 104,
                Name = "Plank",
                MuscleId = upperAbs.Id
            },
            new()
            {
                Id = 105,
                Name = "Sit-ups",
                MuscleId = upperAbs.Id
            },
            new()
            {
                Id = 106,
                Name = "Mountain climbers",
                MuscleId = upperAbs.Id
            },
            new()
            {
                Id = 107,
                Name = "Ab wheel rollouts",
                MuscleId = upperAbs.Id
            },

            #endregion

            #region Lower Abs

            new()
            {
                Id = 108,
                Name = "Leg raises",
                MuscleId = lowerAbs.Id
            },
            new()
            {
                Id = 109,
                Name = "Hanging knee raises",
                MuscleId = lowerAbs.Id
            },
            new()
            {
                Id = 110,
                Name = "Reverse crunches",
                MuscleId = lowerAbs.Id
            },
            new()
            {
                Id = 111,
                Name = "Scissor kicks",
                MuscleId = lowerAbs.Id
            },
            new()
            {
                Id = 112,
                Name = "Captain's chair leg raises",
                MuscleId = lowerAbs.Id
            },

            #endregion

            #region Obliques

            new()
            {
                Id = 113,
                Name = "Russian twists",
                MuscleId = obliques.Id
            },
            new()
            {
                Id = 114,
                Name = "Side plank",
                MuscleId = obliques.Id
            },
            new()
            {
                Id = 115,
                Name = "Bicycle crunches",
                MuscleId = obliques.Id
            },
            new()
            {
                Id = 116,
                Name = "Woodchoppers",
                MuscleId = obliques.Id
            },
            new()
            {
                Id = 117,
                Name = "Standing oblique crunches",
                MuscleId = obliques.Id
            },

            #endregion

            #endregion

            #region Calves

            #region Upper Calf

            new()
            {
                Id = 118,
                Name = "Standing calf raises",
                MuscleId = upperCalf.Id
            },
            new()
            {
                Id = 119,
                Name = "Donkey calf raises",
                MuscleId = upperCalf.Id
            },
            new()
            {
                Id = 120,
                Name = "Calf press on leg press machine",
                MuscleId = upperCalf.Id
            },
            new()
            {
                Id = 121,
                Name = "Skipping rope",
                MuscleId = upperCalf.Id
            },
            new()
            {
                Id = 122,
                Name = "Jump rope calf jumps",
                MuscleId = upperCalf.Id
            },

            #endregion

            #region Lower Calf

            new()
            {
                Id = 123,
                Name = "Seated calf raises",
                MuscleId = lowerCalf.Id
            },
            new()
            {
                Id = 124,
                Name = "Single-leg calf raises",
                MuscleId = lowerCalf.Id
            },
            new()
            {
                Id = 125,
                Name = "Calf raises on a step",
                MuscleId = lowerCalf.Id
            },
            new()
            {
                Id = 126,
                Name = "Sled pushes",
                MuscleId = lowerCalf.Id
            },
            new()
            {
                Id = 127,
                Name = "Calf raises with resistance bands",
                MuscleId = lowerCalf.Id
            },

            #endregion

            #region Tibialis Anterior

            new()
            {
                Id = 128,
                Name = "Toe raises",
                MuscleId = tibialisAnterior.Id
            },
            new()
            {
                Id = 129,
                Name = "Box jumps",
                MuscleId = tibialisAnterior.Id
            },
            new()
            {
                Id = 130,
                Name = "Ankle dorsiflexion with resistance band",
                MuscleId = tibialisAnterior.Id
            },
            new()
            {
                Id = 131,
                Name = "Treadmill incline walks",
                MuscleId = tibialisAnterior.Id
            },

            #endregion

            #endregion

            #region Quadriceps

            #region Vastus Lateralis

            new()
            {
                Id = 132,
                Name = "Squats",
                MuscleId = vastusLateralis.Id
            },
            new()
            {
                Id = 133,
                Name = "Step-ups",
                MuscleId = vastusLateralis.Id
            },
            new()
            {
                Id = 134,
                Name = "Front squats",
                MuscleId = vastusLateralis.Id
            },
            new()
            {
                Id = 135,
                Name = "Wall sits",
                MuscleId = vastusLateralis.Id
            },
            new()
            {
                Id = 136,
                Name = "Leg press",
                MuscleId = vastusLateralis.Id
            },

            #endregion

            #region Vastus Medialis

            new()
            {
                Id = 137,
                Name = "Lunges",
                MuscleId = vastusMedialis.Id
            },
            new()
            {
                Id = 138,
                Name = "Hack squats",
                MuscleId = vastusMedialis.Id
            },
            new()
            {
                Id = 139,
                Name = "Leg extensions",
                MuscleId = vastusMedialis.Id
            },
            new()
            {
                Id = 140,
                Name = "Leg press",
                MuscleId = vastusMedialis.Id
            },
            new()
            {
                Id = 141,
                Name = "Leg press with feet high",
                MuscleId = vastusMedialis.Id
            },

            #endregion

            #region Rectus Femoris

            new()
            {
                Id = 142,
                Name = "Leg press",
                MuscleId = rectusFemoris.Id
            },
            new()
            {
                Id = 143,
                Name = "Bulgarian split squats",
                MuscleId = rectusFemoris.Id
            },
            new()
            {
                Id = 144,
                Name = "Pistol squats",
                MuscleId = rectusFemoris.Id
            },
            new()
            {
                Id = 145,
                Name = "Lunges",
                MuscleId = rectusFemoris.Id
            },
            new()
            {
                Id = 146,
                Name = "Leg extensions",
                MuscleId = rectusFemoris.Id
            },

            #endregion

            #endregion

            #region Glutes

            #region Gluteus Maximus

            new()
            {
                Id = 147,
                Name = "Hip thrusts",
                MuscleId = gluteusMaximus.Id
            },
            new()
            {
                Id = 148,
                Name = "Donkey kicks",
                MuscleId = gluteusMaximus.Id
            },
            new()
            {
                Id = 149,
                Name = "Sumo squats",
                MuscleId = gluteusMaximus.Id
            },
            new()
            {
                Id = 150,
                Name = "Kickbacks",
                MuscleId = gluteusMaximus.Id
            },
            new()
            {
                Id = 151,
                Name = "Bulgarian split squats",
                MuscleId = gluteusMaximus.Id
            },

            #endregion

            #region Gluteus Medius

            new()
            {
                Id = 152,
                Name = "Clamshell exercises",
                MuscleId = gluteusMedius.Id
            },
            new()
            {
                Id = 153,
                Name = "Fire hydrants",
                MuscleId = gluteusMedius.Id
            },
            new()
            {
                Id = 154,
                Name = "Side-lying leg lifts",
                MuscleId = gluteusMedius.Id
            },
            new()
            {
                Id = 155,
                Name = "Lateral band walks",
                MuscleId = gluteusMedius.Id
            },

            #endregion

            #region Gluteus Minimus

            new()
            {
                Id = 156,
                Name = "Glute bridges",
                MuscleId = gluteusMinimus.Id
            },
            new()
            {
                Id = 157,
                Name = "Single-leg hip thrusts",
                MuscleId = gluteusMinimus.Id
            },
            new()
            {
                Id = 158,
                Name = "Banded crab walks",
                MuscleId = gluteusMinimus.Id
            },
            new()
            {
                Id = 159,
                Name = "Reverse lunges",
                MuscleId = gluteusMinimus.Id
            },

            #endregion

            #endregion

            #region Forearms

            #region Wrist Flexors

            new()
            {
                Id = 160,
                Name = "Wrist curls",
                MuscleId = wristFlexors.Id
            },
            new()
            {
                Id = 161,
                Name = "Plate curls",
                MuscleId = wristFlexors.Id
            },
            new()
            {
                Id = 162,
                Name = "Pinch grip holds",
                MuscleId = wristFlexors.Id
            },
            new()
            {
                Id = 163,
                Name = "Finger curls",
                MuscleId = wristFlexors.Id
            },
            new()
            {
                Id = 164,
                Name = "Dumbbell wrist pronation/supination",
                MuscleId = wristFlexors.Id
            },

            #endregion

            #region Wrist Extensors

            new()
            {
                Id = 165,
                Name = "Reverse wrist curls",
                MuscleId = wristExtensors.Id
            },
            new()
            {
                Id = 166,
                Name = "Hammer grip curls",
                MuscleId = wristExtensors.Id
            },
            new()
            {
                Id = 167,
                Name = "Bar hangs",
                MuscleId = wristExtensors.Id
            },
            new()
            {
                Id = 168,
                Name = "Wrist roller",
                MuscleId = wristExtensors.Id
            },

            #endregion

            #region Grip

            new()
            {
                Id = 169,
                Name = "Grip strengthener exercises",
                MuscleId = grip.Id
            },
            new()
            {
                Id = 170,
                Name = "Towel hangs",
                MuscleId = grip.Id
            },
            new()
            {
                Id = 171,
                Name = "Farmer's walks",
                MuscleId = grip.Id
            },
            new()
            {
                Id = 172,
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