using Microsoft.EntityFrameworkCore.Migrations;

namespace MembershipPortal.core.Migrations
{
    public partial class seed_familycategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FamilyCategories",
                columns: new[] { "ID", "FamilyCode", "FamilyDefinition", "FamilyTitle", "SegmentCode" },
                values: new object[,]
                {
                    { 1, 70010000, null, "Arts/Crafts/Needlework Supplies", 70000000 },
                    { 96, 81010000, null, "Lawn/Garden Supplies", 81000000 },
                    { 97, 89020000, null, "Live Animals", 89000000 },
                    { 98, 88030000, null, "Lubricants Variety Packs", 88000000 },
                    { 99, 88010000, null, "Lubricants/Protective Compounds", 88000000 },
                    { 100, 88020000, null, "Lubricants/Protective Compounds Storage/Transfer", 88000000 },
                    { 101, 96010000, null, "Currency/Postage/Certificates", 96000000 },
                    { 95, 73050000, null, "Tableware", 75000000 },
                    { 102, 61010000, null, "Musical Instruments/Accessories", 61000000 },
                    { 104, 10100000, null, "Pet Care", 10000000 },
                    { 105, 10120000, null, "Pet Care/Food Variety Packs", 10000000 },
                    { 106, 10110000, null, "Pet Food/Drinks", 10000000 },
                    { 107, 79010000, null, "Plumbing/Heating/Ventilation/Air Conditioning", 79000000 },
                    { 108, 99010000, null, "Postmortem Products", 99000000 },
                    { 109, 98020000, null, "Formed Raw Material", 98000000 },
                    { 103, 64010000, null, "Personal Accessories", 64000000 },
                    { 94, 73040000, null, "Kitchenware", 75000000 },
                    { 93, 75030000, null, "Ornamental Furnishings", 75000000 },
                    { 92, 75010000, null, "Household/Office Furniture", 75000000 },
                    { 77, 72010000, null, "Major Domestic Appliances", 72000000 },
                    { 78, 72020000, null, "Small Domestic Appliances", 72000000 },
                    { 79, 93100000, null, "Bouquets", 93000000 },
                    { 80, 93050000, null, "Bulbs/Corms/Rhizomes/Tubers", 93000000 },
                    { 81, 93010000, null, "Cut Flowers", 93000000 },
                    { 82, 93020000, null, "Cut Greens", 93000000 },
                    { 83, 93030000, null, "Live Plants (Genus A thru G)", 93000000 },
                    { 84, 93040000, null, "Live Plants (Genus H thru Z)", 93000000 },
                    { 85, 93060000, null, "Plants Variety Packs", 93000000 },
                    { 86, 93110000, null, "Seedlings - Ready to Grow", 93000000 },
                    { 87, 93070000, null, "Seeds/Spores", 93000000 },
                    { 88, 93080000, null, "Shrubs/Trees", 93000000 },
                    { 89, 93090000, null, "Vegetables/Fungi Plants", 93000000 },
                    { 90, 75050000, null, "Baby Furnishings", 75000000 },
                    { 91, 75020000, null, "Fabric/Textile Furnishings", 75000000 },
                    { 110, 98010000, null, "Unformed Raw Material", 98000000 },
                    { 76, 51170000, null, "Veterinary Healthcare", 51000000 },
                    { 111, 85010000, null, "Safety/Protection - DIY", 85000000 },
                    { 113, 91020000, null, "Environmental Safety/Security", 91000000 },
                    { 133, 62060000, null, "Stationery/Office Machinery", 62000000 },
                    { 134, 62070000, null, "Stationery/Office Machinery/Occasion Supplies Variety Packs", 62000000 },
                    { 135, 92010000, null, "Storage Bottles/Cylinders/Barrels (Empty)", 92000000 },
                    { 136, 92040000, null, "Storage/Haulage Aids", 92000000 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FamilyCategories",
                columns: new[] { "ID", "FamilyCode", "FamilyDefinition", "FamilyTitle", "SegmentCode" },
                values: new object[,]
                {
                    { 137, 92020000, null, "Storage/Haulage Boxes/Crates/Trays (Empty)", 92000000 },
                    { 138, 92030000, null, "Storage/Haulage Freight Containers (Empty)", 92000000 },
                    { 132, 62050000, null, "Greeting Cards/Gift Wrap/Occasion Supplies", 62000000 },
                    { 139, 60010000, null, "Textual/Printed/Reference Materials", 60000000 },
                    { 141, 80010000, null, "Tools/Equipment - Hand", 80000000 },
                    { 142, 82010000, null, "Tools/Equipment - Power", 82000000 },
                    { 143, 86020000, null, "Service Provided Gambling Products", 86000000 },
                    { 144, 86010000, null, "Toys/Games", 86000000 },
                    { 145, 77040000, null, "Aircraft", 77000000 },
                    { 146, 77010000, null, "Automotive Accessories and Maintenance", 77000000 },
                    { 140, 84010000, null, "Tool Storage/Workshop Aids", 84000000 },
                    { 131, 71010000, null, "Sports Equipment", 71000000 },
                    { 130, 71020000, null, "Baby Exercisers/Transportation", 71000000 },
                    { 129, 95150000, null, "Travel Services", 95000000 },
                    { 114, 91030000, null, "Home/Business Safety/Security/Surveillance", 91000000 },
                    { 115, 91010000, null, "Personal Safety/Security", 91000000 },
                    { 116, 95030000, null, "Cleaning Services", 95000000 },
                    { 117, 95040000, null, "Communication Services", 95000000 },
                    { 118, 95160000, null, "Dispensing/Vending Machines", 95000000 },
                    { 119, 95050000, null, "Educational & Entertainment Services", 95000000 },
                    { 120, 95060000, null, "Energy and Environmental Services", 95000000 },
                    { 121, 95070000, null, "Financial Services", 95000000 },
                    { 122, 95110000, null, "Food/Drink and Accommodation Services", 95000000 },
                    { 123, 95120000, null, "Maintenance/Repair and Installation Services", 95000000 },
                    { 124, 95130000, null, "Medical and Beauty Care Services", 95000000 },
                    { 125, 95080000, null, "Packaging/Storage Services", 95000000 },
                    { 126, 95090000, null, "Postal Services", 95000000 },
                    { 127, 95100000, null, "Scientific and Technological Services", 95000000 },
                    { 128, 95140000, null, "Transportation Services", 95000000 },
                    { 112, 91050000, null, "Baby Safety/Security/Surveillance", 91000000 },
                    { 75, 51160000, null, "Pharmaceutical Drugs", 51000000 },
                    { 74, 51150000, null, "Medical Devices", 51000000 },
                    { 73, 51130000, null, "Home Diagnostics", 51000000 },
                    { 21, 47120000, null, "Insect/Pest/Allergen Control", 47000000 },
                    { 22, 47210000, null, "Waste Management Products", 47000000 },
                    { 23, 67030000, null, "Activewear", 67000000 },
                    { 24, 67010000, null, "Clothing", 67000000 },
                    { 25, 67050000, null, "Protective Wear", 67000000 },
                    { 26, 67020000, null, "Sleepwear", 67000000 },
                    { 20, 47220000, null, "Industrial Cleaning", 47000000 },
                    { 27, 67060000, null, "Swimwear", 67000000 },
                    { 29, 66010000, null, "Communications", 66000000 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FamilyCategories",
                columns: new[] { "ID", "FamilyCode", "FamilyDefinition", "FamilyTitle", "SegmentCode" },
                values: new object[,]
                {
                    { 30, 65010000, null, "Computers/Video Games", 65000000 },
                    { 31, 94020000, null, "Crops for Food Production", 94000000 },
                    { 32, 94010000, null, "Crops not for food or feed (animal and fish)", 94000000 },
                    { 33, 94030000, null, "Grass and Other Crops for Animal Feed or for Soil Improvement", 94000000 },
                    { 34, 58010000, null, "Cross Segment", 58000000 },
                    { 28, 67040000, null, "Underwear", 67000000 },
                    { 19, 47200000, null, "Cleaning/Hygiene Supplies", 47000000 },
                    { 18, 47190000, null, "Cleaning/Hygiene Products Variety Packs", 47000000 },
                    { 17, 47100000, null, "Cleaning Products", 47000000 },
                    { 2, 68020000, null, "Photography/Optics", 68000000 },
                    { 3, 68010000, null, "Audio Visual Equipment", 68000000 },
                    { 4, 68040000, null, "Audio Visual Media", 68000000 },
                    { 5, 68050000, null, "Audio Visual/Photography Variety Packs", 68000000 },
                    { 6, 68030000, null, "In-car Electronics", 68000000 },
                    { 7, 53220000, null, "Beauty/Personal Care/Hygiene Variety Packs", 53000000 },
                    { 8, 53200000, null, "Body Products", 53000000 },
                    { 9, 53160000, null, "Cosmetics/Fragrances", 53000000 },
                    { 10, 53140000, null, "Hair Products", 53000000 },
                    { 11, 53240000, null, "Maternity Products", 53000000 },
                    { 12, 53180000, null, "Personal Hygiene Products", 53000000 },
                    { 13, 53230000, null, "Personal Intimacy", 53000000 },
                    { 14, 53130000, null, "Skin Products", 53000000 },
                    { 15, 83010000, null, "Building Products", 83000000 },
                    { 16, 74010000, null, "Camping", 74000000 },
                    { 35, 78040000, null, "Electrical Cabling/Wiring", 78000000 },
                    { 36, 78020000, null, "Electrical Connection/Distribution", 78000000 },
                    { 37, 78030000, null, "Electrical Lighting", 78000000 },
                    { 38, 78050000, null, "Electronic Communication Components", 78000000 },
                    { 58, 50330000, null, "Nuts/Seeds - Unprepared/Unprocessed (Perishable)", 50000000 },
                    { 59, 50150000, null, "Oils/Fats Edible", 50000000 },
                    { 60, 50190000, null, "Prepared/Preserved Foods", 50000000 },
                    { 61, 50170000, null, "Seasonings/Preservatives/Extracts", 50000000 },
                    { 62, 50210000, null, "Tobacco/Cannabis/Smoking Accessories", 50000000 },
                    { 63, 50290000, null, "Vegetables - Unprepared/Unprocessed (Frozen)", 50000000 },
                    { 64, 50320000, null, "Vegetables - Unprepared/Unprocessed (Shelf Stable)", 50000000 },
                    { 65, 50260000, null, "Vegetables (Non Leaf) - Unprepared/Unprocessed (Fresh)", 50000000 },
                    { 66, 63010000, null, "Footwear", 63000000 },
                    { 67, 87020000, null, "Fuel Storage/Transfer", 87000000 },
                    { 68, 87010000, null, "Fuels/Fuel Additives", 87000000 },
                    { 69, 51110000, null, "Family Planning", 51000000 },
                    { 70, 51120000, null, "Health Enhancement", 51000000 },
                    { 71, 51100000, null, "Health Treatments/Aids", 51000000 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "FamilyCategories",
                columns: new[] { "ID", "FamilyCode", "FamilyDefinition", "FamilyTitle", "SegmentCode" },
                values: new object[,]
                {
                    { 72, 51140000, null, "Healthcare Variety Packs", 51000000 },
                    { 57, 50340000, null, "Nuts/Seeds - Unprepared/Unprocessed (In Shell)", 50000000 },
                    { 147, 77030000, null, "Cars and Motorcycles", 77000000 },
                    { 56, 50130000, null, "Milk/Butter/Cream/Yogurts/Cheese/Eggs/Substitutes", 50000000 },
                    { 54, 50390000, null, "Meat/Fish/Seafood Substitutes", 50000000 },
                    { 39, 78060000, null, "General Electrical Hardware", 78000000 },
                    { 40, 50200000, null, "Beverages", 50000000 },
                    { 41, 50180000, null, "Bread/Bakery Products", 50000000 },
                    { 42, 50220000, null, "Cereal/Grain/Pulse Products", 50000000 },
                    { 43, 50160000, null, "Confectionery/Sugar Sweetening Products", 50000000 },
                    { 44, 50120000, null, "Fish and Seafood", 50000000 },
                    { 45, 50230000, null, "Food/Beverage/Tobacco Variety Packs", 50000000 },
                    { 46, 50360000, null, "Fresh Garnish (Food)", 50000000 },
                    { 47, 50250000, null, "Fruits - Unprepared/Unprocessed (Fresh)", 50000000 },
                    { 48, 50270000, null, "Fruits - Unprepared/Unprocessed (Frozen)", 50000000 },
                    { 49, 50310000, null, "Fruits - Unprepared/Unprocessed (Shelf Stable)", 50000000 },
                    { 50, 50370000, null, "Fruits/Vegetables Fresh & Fresh Cut", 50000000 },
                    { 51, 50380000, null, "Fruits/Vegetables Fresh Cut", 50000000 },
                    { 52, 50100000, null, "Fruits/Vegetables/Nuts/Seeds Prepared/Processed", 50000000 },
                    { 53, 50350000, null, "Leaf Vegetables - Unprepared/Unprocessed (Fresh)", 50000000 },
                    { 55, 50240000, null, "Meat/Poultry/Other Animals", 50000000 },
                    { 148, 77050000, null, "Specialty Vehicles", 77000000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "FamilyCategories",
                keyColumn: "ID",
                keyValue: 148);

            migrationBuilder.AlterColumn<string>(
                name: "SegmentCode",
                schema: "dbo",
                table: "SegmentCategories",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
