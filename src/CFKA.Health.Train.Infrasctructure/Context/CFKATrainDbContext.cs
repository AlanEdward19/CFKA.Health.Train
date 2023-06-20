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

        #region Shoulder

        Muscle frontDeltoids = new()
        {
            Id = 28,
            EnName = "Front Deltoids",
            PtName = "Deltoides Frontais",
            MainMuscle = EMuscle.Shoulder
        };

        Muscle sideDeltoids = new()
        {
            Id = 29,
            EnName = "Side Deltoids",
            PtName = "Deltoides Laterais",
            MainMuscle = EMuscle.Shoulder
        };

        Muscle rearDeltoids = new()
        {
            Id = 30,
            EnName = "Rear Deltoids",
            PtName = "Deltoides Posteriores",
            MainMuscle = EMuscle.Shoulder
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

            wristFlexors, wristExtensors, grip,

            frontDeltoids, sideDeltoids, rearDeltoids

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
                PtName = "Supino inclinado",
                MuscleId = upperChest.Id
            },
            new()
            {
                Id = 2,
                EnName = "Incline Bench Press with Dumbbells",
                PtName = "Supino inclinado com halteres",
                MuscleId = upperChest.Id
            },
            new()
            {
                Id = 3,
                EnName = "Low Pulley Crossover",
                PtName = "Crucifixo na polia baixa",
                MuscleId = upperChest.Id
            },
            new()
            {
                Id = 4,
                EnName = "Incline Dumbbell Flyes",
                PtName = "Crucifixo inclinado com halteres",
                MuscleId = upperChest.Id
            },
            new()
            {
                Id = 5,
                EnName = "Incline Push-Ups",
                PtName = "Flexao inclinado",
                MuscleId = upperChest.Id
            },

            #endregion

            #region Middle Chest

            new()
            {
                Id = 6,
                EnName = "Bench Press",
                PtName = "Supino reto",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 7,
                EnName = "Bench Press with Dumbbells",
                PtName = "Supino reto com halteres",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 8,
                EnName = "Pulley Crossover",
                PtName = "Crucifixo na polia reto",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 9,
                EnName = "Machine Crossover",
                PtName = "Crucifixo na maquina",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 10,
                EnName = "Push-Up",
                PtName = "Flexao",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 11,
                EnName = "Dumbbell Bench Press",
                PtName = "Supino reto com halteres",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 12,
                EnName = "Chest Press Machine",
                PtName = "Supino reto na maquina",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 13,
                EnName = "Dips",
                PtName = "Mergulho",
                MuscleId = middleChest.Id
            },
            new()
            {
                Id = 14,
                EnName = "Cable Chest Press",
                PtName = "Supino com cabo",
                MuscleId = middleChest.Id
            },

            #endregion

            #region Lower Chest

            new()
            {
                Id = 15,
                PtName = "Supino declinado",
                EnName = "Decline Bench Press",
                MuscleId = lowerChest.Id
            },
            new()
            {
                Id = 16,
                PtName = "Supino declinado com halteres",
                EnName = "Decline Bench Press with Dumbbells",
                MuscleId = lowerChest.Id
            },
            new()
            {
                Id = 17,
                PtName = "Crucifixo na polia alta",
                EnName = "High Pulley Crossover",
                MuscleId = lowerChest.Id
            },
            new()
            {
                Id = 18,
                PtName = "Crucifixo declinado com halteres",
                EnName = "Decline Dumbbell Flyes",
                MuscleId = lowerChest.Id
            },
            new()
            {
                Id = 19,
                PtName = "Flexao declinado",
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
                PtName = "Remada alta com barra",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 21,
                EnName = "Dumbbells high row",
                PtName = "Remada alta com halteres",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 22,
                EnName = "Shoulder shrugs",
                PtName = "Encolhimento de ombros",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 23,
                EnName = "Trapeze raises",
                PtName = "Elevação de trapézio",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 24,
                EnName = "Face pulls",
                PtName = "Puxada de rosto",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 25,
                EnName = "Upright rows",
                PtName = "Elevação frontal",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 26,
                EnName = "Power cleans",
                PtName = "Arranco",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 27,
                EnName = "T-bar rows",
                PtName = "Remada cavalinho",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 28,
                EnName = "Pull-ups",
                PtName = "Barra fixa",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 29,
                EnName = "Lat pulldowns",
                PtName = "Puxada alta",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 30,
                EnName = "Dumbbell Shrugs",
                PtName = "Encolhimento de ombros com halteres",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 31,
                EnName = "Bent-Over Lateral Raises",
                PtName = "Elevação lateral inclinado",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 32,
                EnName = "Kettlebell Swings",
                PtName = "Balanço de kettlebell",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 33,
                EnName = "Arnold Press",
                PtName = "Arnold Press",
                MuscleId = trapezius.Id
            },
            new()
            {
                Id = 34,
                EnName = "Prone Y Raises",
                PtName = "Elevação de Y pronada",
                MuscleId = trapezius.Id
            },

            #endregion

            #region Lats

            new()
            {
                Id = 35,
                EnName = "Front Pulley",
                PtName = "Pulley frontal",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 36,
                EnName = "Back Pulley",
                PtName = "Pulley traseiro",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 37,
                EnName = "Bent-over row",
                PtName = "Remada curvada",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 38,
                EnName = "Pull-ups",
                PtName = "Barra fixa",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 39,
                EnName = "Lat pulldowns",
                PtName = "Puxada alta",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 40,
                EnName = "Seated cable rows",
                PtName = "Remada sentada com cabo",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 41,
                EnName = "Wide grip pull-ups",
                PtName = "Barra fixa com pegada ampla",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 42,
                EnName = "Inverted rows",
                PtName = "Remada invertida",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 43,
                EnName = "Straight arm pulldowns",
                PtName = "Puxada alta com braços estendidos",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 44,
                EnName = "Single-arm dumbbell rows",
                PtName = "Remada unilateral com halteres",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 45,
                EnName = "Barbell Rows",
                PtName = "Remada com barra",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 46,
                EnName = "Close-grip Pulldowns",
                PtName = "Puxada alta com pegada fechada",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 47,
                EnName = "Underhand Cable Pulldowns",
                PtName = "Puxada alta com pegada invertida",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 48,
                EnName = "Seated Row Machine",
                PtName = "Remada sentada na máquina",
                MuscleId = lats.Id
            },
            new()
            {
                Id = 49,
                EnName = "Wide Grip Cable Rows",
                PtName = "Remada com cabo e pegada ampla",
                MuscleId = lats.Id
            },

            #endregion

            #region Low Back

            new()
            {
                Id = 50,
                EnName = "Hyperextensions",
                PtName = "Hiperextensões",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 51,
                EnName = "Deadlifts",
                PtName = "Levantamento terra",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 52,
                EnName = "Good mornings",
                PtName = "Bom dia",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 53,
                EnName = "Supermans",
                PtName = "Super-homens",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 54,
                EnName = "Back extensions",
                PtName = "Extensões de costas",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 55,
                EnName = "Romanian deadlifts",
                PtName = "Levantamento terra romeno",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 56,
                EnName = "Reverse hypers",
                PtName = "Hiperextensões reversas",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 57,
                EnName = "Bird dogs",
                PtName = "Cachorros de caça",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 58,
                EnName = "Russian twists",
                PtName = "Torções russas",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 59,
                EnName = "Plank variations",
                PtName = "Variações de prancha",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 60,
                EnName = "Seated Good Mornings",
                PtName = "Bom dia sentado",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 61,
                EnName = "Prone Back Extensions",
                PtName = "Extensões de costas prono",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 62,
                EnName = "Seated Cable Hyperextensions",
                PtName = "Hiperextensões com cabo sentado",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 63,
                EnName = "Kettlebell Swings",
                PtName = "Balanços com kettlebell",
                MuscleId = lowBack.Id
            },
            new()
            {
                Id = 64,
                EnName = "Reverse Hyper Machine",
                PtName = "Máquina de hiperextensões reversas",
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
                PtName = "Rosca direta com barra",
                MuscleId = brachialis.Id
            },
            new()
            {
                Id = 66,
                EnName = "Dumbbell Hammer curls",
                PtName = "Rosca martelo com halteres",
                MuscleId = brachialis.Id
            },
            new()
            {
                Id = 67,
                EnName = "Preacher Hammer curls",
                PtName = "Rosca martelo no banco scott",
                MuscleId = brachialis.Id
            },
            new()
            {
                Id = 68,
                EnName = "Cable Hammer curls",
                PtName = "Rosca martelo com cabo",
                MuscleId = brachialis.Id
            },
            new()
            {
                Id = 69,
                EnName = "Incline Hammer curls",
                PtName = "Rosca martelo inclinada",
                MuscleId = brachialis.Id
            },

            #endregion

            #region Brachioradialis

            new()
            {
                Id = 70,
                EnName = "Hammer curls",
                PtName = "Rosca martelo",
                MuscleId = brachioradialis.Id
            },
            new()
            {
                Id = 71,
                EnName = "Reverse curls",
                PtName = "Rosca inversa",
                MuscleId = brachioradialis.Id
            },
            new()
            {
                Id = 72,
                EnName = "Wrist curls",
                PtName = "Rosca de punho",
                MuscleId = brachioradialis.Id
            },
            new()
            {
                Id = 73,
                EnName = "Zottman curls",
                PtName = "Rosca Zottman",
                MuscleId = brachioradialis.Id
            },
            new()
            {
                Id = 74,
                EnName = "EZ bar reverse curls",
                PtName = "Rosca inversa com barra EZ",
                MuscleId = brachioradialis.Id
            },

            #endregion

            #region BicepsBrachii

            new()
            {
                Id = 75,
                EnName = "Dumbbell curls",
                PtName = "Rosca alternada com halteres",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 76,
                EnName = "Preacher curls",
                PtName = "Rosca no banco scott",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 77,
                EnName = "Concentration curls",
                PtName = "Rosca concentrada",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 78,
                EnName = "EZ bar curls",
                PtName = "Rosca direta com barra EZ",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 79,
                EnName = "Incline dumbbell curls",
                PtName = "Rosca inclinada com halteres",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 80,
                EnName = "Cable curls",
                PtName = "Rosca com cabo",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 81,
                EnName = "Spider curls",
                PtName = "Rosca aranha",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 82,
                EnName = "Chin-ups",
                PtName = "Barra fixa",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 83,
                EnName = "Seated Dumbbell curls",
                PtName = "Rosca alternada sentado",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 84,
                EnName = "Hammer Strength curls",
                PtName = "Rosca Hammer Strength",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 85,
                EnName = "Machine curls",
                PtName = "Rosca na máquina",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 86,
                EnName = "Close-grip Chin-ups",
                PtName = "Barra fixa pegada fechada",
                MuscleId = bicepsBrachii.Id
            },
            new()
            {
                Id = 87,
                EnName = "Preacher Hammer curls",
                PtName = "Rosca martelo no banco scott",
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
                PtName = "Supino pegada fechada",
                MuscleId = longHeadOfTriceps.Id
            },
            new()
            {
                Id = 89,
                EnName = "Dips",
                PtName = "Paralelas",
                MuscleId = longHeadOfTriceps.Id
            },
            new()
            {
                Id = 90,
                EnName = "Diamond push-ups",
                PtName = "Flexão diamante",
                MuscleId = longHeadOfTriceps.Id
            },
            new()
            {
                Id = 91,
                EnName = "Overhead dumbbell extension",
                PtName = "Extensão de tríceps com halter acima da cabeça",
                MuscleId = longHeadOfTriceps.Id
            },
            new()
            {
                Id = 92,
                EnName = "Reverse grip triceps pushdown",
                PtName = "Tríceps pulldown com pegada invertida",
                MuscleId = longHeadOfTriceps.Id
            },

            #endregion

            #region Medial Head of Triceps

            new()
            {
                Id = 93,
                EnName = "Triceps pushdown",
                PtName = "Tríceps pulldown",
                MuscleId = medialHeadOfTriceps.Id
            },
            new()
            {
                Id = 94,
                EnName = "Triceps kickbacks",
                PtName = "Tríceps kickback",
                MuscleId = medialHeadOfTriceps.Id
            },
            new()
            {
                Id = 95,
                EnName = "Triceps rope pushdown",
                PtName = "Tríceps pulldown com corda",
                MuscleId = medialHeadOfTriceps.Id
            },
            new()
            {
                Id = 96,
                EnName = "Close grip push-ups",
                PtName = "Flexão de braço pegada fechada",
                MuscleId = medialHeadOfTriceps.Id
            },
            new()
            {
                Id = 97,
                EnName = "Bench dips",
                PtName = "Mergulho de banco",
                MuscleId = medialHeadOfTriceps.Id
            },

            #endregion

            #region Lateral Head of Triceps

            new()
            {
                Id = 98,
                EnName = "Overhead triceps extension",
                PtName = "Extensão de tríceps acima da cabeça",
                MuscleId = lateralHeadOfTriceps.Id
            },
            new()
            {
                Id = 99,
                EnName = "Skull crushers",
                PtName = "Crucifixo invertido",
                MuscleId = lateralHeadOfTriceps.Id
            },
            new()
            {
                Id = 100,
                EnName = "Bench dips",
                PtName = "Mergulho de banco",
                MuscleId = lateralHeadOfTriceps.Id
            },
            new()
            {
                Id = 101,
                EnName = "Overhead cable triceps extension",
                PtName = "Extensão de tríceps com cabo acima da cabeça",
                MuscleId = lateralHeadOfTriceps.Id
            },
            new()
            {
                Id = 102,
                EnName = "Dumbbell triceps kickbacks",
                PtName = "Tríceps kickback com halteres",
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
                PtName = "Abdominais",
                MuscleId = upperAbs.Id
            },
            new()
            {
                Id = 104,
                EnName = "Plank",
                PtName = "Prancha",
                MuscleId = upperAbs.Id
            },
            new()
            {
                Id = 105,
                EnName = "Sit-ups",
                PtName = "Flexões de tronco",
                MuscleId = upperAbs.Id
            },
            new()
            {
                Id = 106,
                EnName = "Mountain climbers",
                PtName = "Montanhistas",
                MuscleId = upperAbs.Id
            },
            new()
            {
                Id = 107,
                EnName = "Ab wheel rollouts",
                PtName = "Extensões de abdômen com roda",
                MuscleId = upperAbs.Id
            },

            #endregion

            #region Lower Abs

            new()
            {
                Id = 108,
                EnName = "Leg raises",
                PtName = "Elevação de pernas",
                MuscleId = lowerAbs.Id
            },
            new()
            {
                Id = 109,
                EnName = "Hanging knee raises",
                PtName = "Elevação de joelhos suspensa",
                MuscleId = lowerAbs.Id
            },
            new()
            {
                Id = 110,
                EnName = "Reverse crunches",
                PtName = "Crunches invertidos",
                MuscleId = lowerAbs.Id
            },
            new()
            {
                Id = 111,
                EnName = "Scissor kicks",
                PtName = "Tesoura",
                MuscleId = lowerAbs.Id
            },
            new()
            {
                Id = 112,
                EnName = "Captain's chair leg raises",
                PtName = "Elevação de pernas na cadeira romana",
                MuscleId = lowerAbs.Id
            },

            #endregion

            #region Obliques

            new()
            {
                Id = 113,
                EnName = "Russian twists",
                PtName = "Torções russas",
                MuscleId = obliques.Id
            },
            new()
            {
                Id = 114,
                EnName = "Side plank",
                PtName = "Prancha lateral",
                MuscleId = obliques.Id
            },
            new()
            {
                Id = 115,
                EnName = "Bicycle crunches",
                PtName = "Abdominais de bicicleta",
                MuscleId = obliques.Id
            },
            new()
            {
                Id = 116,
                EnName = "Woodchoppers",
                PtName = "Cortadores de lenha",
                MuscleId = obliques.Id
            },
            new()
            {
                Id = 117,
                EnName = "Standing oblique crunches",
                PtName = "Abdominais oblíquos em pé",
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
                PtName = "Elevação de panturrilha em pé",
                MuscleId = upperCalf.Id
            },
            new()
            {
                Id = 119,
                EnName = "Donkey calf raises",
                PtName = "Elevação de panturrilha no aparelho burro",
                MuscleId = upperCalf.Id
            },
            new()
            {
                Id = 120,
                EnName = "Calf press on leg press machine",
                PtName = "Pressão de panturrilha no aparelho de leg press",
                MuscleId = upperCalf.Id
            },
            new()
            {
                Id = 121,
                EnName = "Skipping rope",
                PtName = "Pular corda",
                MuscleId = upperCalf.Id
            },
            new()
            {
                Id = 122,
                EnName = "Jump rope calf jumps",
                PtName = "Saltos de panturrilha com corda",
                MuscleId = upperCalf.Id
            },

            #endregion

            #region Lower Calf

            new()
            {
                Id = 123,
                EnName = "Seated calf raises",
                PtName = "Elevação de panturrilha sentado",
                MuscleId = lowerCalf.Id
            },
            new()
            {
                Id = 124,
                EnName = "Single-leg calf raises",
                PtName = "Elevação de panturrilha em uma perna",
                MuscleId = lowerCalf.Id
            },
            new()
            {
                Id = 125,
                EnName = "Calf raises on a step",
                PtName = "Elevação de panturrilha em um degrau",
                MuscleId = lowerCalf.Id
            },
            new()
            {
                Id = 126,
                EnName = "Sled pushes",
                PtName = "Empurrões com trenó",
                MuscleId = lowerCalf.Id
            },
            new()
            {
                Id = 127,
                EnName = "Calf raises with resistance bands",
                PtName = "Elevação de panturrilha com faixas de resistência",
                MuscleId = lowerCalf.Id
            },

            #endregion

            #region Tibialis Anterior

            new()
            {
                Id = 128,
                EnName = "Toe raises",
                PtName = "Elevação de ponta de pé",
                MuscleId = tibialisAnterior.Id
            },
            new()
            {
                Id = 129,
                EnName = "Box jumps",
                PtName = "Saltos em caixa",
                MuscleId = tibialisAnterior.Id
            },
            new()
            {
                Id = 130,
                EnName = "Ankle dorsiflexion with resistance band",
                PtName = "Dorsiflexão de tornozelo com faixa de resistência",
                MuscleId = tibialisAnterior.Id
            },
            new()
            {
                Id = 131,
                EnName = "Treadmill incline walks",
                PtName = "Caminhadas em esteira inclinada",
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
                PtName = "Agachamentos",
                MuscleId = vastusLateralis.Id
            },
            new()
            {
                Id = 133,
                EnName = "Step-ups",
                PtName = "Elevação de perna",
                MuscleId = vastusLateralis.Id
            },
            new()
            {
                Id = 134,
                EnName = "Front squats",
                PtName = "Agachamentos frontais",
                MuscleId = vastusLateralis.Id
            },
            new()
            {
                Id = 135,
                EnName = "Wall sits",
                PtName = "Agachamento estático",
                MuscleId = vastusLateralis.Id
            },
            new()
            {
                Id = 136,
                EnName = "Leg press",
                PtName = "Pressão de pernas",
                MuscleId = vastusLateralis.Id
            },

            #endregion

            #region Vastus Medialis

            new()
            {
                Id = 137,
                EnName = "Lunges",
                PtName = "Avanço",
                MuscleId = vastusMedialis.Id
            },
            new()
            {
                Id = 138,
                EnName = "Hack squats",
                PtName = "Agachamentos hack",
                MuscleId = vastusMedialis.Id
            },
            new()
            {
                Id = 139,
                EnName = "Leg extensions",
                PtName = "Extensões de pernas",
                MuscleId = vastusMedialis.Id
            },
            new()
            {
                Id = 140,
                EnName = "Leg press",
                PtName = "Pressão de pernas",
                MuscleId = vastusMedialis.Id
            },
            new()
            {
                Id = 141,
                EnName = "Leg press with feet high",
                PtName = "Pressão de pernas com os pés elevados",
                MuscleId = vastusMedialis.Id
            },

            #endregion

            #region Rectus Femoris

            new()
            {
                Id = 142,
                EnName = "Leg press",
                PtName = "Pressão de pernas",
                MuscleId = rectusFemoris.Id
            },
            new()
            {
                Id = 143,
                EnName = "Bulgarian split squats",
                PtName = "Agachamentos búlgaros",
                MuscleId = rectusFemoris.Id
            },
            new()
            {
                Id = 144,
                EnName = "Pistol squats",
                PtName = "Agachamentos pistol",
                MuscleId = rectusFemoris.Id
            },
            new()
            {
                Id = 145,
                EnName = "Lunges",
                PtName = "Avanço",
                MuscleId = rectusFemoris.Id
            },
            new()
            {
                Id = 146,
                EnName = "Leg extensions",
                PtName = "Extensões de pernas",
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
                PtName = "Levantamento de quadril",
                MuscleId = gluteusMaximus.Id
            },
            new()
            {
                Id = 148,
                EnName = "Donkey kicks",
                PtName = "Chutes de burro",
                MuscleId = gluteusMaximus.Id
            },
            new()
            {
                Id = 149,
                EnName = "Sumo squats",
                PtName = "Agachamentos sumo",
                MuscleId = gluteusMaximus.Id
            },
            new()
            {
                Id = 150,
                EnName = "Kickbacks",
                PtName = "Extensões de perna",
                MuscleId = gluteusMaximus.Id
            },
            new()
            {
                Id = 151,
                EnName = "Bulgarian split squats",
                PtName = "Agachamentos búlgaros",
                MuscleId = gluteusMaximus.Id
            },

            #endregion

            #region Gluteus Medius

            new()
            {
                Id = 152,
                EnName = "Clamshell exercises",
                PtName = "Exercícios de conchinha",
                MuscleId = gluteusMedius.Id
            },
            new()
            {
                Id = 153,
                EnName = "Fire hydrants",
                PtName = "Hidrantes",
                MuscleId = gluteusMedius.Id
            },
            new()
            {
                Id = 154,
                EnName = "Side-lying leg lifts",
                PtName = "Elevações de perna deitado de lado",
                MuscleId = gluteusMedius.Id
            },
            new()
            {
                Id = 155,
                EnName = "Lateral band walks",
                PtName = "Caminhadas laterais com banda",
                MuscleId = gluteusMedius.Id
            },

            #endregion

            #region Gluteus Minimus

            new()
            {
                Id = 156,
                EnName = "Glute bridges",
                PtName = "Ponte de glúteo",
                MuscleId = gluteusMinimus.Id
            },
            new()
            {
                Id = 157,
                EnName = "Single-leg hip thrusts",
                PtName = "Levantamento de quadril com uma perna",
                MuscleId = gluteusMinimus.Id
            },
            new()
            {
                Id = 158,
                EnName = "Banded crab walks",
                PtName = "Caminhadas de caranguejo com banda",
                MuscleId = gluteusMinimus.Id
            },
            new()
            {
                Id = 159,
                EnName = "Reverse lunges",
                PtName = "Avanço reverso",
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
                PtName = "Flexões de pulso",
                MuscleId = wristFlexors.Id
            },
            new()
            {
                Id = 161,
                EnName = "Plate curls",
                PtName = "Cachos com placa",
                MuscleId = wristFlexors.Id
            },
            new()
            {
                Id = 162,
                EnName = "Pinch grip holds",
                PtName = "Agarre de pinça",
                MuscleId = wristFlexors.Id
            },
            new()
            {
                Id = 163,
                EnName = "Finger curls",
                PtName = "Cachos de dedos",
                MuscleId = wristFlexors.Id
            },
            new()
            {
                Id = 164,
                EnName = "Dumbbell wrist pronation/supination",
                PtName = "Pronação/supinação de pulso com halteres",
                MuscleId = wristFlexors.Id
            },

            #endregion

            #region Wrist Extensors

            new()
            {
                Id = 165,
                EnName = "Reverse wrist curls",
                PtName = "Flexões reversas de pulso",
                MuscleId = wristExtensors.Id
            },
            new()
            {
                Id = 166,
                EnName = "Hammer grip curls",
                PtName = "Cachos com pegada de martelo",
                MuscleId = wristExtensors.Id
            },
            new()
            {
                Id = 167,
                EnName = "Bar hangs",
                PtName = "Pendurar na barra",
                MuscleId = wristExtensors.Id
            },
            new()
            {
                Id = 168,
                EnName = "Wrist roller",
                PtName = "Rolo de pulso",
                MuscleId = wristExtensors.Id
            },

            #endregion

            #region Grip

            new()
            {
                Id = 169,
                EnName = "Grip strengthener exercises",
                PtName = "Exercícios para fortalecer o agarre",
                MuscleId = grip.Id
            },
            new()
            {
                Id = 170,
                EnName = "Towel hangs",
                PtName = "Pendurar com toalha",
                MuscleId = grip.Id
            },
            new()
            {
                Id = 171,
                EnName = "Farmer's walks",
                PtName = "Caminhadas de fazendeiro",
                MuscleId = grip.Id
            },
            new()
            {
                Id = 172,
                EnName = "Plate pinches",
                PtName = "Apertar de pratos",
                MuscleId = grip.Id
            },

            #endregion

            #endregion

            #region Shoulders

            #region Front Deltoids

            new()
            {
                Id = 173,
                EnName = "Military Press",
                PtName = "Desenvolvimento Militar",
                MuscleId = frontDeltoids.Id
            },
            new()
            {
                Id = 174,
                EnName = "Arnold Press",
                PtName = "Arnold Press",
                MuscleId = frontDeltoids.Id
            },
            new()
            {
                Id = 175,
                EnName = "Front Dumbbell Raise",
                PtName = "Elevação frontal com halteres",
                MuscleId = frontDeltoids.Id
            },
            new()
            {
                Id = 176,
                EnName = "Barbell Front Raise",
                PtName = "Elevação frontal com barra",
                MuscleId = frontDeltoids.Id
            },
            new()
            {
                Id = 177,
                EnName = "Cable Front Raise",
                PtName = "Elevação frontal com cabo",
                MuscleId = frontDeltoids.Id
            },

            #endregion

            #region Side Deltoids

            new()
            {
                Id = 178,
                EnName = "Lateral Raises",
                PtName = "Elevação lateral",
                MuscleId = sideDeltoids.Id
            },
            new()
            {
                Id = 179,
                EnName = "Dumbbell Lateral Raises",
                PtName = "Elevação lateral com halteres",
                MuscleId = sideDeltoids.Id
            },
            new()
            {
                Id = 180,
                EnName = "Cable Lateral Raises",
                PtName = "Elevação lateral com cabo",
                MuscleId = sideDeltoids.Id
            },
            new()
            {
                Id = 181,
                EnName = "Machine Lateral Raises",
                PtName = "Elevação lateral na máquina",
                MuscleId = sideDeltoids.Id
            },
            new()
            {
                Id = 182,
                EnName = "Bent-Over Lateral Raises",
                PtName = "Elevação lateral inclinada",
                MuscleId = sideDeltoids.Id
            },

            #endregion

            #region Rear Deltoids

            new()
            {
                Id = 183,
                EnName = "Rear Deltoid Flyes",
                PtName = "Flyes para deltoides posteriores",
                MuscleId = rearDeltoids.Id
            },
            new()
            {
                Id = 184,
                EnName = "Bent-Over Rear Deltoid Raises",
                PtName = "Elevação de deltoides posteriores inclinado",
                MuscleId = rearDeltoids.Id
            },
            new()
            {
                Id = 185,
                EnName = "Cable Rear Deltoid Flyes",
                PtName = "Flyes para deltoides posteriores com cabo",
                MuscleId = rearDeltoids.Id
            },
            new()
            {
                Id = 186,
                EnName = "Reverse Pec Deck Flyes",
                PtName = "Flyes inversos no peck deck",
                MuscleId = rearDeltoids.Id
            },
            new()
            {
                Id = 187,
                EnName = "Face Pulls",
                PtName = "Face Pulls",
                MuscleId = rearDeltoids.Id
            }

            #endregion

            #endregion

            #endregion
        });
    }

    #region Db Sets

    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<Muscle> Muscles { get; set; }
    public DbSet<TrainingExercise> TrainingExercises { get; set; }
    public DbSet<Training> Trainings { get; set; }  

    #endregion
}