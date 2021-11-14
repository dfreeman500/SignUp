using Microsoft.EntityFrameworkCore.Migrations;

namespace SignUp.Migrations
{
    public partial class AddTaskItemAndName2ndtry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Item2",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name2",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Item2",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Name2",
                table: "Event");
        }
    }
}
