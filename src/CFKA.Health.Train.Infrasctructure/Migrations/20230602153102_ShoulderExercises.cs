using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CFKA.Health.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ShoulderExercises : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 7,
                column: "MainMuscle",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 8,
                column: "MainMuscle",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 9,
                column: "MainMuscle",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 10,
                column: "MainMuscle",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 11,
                column: "MainMuscle",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 12,
                column: "MainMuscle",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 13,
                column: "MainMuscle",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 14,
                column: "MainMuscle",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 15,
                column: "MainMuscle",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 16,
                column: "MainMuscle",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 17,
                column: "MainMuscle",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 18,
                column: "MainMuscle",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 19,
                column: "MainMuscle",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 20,
                column: "MainMuscle",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 21,
                column: "MainMuscle",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 22,
                column: "MainMuscle",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 23,
                column: "MainMuscle",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 24,
                column: "MainMuscle",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 25,
                column: "MainMuscle",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 26,
                column: "MainMuscle",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 27,
                column: "MainMuscle",
                value: 9);

            migrationBuilder.InsertData(
                table: "Muscles",
                columns: new[] { "Id", "EnName", "MainMuscle", "PtName" },
                values: new object[,]
                {
                    { 28, "Front Deltoids", 2, "Deltoides Frontais" },
                    { 29, "Side Deltoids", 2, "Deltoides Laterais" },
                    { 30, "Rear Deltoids", 2, "Deltoides Posteriores" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "EnName", "MuscleId", "PtName" },
                values: new object[,]
                {
                    { 173, "Military Press", 28, "Desenvolvimento Militar" },
                    { 174, "Arnold Press", 28, "Arnold Press" },
                    { 175, "Front Dumbbell Raise", 28, "Elevação frontal com halteres" },
                    { 176, "Barbell Front Raise", 28, "Elevação frontal com barra" },
                    { 177, "Cable Front Raise", 28, "Elevação frontal com cabo" },
                    { 178, "Lateral Raises", 29, "Elevação lateral" },
                    { 179, "Dumbbell Lateral Raises", 29, "Elevação lateral com halteres" },
                    { 180, "Cable Lateral Raises", 29, "Elevação lateral com cabo" },
                    { 181, "Machine Lateral Raises", 29, "Elevação lateral na máquina" },
                    { 182, "Bent-Over Lateral Raises", 29, "Elevação lateral inclinada" },
                    { 183, "Rear Deltoid Flyes", 30, "Flyes para deltoides posteriores" },
                    { 184, "Bent-Over Rear Deltoid Raises", 30, "Elevação de deltoides posteriores inclinado" },
                    { 185, "Cable Rear Deltoid Flyes", 30, "Flyes para deltoides posteriores com cabo" },
                    { 186, "Reverse Pec Deck Flyes", 30, "Flyes inversos no peck deck" },
                    { 187, "Face Pulls", 30, "Face Pulls" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 7,
                column: "MainMuscle",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 8,
                column: "MainMuscle",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 9,
                column: "MainMuscle",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 10,
                column: "MainMuscle",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 11,
                column: "MainMuscle",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 12,
                column: "MainMuscle",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 13,
                column: "MainMuscle",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 14,
                column: "MainMuscle",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 15,
                column: "MainMuscle",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 16,
                column: "MainMuscle",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 17,
                column: "MainMuscle",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 18,
                column: "MainMuscle",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 19,
                column: "MainMuscle",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 20,
                column: "MainMuscle",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 21,
                column: "MainMuscle",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 22,
                column: "MainMuscle",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 23,
                column: "MainMuscle",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 24,
                column: "MainMuscle",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 25,
                column: "MainMuscle",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 26,
                column: "MainMuscle",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 27,
                column: "MainMuscle",
                value: 8);
        }
    }
}
