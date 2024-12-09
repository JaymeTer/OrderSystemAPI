using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OrderSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class Allseedsbutordersfilled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "ID", "AddressType", "City", "State", "StreetAddress", "StreetAdress2", "ZipCode" },
                values: new object[,]
                {
                    { 2, "Bussiness", "Centralia", "WA", "485 Main st", null, "98596" },
                    { 3, "Home", "Gem", "PA", "626 Alamoa drive", null, "43254" },
                    { 4, "Home", "Jesus", "Christ", "6969 This was hard ave", null, "78449" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "ID", "Birthdate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jayme", "Terwilliger" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joe", "Smith" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angel", "Smexy" }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "ID", "Number", "Type" },
                values: new object[,]
                {
                    { 2, "3605455576", "Cell" },
                    { 3, "3607854298", "Home" },
                    { 4, "3214467819", "Cell" }
                });

            migrationBuilder.InsertData(
                table: "CustomerAddress",
                columns: new[] { "ID", "AddressID", "CustomerID" },
                values: new object[,]
                {
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "PeoplePhone",
                columns: new[] { "ID", "CustomerID", "PeopleID", "PhoneNumberID" },
                values: new object[,]
                {
                    { 2, null, 2, 2 },
                    { 3, null, 3, 3 },
                    { 4, null, 4, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomerAddress",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CustomerAddress",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CustomerAddress",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PeoplePhone",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PeoplePhone",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PeoplePhone",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Orders");
        }
    }
}
