using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zaj1.Migrations
{
    public partial class initialization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataDodania", "PlakatUrl" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 31, 46, 833, DateTimeKind.Local).AddTicks(1760), "MagicHeal.jpg" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataDodania", "PlakatUrl" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 31, 46, 833, DateTimeKind.Local).AddTicks(1801), "Solo.png" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataDodania", "PlakatUrl" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 31, 46, 833, DateTimeKind.Local).AddTicks(1804), "Shrek.jpg" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataDodania", "PlakatUrl" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 31, 46, 833, DateTimeKind.Local).AddTicks(1807), "Exorcisto.jpg" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataDodania", "PlakatUrl" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 31, 46, 833, DateTimeKind.Local).AddTicks(1810), "Harry.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataDodania", "PlakatUrl" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 13, 43, 531, DateTimeKind.Local).AddTicks(8392), "Zaj1/Views/Filmy/Grafiki/MagicHeal" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataDodania", "PlakatUrl" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 13, 43, 531, DateTimeKind.Local).AddTicks(8436), "Zaj1/Views/Filmy/Grafiki/Solo" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataDodania", "PlakatUrl" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 13, 43, 531, DateTimeKind.Local).AddTicks(8439), "Zaj1/Views/Filmy/Grafiki/Shrek" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataDodania", "PlakatUrl" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 13, 43, 531, DateTimeKind.Local).AddTicks(8442), "Zaj1/Views/Filmy/Grafiki/Exorcisto" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataDodania", "PlakatUrl" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 13, 43, 531, DateTimeKind.Local).AddTicks(8445), "Zaj1/Views/Filmy/Grafiki/Harry" });
        }
    }
}
