using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LastShopping.Database.Migrations.UserAppDb
{
    public partial class _20220808UpdateTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManagerLoginLogs_ManagerMain_ManagerId",
                table: "ManagerLoginLogs");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "UserMain",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "RouterName",
                table: "ManagerRouter",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ManagerRoleName",
                table: "ManagerRole",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "ManagerLoginLogs",
                newName: "ManagerMainId");

            migrationBuilder.RenameIndex(
                name: "IX_ManagerLoginLogs_ManagerId",
                table: "ManagerLoginLogs",
                newName: "IX_ManagerLoginLogs_ManagerMainId");

            migrationBuilder.AddForeignKey(
                name: "FK_ManagerLoginLogs_ManagerMain_ManagerMainId",
                table: "ManagerLoginLogs",
                column: "ManagerMainId",
                principalTable: "ManagerMain",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManagerLoginLogs_ManagerMain_ManagerMainId",
                table: "ManagerLoginLogs");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "UserMain",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ManagerRouter",
                newName: "RouterName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ManagerRole",
                newName: "ManagerRoleName");

            migrationBuilder.RenameColumn(
                name: "ManagerMainId",
                table: "ManagerLoginLogs",
                newName: "ManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_ManagerLoginLogs_ManagerMainId",
                table: "ManagerLoginLogs",
                newName: "IX_ManagerLoginLogs_ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ManagerLoginLogs_ManagerMain_ManagerId",
                table: "ManagerLoginLogs",
                column: "ManagerId",
                principalTable: "ManagerMain",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
