using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StayHealthy.Data.Migrations
{
    public partial class Consultmodeladdnewattributesrescaffold : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imageName",
                table: "Consult",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "subject",
                table: "Consult",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageName",
                table: "Consult");

            migrationBuilder.DropColumn(
                name: "subject",
                table: "Consult");
        }
    }
}
