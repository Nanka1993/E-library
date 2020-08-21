using Microsoft.EntityFrameworkCore.Migrations;

namespace E_library.Migrations
{
    public partial class AddBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
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
                    Editors = table.Column<string>(nullable: true),
                    Bbk = table.Column<string>(nullable: true),
                    Isbn = table.Column<string>(nullable: true),
                    PublishingOfficeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
