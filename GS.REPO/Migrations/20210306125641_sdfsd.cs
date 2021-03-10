using Microsoft.EntityFrameworkCore.Migrations;

namespace GS.REPO.Migrations
{
    public partial class sdfsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "BaseGaragePort",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "BaseGaragePort",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "BaseGaragePort");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "BaseGaragePort");
        }
    }
}
