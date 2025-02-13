using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AnotherThreeRolesInsert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "09ec5bc8-ae9a-4728-9791-188be26d77d8", "1", "Admin", "ADMIN" },
                    { "a26d83ad-30a7-4cbb-bc6b-80eaa01cdc04", "2", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09ec5bc8-ae9a-4728-9791-188be26d77d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a26d83ad-30a7-4cbb-bc6b-80eaa01cdc04");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03a3f3de-cb5e-428d-a2e1-fef05fc6afe9", "6174c955-bef5-4e98-adcf-ddc8bd1328d1", "Admin", "ADMIN" },
                    { "a82a3246-f700-42e6-a358-dc5d679cd0aa", null, "User", "USER" }
                });
        }
    }
}
