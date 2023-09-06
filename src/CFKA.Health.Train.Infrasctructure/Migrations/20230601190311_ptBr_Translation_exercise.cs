using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CFKA.Health.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ptBr_Translation_exercise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "EnName", "MuscleId", "PtName" },
                values: new object[,]
                {
                    { 1, "Incline Bench Press", 1, "Supino inclinado" },
                    { 2, "Incline Bench Press with Dumbbells", 1, "Supino inclinado com halteres" },
                    { 3, "Low Pulley Crossover", 1, "Crucifixo na polia baixa" },
                    { 4, "Incline Dumbbell Flyes", 1, "Crucifixo inclinado com halteres" },
                    { 5, "Incline Push-Ups", 1, "Flexao inclinado" },
                    { 6, "Bench Press", 2, "Supino reto" },
                    { 7, "Bench Press with Dumbbells", 2, "Supino reto com halteres" },
                    { 8, "Pulley Crossover", 2, "Crucifixo na polia reto" },
                    { 9, "Machine Crossover", 2, "Crucifixo na maquina" },
                    { 10, "Push-Up", 2, "Flexao" },
                    { 11, "Dumbbell Bench Press", 2, "Supino reto com halteres" },
                    { 12, "Chest Press Machine", 2, "Supino reto na maquina" },
                    { 13, "Dips", 2, "Mergulho" },
                    { 14, "Cable Chest Press", 2, "Supino com cabo" },
                    { 15, "Decline Bench Press", 3, "Supino declinado" },
                    { 16, "Decline Bench Press with Dumbbells", 3, "Supino declinado com halteres" },
                    { 17, "High Pulley Crossover", 3, "Crucifixo na polia alta" },
                    { 18, "Decline Dumbbell Flyes", 3, "Crucifixo declinado com halteres" },
                    { 19, "Decline Push-Ups", 3, "Flexao declinado" },
                    { 20, "Barbell high row", 4, "Remada alta com barra" },
                    { 21, "Dumbbells high row", 4, "Remada alta com halteres" },
                    { 22, "Shoulder shrugs", 4, "Encolhimento de ombros" },
                    { 23, "Trapeze raises", 4, "Elevação de trapézio" },
                    { 24, "Face pulls", 4, "Puxada de rosto" },
                    { 25, "Upright rows", 4, "Elevação frontal" },
                    { 26, "Power cleans", 4, "Arranco" },
                    { 27, "T-bar rows", 4, "Remada cavalinho" },
                    { 28, "Pull-ups", 4, "Barra fixa" },
                    { 29, "Lat pulldowns", 4, "Puxada alta" },
                    { 30, "Dumbbell Shrugs", 4, "Encolhimento de ombros com halteres" },
                    { 31, "Bent-Over Lateral Raises", 4, "Elevação lateral inclinado" },
                    { 32, "Kettlebell Swings", 4, "Balanço de kettlebell" },
                    { 33, "Arnold Press", 4, "Arnold Press" },
                    { 34, "Prone Y Raises", 4, "Elevação de Y pronada" },
                    { 35, "Front Pulley", 5, "Pulley frontal" },
                    { 36, "Back Pulley", 5, "Pulley traseiro" },
                    { 37, "Bent-over row", 5, "Remada curvada" },
                    { 38, "Pull-ups", 5, "Barra fixa" },
                    { 39, "Lat pulldowns", 5, "Puxada alta" },
                    { 40, "Seated cable rows", 5, "Remada sentada com cabo" },
                    { 41, "Wide grip pull-ups", 5, "Barra fixa com pegada ampla" },
                    { 42, "Inverted rows", 5, "Remada invertida" },
                    { 43, "Straight arm pulldowns", 5, "Puxada alta com braços estendidos" },
                    { 44, "Single-arm dumbbell rows", 5, "Remada unilateral com halteres" },
                    { 45, "Barbell Rows", 5, "Remada com barra" },
                    { 46, "Close-grip Pulldowns", 5, "Puxada alta com pegada fechada" },
                    { 47, "Underhand Cable Pulldowns", 5, "Puxada alta com pegada invertida" },
                    { 48, "Seated Row Machine", 5, "Remada sentada na máquina" },
                    { 49, "Wide Grip Cable Rows", 5, "Remada com cabo e pegada ampla" },
                    { 50, "Hyperextensions", 6, "Hiperextensões" },
                    { 51, "Deadlifts", 6, "Levantamento terra" },
                    { 52, "Good mornings", 6, "Bom dia" },
                    { 53, "Supermans", 6, "Super-homens" },
                    { 54, "Back extensions", 6, "Extensões de costas" },
                    { 55, "Romanian deadlifts", 6, "Levantamento terra romeno" },
                    { 56, "Reverse hypers", 6, "Hiperextensões reversas" },
                    { 57, "Bird dogs", 6, "Cachorros de caça" },
                    { 58, "Russian twists", 6, "Torções russas" },
                    { 59, "Plank variations", 6, "Variações de prancha" },
                    { 60, "Seated Good Mornings", 6, "Bom dia sentado" },
                    { 61, "Prone Back Extensions", 6, "Extensões de costas prono" },
                    { 62, "Seated Cable Hyperextensions", 6, "Hiperextensões com cabo sentado" },
                    { 63, "Kettlebell Swings", 6, "Balanços com kettlebell" },
                    { 64, "Reverse Hyper Machine", 6, "Máquina de hiperextensões reversas" },
                    { 65, "Barbell curls", 7, "Rosca direta com barra" },
                    { 66, "Dumbbell Hammer curls", 7, "Rosca martelo com halteres" },
                    { 67, "Preacher Hammer curls", 7, "Rosca martelo no banco scott" },
                    { 68, "Cable Hammer curls", 7, "Rosca martelo com cabo" },
                    { 69, "Incline Hammer curls", 7, "Rosca martelo inclinada" },
                    { 70, "Hammer curls", 8, "Rosca martelo" },
                    { 71, "Reverse curls", 8, "Rosca inversa" },
                    { 72, "Wrist curls", 8, "Rosca de punho" },
                    { 73, "Zottman curls", 8, "Rosca Zottman" },
                    { 74, "EZ bar reverse curls", 8, "Rosca inversa com barra EZ" },
                    { 75, "Dumbbell curls", 9, "Rosca alternada com halteres" },
                    { 76, "Preacher curls", 9, "Rosca no banco scott" },
                    { 77, "Concentration curls", 9, "Rosca concentrada" },
                    { 78, "EZ bar curls", 9, "Rosca direta com barra EZ" },
                    { 79, "Incline dumbbell curls", 9, "Rosca inclinada com halteres" },
                    { 80, "Cable curls", 9, "Rosca com cabo" },
                    { 81, "Spider curls", 9, "Rosca aranha" },
                    { 82, "Chin-ups", 9, "Barra fixa" },
                    { 83, "Seated Dumbbell curls", 9, "Rosca alternada sentado" },
                    { 84, "Hammer Strength curls", 9, "Rosca Hammer Strength" },
                    { 85, "Machine curls", 9, "Rosca na máquina" },
                    { 86, "Close-grip Chin-ups", 9, "Barra fixa pegada fechada" },
                    { 87, "Preacher Hammer curls", 9, "Rosca martelo no banco scott" },
                    { 88, "Close grip bench press", 10, "Supino pegada fechada" },
                    { 89, "Dips", 10, "Paralelas" },
                    { 90, "Diamond push-ups", 10, "Flexão diamante" },
                    { 91, "Overhead dumbbell extension", 10, "Extensão de tríceps com halter acima da cabeça" },
                    { 92, "Reverse grip triceps pushdown", 10, "Tríceps pulldown com pegada invertida" },
                    { 93, "Triceps pushdown", 11, "Tríceps pulldown" },
                    { 94, "Triceps kickbacks", 11, "Tríceps kickback" },
                    { 95, "Triceps rope pushdown", 11, "Tríceps pulldown com corda" },
                    { 96, "Close grip push-ups", 11, "Flexão de braço pegada fechada" },
                    { 97, "Bench dips", 11, "Mergulho de banco" },
                    { 98, "Overhead triceps extension", 12, "Extensão de tríceps acima da cabeça" },
                    { 99, "Skull crushers", 12, "Crucifixo invertido" },
                    { 100, "Bench dips", 12, "Mergulho de banco" },
                    { 101, "Overhead cable triceps extension", 12, "Extensão de tríceps com cabo acima da cabeça" },
                    { 102, "Dumbbell triceps kickbacks", 12, "Tríceps kickback com halteres" },
                    { 103, "Crunches", 13, "Abdominais" },
                    { 104, "Plank", 13, "Prancha" },
                    { 105, "Sit-ups", 13, "Flexões de tronco" },
                    { 106, "Mountain climbers", 13, "Montanhistas" },
                    { 107, "Ab wheel rollouts", 13, "Extensões de abdômen com roda" },
                    { 108, "Leg raises", 14, "Elevação de pernas" },
                    { 109, "Hanging knee raises", 14, "Elevação de joelhos suspensa" },
                    { 110, "Reverse crunches", 14, "Crunches invertidos" },
                    { 111, "Scissor kicks", 14, "Tesoura" },
                    { 112, "Captain's chair leg raises", 14, "Elevação de pernas na cadeira romana" },
                    { 113, "Russian twists", 15, "Torções russas" },
                    { 114, "Side plank", 15, "Prancha lateral" },
                    { 115, "Bicycle crunches", 15, "Abdominais de bicicleta" },
                    { 116, "Woodchoppers", 15, "Cortadores de lenha" },
                    { 117, "Standing oblique crunches", 15, "Abdominais oblíquos em pé" },
                    { 118, "Standing calf raises", 16, "Elevação de panturrilha em pé" },
                    { 119, "Donkey calf raises", 16, "Elevação de panturrilha no aparelho burro" },
                    { 120, "Calf press on leg press machine", 16, "Pressão de panturrilha no aparelho de leg press" },
                    { 121, "Skipping rope", 16, "Pular corda" },
                    { 122, "Jump rope calf jumps", 16, "Saltos de panturrilha com corda" },
                    { 123, "Seated calf raises", 17, "Elevação de panturrilha sentado" },
                    { 124, "Single-leg calf raises", 17, "Elevação de panturrilha em uma perna" },
                    { 125, "Calf raises on a step", 17, "Elevação de panturrilha em um degrau" },
                    { 126, "Sled pushes", 17, "Empurrões com trenó" },
                    { 127, "Calf raises with resistance bands", 17, "Elevação de panturrilha com faixas de resistência" },
                    { 128, "Toe raises", 18, "Elevação de ponta de pé" },
                    { 129, "Box jumps", 18, "Saltos em caixa" },
                    { 130, "Ankle dorsiflexion with resistance band", 18, "Dorsiflexão de tornozelo com faixa de resistência" },
                    { 131, "Treadmill incline walks", 18, "Caminhadas em esteira inclinada" },
                    { 132, "Squats", 19, "Agachamentos" },
                    { 133, "Step-ups", 19, "Elevação de perna" },
                    { 134, "Front squats", 19, "Agachamentos frontais" },
                    { 135, "Wall sits", 19, "Agachamento estático" },
                    { 136, "Leg press", 19, "Pressão de pernas" },
                    { 137, "Lunges", 20, "Avanço" },
                    { 138, "Hack squats", 20, "Agachamentos hack" },
                    { 139, "Leg extensions", 20, "Extensões de pernas" },
                    { 140, "Leg press", 20, "Pressão de pernas" },
                    { 141, "Leg press with feet high", 20, "Pressão de pernas com os pés elevados" },
                    { 142, "Leg press", 21, "Pressão de pernas" },
                    { 143, "Bulgarian split squats", 21, "Agachamentos búlgaros" },
                    { 144, "Pistol squats", 21, "Agachamentos pistol" },
                    { 145, "Lunges", 21, "Avanço" },
                    { 146, "Leg extensions", 21, "Extensões de pernas" },
                    { 147, "Hip thrusts", 22, "Levantamento de quadril" },
                    { 148, "Donkey kicks", 22, "Chutes de burro" },
                    { 149, "Sumo squats", 22, "Agachamentos sumo" },
                    { 150, "Kickbacks", 22, "Extensões de perna" },
                    { 151, "Bulgarian split squats", 22, "Agachamentos búlgaros" },
                    { 152, "Clamshell exercises", 23, "Exercícios de conchinha" },
                    { 153, "Fire hydrants", 23, "Hidrantes" },
                    { 154, "Side-lying leg lifts", 23, "Elevações de perna deitado de lado" },
                    { 155, "Lateral band walks", 23, "Caminhadas laterais com banda" },
                    { 156, "Glute bridges", 24, "Ponte de glúteo" },
                    { 157, "Single-leg hip thrusts", 24, "Levantamento de quadril com uma perna" },
                    { 158, "Banded crab walks", 24, "Caminhadas de caranguejo com banda" },
                    { 159, "Reverse lunges", 24, "Avanço reverso" },
                    { 160, "Wrist curls", 25, "Flexões de pulso" },
                    { 161, "Plate curls", 25, "Cachos com placa" },
                    { 162, "Pinch grip holds", 25, "Agarre de pinça" },
                    { 163, "Finger curls", 25, "Cachos de dedos" },
                    { 164, "Dumbbell wrist pronation/supination", 25, "Pronação/supinação de pulso com halteres" },
                    { 165, "Reverse wrist curls", 26, "Flexões reversas de pulso" },
                    { 166, "Hammer grip curls", 26, "Cachos com pegada de martelo" },
                    { 167, "Bar hangs", 26, "Pendurar na barra" },
                    { 168, "Wrist roller", 26, "Rolo de pulso" },
                    { 169, "Grip strengthener exercises", 27, "Exercícios para fortalecer o agarre" },
                    { 170, "Towel hangs", 27, "Pendurar com toalha" },
                    { 171, "Farmer's walks", 27, "Caminhadas de fazendeiro" },
                    { 172, "Plate pinches", 27, "Apertar de pratos" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 172);
        }
    }
}
