using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroes.Data.Migrations
{
    public partial class SuperHeroes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Atibutes",
                table: "SuperHeroes");

            migrationBuilder.AddColumn<string>(
                name: "AlterEgo",
                table: "SuperHeroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Atributes",
                table: "SuperHeroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Catchphrase",
                table: "SuperHeroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimaryAbility",
                table: "SuperHeroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondaryAbility",
                table: "SuperHeroes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlterEgo",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Atributes",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "Catchphrase",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "PrimaryAbility",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "SecondaryAbility",
                table: "SuperHeroes");

            migrationBuilder.AddColumn<string>(
                name: "Atibutes",
                table: "SuperHeroes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
