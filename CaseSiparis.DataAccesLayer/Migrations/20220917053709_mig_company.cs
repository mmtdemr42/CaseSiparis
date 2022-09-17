using Microsoft.EntityFrameworkCore.Migrations;

namespace CaseSiparis.DataAccesLayer.Migrations
{
    public partial class mig_company : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyID",
                table: "Orders",
                newName: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Orders",
                newName: "CompanyID");
        }
    }
}
