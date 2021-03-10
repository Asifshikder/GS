using Microsoft.EntityFrameworkCore.Migrations;

namespace GS.REPO.Migrations
{
    public partial class dsfsdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogImage");

            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "BlogPost",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductInstall",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInstall", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductInstall");

            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "BlogPost");

            migrationBuilder.CreateTable(
                name: "BlogImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogPostId = table.Column<int>(type: "int", nullable: false),
                    ImageFile = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogImage_BlogPost_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogImage_BlogPostId",
                table: "BlogImage",
                column: "BlogPostId");
        }
    }
}
