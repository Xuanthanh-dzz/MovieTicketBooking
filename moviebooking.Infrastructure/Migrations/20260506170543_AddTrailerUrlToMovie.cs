using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace moviebooking.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddTrailerUrlToMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Traillerurl",
                table: "movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Traillerurl",
                table: "movies");
        }
    }
}
