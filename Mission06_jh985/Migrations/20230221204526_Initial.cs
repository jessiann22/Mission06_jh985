using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_jh985.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Response",
                columns: table => new
                {
                    Title = table.Column<string>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Response_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Action" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Romance" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 4, "Sports" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 5, "Fantasy" });

            migrationBuilder.InsertData(
                table: "Response",
                columns: new[] { "Title", "CategoryID", "Director", "Edited", "Lent", "Notes", "Rating", "Year" },
                values: new object[] { "The Proposal", 3, "Joseph B. Worthin", true, "David A Bednar", "Best Movie created babe", "PG-13", 1980 });

            migrationBuilder.InsertData(
                table: "Response",
                columns: new[] { "Title", "CategoryID", "Director", "Edited", "Lent", "Notes", "Rating", "Year" },
                values: new object[] { "Forever Strong", 4, "Kevin Holt", true, "Dee Dee Holt", "Motivated me to win the state champtionship", "R", 2013 });

            migrationBuilder.InsertData(
                table: "Response",
                columns: new[] { "Title", "CategoryID", "Director", "Edited", "Lent", "Notes", "Rating", "Year" },
                values: new object[] { "Harry Potter", 5, "JK Rowling", false, "Pooh Bear", "pretty good movie babe", "PG-13", 2007 });

            migrationBuilder.CreateIndex(
                name: "IX_Response_CategoryID",
                table: "Response",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Response");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
