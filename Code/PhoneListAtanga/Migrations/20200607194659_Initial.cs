using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneListAtanga.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    NoteId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.NoteId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Adress = table.Column<string>(nullable: false),
                    NoteId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contacts_Notes_NoteId",
                        column: x => x.NoteId,
                        principalTable: "Notes",
                        principalColumn: "NoteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "NoteId", "Name" },
                values: new object[,]
                {
                    { "A", "Aquintance" },
                    { "B", "Business" },
                    { "F", "Friend" },
                    { "C", "Family" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Adress", "Name", "NoteId", "Phone" },
                values: new object[] { 2, "201 Way St Des Moines Iowa 50310", "Jill Dawkins", "A", "515-225-6525" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Adress", "Name", "NoteId", "Phone" },
                values: new object[] { 1, "5225 SE Gateway Johnston IA 50131", "Joe Struss", "B", "515-225-6050" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Adress", "Name", "NoteId", "Phone" },
                values: new object[] { 3, "1252 Millway WaukeeIowa 50222", "Jay Atanga", "C", "515-226-9060" });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_NoteId",
                table: "Contacts",
                column: "NoteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
