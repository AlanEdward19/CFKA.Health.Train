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
            EnName = "Upper Chest",
            PtName = "Peitoral Superior",
            MainMuscle = EMuscle.Chest
        };

        Muscle middleChest = new()
        {
            Id = 2,
            EnName = "Middle Chest",
            PtName = "Peitoral Medio",
            MainMuscle = EMuscle.Chest
        };

        Muscle lowerChest = new()
        {
            Id = 3,
            EnName = "Lower Chest",
            PtName = "Peitoral Inferior",
            MainMuscle = EMuscle.Chest
        };

        #endregion

        #region Back

        Muscle trapezius = new()
        {
            Id = 4,
            EnName = "Trapezius",
            PtName = "Trapezio",
            MainMuscle = EMuscle.Back
        };

        Muscle lats = new()
        {
            Id = 5,
            EnName = "Lats",
            PtName = "Dorsal",
            MainMuscle = EMuscle.Back
        };

        Muscle lowBack = new()
        {
            Id = 6,
            EnName = "Low Back",
            PtName = "Lombar",
            MainMuscle = EMuscle.Back
        };

        #endregion

        #region Biceps

        Muscle brachialis = new()
        {
            Id = 7,
            EnName = "Brachialis",
            PtName = "Braquial",
            MainMuscle = EMuscle.Biceps
        };

        Muscle brachioradialis = new()
        {
            Id = 8,
            EnName = "Brachioradialis",
            PtName = "Braquiorradial",
            MainMuscle = EMuscle.Biceps
        };

        Muscle bicepsBrachii = new()
        {
            Id = 9,
            EnName = "Biceps Brachii",
            PtName = "Biceps Braquial",
            MainMuscle = EMuscle.Biceps
        };

        #endregion

        #region Triceps

        Muscle longHeadOfTriceps = new()
        {
            Id = 10,
            EnName = "Long Head of Triceps",
            PtName = "Cabeça Longa do Triceps",
            MainMuscle = EMuscle.Triceps
        };

        Muscle medialHeadOfTriceps = new()
        {
            Id = 11,
            EnName = "Medial Head of Triceps",
            PtName = "Cabeça Media do Triceps",
            MainMuscle = EMuscle.Triceps
        };

        Muscle lateralHeadOfTriceps = new()
        {
            Id = 12,
            EnName = "Lateral Head of Triceps",
            PtName = "Cabeça Lateral do Triceps",
            MainMuscle = EMuscle.Triceps
        };

        #endregion

        #region Abs

        Muscle upperAbs = new()
        {
            Id = 13,
            EnName = "Upper Abs",
            PtName = "Abdominais Superiores",
            MainMuscle = EMuscle.Abs
        };

        Muscle lowerAbs = new()
        {
            Id = 14,
            EnName = "Lower Abs",
            PtName = "Abdominais Inferiores",
            MainMuscle = EMuscle.Abs
        };

        Muscle obliques = new()
        {
            Id = 15,
            EnName = "Obliques",
            PtName = "Oblíquos",
            MainMuscle = EMuscle.Abs
        };

        #endregion

        #region Calves

        Muscle upperCalf = new()
        {
            Id = 16,
            EnName = "Gastrocnemius (Upper Calf)",
            PtName = "Gastrocnêmio (Parte superior da panturrilha)",
            MainMuscle = EMuscle.Calves
        };

        Muscle lowerCalf = new()
        {
            Id = 17,
            EnName = "Soleus (Lower Calf)",
            PtName = "Sóleo (Parte inferior da panturrilha)",
            MainMuscle = EMuscle.Calves
        };

        Muscle tibialisAnterior = new()
        {
            Id = 18,
            EnName = "Tibialis Anterior",
            PtName = "Tibial Anterior",
            MainMuscle = EMuscle.Calves
        };

        #endregion

        #region Quadriceps

        Muscle vastusLateralis = new()
        {
            Id = 19,
            EnName = "Vastus Lateralis",
            PtName = "Vasto lateral",
            MainMuscle = EMuscle.Quadriceps
        };


        Muscle vastusMedialis = new()
        {
            Id = 20,
            EnName = "Vastus Medialis",
            PtName = "Vasto Medial",
            MainMuscle = EMuscle.Quadriceps
        };

        Muscle rectusFemoris = new()
        {
            Id = 21,
            EnName = "Rectus Femoris",
            PtName = "Reto Femoral",
            MainMuscle = EMuscle.Quadriceps
        };

        #endregion

        #region Glutes

        Muscle gluteusMaximus = new()
        {
            Id = 22,
            EnName = "Gluteus Maximus",
            PtName = "Gluteo Maximo",
            MainMuscle = EMuscle.Glutes
        };

        Muscle gluteusMedius = new()
        {
            Id = 23,
            EnName = "Gluteus Medius",
            PtName = "Gluteo Medio",
            MainMuscle = EMuscle.Glutes
        };

        Muscle gluteusMinimus = new()
        {
            Id = 24,
            EnName = "Gluteus Minimus",
            PtName = "Gluteo Minimo",
            MainMuscle = EMuscle.Glutes
        };

        #endregion

        #region Forearms

        Muscle wristFlexors = new()
        {
            Id = 25,
            EnName = "Wrist Flexors",
            PtName = "Flexores de Punho",
            MainMuscle = EMuscle.Forearms
        };

        Muscle wristExtensors = new()
        {
            Id = 26,
            EnName = "Wrist Extensors",
            PtName = "Extensores de Punho",
            MainMuscle = EMuscle.Forearms
        };

        Muscle grip = new()
        {
            Id = 27,
            EnName = "Grip",
            PtName = "Pegada",
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
                EnName = "Incline Bench Press",
                MuscleId = upperChest.Id
            },
            new()
            {
                Id = 2,
                EnName = "Incline Bench Press with Dumbbells",
                MuscleId = upperChest.Id
            },
            new()
            {
                Id = 3,
                EnName = "Low Pulley Crossover",
                MuscleId = upperChest.Id
            },
            new()
            {
                Id = 4,
                EnName = "Incline Dumbbell Flyes",
                MuscleId = upperChest.Id
            },
            new()
            {
                Id = 5,
                EnName = "Incline Push-Ups",
                MuscleId = upperChest.Id
            },

            #endregion

            #region Middle Chest

            new()
            {
                Id = 6,
                EnName = "Bench Press",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 7,
                EnName = "Bench Press with Dumbbells",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 8,
                EnName = "Pulley Crossover",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 9,
                EnName = "Machine Crossover",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 10,
                EnName = "Push-Up",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 11,
                EnName = "Dumbbell Bench Press",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 12,
                EnName = "Chest Press Machine",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 13,
                EnName = "Dips",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 14,
                EnName = "Cable Chest Press",
                MuscleId = middleChest.Id
            },

            #endregion

            #region Lower Chest

            new()
            {
                Id = 15,
                EnName = "Decline Bench Press",
                MuscleId = lowerChest.Id
            },
            new()
            {
                Id = 16,
                EnName = "Decline Bench Press with Dumbbells",
                MuscleId = lowerChest.Id
            },
            new()
            {
                Id = 17,
                EnName = "High Pulley Crossover",
                MuscleId = lowerChest.Id
            },
            new()
            {
                Id = 18,
                EnName = "Decline Dumbbell Flyes",
                MuscleId = lowerChest.Id
            },
            new()
            {
                Id = 19,
                EnName = "Decline Push-Ups",
                MuscleId = lowerChest.Id
            },

            #endregion

            #endregion

            #region Back

            #region Trapezius

            new()
            {
                Id = 20,
                EnName = "Barbell high row",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 21,
                EnName = "Dumbbells high row",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 22,
                EnName = "Shoulder shrugs",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 23,
                EnName = "Trapeze raises",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 24,
                EnName = "Face pulls",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 25,
                EnName = "Upright rows",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 26,
                EnName = "Power cleans",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 27,
                EnName = "T-bar rows",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 28,
                EnName = "Pull-ups",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 29,
                EnName = "Lat pulldowns",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 30,
                EnName = "Dumbbell Shrugs",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 31,
                EnName = "Bent-Over Lateral Raises",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 32,
                EnName = "Kettlebell Swings",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 33,
                EnName = "Arnold Press",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 34,
                EnName = "Prone Y Raises",
                MuscleId = trapezius.Id
            },

            #endregion

            #region Lats

            new()
            {
                Id = 35,
                EnName = "Front Pulley",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 36,
                EnName = "Back Pulley",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 37,
                EnName = "Bent-over row",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 38,
                EnName = "Pull-ups",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 39,
                EnName = "Lat pulldowns",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 40,
                EnName = "Seated cable rows",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 41,
                EnName = "Wide grip pull-ups",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 42,
                EnName = "Inverted rows",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 43,
                EnName = "Straight arm pulldowns",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 44,
                EnName = "Single-arm dumbbell rows",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 45,
                EnName = "Barbell Rows",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 46,
                EnName = "Close-grip Pulldowns",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 47,
                EnName = "Underhand Cable Pulldowns",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 48,
                EnName = "Seated Row Machine",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 49,
                EnName = "Wide Grip Cable Rows",
                MuscleId = lats.Id
            },

            #endregion

            #region Low Back

            new()
            {
                Id = 50,
                EnName = "Hyperextensions",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 51,
                EnName = "Deadlifts",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 52,
                EnName = "Good mornings",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 53,
                EnName = "Supermans",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 54,
                EnName = "Back extensions",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 55,
                EnName = "Romanian deadlifts",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 56,
                EnName = "Reverse hypers",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 57,
                EnName = "Bird dogs",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 58,
                EnName = "Russian twists",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 59,
                EnName = "Plank variations",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 60,
                EnName = "Seated Good Mornings",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 61,
                EnName = "Prone Back Extensions",
                MuscleId = lowBack.Id
            },
            new()
            {

                Id = 62,
                EnName = "Seated Cable Hyperextensions",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 63,
                EnName = "Kettlebell Swings",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 64,
                EnName = "Reverse Hyper Machine",
                MuscleId = lowBack.Id
            },

            #endregion

            #endregion

            #region Biceps

            #region Brachialis

            new()
            {
                Id = 65,
                EnName = "Barbell curls",
                MuscleId = brachialis.Id
            },
            new()
            {

                Id = 66,
                EnName = "Dumbbell Hammer curls",
                MuscleId = brachialis.Id
            },
            new()
            {
                Id = 67,
                EnName = "Preacher Hammer curls",
                MuscleId = brachialis.Id
            },
            new()
            {
                Id = 68,
                EnName = "Cable Hammer curls",
                MuscleId = brachialis.Id
            },
            new()
            {
                Id = 69,
                EnName = "Incline Hammer curls",
                MuscleId = brachialis.Id
            },

            #endregion

            #region Brachioradialis

            new()
            {
                Id = 70,
                EnName = "Hammer curls",
                MuscleId = brachioradialis.Id
            },
            new()
            {
                Id = 71,
                EnName = "Reverse curls",
                MuscleId = brachioradialis.Id
            },
            new()
            {
                Id = 72,
                EnName = "Wrist curls",
                MuscleId = brachioradialis.Id
            },
            new()
            {
                Id = 73,
                EnName = "Zottman curls",
                MuscleId = brachioradialis.Id
            },
            new()
            {
                Id = 74,
                EnName = "EZ bar reverse curls",
                MuscleId = brachioradialis.Id
            },

            #endregion

            #region BicepsBrachii

            new()
            {
                Id = 75,
                EnName = "Dumbbell curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 76,
                EnName = "Preacher curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 77,
                EnName = "Concentration curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 78,
                EnName = "EZ bar curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 79,
                EnName = "Incline dumbbell curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 80,
                EnName = "Cable curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 81,
                EnName = "Spider curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 82,
                EnName = "Chin-ups",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 83,
                EnName = "Seated Dumbbell curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 84,
                EnName = "Hammer Strength curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 85,
                EnName = "Machine curls",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 86,
                EnName = "Close-grip Chin-ups",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 87,
                EnName = "Preacher Hammer curls",
                MuscleId = bicepsBrachii.Id
            },

            #endregion

            #endregion

            #region Triceps

            #region Long Head of Triceps

            new()
            {
                Id = 88,
                EnName = "Close grip bench press",
                MuscleId = longHeadOfTriceps.Id
            },
            new()
            {
                Id = 89,
                EnName = "Dips",
                MuscleId = longHeadOfTriceps.Id
            },
            new()
            {
                Id = 90,
                EnName = "Diamond push-ups",
                MuscleId = longHeadOfTriceps.Id
            },
            new()
            {
                Id = 91,
                EnName = "Overhead dumbbell extension",
                MuscleId = longHeadOfTriceps.Id
            },
            new()
            {
                Id = 92,
                EnName = "Reverse grip triceps pushdown",
                MuscleId = longHeadOfTriceps.Id
            },

            #endregion

            #region Medial Head Of Triceps

            new()
            {
                Id = 93,
                EnName = "Triceps pushdown",
                MuscleId = medialHeadOfTriceps.Id
            },
            new()
            {
                Id = 94,
                EnName = "Triceps kickbacks",
                MuscleId = medialHeadOfTriceps.Id
            },
            new()
            {
                Id = 95,
                EnName = "Triceps rope pushdown",
                MuscleId = medialHeadOfTriceps.Id
            },
            new()
            {
                Id = 96,
                EnName = "Close grip push-ups",
                MuscleId = medialHeadOfTriceps.Id
            },
            new()
            {
                Id = 97,
                EnName = "Bench dips",
                MuscleId = medialHeadOfTriceps.Id
            },

            #endregion

            #region Lateral Head of Triceps

            new()
            {

                Id = 98,
                EnName = "Overhead triceps extension",
                MuscleId = lateralHeadOfTriceps.Id
            },
            new()
            {
                Id = 99,
                EnName = "Skull crushers",
                MuscleId = lateralHeadOfTriceps.Id
            },
            new()
            {
                Id = 100,
                EnName = "Bench dips",
                MuscleId = lateralHeadOfTriceps.Id
            },
            new()
            {
                Id = 101,
                EnName = "Overhead cable triceps extension",
                MuscleId = lateralHeadOfTriceps.Id
            },
            new()
            {
                Id = 102,
                EnName = "Dumbbell triceps kickbacks",
                MuscleId = lateralHeadOfTriceps.Id
            },

            #endregion

            #endregion

            #region Abs

            #region Upper Abs

            new()
            {
                Id = 103,
                EnName = "Crunches",
                MuscleId = upperAbs.Id
            },
            new()
            {
                Id = 104,
                EnName = "Plank",
                MuscleId = upperAbs.Id
            },
            new()
            {
                Id = 105,
                EnName = "Sit-ups",
                MuscleId = upperAbs.Id
            },
            new()
            {
                Id = 106,
                EnName = "Mountain climbers",
                MuscleId = upperAbs.Id
            },
            new()
            {
                Id = 107,
                EnName = "Ab wheel rollouts",
                MuscleId = upperAbs.Id
            },

            #endregion

            #region Lower Abs

            new()
            {
                Id = 108,
                EnName = "Leg raises",
                MuscleId = lowerAbs.Id
            },
            new()
            {
                Id = 109,
                EnName = "Hanging knee raises",
                MuscleId = lowerAbs.Id
            },
            new()
            {
                Id = 110,
                EnName = "Reverse crunches",
                MuscleId = lowerAbs.Id
            },
            new()
            {
                Id = 111,
                EnName = "Scissor kicks",
                MuscleId = lowerAbs.Id
            },
            new()
            {
                Id = 112,
                EnName = "Captain's chair leg raises",
                MuscleId = lowerAbs.Id
            },

            #endregion

            #region Obliques

            new()
            {
                Id = 113,
                EnName = "Russian twists",
                MuscleId = obliques.Id
            },
            new()
            {
                Id = 114,
                EnName = "Side plank",
                MuscleId = obliques.Id
            },
            new()
            {
                Id = 115,
                EnName = "Bicycle crunches",
                MuscleId = obliques.Id
            },
            new()
            {
                Id = 116,
                EnName = "Woodchoppers",
                MuscleId = obliques.Id
            },
            new()
            {
                Id = 117,
                EnName = "Standing oblique crunches",
                MuscleId = obliques.Id
            },

            #endregion

            #endregion

            #region Calves

            #region Upper Calf

            new()
            {
                Id = 118,
                EnName = "Standing calf raises",
                MuscleId = upperCalf.Id
            },
            new()
            {
                Id = 119,
                EnName = "Donkey calf raises",
                MuscleId = upperCalf.Id
            },
            new()
            {
                Id = 120,
                EnName = "Calf press on leg press machine",
                MuscleId = upperCalf.Id
            },
            new()
            {
                Id = 121,
                EnName = "Skipping rope",
                MuscleId = upperCalf.Id
            },
            new()
            {
                Id = 122,
                EnName = "Jump rope calf jumps",
                MuscleId = upperCalf.Id
            },

            #endregion

            #region Lower Calf

            new()
            {
                Id = 123,
                EnName = "Seated calf raises",
                MuscleId = lowerCalf.Id
            },
            new()
            {
                Id = 124,
                EnName = "Single-leg calf raises",
                MuscleId = lowerCalf.Id
            },
            new()
            {
                Id = 125,
                EnName = "Calf raises on a step",
                MuscleId = lowerCalf.Id
            },
            new()
            {
                Id = 126,
                EnName = "Sled pushes",
                MuscleId = lowerCalf.Id
            },
            new()
            {
                Id = 127,
                EnName = "Calf raises with resistance bands",
                MuscleId = lowerCalf.Id
            },

            #endregion

            #region Tibialis Anterior

            new()
            {
                Id = 128,
                EnName = "Toe raises",
                MuscleId = tibialisAnterior.Id
            },
            new()
            {
                Id = 129,
                EnName = "Box jumps",
                MuscleId = tibialisAnterior.Id
            },
            new()
            {
                Id = 130,
                EnName = "Ankle dorsiflexion with resistance band",
                MuscleId = tibialisAnterior.Id
            },
            new()
            {
                Id = 131,
                EnName = "Treadmill incline walks",
                MuscleId = tibialisAnterior.Id
            },

            #endregion

            #endregion

            #region Quadriceps

            #region Vastus Lateralis

            new()
            {
                Id = 132,
                EnName = "Squats",
                MuscleId = vastusLateralis.Id
            },
            new()
            {
                Id = 133,
                EnName = "Step-ups",
                MuscleId = vastusLateralis.Id
            },
            new()
            {
                Id = 134,
                EnName = "Front squats",
                MuscleId = vastusLateralis.Id
            },
            new()
            {
                Id = 135,
                EnName = "Wall sits",
                MuscleId = vastusLateralis.Id
            },
            new()
            {
                Id = 136,
                EnName = "Leg press",
                MuscleId = vastusLateralis.Id
            },

            #endregion

            #region Vastus Medialis

            new()
            {
                Id = 137,
                EnName = "Lunges",
                MuscleId = vastusMedialis.Id
            },
            new()
            {
                Id = 138,
                EnName = "Hack squats",
                MuscleId = vastusMedialis.Id
            },
            new()
            {
                Id = 139,
                EnName = "Leg extensions",
                MuscleId = vastusMedialis.Id
            },
            new()
            {
                Id = 140,
                EnName = "Leg press",
                MuscleId = vastusMedialis.Id
            },
            new()
            {
                Id = 141,
                EnName = "Leg press with feet high",
                MuscleId = vastusMedialis.Id
            },

            #endregion

            #region Rectus Femoris

            new()
            {
                Id = 142,
                EnName = "Leg press",
                MuscleId = rectusFemoris.Id
            },
            new()
            {
                Id = 143,
                EnName = "Bulgarian split squats",
                MuscleId = rectusFemoris.Id
            },
            new()
            {
                Id = 144,
                EnName = "Pistol squats",
                MuscleId = rectusFemoris.Id
            },
            new()
            {
                Id = 145,
                EnName = "Lunges",
                MuscleId = rectusFemoris.Id
            },
            new()
            {
                Id = 146,
                EnName = "Leg extensions",
                MuscleId = rectusFemoris.Id
            },

            #endregion

            #endregion

            #region Glutes

            #region Gluteus Maximus

            new()
            {
                Id = 147,
                EnName = "Hip thrusts",
                MuscleId = gluteusMaximus.Id
            },
            new()
            {
                Id = 148,
                EnName = "Donkey kicks",
                MuscleId = gluteusMaximus.Id
            },
            new()
            {
                Id = 149,
                EnName = "Sumo squats",
                MuscleId = gluteusMaximus.Id
            },
            new()
            {
                Id = 150,
                EnName = "Kickbacks",
                MuscleId = gluteusMaximus.Id
            },
            new()
            {
                Id = 151,
                EnName = "Bulgarian split squats",
                MuscleId = gluteusMaximus.Id
            },

            #endregion

            #region Gluteus Medius

            new()
            {
                Id = 152,
                EnName = "Clamshell exercises",
                MuscleId = gluteusMedius.Id
            },
            new()
            {
                Id = 153,
                EnName = "Fire hydrants",
                MuscleId = gluteusMedius.Id
            },
            new()
            {
                Id = 154,
                EnName = "Side-lying leg lifts",
                MuscleId = gluteusMedius.Id
            },
            new()
            {
                Id = 155,
                EnName = "Lateral band walks",
                MuscleId = gluteusMedius.Id
            },

            #endregion

            #region Gluteus Minimus

            new()
            {
                Id = 156,
                EnName = "Glute bridges",
                MuscleId = gluteusMinimus.Id
            },
            new()
            {
                Id = 157,
                EnName = "Single-leg hip thrusts",
                MuscleId = gluteusMinimus.Id
            },
            new()
            {
                Id = 158,
                EnName = "Banded crab walks",
                MuscleId = gluteusMinimus.Id
            },
            new()
            {
                Id = 159,
                EnName = "Reverse lunges",
                MuscleId = gluteusMinimus.Id
            },

            #endregion

            #endregion

            #region Forearms

            #region Wrist Flexors

            new()
            {
                Id = 160,
                EnName = "Wrist curls",
                MuscleId = wristFlexors.Id
            },
            new()
            {
                Id = 161,
                EnName = "Plate curls",
                MuscleId = wristFlexors.Id
            },
            new()
            {
                Id = 162,
                EnName = "Pinch grip holds",
                MuscleId = wristFlexors.Id
            },
            new()
            {
                Id = 163,
                EnName = "Finger curls",
                MuscleId = wristFlexors.Id
            },
            new()
            {
                Id = 164,
                EnName = "Dumbbell wrist pronation/supination",
                MuscleId = wristFlexors.Id
            },

            #endregion

            #region Wrist Extensors

            new()
            {
                Id = 165,
                EnName = "Reverse wrist curls",
                MuscleId = wristExtensors.Id
            },
            new()
            {
                Id = 166,
                EnName = "Hammer grip curls",
                MuscleId = wristExtensors.Id
            },
            new()
            {
                Id = 167,
                EnName = "Bar hangs",
                MuscleId = wristExtensors.Id
            },
            new()
            {
                Id = 168,
                EnName = "Wrist roller",
                MuscleId = wristExtensors.Id
            },

            #endregion

            #region Grip

            new()
            {
                Id = 169,
                EnName = "Grip strengthener exercises",
                MuscleId = grip.Id
            },
            new()
            {
                Id = 170,
                EnName = "Towel hangs",
                MuscleId = grip.Id
            },
            new()
            {
                Id = 171,
                EnName = "Farmer's walks",
                MuscleId = grip.Id
            },
            new()
            {
                Id = 172,
                EnName = "Plate pinches",
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