using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MembershipPortal.core.Migrations
{
    public partial class GTINRequest_datetype_null : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "GTINRequests",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    company_id = table.Column<int>(type: "int", nullable: false),
                    registrationid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gtinfee_id = table.Column<int>(type: "int", nullable: false),
                    gtincount = table.Column<int>(type: "int", nullable: false),
                    totalcost = table.Column<double>(type: "float", nullable: false),
                    dateofrequest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isapproved = table.Column<bool>(type: "bit", nullable: false),
                    approvedby = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    approvaldate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isgcpassigned = table.Column<bool>(type: "bit", nullable: false),
                    assigneddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    assignedby = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    requesttype = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    imagerequest_id = table.Column<int>(type: "int", nullable: true),
                    createdon = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedon = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GTINRequests", x => x.id);
                    table.ForeignKey(
                        name: "FK_GTINRequests_CompanyModel_company_id",
                        column: x => x.company_id,
                        principalSchema: "dbo",
                        principalTable: "CompanyModel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GTINRequests_GTINFees_gtinfee_id",
                        column: x => x.gtinfee_id,
                        principalSchema: "dbo",
                        principalTable: "GTINFees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropTable(
                name: "GTINRequests",
                schema: "dbo");
        }
    }
}
