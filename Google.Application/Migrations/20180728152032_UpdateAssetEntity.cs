using Microsoft.EntityFrameworkCore.Migrations;

namespace Google.Application.Migrations
{
    public partial class UpdateAssetEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FileType",
                table: "Assets",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileType",
                table: "Assets",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
