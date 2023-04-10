using Microsoft.EntityFrameworkCore.Migrations;

namespace MembershipPortal.core.Migrations
{
    public partial class Product_AddMoreImageFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "leftimage",
                schema: "dbo",
                table: "Products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "otherimage",
                schema: "dbo",
                table: "Products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "rightimage",
                schema: "dbo",
                table: "Products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "checksum",
                schema: "dbo",
                table: "GTINInformations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "leftimage",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "otherimage",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "rightimage",
                schema: "dbo",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "checksum",
                schema: "dbo",
                table: "GTINInformations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
