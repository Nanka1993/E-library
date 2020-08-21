using Microsoft.EntityFrameworkCore.Migrations;

namespace E_library.Migrations
{
    public partial class AddDissertations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dissertations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CountryName = table.Column<string>(nullable: true),
                    IsOriginal = table.Column<bool>(nullable: false),
                    CityName = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    PageAmount = table.Column<int>(nullable: false),
                    Authors = table.Column<string>(nullable: true),
                    Udk = table.Column<string>(nullable: true),
                    Institution = table.Column<string>(nullable: true),
                    AcademicAdviser = table.Column<string>(nullable: true),
                    ScientificSpecialtiy = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dissertations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dissertations");
        }
    }
}
