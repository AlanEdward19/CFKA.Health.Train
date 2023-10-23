using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CFKA.Health.Train.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Muscles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainMuscle = table.Column<int>(type: "int", nullable: false),
                    EnName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PtName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muscles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    TrainerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Users_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PtName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseVideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MuscleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercises_Muscles_MuscleId",
                        column: x => x.MuscleId,
                        principalTable: "Muscles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PtName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainings_Users_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trainings_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrainingExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    Observations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainingId = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingExercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingExercises_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingExercises_Trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Muscles",
                columns: new[] { "Id", "EnName", "MainMuscle", "PtName" },
                values: new object[,]
                {
                    { 1, "Upper Chest", 0, "Peitoral Superior" },
                    { 2, "Middle Chest", 0, "Peitoral Medio" },
                    { 3, "Lower Chest", 0, "Peitoral Inferior" },
                    { 4, "Trapezius", 1, "Trapezio" },
                    { 5, "Lats", 1, "Dorsal" },
                    { 6, "Low Back", 1, "Lombar" },
                    { 7, "Brachialis", 3, "Braquial" },
                    { 8, "Brachioradialis", 3, "Braquiorradial" },
                    { 9, "Biceps Brachii", 3, "Biceps Braquial" },
                    { 10, "Long Head of Triceps", 4, "Cabeça Longa do Triceps" },
                    { 11, "Medial Head of Triceps", 4, "Cabeça Media do Triceps" },
                    { 12, "Lateral Head of Triceps", 4, "Cabeça Lateral do Triceps" },
                    { 13, "Upper Abs", 5, "Abdominais Superiores" },
                    { 14, "Lower Abs", 5, "Abdominais Inferiores" },
                    { 15, "Obliques", 5, "Oblíquos" },
                    { 16, "Gastrocnemius (Upper Calf)", 6, "Gastrocnêmio (Parte superior da panturrilha)" },
                    { 17, "Soleus (Lower Calf)", 6, "Sóleo (Parte inferior da panturrilha)" },
                    { 18, "Tibialis Anterior", 6, "Tibial Anterior" },
                    { 19, "Vastus Lateralis", 7, "Vasto lateral" },
                    { 20, "Vastus Medialis", 7, "Vasto Medial" },
                    { 21, "Rectus Femoris", 7, "Reto Femoral" },
                    { 22, "Gluteus Maximus", 8, "Gluteo Maximo" },
                    { 23, "Gluteus Medius", 8, "Gluteo Medio" },
                    { 24, "Gluteus Minimus", 8, "Gluteo Minimo" },
                    { 25, "Wrist Flexors", 9, "Flexores de Punho" },
                    { 26, "Wrist Extensors", 9, "Extensores de Punho" },
                    { 27, "Grip", 9, "Pegada" },
                    { 28, "Front Deltoids", 2, "Deltoides Frontais" },
                    { 29, "Side Deltoids", 2, "Deltoides Laterais" },
                    { 30, "Rear Deltoids", 2, "Deltoides Posteriores" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "EnName", "ExerciseVideoUrl", "MuscleId", "PtName" },
                values: new object[,]
                {
                    { 1, "Incline Bench Press", null, 1, "Supino inclinado" },
                    { 2, "Incline Bench Press with Dumbbells", null, 1, "Supino inclinado com halteres" },
                    { 3, "Low Pulley Crossover", null, 1, "Crucifixo na polia baixa" },
                    { 4, "Incline Dumbbell Flyes", null, 1, "Crucifixo inclinado com halteres" },
                    { 5, "Incline Push-Ups", null, 1, "Flexao inclinado" },
                    { 6, "Bench Press", null, 2, "Supino reto" },
                    { 7, "Bench Press with Dumbbells", null, 2, "Supino reto com halteres" },
                    { 8, "Pulley Crossover", null, 2, "Crucifixo na polia reto" },
                    { 9, "Machine Crossover", null, 2, "Crucifixo na maquina" },
                    { 10, "Push-Up", null, 2, "Flexao" },
                    { 11, "Dumbbell Bench Press", null, 2, "Supino reto com halteres" },
                    { 12, "Chest Press Machine", null, 2, "Supino reto na maquina" },
                    { 13, "Dips", null, 2, "Mergulho" },
                    { 14, "Cable Chest Press", null, 2, "Supino com cabo" },
                    { 15, "Decline Bench Press", null, 3, "Supino declinado" },
                    { 16, "Decline Bench Press with Dumbbells", null, 3, "Supino declinado com halteres" },
                    { 17, "High Pulley Crossover", null, 3, "Crucifixo na polia alta" },
                    { 18, "Decline Dumbbell Flyes", null, 3, "Crucifixo declinado com halteres" },
                    { 19, "Decline Push-Ups", null, 3, "Flexao declinado" },
                    { 20, "Barbell high row", null, 4, "Remada alta com barra" },
                    { 21, "Dumbbells high row", null, 4, "Remada alta com halteres" },
                    { 22, "Shoulder shrugs", null, 4, "Encolhimento de ombros" },
                    { 23, "Trapeze raises", null, 4, "Elevação de trapézio" },
                    { 24, "Face pulls", null, 4, "Puxada de rosto" },
                    { 25, "Upright rows", null, 4, "Elevação frontal" },
                    { 26, "Power cleans", null, 4, "Arranco" },
                    { 27, "T-bar rows", null, 4, "Remada cavalinho" },
                    { 28, "Pull-ups", null, 4, "Barra fixa" },
                    { 29, "Lat pulldowns", null, 4, "Puxada alta" },
                    { 30, "Dumbbell Shrugs", null, 4, "Encolhimento de ombros com halteres" },
                    { 31, "Bent-Over Lateral Raises", null, 4, "Elevação lateral inclinado" },
                    { 32, "Kettlebell Swings", null, 4, "Balanço de kettlebell" },
                    { 33, "Arnold Press", null, 4, "Arnold Press" },
                    { 34, "Prone Y Raises", null, 4, "Elevação de Y pronada" },
                    { 35, "Front Pulley", null, 5, "Pulley frontal" },
                    { 36, "Back Pulley", null, 5, "Pulley traseiro" },
                    { 37, "Bent-over row", null, 5, "Remada curvada" },
                    { 38, "Pull-ups", null, 5, "Barra fixa" },
                    { 39, "Lat pulldowns", null, 5, "Puxada alta" },
                    { 40, "Seated cable rows", null, 5, "Remada sentada com cabo" },
                    { 41, "Wide grip pull-ups", null, 5, "Barra fixa com pegada ampla" },
                    { 42, "Inverted rows", null, 5, "Remada invertida" },
                    { 43, "Straight arm pulldowns", null, 5, "Puxada alta com braços estendidos" },
                    { 44, "Single-arm dumbbell rows", null, 5, "Remada unilateral com halteres" },
                    { 45, "Barbell Rows", null, 5, "Remada com barra" },
                    { 46, "Close-grip Pulldowns", null, 5, "Puxada alta com pegada fechada" },
                    { 47, "Underhand Cable Pulldowns", null, 5, "Puxada alta com pegada invertida" },
                    { 48, "Seated Row Machine", null, 5, "Remada sentada na máquina" },
                    { 49, "Wide Grip Cable Rows", null, 5, "Remada com cabo e pegada ampla" },
                    { 50, "Hyperextensions", null, 6, "Hiperextensões" },
                    { 51, "Deadlifts", null, 6, "Levantamento terra" },
                    { 52, "Good mornings", null, 6, "Bom dia" },
                    { 53, "Supermans", null, 6, "Super-homens" },
                    { 54, "Back extensions", null, 6, "Extensões de costas" },
                    { 55, "Romanian deadlifts", null, 6, "Levantamento terra romeno" },
                    { 56, "Reverse hypers", null, 6, "Hiperextensões reversas" },
                    { 57, "Bird dogs", null, 6, "Cachorros de caça" },
                    { 58, "Russian twists", null, 6, "Torções russas" },
                    { 59, "Plank variations", null, 6, "Variações de prancha" },
                    { 60, "Seated Good Mornings", null, 6, "Bom dia sentado" },
                    { 61, "Prone Back Extensions", null, 6, "Extensões de costas prono" },
                    { 62, "Seated Cable Hyperextensions", null, 6, "Hiperextensões com cabo sentado" },
                    { 63, "Kettlebell Swings", null, 6, "Balanços com kettlebell" },
                    { 64, "Reverse Hyper Machine", null, 6, "Máquina de hiperextensões reversas" },
                    { 65, "Barbell curls", null, 7, "Rosca direta com barra" },
                    { 66, "Dumbbell Hammer curls", null, 7, "Rosca martelo com halteres" },
                    { 67, "Preacher Hammer curls", null, 7, "Rosca martelo no banco scott" },
                    { 68, "Cable Hammer curls", null, 7, "Rosca martelo com cabo" },
                    { 69, "Incline Hammer curls", null, 7, "Rosca martelo inclinada" },
                    { 70, "Hammer curls", null, 8, "Rosca martelo" },
                    { 71, "Reverse curls", null, 8, "Rosca inversa" },
                    { 72, "Wrist curls", null, 8, "Rosca de punho" },
                    { 73, "Zottman curls", null, 8, "Rosca Zottman" },
                    { 74, "EZ bar reverse curls", null, 8, "Rosca inversa com barra EZ" },
                    { 75, "Dumbbell curls", null, 9, "Rosca alternada com halteres" },
                    { 76, "Preacher curls", null, 9, "Rosca no banco scott" },
                    { 77, "Concentration curls", null, 9, "Rosca concentrada" },
                    { 78, "EZ bar curls", null, 9, "Rosca direta com barra EZ" },
                    { 79, "Incline dumbbell curls", null, 9, "Rosca inclinada com halteres" },
                    { 80, "Cable curls", null, 9, "Rosca com cabo" },
                    { 81, "Spider curls", null, 9, "Rosca aranha" },
                    { 82, "Chin-ups", null, 9, "Barra fixa" },
                    { 83, "Seated Dumbbell curls", null, 9, "Rosca alternada sentado" },
                    { 84, "Hammer Strength curls", null, 9, "Rosca Hammer Strength" },
                    { 85, "Machine curls", null, 9, "Rosca na máquina" },
                    { 86, "Close-grip Chin-ups", null, 9, "Barra fixa pegada fechada" },
                    { 87, "Preacher Hammer curls", null, 9, "Rosca martelo no banco scott" },
                    { 88, "Close grip bench press", null, 10, "Supino pegada fechada" },
                    { 89, "Dips", null, 10, "Paralelas" },
                    { 90, "Diamond push-ups", null, 10, "Flexão diamante" },
                    { 91, "Overhead dumbbell extension", null, 10, "Extensão de tríceps com halter acima da cabeça" },
                    { 92, "Reverse grip triceps pushdown", null, 10, "Tríceps pulldown com pegada invertida" },
                    { 93, "Triceps pushdown", null, 11, "Tríceps pulldown" },
                    { 94, "Triceps kickbacks", null, 11, "Tríceps kickback" },
                    { 95, "Triceps rope pushdown", null, 11, "Tríceps pulldown com corda" },
                    { 96, "Close grip push-ups", null, 11, "Flexão de braço pegada fechada" },
                    { 97, "Bench dips", null, 11, "Mergulho de banco" },
                    { 98, "Overhead triceps extension", null, 12, "Extensão de tríceps acima da cabeça" },
                    { 99, "Skull crushers", null, 12, "Crucifixo invertido" },
                    { 100, "Bench dips", null, 12, "Mergulho de banco" },
                    { 101, "Overhead cable triceps extension", null, 12, "Extensão de tríceps com cabo acima da cabeça" },
                    { 102, "Dumbbell triceps kickbacks", null, 12, "Tríceps kickback com halteres" },
                    { 103, "Crunches", null, 13, "Abdominais" },
                    { 104, "Plank", null, 13, "Prancha" },
                    { 105, "Sit-ups", null, 13, "Flexões de tronco" },
                    { 106, "Mountain climbers", null, 13, "Montanhistas" },
                    { 107, "Ab wheel rollouts", null, 13, "Extensões de abdômen com roda" },
                    { 108, "Leg raises", null, 14, "Elevação de pernas" },
                    { 109, "Hanging knee raises", null, 14, "Elevação de joelhos suspensa" },
                    { 110, "Reverse crunches", null, 14, "Crunches invertidos" },
                    { 111, "Scissor kicks", null, 14, "Tesoura" },
                    { 112, "Captain's chair leg raises", null, 14, "Elevação de pernas na cadeira romana" },
                    { 113, "Russian twists", null, 15, "Torções russas" },
                    { 114, "Side plank", null, 15, "Prancha lateral" },
                    { 115, "Bicycle crunches", null, 15, "Abdominais de bicicleta" },
                    { 116, "Woodchoppers", null, 15, "Cortadores de lenha" },
                    { 117, "Standing oblique crunches", null, 15, "Abdominais oblíquos em pé" },
                    { 118, "Standing calf raises", null, 16, "Elevação de panturrilha em pé" },
                    { 119, "Donkey calf raises", null, 16, "Elevação de panturrilha no aparelho burro" },
                    { 120, "Calf press on leg press machine", null, 16, "Pressão de panturrilha no aparelho de leg press" },
                    { 121, "Skipping rope", null, 16, "Pular corda" },
                    { 122, "Jump rope calf jumps", null, 16, "Saltos de panturrilha com corda" },
                    { 123, "Seated calf raises", null, 17, "Elevação de panturrilha sentado" },
                    { 124, "Single-leg calf raises", null, 17, "Elevação de panturrilha em uma perna" },
                    { 125, "Calf raises on a step", null, 17, "Elevação de panturrilha em um degrau" },
                    { 126, "Sled pushes", null, 17, "Empurrões com trenó" },
                    { 127, "Calf raises with resistance bands", null, 17, "Elevação de panturrilha com faixas de resistência" },
                    { 128, "Toe raises", null, 18, "Elevação de ponta de pé" },
                    { 129, "Box jumps", null, 18, "Saltos em caixa" },
                    { 130, "Ankle dorsiflexion with resistance band", null, 18, "Dorsiflexão de tornozelo com faixa de resistência" },
                    { 131, "Treadmill incline walks", null, 18, "Caminhadas em esteira inclinada" },
                    { 132, "Squats", null, 19, "Agachamentos" },
                    { 133, "Step-ups", null, 19, "Elevação de perna" },
                    { 134, "Front squats", null, 19, "Agachamentos frontais" },
                    { 135, "Wall sits", null, 19, "Agachamento estático" },
                    { 136, "Leg press", null, 19, "Pressão de pernas" },
                    { 137, "Lunges", null, 20, "Avanço" },
                    { 138, "Hack squats", null, 20, "Agachamentos hack" },
                    { 139, "Leg extensions", null, 20, "Extensões de pernas" },
                    { 140, "Leg press", null, 20, "Pressão de pernas" },
                    { 141, "Leg press with feet high", null, 20, "Pressão de pernas com os pés elevados" },
                    { 142, "Leg press", null, 21, "Pressão de pernas" },
                    { 143, "Bulgarian split squats", null, 21, "Agachamentos búlgaros" },
                    { 144, "Pistol squats", null, 21, "Agachamentos pistol" },
                    { 145, "Lunges", null, 21, "Avanço" },
                    { 146, "Leg extensions", null, 21, "Extensões de pernas" },
                    { 147, "Hip thrusts", null, 22, "Levantamento de quadril" },
                    { 148, "Donkey kicks", null, 22, "Chutes de burro" },
                    { 149, "Sumo squats", null, 22, "Agachamentos sumo" },
                    { 150, "Kickbacks", null, 22, "Extensões de perna" },
                    { 151, "Bulgarian split squats", null, 22, "Agachamentos búlgaros" },
                    { 152, "Clamshell exercises", null, 23, "Exercícios de conchinha" },
                    { 153, "Fire hydrants", null, 23, "Hidrantes" },
                    { 154, "Side-lying leg lifts", null, 23, "Elevações de perna deitado de lado" },
                    { 155, "Lateral band walks", null, 23, "Caminhadas laterais com banda" },
                    { 156, "Glute bridges", null, 24, "Ponte de glúteo" },
                    { 157, "Single-leg hip thrusts", null, 24, "Levantamento de quadril com uma perna" },
                    { 158, "Banded crab walks", null, 24, "Caminhadas de caranguejo com banda" },
                    { 159, "Reverse lunges", null, 24, "Avanço reverso" },
                    { 160, "Wrist curls", null, 25, "Flexões de pulso" },
                    { 161, "Plate curls", null, 25, "Cachos com placa" },
                    { 162, "Pinch grip holds", null, 25, "Agarre de pinça" },
                    { 163, "Finger curls", null, 25, "Cachos de dedos" },
                    { 164, "Dumbbell wrist pronation/supination", null, 25, "Pronação/supinação de pulso com halteres" },
                    { 165, "Reverse wrist curls", null, 26, "Flexões reversas de pulso" },
                    { 166, "Hammer grip curls", null, 26, "Cachos com pegada de martelo" },
                    { 167, "Bar hangs", null, 26, "Pendurar na barra" },
                    { 168, "Wrist roller", null, 26, "Rolo de pulso" },
                    { 169, "Grip strengthener exercises", null, 27, "Exercícios para fortalecer o agarre" },
                    { 170, "Towel hangs", null, 27, "Pendurar com toalha" },
                    { 171, "Farmer's walks", null, 27, "Caminhadas de fazendeiro" },
                    { 172, "Plate pinches", null, 27, "Apertar de pratos" },
                    { 173, "Military Press", null, 28, "Desenvolvimento Militar" },
                    { 174, "Arnold Press", null, 28, "Arnold Press" },
                    { 175, "Front Dumbbell Raise", null, 28, "Elevação frontal com halteres" },
                    { 176, "Barbell Front Raise", null, 28, "Elevação frontal com barra" },
                    { 177, "Cable Front Raise", null, 28, "Elevação frontal com cabo" },
                    { 178, "Lateral Raises", null, 29, "Elevação lateral" },
                    { 179, "Dumbbell Lateral Raises", null, 29, "Elevação lateral com halteres" },
                    { 180, "Cable Lateral Raises", null, 29, "Elevação lateral com cabo" },
                    { 181, "Machine Lateral Raises", null, 29, "Elevação lateral na máquina" },
                    { 182, "Bent-Over Lateral Raises", null, 29, "Elevação lateral inclinada" },
                    { 183, "Rear Deltoid Flyes", null, 30, "Flyes para deltoides posteriores" },
                    { 184, "Bent-Over Rear Deltoid Raises", null, 30, "Elevação de deltoides posteriores inclinado" },
                    { 185, "Cable Rear Deltoid Flyes", null, 30, "Flyes para deltoides posteriores com cabo" },
                    { 186, "Reverse Pec Deck Flyes", null, 30, "Flyes inversos no peck deck" },
                    { 187, "Face Pulls", null, 30, "Face Pulls" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_MuscleId",
                table: "Exercises",
                column: "MuscleId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingExercises_ExerciseId",
                table: "TrainingExercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingExercises_TrainingId",
                table: "TrainingExercises",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_ClientId",
                table: "Trainings",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_OwnerId",
                table: "Trainings",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TrainerId",
                table: "Users",
                column: "TrainerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainingExercises");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "Muscles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
