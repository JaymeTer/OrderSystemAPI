using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class ExpandedPhones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Customer");

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PeoplePhone",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeopleID = table.Column<int>(type: "int", nullable: false),
                    PhoneNumberID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeoplePhone", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PeoplePhone_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeoplePhone_PhoneNumbers_PhoneNumberID",
                        column: x => x.PhoneNumberID,
                        principalTable: "PhoneNumbers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeoplePhone_CustomerID",
                table: "PeoplePhone",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_PeoplePhone_PhoneNumberID",
                table: "PeoplePhone",
                column: "PhoneNumberID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeoplePhone");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
