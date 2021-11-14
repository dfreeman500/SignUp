using Microsoft.EntityFrameworkCore.Migrations;

namespace SignUp.Migrations
{
    public partial class SeedAttempt4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Email", "EventId", "PersonName", "PhoneNumber" },
                values: new object[] { 1, "a", 1, "G", "1" });
        }
    }
}
