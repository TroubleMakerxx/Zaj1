using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zaj1.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PlakatUrl",
                table: "Filmy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlakatUrl",
                table: "Filmy");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataDodania",
                value: new DateTime(2024, 3, 6, 10, 43, 53, 737, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataDodania",
                value: new DateTime(2024, 3, 6, 10, 43, 53, 737, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataDodania",
                value: new DateTime(2024, 3, 6, 10, 43, 53, 737, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataDodania",
                value: new DateTime(2024, 3, 6, 10, 43, 53, 737, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataDodania",
                value: new DateTime(2024, 3, 6, 10, 43, 53, 737, DateTimeKind.Local).AddTicks(2035));
        }
    }
}
