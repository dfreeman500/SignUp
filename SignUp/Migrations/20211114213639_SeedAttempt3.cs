using Microsoft.EntityFrameworkCore.Migrations;

namespace SignUp.Migrations
{
    public partial class SeedAttempt3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Email", "EventId", "PersonName", "PhoneNumber" },
                values: new object[] { -2147482647, "Goliath@goliath.com", 1, "Goliath", "555-555-5555" });
        }
    }
}
