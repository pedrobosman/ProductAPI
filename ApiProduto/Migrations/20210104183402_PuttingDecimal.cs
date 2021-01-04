using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiProduto.Migrations
{
    public partial class PuttingDecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Produtos",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Preco",
                value: 1.29m);

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Preco",
                value: 5.99m);

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Preco",
                value: 189.90m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Preco",
                table: "Produtos",
                type: "float",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Preco",
                value: 1.29f);

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Preco",
                value: 5.99f);

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Preco",
                value: 189.9f);
        }
    }
}
