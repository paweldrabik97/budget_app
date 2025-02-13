using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AnotherRolesInsert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "5dc81b8d-4299-4894-a7b8-3a48582fcb7d", "3fa42654-5e3f-4f2c-a819-4aaf9ec47998", "Admin", "ADMIN" },
                    { "7fcb0247-adea-404f-ad49-17539b8f132e", "37fb5e3a-de88-45e2-a5ae-665cd2dab0c1", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dc81b8d-4299-4894-a7b8-3a48582fcb7d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fcb0247-adea-404f-ad49-17539b8f132e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "011c50fb-21d1-40e0-ae43-3dd027531a65", null, "User", "USER" },
                    { "7a8420e9-53f1-43c4-a0b3-5a4695fa7293", null, "Admin", "ADMIN" }
                });
        }
    }
}
