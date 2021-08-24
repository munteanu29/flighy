using Microsoft.EntityFrameworkCore.Migrations;

namespace itec_backend.Migrations
{
    public partial class updateartist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "ArtistEntities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "ArtistEntities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ArtistEntities",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "ArtistEntities");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "ArtistEntities");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ArtistEntities");
        }
    }
}
