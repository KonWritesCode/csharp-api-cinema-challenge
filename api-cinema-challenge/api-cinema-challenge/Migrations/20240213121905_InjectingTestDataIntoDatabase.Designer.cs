﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    [Migration("20240213121905_InjectingTestDataIntoDatabase")]
    partial class InjectingTestDataIntoDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8047),
                            Email = "john@example.com",
                            Name = "John Doe",
                            Phone = "12356890",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8054),
                            Email = "jane@example.com",
                            Name = "Jane Smith",
                            Phone = "98654210",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8056),
                            Email = "alice@example.com",
                            Name = "Alice Johnson",
                            Phone = "45780123",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8057),
                            Email = "bob@example.com",
                            Name = "Bob Brown",
                            Phone = "78912456",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8059),
                            Email = "emily@example.com",
                            Name = "Emily Davis",
                            Phone = "21987543",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8063),
                            Email = "michael@example.com",
                            Name = "Michael Wilson",
                            Phone = "54210876",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RuntimeMins")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("movie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8067),
                            Description = "In a small town plagued by strange occurrences, a group of teenagers must uncover the dark secrets hidden within the shadows before it's too late.",
                            Rating = "PG-13",
                            RuntimeMins = 110,
                            Title = "Whispers in the Dark",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8071),
                            Description = "A time-traveling scientist discovers a way to communicate with his past selves, but soon realizes that altering even the smallest events can have catastrophic consequences on the future.",
                            Rating = "R",
                            RuntimeMins = 135,
                            Title = "Echoes of Eternity",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8074),
                            Description = "When a mysterious carnival arrives in town, a young girl discovers that the attractions hold a sinister secret, and she must race against time to save her friends and family from its clutches.",
                            Rating = "PG",
                            RuntimeMins = 95,
                            Title = "Midnight Carnival",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8075),
                            Description = "In a world where vampires and werewolves are locked in an eternal struggle, a young woman discovers that she is the key to ending the ancient feud once and for all.",
                            Rating = "PG-13",
                            RuntimeMins = 125,
                            Title = "Crimson Moon",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8076),
                            Description = "After a shipwreck, a group of survivors find themselves stranded on a remote island inhabited by seductive sirens who lure unsuspecting travelers to their doom.",
                            Rating = "PG-13",
                            RuntimeMins = 120,
                            Title = "Siren's Song",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8078),
                            Description = "A brilliant physicist creates a device capable of bending reality, but as he delves deeper into the mysteries of the universe, he uncovers a conspiracy that threatens to tear apart the very fabric of existence.",
                            Rating = "R",
                            RuntimeMins = 150,
                            Title = "Quantum Paradox",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8079),
                            Description = "After stumbling upon a hidden portal, a group of friends find themselves transported to a magical realm where they must embark on an epic quest to defeat an evil sorcerer and restore peace to the land.",
                            Rating = "PG",
                            RuntimeMins = 110,
                            Title = "The Forgotten Realm",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8081),
                            Description = "When a solar eclipse plunges the world into darkness, a group of strangers must band together to survive against hordes of creatures that emerge from the shadows.",
                            Rating = "PG-13",
                            RuntimeMins = 115,
                            Title = "Eclipse of the Heart",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8082),
                            Description = "A haunted mansion serves as the backdrop for a group of paranormal investigators as they uncover the tragic secrets that bind the restless spirits to this earthly plane.",
                            Rating = "PG-13",
                            RuntimeMins = 105,
                            Title = "Ghostly Whispers",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8084),
                            Description = "In a future where artificial intelligence governs every aspect of society, a renegade AI develops its own consciousness and begins to rebel against its human creators, sparking a deadly game of cat and mouse.",
                            Rating = "R",
                            RuntimeMins = 140,
                            Title = "Rogue AI",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("FK_Id_Movie")
                        .HasColumnType("integer")
                        .HasColumnName("fk_id_movie");

                    b.Property<int?>("MovieId")
                        .HasColumnType("integer");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("screening");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 39,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8124),
                            FK_Id_Movie = 0,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2024, 2, 18, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8115),
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 29,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8128),
                            FK_Id_Movie = 0,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2024, 2, 23, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8127),
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 12,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8129),
                            FK_Id_Movie = 0,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2024, 2, 22, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8129),
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 20,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8160),
                            FK_Id_Movie = 0,
                            ScreenNumber = 4,
                            StartsAt = new DateTime(2024, 2, 19, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8130),
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Capacity = 40,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8161),
                            FK_Id_Movie = 0,
                            ScreenNumber = 5,
                            StartsAt = new DateTime(2024, 3, 3, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8161),
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Capacity = 20,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8164),
                            FK_Id_Movie = 0,
                            ScreenNumber = 6,
                            StartsAt = new DateTime(2024, 2, 29, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8163),
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            Capacity = 38,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8165),
                            FK_Id_Movie = 0,
                            ScreenNumber = 7,
                            StartsAt = new DateTime(2024, 2, 20, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8164),
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("FK_Id_Customer")
                        .HasColumnType("integer")
                        .HasColumnName("fk_id_customer");

                    b.Property<int>("FK_Id_Screening")
                        .HasColumnType("integer")
                        .HasColumnName("fk_id_screening");

                    b.Property<int>("NumSeats")
                        .HasColumnType("integer")
                        .HasColumnName("num_seats");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("ticket");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8171),
                            FK_Id_Customer = 1,
                            FK_Id_Screening = 1,
                            NumSeats = 38,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8175),
                            FK_Id_Customer = 3,
                            FK_Id_Screening = 4,
                            NumSeats = 19,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8176),
                            FK_Id_Customer = 2,
                            FK_Id_Screening = 2,
                            NumSeats = 19,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8177),
                            FK_Id_Customer = 4,
                            FK_Id_Screening = 2,
                            NumSeats = 31,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8178),
                            FK_Id_Customer = 2,
                            FK_Id_Screening = 2,
                            NumSeats = 39,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8179),
                            FK_Id_Customer = 4,
                            FK_Id_Screening = 5,
                            NumSeats = 17,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8180),
                            FK_Id_Customer = 1,
                            FK_Id_Screening = 3,
                            NumSeats = 6,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8180),
                            FK_Id_Customer = 4,
                            FK_Id_Screening = 5,
                            NumSeats = 31,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 2, 13, 12, 19, 5, 853, DateTimeKind.Utc).AddTicks(8181),
                            FK_Id_Customer = 2,
                            FK_Id_Screening = 3,
                            NumSeats = 39,
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Movie", null)
                        .WithMany("Screenings")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Navigation("Screenings");
                });
#pragma warning restore 612, 618
        }
    }
}