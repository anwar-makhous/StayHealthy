using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StayHealthy.Data.Migrations
{
    public partial class CreateConsultTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    content = table.Column<string>(type: "TEXT", nullable: true),
                    answered = table.Column<bool>(type: "INTEGER", nullable: false),
                    reply = table.Column<string>(type: "TEXT", nullable: true),
                    patientId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consult", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consult");
        }
    }
}
