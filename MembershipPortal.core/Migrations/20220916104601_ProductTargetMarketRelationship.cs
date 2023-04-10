using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MembershipPortal.core.Migrations
{
    public partial class ProductTargetMarketRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_TargetMarkets_targetmarket_id",
                schema: "dbo",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_targetmarket_id",
                schema: "dbo",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "targetmarket_id",
                schema: "dbo",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ProductTargetMarkets",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    targetmarket_id = table.Column<int>(type: "int", nullable: false),
                    registrationid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datecreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTargetMarkets", x => new { x.id, x.product_id, x.targetmarket_id });
                    table.ForeignKey(
                        name: "FK_ProductTargetMarkets_Products_product_id",
                        column: x => x.product_id,
                        principalSchema: "dbo",
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTargetMarkets_TargetMarkets_targetmarket_id",
                        column: x => x.targetmarket_id,
                        principalSchema: "dbo",
                        principalTable: "TargetMarkets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTargetMarkets_product_id",
                schema: "dbo",
                table: "ProductTargetMarkets",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTargetMarkets_targetmarket_id",
                schema: "dbo",
                table: "ProductTargetMarkets",
                column: "targetmarket_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTargetMarkets",
                schema: "dbo");

            migrationBuilder.AlterColumn<int>(
                name: "targetmarket_id",
                schema: "dbo",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_targetmarket_id",
                schema: "dbo",
                table: "Products",
                column: "targetmarket_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TargetMarkets_targetmarket_id",
                schema: "dbo",
                table: "Products",
                column: "targetmarket_id",
                principalSchema: "dbo",
                principalTable: "TargetMarkets",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
