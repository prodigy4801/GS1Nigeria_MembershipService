using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MembershipPortal.core.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BrickCategories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brick_id = table.Column<int>(type: "int", nullable: false),
                    brick = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: DateTime.Now),
                    modifieddate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrickCategories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GLNInformations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    registrationid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    gln = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    companyprefix = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: DateTime.Now),
                    modifieddate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLNInformations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GTINInformations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    registrationid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    gtin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    companyprefix = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    productcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    checksum = table.Column<int>(type: "int", nullable: false),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: DateTime.Now),
                    modifieddate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GTINInformations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ITFInformations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    registrationid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    itf14 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    companyprefix = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: DateTime.Now),
                    modifieddate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITFInformations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NetContents",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: DateTime.Now),
                    modifieddate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetContents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PackageLevels",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    level = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: DateTime.Now),
                    modifieddate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageLevels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PackagingTypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    packagingname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: DateTime.Now),
                    modifieddate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackagingTypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TargetMarkets",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetMarkets", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gtin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    registrationid = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    netcontent_id = table.Column<int>(type: "int", nullable: false),
                    brandname = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    packagingtype_id = table.Column<int>(type: "int", nullable: false),
                    productdescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    marketingmessage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    targetmarket_id = table.Column<int>(type: "int", nullable: false),
                    consumerfirstavailabilitydate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    netweight = table.Column<double>(type: "float", nullable: false),
                    iscompleted = table.Column<bool>(type: "bit", nullable: false),
                    grossweight = table.Column<double>(type: "float", nullable: false),
                    brickcategory_id = table.Column<int>(type: "int", nullable: false),
                    frontimage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    hasimage = table.Column<bool>(type: "bit", nullable: false),
                    backimage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    dateoflisting = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ingredients = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    allergeninfo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    nafdacnumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    storageinstruction = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    directionofuse = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    lifespan = table.Column<int>(type: "int", nullable: false),
                    lifespanunit = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    packaginglevel_id = table.Column<int>(type: "int", nullable: false),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: DateTime.Now),
                    modifieddate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_BrickCategories_brickcategory_id",
                        column: x => x.brickcategory_id,
                        principalTable: "BrickCategories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_NetContents_netcontent_id",
                        column: x => x.netcontent_id,
                        principalTable: "NetContents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_PackageLevels_packaginglevel_id",
                        column: x => x.packaginglevel_id,
                        principalTable: "PackageLevels",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_PackagingTypes_packagingtype_id",
                        column: x => x.packagingtype_id,
                        principalTable: "PackagingTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_TargetMarkets_targetmarket_id",
                        column: x => x.targetmarket_id,
                        principalTable: "TargetMarkets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_brickcategory_id",
                table: "Products",
                column: "brickcategory_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_netcontent_id",
                table: "Products",
                column: "netcontent_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_packaginglevel_id",
                table: "Products",
                column: "packaginglevel_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_packagingtype_id",
                table: "Products",
                column: "packagingtype_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_targetmarket_id",
                table: "Products",
                column: "targetmarket_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GLNInformations");

            migrationBuilder.DropTable(
                name: "GTINInformations");

            migrationBuilder.DropTable(
                name: "ITFInformations");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "BrickCategories");

            migrationBuilder.DropTable(
                name: "NetContents");

            migrationBuilder.DropTable(
                name: "PackageLevels");

            migrationBuilder.DropTable(
                name: "PackagingTypes");

            migrationBuilder.DropTable(
                name: "TargetMarkets");
        }
    }
}
