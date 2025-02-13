using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AnotherOneRolesInsert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "00b2911a-4448-4a0e-9946-3ab401b9d965", null, "User", "USER" },
                    { "3ca1440e-f1bf-4bb5-84b0-68c10b684d6a", "dfb1f236-bfef-4ca8-b6a4-e03ce7f87083", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00b2911a-4448-4a0e-9946-3ab401b9d965");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ca1440e-f1bf-4bb5-84b0-68c10b684d6a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5dc81b8d-4299-4894-a7b8-3a48582fcb7d", "3fa42654-5e3f-4f2c-a819-4aaf9ec47998", "Admin", "ADMIN" },
                    { "7fcb0247-adea-404f-ad49-17539b8f132e", "37fb5e3a-de88-45e2-a5ae-665cd2dab0c1", "User", "USER" }
                });
        }
    }
}
