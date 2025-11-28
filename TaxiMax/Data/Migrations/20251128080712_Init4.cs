using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxiMax.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rola",
                table: "Zlecenia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rola",
                table: "Zlecenia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
