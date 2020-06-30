using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentsAtanga.Migrations.Student
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Grade = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "Grade", "LastName" },
                values: new object[,]
                {
                    { 1, "John", "A", "Emeka" },
                    { 2, "Peter", "B", "Oniocha" },
                    { 3, "Frank", "A", "Eneigho" },
                    { 4, "Hamlet", "C", "Ngong" },
                    { 5, "Mark", "A", "Jacob" },
                    { 6, "Luke", "B", "Marshall" },
                    { 7, "James", "B", "Tyshawn" },
                    { 8, "Richard", "C", "Roberts" },
                    { 9, "Philip", "A", "Grace" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
