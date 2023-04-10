using Microsoft.EntityFrameworkCore.Migrations;

namespace MembershipPortal.core.Migrations
{
    public partial class Initial_Segement_Family_Class_CategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SegmentCategories",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SegmentCode = table.Column<int>(type: "int", nullable: false),
                    SegmentTitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    SegmentDefinition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SegmentCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FamilyCategories",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FamilyCode = table.Column<int>(type: "int", nullable: false),
                    SegmentCode = table.Column<int>(type: "int", nullable: false),
                    FamilyTitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FamilyDefinition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyCategories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FamilyCategories_SegmentCategories_SegmentCode",
                        column: x => x.SegmentCode,
                        principalSchema: "dbo",
                        principalTable: "SegmentCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassCategories",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassCode = table.Column<int>(type: "int", nullable: false),
                    SegmentCode = table.Column<int>(type: "int", nullable: false),
                    FamilyCode = table.Column<int>(type: "int", nullable: false),
                    ClassTitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ClassDefinition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassCategories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClassCategories_FamilyCategories_FamilyCode",
                        column: x => x.FamilyCode,
                        principalSchema: "dbo",
                        principalTable: "FamilyCategories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassCategories_ClassCode",
                schema: "dbo",
                table: "ClassCategories",
                column: "ClassCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClassCategories_FamilyCode",
                schema: "dbo",
                table: "ClassCategories",
                column: "FamilyCode");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyCategories_FamilyCode",
                schema: "dbo",
                table: "FamilyCategories",
                column: "FamilyCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FamilyCategories_SegmentCode",
                schema: "dbo",
                table: "FamilyCategories",
                column: "SegmentCode");

            migrationBuilder.CreateIndex(
                name: "IX_SegmentCategories_SegmentCode",
                schema: "dbo",
                table: "SegmentCategories",
                column: "SegmentCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassCategories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "FamilyCategories",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SegmentCategories",
                schema: "dbo");
        }
    }
}
