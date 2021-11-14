using Microsoft.EntityFrameworkCore.Migrations;

namespace SignUp.Migrations
{
    public partial class fiveItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Item3",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Item4",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Item5",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name3",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name4",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name5",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Item3",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Item4",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Item5",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Name3",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Name4",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Name5",
                table: "Event");
        }
    }
}
