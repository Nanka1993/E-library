using Microsoft.EntityFrameworkCore.Migrations;

namespace E_library.Migrations
{
    public partial class AddMagazines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Magazines",
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
                    Number = table.Column<int>(nullable: false),
                    Issn = table.Column<string>(nullable: true),
                    RubricatorName = table.Column<string>(nullable: true),
                    IsIncludedInWebOfScience = table.Column<bool>(nullable: false),
                    IsIncludedVak = table.Column<bool>(nullable: false),
                    InclusionInformationInRints = table.Column<string>(nullable: true),
                    InclusionInformationInScopus = table.Column<string>(nullable: true),
                    PublishingOfficeName = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magazines", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Magazines");
        }
    }
}
