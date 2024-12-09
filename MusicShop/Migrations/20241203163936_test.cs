using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicShop.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HResult",
                table: "artists",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HelpLink",
                table: "artists",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "artists",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HResult",
                table: "artists");

            migrationBuilder.DropColumn(
                name: "HelpLink",
                table: "artists");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "artists");
        }
    }
}
