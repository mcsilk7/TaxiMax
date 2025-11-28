using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxiMax.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rola",
                table: "Zlecenia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "wykonawca",
                table: "Zlecenia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rola",
                table: "Zlecenia");

            migrationBuilder.DropColumn(
                name: "wykonawca",
                table: "Zlecenia");
        }
    }
}
