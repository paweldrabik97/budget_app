using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AnotherTwoRolesInsert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "03a3f3de-cb5e-428d-a2e1-fef05fc6afe9", "6174c955-bef5-4e98-adcf-ddc8bd1328d1", "Admin", "ADMIN" },
                    { "a82a3246-f700-42e6-a358-dc5d679cd0aa", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03a3f3de-cb5e-428d-a2e1-fef05fc6afe9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a82a3246-f700-42e6-a358-dc5d679cd0aa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00b2911a-4448-4a0e-9946-3ab401b9d965", null, "User", "USER" },
                    { "3ca1440e-f1bf-4bb5-84b0-68c10b684d6a", "dfb1f236-bfef-4ca8-b6a4-e03ce7f87083", "Admin", "ADMIN" }
                });
        }
    }
}
