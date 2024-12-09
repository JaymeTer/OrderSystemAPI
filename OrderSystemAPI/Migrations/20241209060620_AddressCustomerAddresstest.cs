using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddressCustomerAddresstest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "ID", "AddressType", "City", "State", "StreetAddress", "StreetAdress2", "ZipCode" },
                values: new object[] { 1, "Home", "Winlock", "WA", "408 sw Kerron st", null, "98596" });

            migrationBuilder.InsertData(
                table: "CustomerAddress",
                columns: new[] { "ID", "AddressID", "CustomerID" },
                values: new object[] { 1, 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomerAddress",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
