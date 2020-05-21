using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_TaxPayers_TaxPayerId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "TaxPayerId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TaxPayers_TaxPayerId",
                table: "Products",
                column: "TaxPayerId",
                principalTable: "TaxPayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_TaxPayers_TaxPayerId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "TaxPayerId",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TaxPayers_TaxPayerId",
                table: "Products",
                column: "TaxPayerId",
                principalTable: "TaxPayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
