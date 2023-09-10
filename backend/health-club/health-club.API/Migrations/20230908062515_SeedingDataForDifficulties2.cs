using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace health_club.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataForDifficulties2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("98404c19-bca0-4421-bb17-1a64360890de"), "Hard" },
                    { new Guid("ddfdf227-2cfe-484c-a911-04756f9cac34"), "Medium" },
                    { new Guid("f903e81c-7be0-4f1f-a1bf-75645e618028"), "Easy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("98404c19-bca0-4421-bb17-1a64360890de"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("ddfdf227-2cfe-484c-a911-04756f9cac34"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("f903e81c-7be0-4f1f-a1bf-75645e618028"));
        }
    }
}
