using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a4dc4bb-4f64-4809-9adf-b9ee486f1a0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5a7c29c-d1b6-4e11-acd1-90485d84d6c8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "011c50fb-21d1-40e0-ae43-3dd027531a65", null, "User", "USER" },
                    { "7a8420e9-53f1-43c4-a0b3-5a4695fa7293", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "011c50fb-21d1-40e0-ae43-3dd027531a65");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a8420e9-53f1-43c4-a0b3-5a4695fa7293");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a4dc4bb-4f64-4809-9adf-b9ee486f1a0d", null, "User", "USER" },
                    { "f5a7c29c-d1b6-4e11-acd1-90485d84d6c8", null, "Admin", "ADMIN" }
                });
        }
    }
}
