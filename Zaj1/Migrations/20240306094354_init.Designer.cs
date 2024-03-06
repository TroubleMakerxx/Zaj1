﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Zaj1.Models;

#nullable disable

namespace Zaj1.Migrations
{
    [DbContext(typeof(FilmyConetext))]
    [Migration("20240306094354_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Zaj1.Models.film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataDodania")
                        .HasColumnType("datetime2");

                    b.Property<int>("KategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Rezyser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tytul")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriaId");

                    b.ToTable("Filmy");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cena = "25zł",
                            DataDodania = new DateTime(2024, 3, 6, 10, 43, 53, 737, DateTimeKind.Local).AddTicks(1978),
                            KategoriaId = 2,
                            Opis = "Thriller science fiction o kradzieży danych umysłu",
                            Rezyser = "Christopher Nolan",
                            Tytul = "Incepcja"
                        },
                        new
                        {
                            Id = 2,
                            Cena = "22zł",
                            DataDodania = new DateTime(2024, 3, 6, 10, 43, 53, 737, DateTimeKind.Local).AddTicks(2023),
                            KategoriaId = 2,
                            Opis = "Film akcji o walce ludzi przeciwko maszynom",
                            Rezyser = "Lana Wachowski, Lilly Wachowski",
                            Tytul = "Matrix"
                        },
                        new
                        {
                            Id = 3,
                            Cena = "18zł",
                            DataDodania = new DateTime(2024, 3, 6, 10, 43, 53, 737, DateTimeKind.Local).AddTicks(2027),
                            KategoriaId = 3,
                            Opis = "Dramat więzienny oparty na noweli Stephena Kinga",
                            Rezyser = "Frank Darabont",
                            Tytul = "Shawshank Redemption"
                        },
                        new
                        {
                            Id = 4,
                            Cena = "23zł",
                            DataDodania = new DateTime(2024, 3, 6, 10, 43, 53, 737, DateTimeKind.Local).AddTicks(2031),
                            KategoriaId = 3,
                            Opis = "Western o niewolnictwie i zemście",
                            Rezyser = "Quentin Tarantino",
                            Tytul = "Django Unchained"
                        },
                        new
                        {
                            Id = 5,
                            Cena = "28zł",
                            DataDodania = new DateTime(2024, 3, 6, 10, 43, 53, 737, DateTimeKind.Local).AddTicks(2035),
                            KategoriaId = 2,
                            Opis = "Epicki film science fiction o podróży międzygwiezdnej",
                            Rezyser = "Christopher Nolan",
                            Tytul = "Interstellar"
                        });
                });

            modelBuilder.Entity("Zaj1.Models.Kategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategorie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nazwa = "Akcja",
                            Opis = "Filmy pełne ekscytujących scen akcji"
                        },
                        new
                        {
                            Id = 2,
                            Nazwa = "Science Fiction",
                            Opis = "Filmy o niesamowitej technologii, podróżach kosmicznych itp."
                        },
                        new
                        {
                            Id = 3,
                            Nazwa = "Dramat",
                            Opis = "Filmy poruszające emocje i przedstawiające złożone historie"
                        },
                        new
                        {
                            Id = 4,
                            Nazwa = "Western",
                            Opis = "Filmy osadzone w dzikim Zachodzie z charakterystycznymi elementami"
                        },
                        new
                        {
                            Id = 5,
                            Nazwa = "Thriller",
                            Opis = "Filmy z napięciem i elementami zagadki"
                        },
                        new
                        {
                            Id = 6,
                            Nazwa = "Komedia",
                            Opis = "Filmy, które mają za zadanie rozbawić widza"
                        });
                });

            modelBuilder.Entity("Zaj1.Models.film", b =>
                {
                    b.HasOne("Zaj1.Models.Kategoria", "Kategoria")
                        .WithMany("Filmy")
                        .HasForeignKey("KategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategoria");
                });

            modelBuilder.Entity("Zaj1.Models.Kategoria", b =>
                {
                    b.Navigation("Filmy");
                });
#pragma warning restore 612, 618
        }
    }
}
