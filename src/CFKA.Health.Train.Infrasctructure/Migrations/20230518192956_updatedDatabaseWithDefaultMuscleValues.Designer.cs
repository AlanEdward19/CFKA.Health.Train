﻿// <auto-generated />
using CFKA.Health.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CFKA.Health.Infrastructure.Migrations
{
    [DbContext(typeof(CFKATrainDbContext))]
    [Migration("20230518192956_updatedDatabaseWithDefaultMuscleValues")]
    partial class updatedDatabaseWithDefaultMuscleValues
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CFKA.Health.Domain.Entities.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("MuscleId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MuscleId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("CFKA.Health.Domain.Entities.Muscle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("MainMuscle")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Muscles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MainMuscle = 0,
                            Name = "Upper Chest"
                        },
                        new
                        {
                            Id = 2,
                            MainMuscle = 0,
                            Name = "Middle Chest"
                        },
                        new
                        {
                            Id = 3,
                            MainMuscle = 0,
                            Name = "Lower Chest"
                        },
                        new
                        {
                            Id = 4,
                            MainMuscle = 1,
                            Name = "Trapezius"
                        },
                        new
                        {
                            Id = 5,
                            MainMuscle = 1,
                            Name = "Lats"
                        },
                        new
                        {
                            Id = 6,
                            MainMuscle = 1,
                            Name = "Low Back"
                        },
                        new
                        {
                            Id = 7,
                            MainMuscle = 2,
                            Name = "Brachialis"
                        },
                        new
                        {
                            Id = 8,
                            MainMuscle = 2,
                            Name = "Brachioradialis"
                        },
                        new
                        {
                            Id = 9,
                            MainMuscle = 2,
                            Name = "Biceps Brachii"
                        },
                        new
                        {
                            Id = 10,
                            MainMuscle = 3,
                            Name = "Long Head of Triceps"
                        },
                        new
                        {
                            Id = 11,
                            MainMuscle = 3,
                            Name = "Medial Head of Triceps"
                        },
                        new
                        {
                            Id = 12,
                            MainMuscle = 3,
                            Name = "Lateral Head of Triceps"
                        },
                        new
                        {
                            Id = 13,
                            MainMuscle = 4,
                            Name = "Upper Abs"
                        },
                        new
                        {
                            Id = 14,
                            MainMuscle = 4,
                            Name = "Lower Abs"
                        },
                        new
                        {
                            Id = 15,
                            MainMuscle = 4,
                            Name = "Obliques"
                        },
                        new
                        {
                            Id = 16,
                            MainMuscle = 5,
                            Name = "Gastrocnemius (Upper Calf)"
                        },
                        new
                        {
                            Id = 17,
                            MainMuscle = 5,
                            Name = "Soleus (Lower Calf)"
                        },
                        new
                        {
                            Id = 18,
                            MainMuscle = 5,
                            Name = "Tibialis Anterior"
                        },
                        new
                        {
                            Id = 19,
                            MainMuscle = 6,
                            Name = "Vastus Lateralis"
                        },
                        new
                        {
                            Id = 20,
                            MainMuscle = 6,
                            Name = "Vastus Medialis"
                        },
                        new
                        {
                            Id = 21,
                            MainMuscle = 6,
                            Name = "Rectus Femoris"
                        },
                        new
                        {
                            Id = 22,
                            MainMuscle = 7,
                            Name = "Gluteus Maximus"
                        },
                        new
                        {
                            Id = 23,
                            MainMuscle = 7,
                            Name = "Gluteus Medius"
                        },
                        new
                        {
                            Id = 24,
                            MainMuscle = 7,
                            Name = "Gluteus Minimus"
                        },
                        new
                        {
                            Id = 25,
                            MainMuscle = 8,
                            Name = "Wrist Flexors"
                        },
                        new
                        {
                            Id = 26,
                            MainMuscle = 8,
                            Name = "Wrist Extensors"
                        },
                        new
                        {
                            Id = 27,
                            MainMuscle = 8,
                            Name = "Grip"
                        });
                });

            modelBuilder.Entity("CFKA.Health.Domain.Entities.Exercise", b =>
                {
                    b.HasOne("CFKA.Health.Domain.Entities.Muscle", "Muscle")
                        .WithMany("Exercises")
                        .HasForeignKey("MuscleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Muscle");
                });

            modelBuilder.Entity("CFKA.Health.Domain.Entities.Muscle", b =>
                {
                    b.Navigation("Exercises");
                });
#pragma warning restore 612, 618
        }
    }
}
