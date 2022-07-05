using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MembershipPortal.core.Migrations
{
    public partial class BrandInformation_Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "brandinformation_id",
                schema: "dbo",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BrandInformations",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brandname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    registrationid = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifieddate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandInformations", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_brandinformation_id",
                schema: "dbo",
                table: "Products",
                column: "brandinformation_id");

            migrationBuilder.CreateIndex(
                name: "IX_BrandInformations_brandname",
                schema: "dbo",
                table: "BrandInformations",
                column: "brandname",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BrandInformations_brandinformation_id",
                schema: "dbo",
                table: "Products",
                column: "brandinformation_id",
                principalSchema: "dbo",
                principalTable: "BrandInformations",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_BrandInformations_brandinformation_id",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropTable(
                name: "BrandInformations",
                schema: "dbo");

            migrationBuilder.DropIndex(
                name: "IX_Products_brandinformation_id",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "brandinformation_id",
                schema: "dbo",
                table: "Products");
        }
    }
}
