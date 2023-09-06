using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CFKA.Health.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserRelatedTrain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingExercises_Trainings_TrainingId",
                table: "TrainingExercises");

            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Trainings");

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerId",
                table: "Trainings",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "TrainingId",
                table: "TrainingExercises",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_OwnerId",
                table: "Trainings",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingExercises_Trainings_TrainingId",
                table: "TrainingExercises",
                column: "TrainingId",
                principalTable: "Trainings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainings_Users_OwnerId",
                table: "Trainings",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingExercises_Trainings_TrainingId",
                table: "TrainingExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainings_Users_OwnerId",
                table: "Trainings");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Trainings_OwnerId",
                table: "Trainings");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Trainings");

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Trainings",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "TrainingId",
                table: "TrainingExercises",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingExercises_Trainings_TrainingId",
                table: "TrainingExercises",
                column: "TrainingId",
                principalTable: "Trainings",
                principalColumn: "Id");
        }
    }
}
