using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MembershipPortal.core.Migrations
{
    public partial class Seed_Record_countries_states_lga_gtinfee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GTINRequests_CompanyModel_company_id",
                schema: "dbo",
                table: "GTINRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_CompanyModel_Companiesid",
                schema: "dbo",
                table: "Users");

            migrationBuilder.DropTable(
                name: "CompanyModel",
                schema: "dbo");

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Countries",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Afghanistan" },
                    { 160, "Niger" },
                    { 161, "Nigeria" },
                    { 162, "Niue" },
                    { 163, "Norfolk Island" },
                    { 164, "Northern Mariana Islands" },
                    { 165, "Norway" },
                    { 166, "Oman" },
                    { 167, "Pakistan" },
                    { 168, "Palau" },
                    { 169, "Palestinian Territory Occupied" },
                    { 170, "Panama" },
                    { 171, "Papua new Guinea" },
                    { 172, "Paraguay" },
                    { 173, "Peru" },
                    { 174, "Philippines" },
                    { 175, "Pitcairn Island" },
                    { 176, "Poland" },
                    { 177, "Portugal" },
                    { 178, "Puerto Rico" },
                    { 179, "Qatar" },
                    { 180, "Reunion" },
                    { 181, "Romania" },
                    { 182, "Russia" },
                    { 183, "Rwanda" },
                    { 184, "Saint Helena" },
                    { 185, "Saint Kitts And Nevis" },
                    { 186, "Saint Lucia" },
                    { 159, "Nicaragua" },
                    { 158, "New Zealand" },
                    { 157, "New Caledonia" },
                    { 156, "Netherlands The" },
                    { 128, "Macau S.A.R." },
                    { 129, "Macedonia" },
                    { 130, "Madagascar" },
                    { 131, "Malawi" },
                    { 132, "Malaysia" },
                    { 133, "Maldives" },
                    { 134, "Mali" },
                    { 135, "Malta" },
                    { 136, "Man (Isle of)" },
                    { 137, "Marshall Islands" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Countries",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 138, "Martinique" },
                    { 139, "Mauritania" },
                    { 140, "Mauritius" },
                    { 187, "Saint Pierre and Miquelon" },
                    { 141, "Mayotte" },
                    { 143, "Micronesia" },
                    { 144, "Moldova" },
                    { 145, "Monaco" },
                    { 146, "Mongolia" },
                    { 147, "Montenegro" },
                    { 148, "Montserrat" },
                    { 149, "Morocco" },
                    { 150, "Mozambique" },
                    { 151, "Myanmar" },
                    { 152, "Namibia" },
                    { 153, "Nauru" },
                    { 154, "Nepal" },
                    { 155, "Bonaire, Sint Eustatius and Saba" },
                    { 142, "Mexico" },
                    { 127, "Luxembourg" },
                    { 188, "Saint Vincent And The Grenadines" },
                    { 190, "Saint-Martin (French part)" },
                    { 224, "Tunisia" },
                    { 225, "Turkey" },
                    { 226, "Turkmenistan" },
                    { 227, "Turks And Caicos Islands" },
                    { 228, "Tuvalu" },
                    { 229, "Uganda" },
                    { 230, "Ukraine" },
                    { 231, "United Arab Emirates" },
                    { 232, "United Kingdom" },
                    { 233, "United States" },
                    { 234, "United States Minor Outlying Islands" },
                    { 235, "Uruguay" },
                    { 236, "Uzbekistan" },
                    { 237, "Vanuatu" },
                    { 238, "Vatican City State (Holy See)" },
                    { 239, "Venezuela" },
                    { 240, "Vietnam" },
                    { 241, "Virgin Islands (British)" },
                    { 242, "Virgin Islands (US)" },
                    { 243, "Wallis And Futuna Islands" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Countries",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 244, "Western Sahara" },
                    { 245, "Yemen" },
                    { 246, "Zambia" },
                    { 247, "Zimbabwe" },
                    { 248, "Kosovo" },
                    { 249, "Curaçao" },
                    { 250, "Sint Maarten (Dutch part)" },
                    { 223, "Trinidad And Tobago" },
                    { 222, "Tonga" },
                    { 221, "Tokelau" },
                    { 220, "Togo" },
                    { 191, "Samoa" },
                    { 192, "San Marino" },
                    { 193, "Sao Tome and Principe" },
                    { 194, "Saudi Arabia" },
                    { 195, "Senegal" },
                    { 196, "Serbia" },
                    { 197, "Seychelles" },
                    { 198, "Sierra Leone" },
                    { 199, "Singapore" },
                    { 200, "Slovakia" },
                    { 201, "Slovenia" },
                    { 202, "Solomon Islands" },
                    { 204, "South Africa" },
                    { 189, "Saint-Barthelemy" },
                    { 205, "South Georgia" },
                    { 207, "Spain" },
                    { 208, "Sri Lanka" },
                    { 209, "Sudan" },
                    { 210, "Suriname" },
                    { 211, "Svalbard And Jan Mayen Islands" },
                    { 212, "Swaziland" },
                    { 213, "Sweden" },
                    { 214, "Switzerland" },
                    { 215, "Syria" },
                    { 216, "Taiwan" },
                    { 217, "Tajikistan" },
                    { 218, "Tanzania" },
                    { 219, "Thailand" },
                    { 206, "South Sudan" },
                    { 126, "Lithuania" },
                    { 203, "Somalia" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Countries",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 124, "Libya" },
                    { 33, "Brunei" },
                    { 34, "Bulgaria" },
                    { 35, "Burkina Faso" },
                    { 36, "Burundi" },
                    { 37, "Cambodia" },
                    { 38, "Cameroon" },
                    { 39, "Canada" },
                    { 40, "Cape Verde" },
                    { 41, "Cayman Islands" },
                    { 42, "Central African Republic" },
                    { 43, "Chad" },
                    { 44, "Chile" },
                    { 45, "China" },
                    { 46, "Christmas Island" },
                    { 47, "Cocos (Keeling) Islands" },
                    { 48, "Colombia" },
                    { 49, "Comoros" },
                    { 50, "Congo" },
                    { 51, "Congo The Democratic Republic Of The" },
                    { 52, "Cook Islands" },
                    { 53, "Costa Rica" },
                    { 54, "Cote D'Ivoire (Ivory Coast)" },
                    { 55, "Croatia (Hrvatska)" },
                    { 57, "Cyprus" },
                    { 58, "Czech Republic" },
                    { 59, "Denmark" },
                    { 60, "Djibouti" },
                    { 32, "British Indian Ocean Territory" },
                    { 61, "Dominica" },
                    { 31, "Brazil" },
                    { 29, "Botswana" },
                    { 2, "Aland Islands" },
                    { 3, "Albania" },
                    { 4, "Algeria" },
                    { 5, "American Samoa" },
                    { 6, "Andorra" },
                    { 7, "Angola" },
                    { 8, "Anguilla" },
                    { 9, "Antarctica" },
                    { 10, "Antigua And Barbuda" },
                    { 11, "Argentina" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Countries",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 12, "Armenia" },
                    { 13, "Aruba" },
                    { 14, "Australia" },
                    { 15, "Austria" },
                    { 16, "Azerbaijan" },
                    { 17, "Bahamas The" },
                    { 18, "Bahrain" },
                    { 19, "Bangladesh" },
                    { 20, "Barbados" },
                    { 21, "Belarus" },
                    { 22, "Belgium" },
                    { 23, "Belize" },
                    { 24, "Benin" },
                    { 25, "Bermuda" },
                    { 26, "Bhutan" },
                    { 27, "Bolivia" },
                    { 28, "Bosnia and Herzegovina" },
                    { 30, "Bouvet Island" },
                    { 62, "Dominican Republic" },
                    { 56, "Cuba" },
                    { 64, "Ecuador" },
                    { 96, "Heard Island and McDonald Islands" },
                    { 97, "Honduras" },
                    { 98, "Hong Kong S.A.R." },
                    { 63, "East Timor" },
                    { 100, "Iceland" },
                    { 101, "India" },
                    { 102, "Indonesia" },
                    { 103, "Iran" },
                    { 104, "Iraq" },
                    { 105, "Ireland" },
                    { 106, "Israel" },
                    { 107, "Italy" },
                    { 108, "Jamaica" },
                    { 95, "Haiti" },
                    { 109, "Japan" },
                    { 111, "Jordan" },
                    { 112, "Kazakhstan" },
                    { 113, "Kenya" },
                    { 114, "Kiribati" },
                    { 115, "Korea North" },
                    { 116, "Korea South" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Countries",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 117, "Kuwait" },
                    { 118, "Kyrgyzstan" },
                    { 119, "Laos" },
                    { 120, "Latvia" },
                    { 121, "Lebanon" },
                    { 122, "Lesotho" },
                    { 123, "Liberia" },
                    { 110, "Jersey" },
                    { 94, "Guyana" },
                    { 99, "Hungary" },
                    { 92, "Guinea" },
                    { 65, "Egypt" },
                    { 66, "El Salvador" },
                    { 67, "Equatorial Guinea" },
                    { 68, "Eritrea" },
                    { 69, "Estonia" },
                    { 70, "Ethiopia" },
                    { 71, "Falkland Islands" },
                    { 93, "Guinea-Bissau" },
                    { 73, "Fiji Islands" },
                    { 74, "Finland" },
                    { 75, "France" },
                    { 76, "French Guiana" },
                    { 77, "French Polynesia" },
                    { 72, "Faroe Islands" },
                    { 79, "Gabon" },
                    { 78, "French Southern Territories" },
                    { 90, "Guatemala" },
                    { 89, "Guam" },
                    { 88, "Guadeloupe" },
                    { 87, "Grenada" },
                    { 86, "Greenland" },
                    { 91, "Guernsey and Alderney" },
                    { 84, "Gibraltar" },
                    { 85, "Greece" },
                    { 80, "Gambia The" },
                    { 81, "Georgia" },
                    { 125, "Liechtenstein" },
                    { 83, "Ghana" },
                    { 82, "Germany" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "GTINFees",
                columns: new[] { "ID", "AdditionalFee", "Description", "NumberOfGtins", "Price", "RenewalFee" },
                values: new object[,]
                {
                    { 32, 260000.0, "401-1000", 1000, 312500.0, 250000.0 },
                    { 31, 235000.0, "301-400", 400, 247500.0, 225000.0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "GTINFees",
                columns: new[] { "ID", "AdditionalFee", "Description", "NumberOfGtins", "Price", "RenewalFee" },
                values: new object[,]
                {
                    { 30, 210000.0, "201-300", 300, 222500.0, 200000.0 },
                    { 29, 185000.0, "151-200", 200, 197500.0, 175000.0 },
                    { 19, 20000.0, "01-10", 10, 32500.0, 10000.0 },
                    { 27, 135000.0, "81-100", 100, 147500.0, 125000.0 },
                    { 26, 110000.0, "71-80", 80, 122500.0, 100000.0 },
                    { 25, 85000.0, "61-70", 70, 97500.0, 75000.0 },
                    { 24, 65000.0, "51-60", 60, 77500.0, 55000.0 },
                    { 23, 55000.0, "41-50", 50, 67500.0, 45000.0 },
                    { 22, 45000.0, "31-40", 40, 57500.0, 35000.0 },
                    { 21, 35000.0, "21-30", 30, 47500.0, 25000.0 },
                    { 20, 25000.0, "11-20", 20, 37500.0, 15000.0 },
                    { 28, 160000.0, "101-150", 150, 172500.0, 150000.0 },
                    { 16, 0.0, "2000 plus", 2000, 0.0, 400000.0 },
                    { 14, 282000.0, "301-400", 400, 297000.0, 270000.0 },
                    { 15, 312000.0, "401-1000", 1000, 375000.0, 300000.0 },
                    { 2, 24000.0, "6-10", 10, 39000.0, 10000.0 },
                    { 3, 30000.0, "11-20", 20, 45000.0, 15000.0 },
                    { 4, 42000.0, "21-30", 30, 57000.0, 25000.0 },
                    { 5, 54000.0, "31-40", 40, 69000.0, 42000.0 },
                    { 6, 66000.0, "41-50", 50, 81000.0, 54000.0 },
                    { 1, 15000.0, "1-5", 5, 33000.0, 10000.0 },
                    { 8, 102000.0, "61-70", 70, 117000.0, 90000.0 },
                    { 9, 13200.0, "71-80", 80, 147000.0, 120000.0 },
                    { 10, 162000.0, "81-100", 100, 177000.0, 150000.0 },
                    { 11, 192000.0, "101-150", 150, 207000.0, 180000.0 },
                    { 12, 222000.0, "151-200", 200, 237000.0, 210000.0 },
                    { 7, 78000.0, "51-60", 60, 93000.0, 66000.0 },
                    { 13, 252000.0, "201-300", 300, 267000.0, 240000.0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "LocalGovts",
                columns: new[] { "id", "name", "state_id" },
                values: new object[,]
                {
                    { 170, "Panama", 0 },
                    { 169, "Palestinian Territory Occupied", 0 },
                    { 168, "Palau", 0 },
                    { 167, "Pakistan", 0 },
                    { 166, "Oman", 0 },
                    { 163, "Norfolk Island", 0 },
                    { 164, "Northern Mariana Islands", 0 },
                    { 162, "Niue", 0 },
                    { 161, "Nigeria", 0 },
                    { 160, "Niger", 0 },
                    { 171, "Papua new Guinea", 0 },
                    { 165, "Norway", 0 },
                    { 172, "Paraguay", 0 },
                    { 180, "Reunion", 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "LocalGovts",
                columns: new[] { "id", "name", "state_id" },
                values: new object[,]
                {
                    { 174, "Philippines", 0 },
                    { 175, "Pitcairn Island", 0 },
                    { 176, "Poland", 0 },
                    { 177, "Portugal", 0 },
                    { 178, "Puerto Rico", 0 },
                    { 179, "Qatar", 0 },
                    { 159, "Nicaragua", 0 },
                    { 181, "Romania", 0 },
                    { 182, "Russia", 0 },
                    { 183, "Rwanda", 0 },
                    { 184, "Saint Helena", 0 },
                    { 185, "Saint Kitts And Nevis", 0 },
                    { 186, "Saint Lucia", 0 },
                    { 173, "Peru", 0 },
                    { 158, "New Zealand", 0 },
                    { 151, "Myanmar", 0 },
                    { 156, "Netherlands The", 0 },
                    { 128, "Macau S.A.R.", 0 },
                    { 129, "Macedonia", 0 },
                    { 130, "Madagascar", 0 },
                    { 131, "Malawi", 0 },
                    { 132, "Malaysia", 0 },
                    { 133, "Maldives", 0 },
                    { 134, "Mali", 0 },
                    { 135, "Malta", 0 },
                    { 136, "Man (Isle of)", 0 },
                    { 137, "Marshall Islands", 0 },
                    { 138, "Martinique", 0 },
                    { 139, "Mauritania", 0 },
                    { 140, "Mauritius", 0 },
                    { 157, "New Caledonia", 0 },
                    { 141, "Mayotte", 0 },
                    { 143, "Micronesia", 0 },
                    { 144, "Moldova", 0 },
                    { 145, "Monaco", 0 },
                    { 146, "Mongolia", 0 },
                    { 147, "Montenegro", 0 },
                    { 148, "Montserrat", 0 },
                    { 149, "Morocco", 0 },
                    { 150, "Mozambique", 0 },
                    { 187, "Saint Pierre and Miquelon", 0 },
                    { 152, "Namibia", 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "LocalGovts",
                columns: new[] { "id", "name", "state_id" },
                values: new object[,]
                {
                    { 153, "Nauru", 0 },
                    { 154, "Nepal", 0 },
                    { 155, "Bonaire, Sint Eustatius and Saba", 0 },
                    { 142, "Mexico", 0 },
                    { 188, "Saint Vincent And The Grenadines", 0 },
                    { 196, "Serbia", 0 },
                    { 190, "Saint-Martin (French part)", 0 },
                    { 224, "Tunisia", 0 },
                    { 225, "Turkey", 0 },
                    { 226, "Turkmenistan", 0 },
                    { 227, "Turks And Caicos Islands", 0 },
                    { 228, "Tuvalu", 0 },
                    { 229, "Uganda", 0 },
                    { 230, "Ukraine", 0 },
                    { 231, "United Arab Emirates", 0 },
                    { 232, "United Kingdom", 0 },
                    { 233, "United States", 0 },
                    { 234, "United States Minor Outlying Islands", 0 },
                    { 235, "Uruguay", 0 },
                    { 236, "Uzbekistan", 0 },
                    { 223, "Trinidad And Tobago", 0 },
                    { 237, "Vanuatu", 0 },
                    { 239, "Venezuela", 0 },
                    { 240, "Vietnam", 0 },
                    { 241, "Virgin Islands (British)", 0 },
                    { 242, "Virgin Islands (US)", 0 },
                    { 243, "Wallis And Futuna Islands", 0 },
                    { 244, "Western Sahara", 0 },
                    { 245, "Yemen", 0 },
                    { 246, "Zambia", 0 },
                    { 247, "Zimbabwe", 0 },
                    { 248, "Kosovo", 0 },
                    { 249, "Curaçao", 0 },
                    { 250, "Sint Maarten (Dutch part)", 0 },
                    { 127, "Luxembourg", 0 },
                    { 238, "Vatican City State (Holy See)", 0 },
                    { 189, "Saint-Barthelemy", 0 },
                    { 222, "Tonga", 0 },
                    { 220, "Togo", 0 },
                    { 191, "Samoa", 0 },
                    { 192, "San Marino", 0 },
                    { 193, "Sao Tome and Principe", 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "LocalGovts",
                columns: new[] { "id", "name", "state_id" },
                values: new object[,]
                {
                    { 194, "Saudi Arabia", 0 },
                    { 195, "Senegal", 0 },
                    { 197, "Seychelles", 0 },
                    { 198, "Sierra Leone", 0 },
                    { 199, "Singapore", 0 },
                    { 200, "Slovakia", 0 },
                    { 201, "Slovenia", 0 },
                    { 202, "Solomon Islands", 0 },
                    { 203, "Somalia", 0 },
                    { 204, "South Africa", 0 },
                    { 221, "Tokelau", 0 },
                    { 205, "South Georgia", 0 },
                    { 207, "Spain", 0 },
                    { 208, "Sri Lanka", 0 },
                    { 209, "Sudan", 0 },
                    { 210, "Suriname", 0 },
                    { 211, "Svalbard And Jan Mayen Islands", 0 },
                    { 212, "Swaziland", 0 },
                    { 213, "Sweden", 0 },
                    { 214, "Switzerland", 0 },
                    { 215, "Syria", 0 },
                    { 216, "Taiwan", 0 },
                    { 217, "Tajikistan", 0 },
                    { 218, "Tanzania", 0 },
                    { 219, "Thailand", 0 },
                    { 206, "South Sudan", 0 },
                    { 126, "Lithuania", 0 },
                    { 110, "Jersey", 0 },
                    { 124, "Libya", 0 },
                    { 33, "Brunei", 0 },
                    { 34, "Bulgaria", 0 },
                    { 35, "Burkina Faso", 0 },
                    { 36, "Burundi", 0 },
                    { 37, "Cambodia", 0 },
                    { 38, "Cameroon", 0 },
                    { 39, "Canada", 0 },
                    { 40, "Cape Verde", 0 },
                    { 41, "Cayman Islands", 0 },
                    { 42, "Central African Republic", 0 },
                    { 43, "Chad", 0 },
                    { 44, "Chile", 0 },
                    { 45, "China", 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "LocalGovts",
                columns: new[] { "id", "name", "state_id" },
                values: new object[,]
                {
                    { 46, "Christmas Island", 0 },
                    { 47, "Cocos (Keeling) Islands", 0 },
                    { 48, "Colombia", 0 },
                    { 49, "Comoros", 0 },
                    { 50, "Congo", 0 },
                    { 51, "Congo The Democratic Republic Of The", 0 },
                    { 52, "Cook Islands", 0 },
                    { 53, "Costa Rica", 0 },
                    { 54, "Cote D'Ivoire (Ivory Coast)", 0 },
                    { 55, "Croatia (Hrvatska)", 0 },
                    { 56, "Cuba", 0 },
                    { 57, "Cyprus", 0 },
                    { 58, "Czech Republic", 0 },
                    { 59, "Denmark", 0 },
                    { 32, "British Indian Ocean Territory", 0 },
                    { 31, "Brazil", 0 },
                    { 30, "Bouvet Island", 0 },
                    { 29, "Botswana", 0 },
                    { 125, "Liechtenstein", 0 },
                    { 2, "Aland Islands", 0 },
                    { 3, "Albania", 0 },
                    { 4, "Algeria", 0 },
                    { 5, "American Samoa", 0 },
                    { 6, "Andorra", 0 },
                    { 7, "Angola", 0 },
                    { 8, "Anguilla", 0 },
                    { 9, "Antarctica", 0 },
                    { 10, "Antigua And Barbuda", 0 },
                    { 11, "Argentina", 0 },
                    { 12, "Armenia", 0 },
                    { 13, "Aruba", 0 },
                    { 60, "Djibouti", 0 },
                    { 14, "Australia", 0 },
                    { 16, "Azerbaijan", 0 },
                    { 17, "Bahamas The", 0 },
                    { 18, "Bahrain", 0 },
                    { 19, "Bangladesh", 0 },
                    { 20, "Barbados", 0 },
                    { 21, "Belarus", 0 },
                    { 22, "Belgium", 0 },
                    { 23, "Belize", 0 },
                    { 24, "Benin", 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "LocalGovts",
                columns: new[] { "id", "name", "state_id" },
                values: new object[,]
                {
                    { 25, "Bermuda", 0 },
                    { 26, "Bhutan", 0 },
                    { 27, "Bolivia", 0 },
                    { 28, "Bosnia and Herzegovina", 0 },
                    { 15, "Austria", 0 },
                    { 61, "Dominica", 0 },
                    { 1, "Afghanistan", 0 },
                    { 63, "East Timor", 0 },
                    { 96, "Heard Island and McDonald Islands", 0 },
                    { 97, "Honduras", 0 },
                    { 98, "Hong Kong S.A.R.", 0 },
                    { 99, "Hungary", 0 },
                    { 100, "Iceland", 0 },
                    { 101, "India", 0 },
                    { 102, "Indonesia", 0 },
                    { 103, "Iran", 0 },
                    { 104, "Iraq", 0 },
                    { 105, "Ireland", 0 },
                    { 106, "Israel", 0 },
                    { 108, "Jamaica", 0 },
                    { 109, "Japan", 0 },
                    { 111, "Jordan", 0 },
                    { 112, "Kazakhstan", 0 },
                    { 113, "Kenya", 0 },
                    { 114, "Kiribati", 0 },
                    { 115, "Korea North", 0 },
                    { 116, "Korea South", 0 },
                    { 117, "Kuwait", 0 },
                    { 118, "Kyrgyzstan", 0 },
                    { 119, "Laos", 0 },
                    { 120, "Latvia", 0 },
                    { 121, "Lebanon", 0 },
                    { 122, "Lesotho", 0 },
                    { 123, "Liberia", 0 },
                    { 62, "Dominican Republic", 0 },
                    { 95, "Haiti", 0 },
                    { 94, "Guyana", 0 },
                    { 107, "Italy", 0 },
                    { 92, "Guinea", 0 },
                    { 64, "Ecuador", 0 },
                    { 65, "Egypt", 0 },
                    { 93, "Guinea-Bissau", 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "LocalGovts",
                columns: new[] { "id", "name", "state_id" },
                values: new object[,]
                {
                    { 67, "Equatorial Guinea", 0 },
                    { 68, "Eritrea", 0 },
                    { 69, "Estonia", 0 },
                    { 70, "Ethiopia", 0 },
                    { 71, "Falkland Islands", 0 },
                    { 72, "Faroe Islands", 0 },
                    { 73, "Fiji Islands", 0 },
                    { 74, "Finland", 0 },
                    { 75, "France", 0 },
                    { 76, "French Guiana", 0 },
                    { 77, "French Polynesia", 0 },
                    { 66, "El Salvador", 0 },
                    { 90, "Guatemala", 0 },
                    { 89, "Guam", 0 },
                    { 88, "Guadeloupe", 0 },
                    { 87, "Grenada", 0 },
                    { 78, "French Southern Territories", 0 },
                    { 85, "Greece", 0 },
                    { 84, "Gibraltar", 0 },
                    { 86, "Greenland", 0 },
                    { 82, "Germany", 0 },
                    { 81, "Georgia", 0 },
                    { 80, "Gambia The", 0 },
                    { 91, "Guernsey and Alderney", 0 },
                    { 79, "Gabon", 0 },
                    { 83, "Ghana", 0 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "States",
                columns: new[] { "id", "country_id", "name" },
                values: new object[,]
                {
                    { 169, 0, "Palestinian Territory Occupied" },
                    { 168, 0, "Palau" },
                    { 167, 0, "Pakistan" },
                    { 166, 0, "Oman" },
                    { 165, 0, "Norway" },
                    { 185, 0, "Saint Kitts And Nevis" },
                    { 163, 0, "Norfolk Island" },
                    { 162, 0, "Niue" },
                    { 161, 0, "Nigeria" },
                    { 160, 0, "Niger" },
                    { 170, 0, "Panama" },
                    { 164, 0, "Northern Mariana Islands" },
                    { 171, 0, "Papua new Guinea" },
                    { 178, 0, "Puerto Rico" },
                    { 173, 0, "Peru" },
                    { 174, 0, "Philippines" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "States",
                columns: new[] { "id", "country_id", "name" },
                values: new object[,]
                {
                    { 175, 0, "Pitcairn Island" },
                    { 176, 0, "Poland" },
                    { 177, 0, "Portugal" },
                    { 179, 0, "Qatar" },
                    { 180, 0, "Reunion" },
                    { 181, 0, "Romania" },
                    { 182, 0, "Russia" },
                    { 183, 0, "Rwanda" },
                    { 184, 0, "Saint Helena" },
                    { 159, 0, "Nicaragua" },
                    { 172, 0, "Paraguay" },
                    { 158, 0, "New Zealand" },
                    { 128, 0, "Macau S.A.R." },
                    { 156, 0, "Netherlands The" },
                    { 127, 0, "Luxembourg" },
                    { 129, 0, "Macedonia" },
                    { 130, 0, "Madagascar" },
                    { 131, 0, "Malawi" },
                    { 132, 0, "Malaysia" },
                    { 133, 0, "Maldives" },
                    { 134, 0, "Mali" },
                    { 135, 0, "Malta" },
                    { 136, 0, "Man (Isle of)" },
                    { 137, 0, "Marshall Islands" },
                    { 138, 0, "Martinique" },
                    { 139, 0, "Mauritania" },
                    { 140, 0, "Mauritius" },
                    { 157, 0, "New Caledonia" },
                    { 141, 0, "Mayotte" },
                    { 143, 0, "Micronesia" },
                    { 144, 0, "Moldova" },
                    { 145, 0, "Monaco" },
                    { 146, 0, "Mongolia" },
                    { 147, 0, "Montenegro" },
                    { 148, 0, "Montserrat" },
                    { 149, 0, "Morocco" },
                    { 150, 0, "Mozambique" },
                    { 151, 0, "Myanmar" },
                    { 152, 0, "Namibia" },
                    { 153, 0, "Nauru" },
                    { 154, 0, "Nepal" },
                    { 155, 0, "Bonaire, Sint Eustatius and Saba" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "States",
                columns: new[] { "id", "country_id", "name" },
                values: new object[,]
                {
                    { 142, 0, "Mexico" },
                    { 186, 0, "Saint Lucia" },
                    { 216, 0, "Taiwan" },
                    { 188, 0, "Saint Vincent And The Grenadines" },
                    { 222, 0, "Tonga" },
                    { 223, 0, "Trinidad And Tobago" },
                    { 224, 0, "Tunisia" },
                    { 225, 0, "Turkey" },
                    { 226, 0, "Turkmenistan" },
                    { 227, 0, "Turks And Caicos Islands" },
                    { 228, 0, "Tuvalu" },
                    { 229, 0, "Uganda" },
                    { 230, 0, "Ukraine" },
                    { 231, 0, "United Arab Emirates" },
                    { 232, 0, "United Kingdom" },
                    { 233, 0, "United States" },
                    { 234, 0, "United States Minor Outlying Islands" },
                    { 221, 0, "Tokelau" },
                    { 235, 0, "Uruguay" },
                    { 237, 0, "Vanuatu" },
                    { 238, 0, "Vatican City State (Holy See)" },
                    { 239, 0, "Venezuela" },
                    { 240, 0, "Vietnam" },
                    { 241, 0, "Virgin Islands (British)" },
                    { 242, 0, "Virgin Islands (US)" },
                    { 243, 0, "Wallis And Futuna Islands" },
                    { 244, 0, "Western Sahara" },
                    { 245, 0, "Yemen" },
                    { 246, 0, "Zambia" },
                    { 247, 0, "Zimbabwe" },
                    { 126, 0, "Lithuania" },
                    { 248, 0, "Kosovo" },
                    { 236, 0, "Uzbekistan" },
                    { 187, 0, "Saint Pierre and Miquelon" },
                    { 220, 0, "Togo" },
                    { 218, 0, "Tanzania" },
                    { 189, 0, "Saint-Barthelemy" },
                    { 190, 0, "Saint-Martin (French part)" },
                    { 191, 0, "Samoa" },
                    { 192, 0, "San Marino" },
                    { 193, 0, "Sao Tome and Principe" },
                    { 194, 0, "Saudi Arabia" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "States",
                columns: new[] { "id", "country_id", "name" },
                values: new object[,]
                {
                    { 195, 0, "Senegal" },
                    { 196, 0, "Serbia" },
                    { 197, 0, "Seychelles" },
                    { 198, 0, "Sierra Leone" },
                    { 199, 0, "Singapore" },
                    { 200, 0, "Slovakia" },
                    { 201, 0, "Slovenia" },
                    { 219, 0, "Thailand" },
                    { 202, 0, "Solomon Islands" },
                    { 204, 0, "South Africa" },
                    { 205, 0, "South Georgia" },
                    { 206, 0, "South Sudan" },
                    { 207, 0, "Spain" },
                    { 208, 0, "Sri Lanka" },
                    { 209, 0, "Sudan" },
                    { 210, 0, "Suriname" },
                    { 211, 0, "Svalbard And Jan Mayen Islands" },
                    { 212, 0, "Swaziland" },
                    { 213, 0, "Sweden" },
                    { 214, 0, "Switzerland" },
                    { 215, 0, "Syria" },
                    { 217, 0, "Tajikistan" },
                    { 203, 0, "Somalia" },
                    { 125, 0, "Liechtenstein" },
                    { 63, 0, "East Timor" },
                    { 123, 0, "Liberia" },
                    { 32, 0, "British Indian Ocean Territory" },
                    { 33, 0, "Brunei" },
                    { 34, 0, "Bulgaria" },
                    { 35, 0, "Burkina Faso" },
                    { 36, 0, "Burundi" },
                    { 37, 0, "Cambodia" },
                    { 38, 0, "Cameroon" },
                    { 39, 0, "Canada" },
                    { 40, 0, "Cape Verde" },
                    { 41, 0, "Cayman Islands" },
                    { 42, 0, "Central African Republic" },
                    { 43, 0, "Chad" },
                    { 44, 0, "Chile" },
                    { 45, 0, "China" },
                    { 46, 0, "Christmas Island" },
                    { 47, 0, "Cocos (Keeling) Islands" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "States",
                columns: new[] { "id", "country_id", "name" },
                values: new object[,]
                {
                    { 48, 0, "Colombia" },
                    { 49, 0, "Comoros" },
                    { 50, 0, "Congo" },
                    { 51, 0, "Congo The Democratic Republic Of The" },
                    { 52, 0, "Cook Islands" },
                    { 53, 0, "Costa Rica" },
                    { 54, 0, "Cote D'Ivoire (Ivory Coast)" },
                    { 55, 0, "Croatia (Hrvatska)" },
                    { 56, 0, "Cuba" },
                    { 57, 0, "Cyprus" },
                    { 58, 0, "Czech Republic" },
                    { 31, 0, "Brazil" },
                    { 30, 0, "Bouvet Island" },
                    { 29, 0, "Botswana" },
                    { 28, 0, "Bosnia and Herzegovina" },
                    { 249, 0, "Curaçao" },
                    { 1, 0, "Afghanistan" },
                    { 2, 0, "Aland Islands" },
                    { 3, 0, "Albania" },
                    { 4, 0, "Algeria" },
                    { 5, 0, "American Samoa" },
                    { 6, 0, "Andorra" },
                    { 7, 0, "Angola" },
                    { 8, 0, "Anguilla" },
                    { 9, 0, "Antarctica" },
                    { 10, 0, "Antigua And Barbuda" },
                    { 11, 0, "Argentina" },
                    { 12, 0, "Armenia" },
                    { 59, 0, "Denmark" },
                    { 13, 0, "Aruba" },
                    { 15, 0, "Austria" },
                    { 16, 0, "Azerbaijan" },
                    { 17, 0, "Bahamas The" },
                    { 18, 0, "Bahrain" },
                    { 19, 0, "Bangladesh" },
                    { 20, 0, "Barbados" },
                    { 21, 0, "Belarus" },
                    { 22, 0, "Belgium" },
                    { 23, 0, "Belize" },
                    { 24, 0, "Benin" },
                    { 25, 0, "Bermuda" },
                    { 26, 0, "Bhutan" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "States",
                columns: new[] { "id", "country_id", "name" },
                values: new object[,]
                {
                    { 27, 0, "Bolivia" },
                    { 14, 0, "Australia" },
                    { 124, 0, "Libya" },
                    { 60, 0, "Djibouti" },
                    { 62, 0, "Dominican Republic" },
                    { 96, 0, "Heard Island and McDonald Islands" },
                    { 97, 0, "Honduras" },
                    { 98, 0, "Hong Kong S.A.R." },
                    { 99, 0, "Hungary" },
                    { 100, 0, "Iceland" },
                    { 101, 0, "India" },
                    { 102, 0, "Indonesia" },
                    { 103, 0, "Iran" },
                    { 104, 0, "Iraq" },
                    { 105, 0, "Ireland" },
                    { 106, 0, "Israel" },
                    { 107, 0, "Italy" },
                    { 108, 0, "Jamaica" },
                    { 109, 0, "Japan" },
                    { 110, 0, "Jersey" },
                    { 111, 0, "Jordan" },
                    { 112, 0, "Kazakhstan" },
                    { 113, 0, "Kenya" },
                    { 114, 0, "Kiribati" },
                    { 115, 0, "Korea North" },
                    { 116, 0, "Korea South" },
                    { 117, 0, "Kuwait" },
                    { 118, 0, "Kyrgyzstan" },
                    { 119, 0, "Laos" },
                    { 120, 0, "Latvia" },
                    { 121, 0, "Lebanon" },
                    { 122, 0, "Lesotho" },
                    { 95, 0, "Haiti" },
                    { 94, 0, "Guyana" },
                    { 93, 0, "Guinea-Bissau" },
                    { 92, 0, "Guinea" },
                    { 64, 0, "Ecuador" },
                    { 65, 0, "Egypt" },
                    { 66, 0, "El Salvador" },
                    { 67, 0, "Equatorial Guinea" },
                    { 68, 0, "Eritrea" },
                    { 69, 0, "Estonia" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "States",
                columns: new[] { "id", "country_id", "name" },
                values: new object[,]
                {
                    { 70, 0, "Ethiopia" },
                    { 71, 0, "Falkland Islands" },
                    { 72, 0, "Faroe Islands" },
                    { 73, 0, "Fiji Islands" },
                    { 74, 0, "Finland" },
                    { 75, 0, "France" },
                    { 76, 0, "French Guiana" },
                    { 61, 0, "Dominica" },
                    { 77, 0, "French Polynesia" },
                    { 79, 0, "Gabon" },
                    { 80, 0, "Gambia The" },
                    { 81, 0, "Georgia" },
                    { 82, 0, "Germany" },
                    { 83, 0, "Ghana" },
                    { 84, 0, "Gibraltar" },
                    { 85, 0, "Greece" },
                    { 86, 0, "Greenland" },
                    { 87, 0, "Grenada" },
                    { 88, 0, "Guadeloupe" },
                    { 89, 0, "Guam" },
                    { 90, 0, "Guatemala" },
                    { 91, 0, "Guernsey and Alderney" },
                    { 78, 0, "French Southern Territories" },
                    { 250, 0, "Sint Maarten (Dutch part)" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_GTINRequests_Companies_company_id",
                schema: "dbo",
                table: "GTINRequests",
                column: "company_id",
                principalSchema: "dbo",
                principalTable: "Companies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Companies_Companiesid",
                schema: "dbo",
                table: "Users",
                column: "Companiesid",
                principalSchema: "dbo",
                principalTable: "Companies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GTINRequests_Companies_company_id",
                schema: "dbo",
                table: "GTINRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Companies_Companiesid",
                schema: "dbo",
                table: "Users");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Countries",
                keyColumn: "id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "GTINFees",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "LocalGovts",
                keyColumn: "id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "States",
                keyColumn: "id",
                keyValue: 250);

            migrationBuilder.CreateTable(
                name: "CompanyModel",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfApproval = table.Column<DateTime>(type: "datetime2", nullable: false),
                    approvalstatus = table.Column<bool>(type: "bit", nullable: false),
                    cacnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    companyaddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    companyname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdon = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateofincorporation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    factoryaddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isregistrationcompleted = table.Column<bool>(type: "bit", nullable: false),
                    modifiedon = table.Column<DateTime>(type: "datetime2", nullable: false),
                    phonenumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    registrationdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    registrationid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyModel", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_GTINRequests_CompanyModel_company_id",
                schema: "dbo",
                table: "GTINRequests",
                column: "company_id",
                principalSchema: "dbo",
                principalTable: "CompanyModel",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_CompanyModel_Companiesid",
                schema: "dbo",
                table: "Users",
                column: "Companiesid",
                principalSchema: "dbo",
                principalTable: "CompanyModel",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
