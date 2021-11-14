using Microsoft.EntityFrameworkCore.Migrations;

namespace SignUp.Migrations
{
    public partial class AddTaskItemAndName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Item1",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name1",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Item1",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Name1",
                table: "Event");
        }
    }
}
