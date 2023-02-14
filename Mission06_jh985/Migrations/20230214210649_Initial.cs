using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_jh985.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Response",
                columns: table => new
                {
                    Title = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Response", x => x.Title);
                });

            migrationBuilder.InsertData(
                table: "Response",
                columns: new[] { "Title", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Year" },
                values: new object[] { "The Proposal", "Romance", "Joseph B. Worthin", true, "David A Bednar", "Best Movie created babe", "PG-13", 1980 });

            migrationBuilder.InsertData(
                table: "Response",
                columns: new[] { "Title", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Year" },
                values: new object[] { "Harry Potter", "Fantasy", "JK Rowling", false, "Pooh Bear", "pretty good movie babe", "PG-13", 2007 });

            migrationBuilder.InsertData(
                table: "Response",
                columns: new[] { "Title", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Year" },
                values: new object[] { "Forever Strong", "Sports", "Kevin Holt", true, "Dee Dee Holt", "Motivated me to win the state champtionship", "R", 2013 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Response");
        }
    }
}
