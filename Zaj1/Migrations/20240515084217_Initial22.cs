using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zaj1.Migrations
{
    public partial class Initial22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filmy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tytul = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rezyser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataDodania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlakatUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filmy_Kategorie_KategoriaId",
                        column: x => x.KategoriaId,
                        principalTable: "Kategorie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategorie",
                columns: new[] { "Id", "Nazwa", "Opis" },
                values: new object[,]
                {
                    { 1, "Akcja", "Filmy pełne ekscytujących scen akcji" },
                    { 2, "Science Fiction", "Filmy o niesamowitej technologii, podróżach kosmicznych itp." },
                    { 3, "Dramat", "Filmy poruszające emocje i przedstawiające złożone historie" },
                    { 4, "Western", "Filmy osadzone w dzikim Zachodzie z charakterystycznymi elementami" },
                    { 5, "Thriller", "Filmy z napięciem i elementami zagadki" },
                    { 6, "Komedia", "Filmy, które mają za zadanie rozbawić widza" }
                });

            migrationBuilder.InsertData(
                table: "Filmy",
                columns: new[] { "Id", "Cena", "DataDodania", "KategoriaId", "Opis", "PlakatUrl", "Rezyser", "Tytul" },
                values: new object[,]
                {
                    { 1, 25m, new DateTime(2024, 5, 15, 10, 42, 17, 224, DateTimeKind.Local).AddTicks(8591), 2, "Thriller science fiction o kradzieży danych umysłu", "MagicHeal.jpg", "Christopher Nolan", "Incepcja" },
                    { 2, 22m, new DateTime(2024, 5, 15, 10, 42, 17, 224, DateTimeKind.Local).AddTicks(8626), 2, "Film akcji o walce ludzi przeciwko maszynom", "Solo.png", "Lana Wachowski, Lilly Wachowski", "Matrix" },
                    { 3, 18m, new DateTime(2024, 5, 15, 10, 42, 17, 224, DateTimeKind.Local).AddTicks(8630), 3, "Dramat więzienny oparty na noweli Stephena Kinga", "Shrek.jpg", "Frank Darabont", "Shawshank Redemption" },
                    { 4, 23m, new DateTime(2024, 5, 15, 10, 42, 17, 224, DateTimeKind.Local).AddTicks(8633), 3, "Western o niewolnictwie i zemście", "Exorcisto.jpg", "Quentin Tarantino", "Django Unchained" },
                    { 5, 28m, new DateTime(2024, 5, 15, 10, 42, 17, 224, DateTimeKind.Local).AddTicks(8636), 2, "Epicki film science fiction o podróży międzygwiezdnej", "Harry.jpg", "Christopher Nolan", "Interstellar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmy_KategoriaId",
                table: "Filmy",
                column: "KategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmy");

            migrationBuilder.DropTable(
                name: "Kategorie");
        }
    }
}
