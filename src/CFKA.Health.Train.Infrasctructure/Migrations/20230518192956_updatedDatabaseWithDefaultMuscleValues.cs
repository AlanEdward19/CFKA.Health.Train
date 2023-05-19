using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CFKA.Health.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedDatabaseWithDefaultMuscleValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Muscles",
                columns: new[] { "Id", "MainMuscle", "Name" },
                values: new object[,]
                {
                    { 1, 0, "Upper Chest" },
                    { 2, 0, "Middle Chest" },
                    { 3, 0, "Lower Chest" },
                    { 4, 1, "Trapezius" },
                    { 5, 1, "Lats" },
                    { 6, 1, "Low Back" },
                    { 7, 2, "Brachialis" },
                    { 8, 2, "Brachioradialis" },
                    { 9, 2, "Biceps Brachii" },
                    { 10, 3, "Long Head of Triceps" },
                    { 11, 3, "Medial Head of Triceps" },
                    { 12, 3, "Lateral Head of Triceps" },
                    { 13, 4, "Upper Abs" },
                    { 14, 4, "Lower Abs" },
                    { 15, 4, "Obliques" },
                    { 16, 5, "Gastrocnemius (Upper Calf)" },
                    { 17, 5, "Soleus (Lower Calf)" },
                    { 18, 5, "Tibialis Anterior" },
                    { 19, 6, "Vastus Lateralis" },
                    { 20, 6, "Vastus Medialis" },
                    { 21, 6, "Rectus Femoris" },
                    { 22, 7, "Gluteus Maximus" },
                    { 23, 7, "Gluteus Medius" },
                    { 24, 7, "Gluteus Minimus" },
                    { 25, 8, "Wrist Flexors" },
                    { 26, 8, "Wrist Extensors" },
                    { 27, 8, "Grip" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Muscles",
                keyColumn: "Id",
                keyValue: 27);
        }
    }
}
