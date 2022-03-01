using Microsoft.EntityFrameworkCore.Migrations;

namespace MembershipPortal.core.Migrations
{
    public partial class makeprodunique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_gtin",
                table: "Products",
                column: "gtin",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_gtin",
                table: "Products");
        }
    }
}
