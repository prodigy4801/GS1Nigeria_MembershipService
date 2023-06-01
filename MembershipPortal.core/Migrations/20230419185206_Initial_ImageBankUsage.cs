using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MembershipPortal.core.Migrations
{
    public partial class Initial_ImageBankUsage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImageBankUsages",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    registrationid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gtin = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    downloadCount = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageBankUsages", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageBankUsages_gtin",
                schema: "dbo",
                table: "ImageBankUsages",
                column: "gtin",
                unique: true,
                filter: "[gtin] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageBankUsages",
                schema: "dbo");
        }
    }
}
