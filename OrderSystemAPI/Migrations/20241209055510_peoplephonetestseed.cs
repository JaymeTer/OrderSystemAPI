using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class peoplephonetestseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "ID", "Birthdate", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alys", "Terwilliger" });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "ID", "Number", "Type" },
                values: new object[] { 1, "3602063171", "Cell" });

            migrationBuilder.InsertData(
                table: "PeoplePhone",
                columns: new[] { "ID", "CustomerID", "PeopleID", "PhoneNumberID" },
                values: new object[] { 1, null, 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PeoplePhone",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PhoneNumbers",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
