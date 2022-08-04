using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MembershipPortal.core.Migrations
{
    public partial class ApplicationContext_Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "BrandInformations",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brandname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    registrationid = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifieddate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandInformations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BrickCategories",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brick_id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    brick = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrickCategories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GCPInformations",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyPrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GtinCount = table.Column<int>(type: "int", nullable: false),
                    MaxGtin = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    IsEmailSent = table.Column<bool>(type: "bit", nullable: false),
                    DateOfIssuance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCPInformations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GLNInformations",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    registrationid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    glnrequestid = table.Column<int>(type: "int", nullable: false),
                    gln = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    companyprefix = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    asignedby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifieddate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GLNInformations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GTINInformations",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    registrationid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    gtin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    companyprefix = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    productcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    checksum = table.Column<int>(type: "int", nullable: false),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifieddate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GTINInformations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ITFInformations",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    registrationid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    itf14 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    companyprefix = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifieddate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITFInformations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NetContents",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetContents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PackageLevels",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageLevels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PackagingTypes",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackagingTypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TargetMarkets",
                schema: "dbo",
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
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gtin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    registrationid = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    netcontent_id = table.Column<int>(type: "int", nullable: true),
                    brandname = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    brandinformation_id = table.Column<int>(type: "int", nullable: true),
                    packagingtype_id = table.Column<int>(type: "int", nullable: true),
                    productdescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    marketingmessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    targetmarket_id = table.Column<int>(type: "int", nullable: true),
                    consumerfirstavailabilitydate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    netweight = table.Column<double>(type: "float", nullable: false),
                    iscompleted = table.Column<bool>(type: "bit", nullable: false),
                    grossweight = table.Column<double>(type: "float", nullable: false),
                    brickcategory_id = table.Column<int>(type: "int", nullable: true),
                    frontimage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    hasimage = table.Column<bool>(type: "bit", nullable: false),
                    backimage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    dateoflisting = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ingredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    allergeninfo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    nafdacnumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    storageinstruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    directionofuse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lifespan = table.Column<int>(type: "int", nullable: false),
                    lifespanunit = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    packaginglevel_id = table.Column<int>(type: "int", nullable: true),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifieddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPharma = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_BrandInformations_brandinformation_id",
                        column: x => x.brandinformation_id,
                        principalSchema: "dbo",
                        principalTable: "BrandInformations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_BrickCategories_brickcategory_id",
                        column: x => x.brickcategory_id,
                        principalSchema: "dbo",
                        principalTable: "BrickCategories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_NetContents_netcontent_id",
                        column: x => x.netcontent_id,
                        principalSchema: "dbo",
                        principalTable: "NetContents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_PackageLevels_packaginglevel_id",
                        column: x => x.packaginglevel_id,
                        principalSchema: "dbo",
                        principalTable: "PackageLevels",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_PackagingTypes_packagingtype_id",
                        column: x => x.packagingtype_id,
                        principalSchema: "dbo",
                        principalTable: "PackagingTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_TargetMarkets_targetmarket_id",
                        column: x => x.targetmarket_id,
                        principalSchema: "dbo",
                        principalTable: "TargetMarkets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExternalUnifiedModels",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    functionalname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    genericname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    tradeitemdescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    strength = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    productform = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    routeofadministration = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    shelflife = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    atccode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    packsize = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    quantity = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    unitofmeasure = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    primarypackagingmaterial = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    labeldescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    datecreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datemodified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifiedby = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalUnifiedModels", x => x.id);
                    table.ForeignKey(
                        name: "FK_ExternalUnifiedModels_Products_product_id",
                        column: x => x.product_id,
                        principalSchema: "dbo",
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PharmaceuticalInformations",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenericName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradeItemDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Strength = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductForm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RouteOfAdministration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ATCCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryPackagingMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmaceuticalInformations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PharmaceuticalInformations_Products_ProductID",
                        column: x => x.ProductID,
                        principalSchema: "dbo",
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrandInformations_brandname",
                schema: "dbo",
                table: "BrandInformations",
                column: "brandname",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExternalUnifiedModels_product_id",
                schema: "dbo",
                table: "ExternalUnifiedModels",
                column: "product_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PharmaceuticalInformations_ProductID",
                schema: "dbo",
                table: "PharmaceuticalInformations",
                column: "ProductID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_brandinformation_id",
                schema: "dbo",
                table: "Products",
                column: "brandinformation_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_brickcategory_id",
                schema: "dbo",
                table: "Products",
                column: "brickcategory_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_gtin",
                schema: "dbo",
                table: "Products",
                column: "gtin",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_netcontent_id",
                schema: "dbo",
                table: "Products",
                column: "netcontent_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_packaginglevel_id",
                schema: "dbo",
                table: "Products",
                column: "packaginglevel_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_packagingtype_id",
                schema: "dbo",
                table: "Products",
                column: "packagingtype_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_targetmarket_id",
                schema: "dbo",
                table: "Products",
                column: "targetmarket_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExternalUnifiedModels",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GCPInformations",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GLNInformations",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GTINInformations",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ITFInformations",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PharmaceuticalInformations",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BrandInformations",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BrickCategories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "NetContents",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PackageLevels",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PackagingTypes",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TargetMarkets",
                schema: "dbo");
        }
    }
}
