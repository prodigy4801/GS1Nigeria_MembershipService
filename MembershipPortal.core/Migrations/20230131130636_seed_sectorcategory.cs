using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MembershipPortal.core.Migrations
{
    public partial class seed_sectorcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "SegmentCategories",
                columns: new[] { "ID", "SegmentCode", "SegmentDefinition", "SegmentTitle" },
                values: new object[,]
                {
                    { 1, "70000000", "", "Arts/Crafts/Needlework" },
                    { 23, "88000000", "", "Lubricants" },
                    { 24, "96000000", "", "Monetary Assets" },
                    { 25, "61000000", "", "Music" },
                    { 26, "64000000", "", "Personal Accessories" },
                    { 27, "10000000", "", "Pet Care/Food" },
                    { 28, "79000000", "", "Plumbing/Heating/Ventilation/Air Conditioning" },
                    { 29, "98000000", "", "Raw Materials (Non Food)" },
                    { 30, "85000000", "", "Safety/Protection - DIY" },
                    { 31, "91000000", "", "Safety/Security/Surveillance" },
                    { 32, "95000000", "", "Services/Vending Machines" },
                    { 33, "71000000", "", "Sports Equipment" },
                    { 34, "62000000", "", "Stationery/Office Machinery/Occasion Supplies" },
                    { 35, "92000000", "", "Storage/Haulage Containers" },
                    { 36, "60000000", "", "Textual/Printed/Reference Materials" },
                    { 37, "84000000", "", "Tool Storage/Workshop Aids" },
                    { 38, "80000000", "", "Tools/Equipment - Hand" },
                    { 39, "82000000", "", "Tools/Equipment - Power" },
                    { 22, "89000000", "", "Live Animals" },
                    { 40, "86000000", "", "Toys/Games" },
                    { 21, "81000000", "", "Lawn/Garden Supplies" },
                    { 19, "75000000", "", "Household/Office Furniture/Furnishings" },
                    { 2, "68000000", "", "Audio Visual/Photography" },
                    { 3, "53000000", "", "Beauty/Personal Care/Hygiene" },
                    { 4, "83000000", "", "Building Products" },
                    { 5, "74000000", "", "Camping" },
                    { 6, "47000000", "", "Cleaning/Hygiene Products" },
                    { 7, "67000000", "", "Clothing" },
                    { 8, "66000000", "", "Communications" },
                    { 9, "65000000", "", "Computing" },
                    { 10, "94000000", "", "Crops" },
                    { 11, "58000000", "", "Cross Segment" },
                    { 12, "78000000", "", "Electrical Supplies" },
                    { 13, "50000000", "", "Food/Beverage/Tobacco" },
                    { 14, "63000000", "", "Footwear" },
                    { 15, "87000000", "", "Fuels/Gases" },
                    { 16, "51000000", "", "Healthcare" },
                    { 17, "72000000", "", "Home Appliances" },
                    { 18, "93000000", "", "Horticulture Plants" },
                    { 20, "73000000", "", "Kitchenware and Tableware" },
                    { 41, "77000000", "", "Vehicle" }
                });

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
