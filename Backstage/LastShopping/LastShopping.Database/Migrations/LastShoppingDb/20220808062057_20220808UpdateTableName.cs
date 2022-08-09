using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LastShopping.Database.Migrations.LastShoppingDb
{
    public partial class _20220808UpdateTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "是否結單",
                table: "PurchaseOrderDetails",
                newName: "check");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "check",
                table: "PurchaseOrderDetails",
                newName: "是否結單");
        }
    }
}
