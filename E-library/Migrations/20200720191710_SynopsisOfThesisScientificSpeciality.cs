using Microsoft.EntityFrameworkCore.Migrations;

namespace E_library.Migrations
{
    public partial class SynopsisOfThesisScientificSpeciality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScientificSpecialtiy",
                table: "SynopsisOfThesises");

            migrationBuilder.AddColumn<string>(
                name: "ScientificSpeciality",
                table: "SynopsisOfThesises",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScientificSpeciality",
                table: "SynopsisOfThesises");

            migrationBuilder.AddColumn<string>(
                name: "ScientificSpecialtiy",
                table: "SynopsisOfThesises",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
