using Microsoft.EntityFrameworkCore.Migrations;

namespace E_library.Migrations
{
    public partial class AddSynopsisesOfThesis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SynopsisOfThesises",
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
                    DissertationId = table.Column<int>(nullable: true),
                    Institution = table.Column<string>(nullable: true),
                    AcademicAdviser = table.Column<string>(nullable: true),
                    ScientificSpecialtiy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SynopsisOfThesises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SynopsisOfThesises_Dissertations_DissertationId",
                        column: x => x.DissertationId,
                        principalTable: "Dissertations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SynopsisOfThesises_DissertationId",
                table: "SynopsisOfThesises",
                column: "DissertationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SynopsisOfThesises");
        }
    }
}
