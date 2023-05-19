using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CFKA.Health.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateExerciseTableWithDefaultValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "MuscleId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Incline Bench Press" },
                    { 2, 1, "Incline Bench Press with Dumbbells" },
                    { 3, 1, "Low Pulley Crossover" },
                    { 4, 1, "Incline Dumbbell Flyes" },
                    { 5, 1, "Incline Push-Ups" },
                    { 6, 2, "Bench Press" },
                    { 7, 2, "Bench Press with Dumbbells" },
                    { 8, 2, "Pulley Crossover" },
                    { 9, 2, "Machine Crossover" },
                    { 10, 2, "Push-Up" },
                    { 11, 2, "Dumbbell Bench Press" },
                    { 12, 2, "Chest Press Machine" },
                    { 13, 2, "Dips" },
                    { 14, 2, "Cable Chest Press" },
                    { 15, 3, "Decline Bench Press" },
                    { 16, 3, "Decline Bench Press with Dumbbells" },
                    { 17, 3, "High Pulley Crossover" },
                    { 18, 3, "Decline Dumbbell Flyes" },
                    { 19, 3, "Decline Push-Ups" },
                    { 20, 4, "Barbell high row" },
                    { 21, 4, "Dumbbells high row" },
                    { 22, 4, "Shoulder shrugs" },
                    { 23, 4, "Trapeze raises" },
                    { 24, 4, "Face pulls" },
                    { 25, 4, "Upright rows" },
                    { 26, 4, "Power cleans" },
                    { 27, 4, "T-bar rows" },
                    { 28, 4, "Pull-ups" },
                    { 29, 4, "Lat pulldowns" },
                    { 30, 4, "Dumbbell Shrugs" },
                    { 31, 4, "Bent-Over Lateral Raises" },
                    { 32, 4, "Kettlebell Swings" },
                    { 33, 4, "Arnold Press" },
                    { 34, 4, "Prone Y Raises" },
                    { 35, 5, "Front Pulley" },
                    { 36, 5, "Back Pulley" },
                    { 37, 5, "Bent-over row" },
                    { 38, 5, "Pull-ups" },
                    { 39, 5, "Lat pulldowns" },
                    { 40, 5, "Seated cable rows" },
                    { 41, 5, "Wide grip pull-ups" },
                    { 42, 5, "Inverted rows" },
                    { 43, 5, "Straight arm pulldowns" },
                    { 44, 5, "Single-arm dumbbell rows" },
                    { 45, 5, "Barbell Rows" },
                    { 46, 5, "Close-grip Pulldowns" },
                    { 47, 5, "Underhand Cable Pulldowns" },
                    { 48, 5, "Seated Row Machine" },
                    { 49, 5, "Wide Grip Cable Rows" },
                    { 50, 6, "Hyperextensions" },
                    { 51, 6, "Deadlifts" },
                    { 52, 6, "Good mornings" },
                    { 53, 6, "Supermans" },
                    { 54, 6, "Back extensions" },
                    { 55, 6, "Romanian deadlifts" },
                    { 56, 6, "Reverse hypers" },
                    { 57, 6, "Bird dogs" },
                    { 58, 6, "Russian twists" },
                    { 59, 6, "Plank variations" },
                    { 60, 6, "Seated Good Mornings" },
                    { 61, 6, "Prone Back Extensions" },
                    { 62, 6, "Seated Cable Hyperextensions" },
                    { 63, 6, "Kettlebell Swings" },
                    { 64, 6, "Reverse Hyper Machine" },
                    { 65, 7, "Barbell curls" },
                    { 66, 7, "Dumbbell Hammer curls" },
                    { 67, 7, "Preacher Hammer curls" },
                    { 68, 7, "Cable Hammer curls" },
                    { 69, 7, "Incline Hammer curls" },
                    { 70, 8, "Hammer curls" },
                    { 71, 8, "Reverse curls" },
                    { 72, 8, "Wrist curls" },
                    { 73, 8, "Zottman curls" },
                    { 74, 8, "EZ bar reverse curls" },
                    { 75, 9, "Dumbbell curls" },
                    { 76, 9, "Preacher curls" },
                    { 77, 9, "Concentration curls" },
                    { 78, 9, "EZ bar curls" },
                    { 79, 9, "Incline dumbbell curls" },
                    { 80, 9, "Cable curls" },
                    { 81, 9, "Spider curls" },
                    { 82, 9, "Chin-ups" },
                    { 83, 9, "Seated Dumbbell curls" },
                    { 84, 9, "Hammer Strength curls" },
                    { 85, 9, "Machine curls" },
                    { 86, 9, "Close-grip Chin-ups" },
                    { 87, 9, "Preacher Hammer curls" },
                    { 88, 10, "Close grip bench press" },
                    { 89, 10, "Dips" },
                    { 90, 10, "Diamond push-ups" },
                    { 91, 10, "Overhead dumbbell extension" },
                    { 92, 10, "Reverse grip triceps pushdown" },
                    { 93, 11, "Triceps pushdown" },
                    { 94, 11, "Triceps kickbacks" },
                    { 95, 11, "Triceps rope pushdown" },
                    { 96, 11, "Close grip push-ups" },
                    { 97, 11, "Bench dips" },
                    { 98, 12, "Overhead triceps extension" },
                    { 99, 12, "Skull crushers" },
                    { 100, 12, "Bench dips" },
                    { 101, 12, "Overhead cable triceps extension" },
                    { 102, 12, "Dumbbell triceps kickbacks" },
                    { 103, 13, "Crunches" },
                    { 104, 13, "Plank" },
                    { 105, 13, "Sit-ups" },
                    { 106, 13, "Mountain climbers" },
                    { 107, 13, "Ab wheel rollouts" },
                    { 108, 14, "Leg raises" },
                    { 109, 14, "Hanging knee raises" },
                    { 110, 14, "Reverse crunches" },
                    { 111, 14, "Scissor kicks" },
                    { 112, 14, "Captain's chair leg raises" },
                    { 113, 15, "Russian twists" },
                    { 114, 15, "Side plank" },
                    { 115, 15, "Bicycle crunches" },
                    { 116, 15, "Woodchoppers" },
                    { 117, 15, "Standing oblique crunches" },
                    { 118, 16, "Standing calf raises" },
                    { 119, 16, "Donkey calf raises" },
                    { 120, 16, "Calf press on leg press machine" },
                    { 121, 16, "Skipping rope" },
                    { 122, 16, "Jump rope calf jumps" },
                    { 123, 17, "Seated calf raises" },
                    { 124, 17, "Single-leg calf raises" },
                    { 125, 17, "Calf raises on a step" },
                    { 126, 17, "Sled pushes" },
                    { 127, 17, "Calf raises with resistance bands" },
                    { 128, 18, "Toe raises" },
                    { 129, 18, "Box jumps" },
                    { 130, 18, "Ankle dorsiflexion with resistance band" },
                    { 131, 18, "Treadmill incline walks" },
                    { 132, 19, "Squats" },
                    { 133, 19, "Step-ups" },
                    { 134, 19, "Front squats" },
                    { 135, 19, "Wall sits" },
                    { 136, 19, "Leg press" },
                    { 137, 20, "Lunges" },
                    { 138, 20, "Hack squats" },
                    { 139, 20, "Leg extensions" },
                    { 140, 20, "Leg press" },
                    { 141, 20, "Leg press with feet high" },
                    { 142, 21, "Leg press" },
                    { 143, 21, "Bulgarian split squats" },
                    { 144, 21, "Pistol squats" },
                    { 145, 21, "Lunges" },
                    { 146, 21, "Leg extensions" },
                    { 147, 22, "Hip thrusts" },
                    { 148, 22, "Donkey kicks" },
                    { 149, 22, "Sumo squats" },
                    { 150, 22, "Kickbacks" },
                    { 151, 22, "Bulgarian split squats" },
                    { 152, 23, "Clamshell exercises" },
                    { 153, 23, "Fire hydrants" },
                    { 154, 23, "Side-lying leg lifts" },
                    { 155, 23, "Lateral band walks" },
                    { 156, 24, "Glute bridges" },
                    { 157, 24, "Single-leg hip thrusts" },
                    { 158, 24, "Banded crab walks" },
                    { 159, 24, "Reverse lunges" },
                    { 160, 25, "Wrist curls" },
                    { 161, 25, "Plate curls" },
                    { 162, 25, "Pinch grip holds" },
                    { 163, 25, "Finger curls" },
                    { 164, 25, "Dumbbell wrist pronation/supination" },
                    { 165, 26, "Reverse wrist curls" },
                    { 166, 26, "Hammer grip curls" },
                    { 167, 26, "Bar hangs" },
                    { 168, 26, "Wrist roller" },
                    { 169, 27, "Grip strengthener exercises" },
                    { 170, 27, "Towel hangs" },
                    { 171, 27, "Farmer's walks" },
                    { 172, 27, "Plate pinches" }
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
