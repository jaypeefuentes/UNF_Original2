using Microsoft.EntityFrameworkCore.Migrations;

namespace UNFHackathonManagementSystem.Data.Migrations
{
    public partial class Competition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Competition",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Competition",
                newName: "Date");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Competition",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Organizer",
                table: "Competition",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Competition");

            migrationBuilder.DropColumn(
                name: "Organizer",
                table: "Competition");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Competition",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Competition",
                newName: "EndDate");
        }
    }
}
