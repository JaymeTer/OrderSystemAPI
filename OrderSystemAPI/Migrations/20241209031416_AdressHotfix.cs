using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdressHotfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Customer_CustomerID",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_CustomerID",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Address");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_AddressID",
                table: "CustomerAddress",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_Address_AddressID",
                table: "CustomerAddress",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_Address_AddressID",
                table: "CustomerAddress");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAddress_AddressID",
                table: "CustomerAddress");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Address_CustomerID",
                table: "Address",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Customer_CustomerID",
                table: "Address",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
