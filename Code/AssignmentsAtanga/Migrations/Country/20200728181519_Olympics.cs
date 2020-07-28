using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentsAtanga.Migrations.Country
{
    public partial class Olympics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    GameId = table.Column<string>(nullable: false),
                    CategoryId = table.Column<string>(nullable: false),
                    photopath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                    table.ForeignKey(
                        name: "FK_Countries_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { "indoor", "Indoor" },
                    { "outdoor", "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Name" },
                values: new object[,]
                {
                    { "winter", "Winter Olympics" },
                    { "Summer", "Summer Olympics" },
                    { "Para", "Paralympics" },
                    { "Youth", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CategoryId", "GameId", "Name", "photopath" },
                values: new object[,]
                {
                    { "can", "indoor", "Winter", "Canada", "CAN.png" },
                    { "fin", "outdoor", "Youth", "Finland", "FIN.png" },
                    { "rus", "indoor", "Youth", "Russia", "RUS.png" },
                    { "cyp", "indoor", "Youth", "Cyprus", "CYP.png" },
                    { "fra", "indoor", "Youth", "France", "FRA.png" },
                    { "zim", "outdoor", "Para", "Zimbabwe", "ZIM.png" },
                    { "pak", "outdoor", "Para", "Pakistan", "PAK.png" },
                    { "aus", "outdoor", "Para", "Austria", "AUS.png" },
                    { "ukr", "indoor", "Para", "Ukraine", "UKR.png" },
                    { "uru", "indoor", "Para", "Uruguay", "URU.png" },
                    { "thai", "indoor", "Para", "Thailand", "THAI.png" },
                    { "usa", "outdoor", "Summer", "USA", "USA.png" },
                    { "neth", "outdoor", "Summer", "Netherlands", "NETH.png" },
                    { "bra", "outdoor", "Summer", "Brazil", "BRA.png" },
                    { "mex", "indoor", "Summer", "Mexico", "MEX.png" },
                    { "jap", "outdoor", "Winter", "Japan", "JAP.png" },
                    { "ita", "outdoor", "Winter", "Italy", "ITA.png" },
                    { "jam", "outdoor", "Winter", "Jamaica", "JAM.png" },
                    { "Chi", "indoor", "Summer ", "China", "CHI.png" },
                    { "ger", "indoor", "Summer ", "Germany", "GER.png" },
                    { "gb", "indoor", "Winter", "Great Britain", "GB.png" },
                    { "Swe", "indoor", "Winter", "Sweden", "SWE.png" },
                    { "slov", "outdoor", "Youth", "Slovakia", "SLOV.png" },
                    { "port", "outdoor", "Youth", "Portugal", "PORT.png" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CategoryId",
                table: "Countries",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameId",
                table: "Countries",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
