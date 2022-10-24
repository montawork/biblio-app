using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Addesses");

            migrationBuilder.DropColumn(
                name: "HouseNumber",
                table: "Addesses");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Addesses",
                newName: "City");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                table: "Addesses",
                newName: "State");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Addesses",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "HouseNumber",
                table: "Addesses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
