using Microsoft.EntityFrameworkCore.Migrations;

namespace UNFHackathonManagementSystem.Data.Migrations
{
    public partial class Added_Image_To_Competition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Competition",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Competition");
        }
    }
}
