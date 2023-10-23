using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CFKA.Health.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TrainerAndClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainings_Users_OwnerId",
                table: "Trainings");

            migrationBuilder.AddColumn<Guid>(
                name: "TrainerId",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "Trainings",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Users_TrainerId",
                table: "Users",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_ClientId",
                table: "Trainings",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainings_Users_ClientId",
                table: "Trainings",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainings_Users_OwnerId",
                table: "Trainings",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_TrainerId",
                table: "Users",
                column: "TrainerId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainings_Users_ClientId",
                table: "Trainings");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainings_Users_OwnerId",
                table: "Trainings");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_TrainerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_TrainerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Trainings_ClientId",
                table: "Trainings");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Trainings");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainings_Users_OwnerId",
                table: "Trainings",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
