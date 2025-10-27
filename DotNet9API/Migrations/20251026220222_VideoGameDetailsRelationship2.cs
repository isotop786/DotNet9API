using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNet9API.Migrations
{
    /// <inheritdoc />
    public partial class VideoGameDetailsRelationship2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "VideoGameDetails",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "VideoGameDetails",
                newName: "Title");
        }
    }
}
