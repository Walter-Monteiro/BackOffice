using Microsoft.EntityFrameworkCore.Migrations;

namespace Crude.Migrations
{
    public partial class seedCidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome" },
                values: new object[] { 1, 39.600000000000001, -8.4000000000000004, "Tomar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
