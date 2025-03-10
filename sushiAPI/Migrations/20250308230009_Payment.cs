using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sushiAPI.Migrations
{
    /// <inheritdoc />
    public partial class Payment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Payments",
                newName: "PostCode");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Payments",
                newName: "PhoneNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostCode",
                table: "Payments",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Payments",
                newName: "Email");
        }
    }
}
