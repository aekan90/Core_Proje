using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_changenameforExperience : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Experiances",
                table: "Experiances");

            migrationBuilder.RenameTable(
                name: "Experiances",
                newName: "Experiences");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experiences",
                table: "Experiences",
                column: "ExperianceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Experiences",
                table: "Experiences");

            migrationBuilder.RenameTable(
                name: "Experiences",
                newName: "Experiances");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experiances",
                table: "Experiances",
                column: "ExperianceId");
        }
    }
}
