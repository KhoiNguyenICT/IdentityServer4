using Microsoft.EntityFrameworkCore.Migrations;

namespace Google.Application.Migrations
{
    public partial class UpdateAssetEntity1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileType",
                table: "Assets",
                newName: "ContentType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContentType",
                table: "Assets",
                newName: "FileType");
        }
    }
}
