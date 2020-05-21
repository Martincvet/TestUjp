using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_DDVs_DDVId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_TaxPayers_TaxPayerId",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Product_TaxPayerId",
                table: "Products",
                newName: "IX_Products_TaxPayerId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_DDVId",
                table: "Products",
                newName: "IX_Products_DDVId");

            migrationBuilder.AlterColumn<int>(
                name: "TaxPayerId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DDVId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_DDVs_DDVId",
                table: "Products",
                column: "DDVId",
                principalTable: "DDVs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TaxPayers_TaxPayerId",
                table: "Products",
                column: "TaxPayerId",
                principalTable: "TaxPayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_DDVs_DDVId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_TaxPayers_TaxPayerId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameIndex(
                name: "IX_Products_TaxPayerId",
                table: "Product",
                newName: "IX_Product_TaxPayerId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_DDVId",
                table: "Product",
                newName: "IX_Product_DDVId");

            migrationBuilder.AlterColumn<int>(
                name: "TaxPayerId",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DDVId",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_DDVs_DDVId",
                table: "Product",
                column: "DDVId",
                principalTable: "DDVs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_TaxPayers_TaxPayerId",
                table: "Product",
                column: "TaxPayerId",
                principalTable: "TaxPayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
