using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace itec_backend.Migrations
{
    public partial class addartist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryEntities");

            migrationBuilder.CreateTable(
                name: "ArtistEntities",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistEntities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistEntities");

            migrationBuilder.CreateTable(
                name: "CountryEntities",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(767)", nullable: false),
                    CovidVaccinationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CovidVaccinationRate = table.Column<float>(type: "float", nullable: false),
                    Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryEntities", x => x.Id);
                });
        }
    }
}
