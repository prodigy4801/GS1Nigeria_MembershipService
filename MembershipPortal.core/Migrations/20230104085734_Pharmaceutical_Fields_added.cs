using Microsoft.EntityFrameworkCore.Migrations;

namespace MembershipPortal.core.Migrations
{
    public partial class Pharmaceutical_Fields_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActiveIngredient",
                schema: "dbo",
                table: "PharmaceuticalInformations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DirectionOfUse",
                schema: "dbo",
                table: "PharmaceuticalInformations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FunctionalName",
                schema: "dbo",
                table: "PharmaceuticalInformations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShelfLife",
                schema: "dbo",
                table: "PharmaceuticalInformations",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiveIngredient",
                schema: "dbo",
                table: "PharmaceuticalInformations");

            migrationBuilder.DropColumn(
                name: "DirectionOfUse",
                schema: "dbo",
                table: "PharmaceuticalInformations");

            migrationBuilder.DropColumn(
                name: "FunctionalName",
                schema: "dbo",
                table: "PharmaceuticalInformations");

            migrationBuilder.DropColumn(
                name: "ShelfLife",
                schema: "dbo",
                table: "PharmaceuticalInformations");
        }
    }
}
