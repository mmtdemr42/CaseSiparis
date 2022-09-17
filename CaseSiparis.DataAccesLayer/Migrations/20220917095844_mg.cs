using Microsoft.EntityFrameworkCore.Migrations;

namespace CaseSiparis.DataAccesLayer.Migrations
{
    public partial class mg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Orders",
                newName: "ProductId");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderCompanyId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "OrderProductAmount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "OrderProductCount",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Companies",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderCompanyId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderProductAmount",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderProductCount",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Orders",
                newName: "CompanyId");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);
        }
    }
}
