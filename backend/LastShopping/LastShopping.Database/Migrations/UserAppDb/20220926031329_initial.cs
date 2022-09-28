using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LastShopping.Database.Migrations.UserAppDb
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ManagerRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "管理平台身分Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "身分名稱"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "建立時間"),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "修改時間")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManagerRouter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "路由Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, comment: "路由名稱"),
                    Link = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, comment: "網頁連結"),
                    Icon = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true, comment: "圖標"),
                    GroupId = table.Column<int>(type: "int", nullable: false, comment: "路由身分"),
                    Flag = table.Column<bool>(type: "bit", nullable: false, comment: "路由使用權限")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerRouter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserMain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "使用者Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "姓名"),
                    Account = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "帳號"),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, comment: "密碼"),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, comment: "電子信箱"),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, comment: "地址"),
                    Birthday = table.Column<DateTime>(type: "Date", nullable: false, comment: "出生年月日"),
                    Flag = table.Column<bool>(type: "bit", nullable: false, comment: "帳號是否開啟"),
                    Cable = table.Column<bool>(type: "bit", nullable: false, comment: "電報功能"),
                    Privacy = table.Column<bool>(type: "bit", nullable: false, comment: "隱私權"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "建立時間"),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "修改時間")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMain", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManagerMain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "管理者ID")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "姓名"),
                    Account = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "帳號"),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, comment: "密碼"),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, comment: "電子信箱"),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, comment: "地址"),
                    Birthday = table.Column<DateTime>(type: "Date", nullable: false, comment: "管理者登入紀錄表Id"),
                    Flag = table.Column<bool>(type: "bit", nullable: false, comment: "帳號是否開啟"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "建立時間"),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "修改時間"),
                    ManagerRoleId = table.Column<int>(type: "int", nullable: false, comment: "管理者身分Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerMain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManagerMain_ManagerRole_ManagerRoleId",
                        column: x => x.ManagerRoleId,
                        principalTable: "ManagerRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManagerRoleAuths",
                columns: table => new
                {
                    ManagerRoleId = table.Column<int>(type: "int", nullable: false, comment: "管理平台身分Id"),
                    ManagerRouterId = table.Column<int>(type: "int", nullable: false, comment: "路由ID"),
                    ViewAuth = table.Column<bool>(type: "bit", nullable: false, comment: "瀏覽權限"),
                    CreateAuth = table.Column<bool>(type: "bit", nullable: false, comment: "新增權限"),
                    ModifyAuth = table.Column<bool>(type: "bit", nullable: false, comment: "修改權限"),
                    DeleteAuth = table.Column<bool>(type: "bit", nullable: false, comment: "刪除權限"),
                    ExportAuth = table.Column<bool>(type: "bit", nullable: false, comment: "檔案權限"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "建立時間"),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "修改時間")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerRoleAuths", x => new { x.ManagerRoleId, x.ManagerRouterId });
                    table.ForeignKey(
                        name: "FK_ManagerRoleAuths_ManagerRole_ManagerRoleId",
                        column: x => x.ManagerRoleId,
                        principalTable: "ManagerRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManagerRoleAuths_ManagerRouter_ManagerRouterId",
                        column: x => x.ManagerRouterId,
                        principalTable: "ManagerRouter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLoginLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "使用者登入紀錄Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "登入時間"),
                    Flag = table.Column<bool>(type: "bit", nullable: false, comment: "登入成功失敗"),
                    UserMainId = table.Column<int>(type: "int", nullable: false, comment: "使用者Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLoginLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLoginLogs_UserMain_UserMainId",
                        column: x => x.UserMainId,
                        principalTable: "UserMain",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRefreshTokenLogs",
                columns: table => new
                {
                    RefreshToken = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "使用者Token紀錄"),
                    UserMainId = table.Column<int>(type: "int", nullable: false, comment: "使用者Id"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "建立時間"),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Token有效時間")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRefreshTokenLogs", x => new { x.RefreshToken, x.UserMainId });
                    table.ForeignKey(
                        name: "FK_UserRefreshTokenLogs_UserMain_UserMainId",
                        column: x => x.UserMainId,
                        principalTable: "UserMain",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManagerLoginLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "管理者登入紀錄表Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "管理者登入時間"),
                    Flag = table.Column<bool>(type: "bit", nullable: false, comment: "管理者登入成功失敗"),
                    ManagerMainId = table.Column<int>(type: "int", nullable: false, comment: "管理者Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerLoginLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManagerLoginLogs_ManagerMain_ManagerMainId",
                        column: x => x.ManagerMainId,
                        principalTable: "ManagerMain",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManagerRefreshTokenLogs",
                columns: table => new
                {
                    RefreshToken = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Token紀錄"),
                    ManagerMainId = table.Column<int>(type: "int", nullable: false, comment: "管理者Id"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "建立時間"),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Token有效時間")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerRefreshTokenLogs", x => new { x.RefreshToken, x.ManagerMainId });
                    table.ForeignKey(
                        name: "FK_ManagerRefreshTokenLogs_ManagerMain_ManagerMainId",
                        column: x => x.ManagerMainId,
                        principalTable: "ManagerMain",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManagerLoginLogs_Id",
                table: "ManagerLoginLogs",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerLoginLogs_ManagerMainId",
                table: "ManagerLoginLogs",
                column: "ManagerMainId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerMain_Account",
                table: "ManagerMain",
                column: "Account");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerMain_ManagerRoleId",
                table: "ManagerMain",
                column: "ManagerRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerRefreshTokenLogs_ManagerMainId",
                table: "ManagerRefreshTokenLogs",
                column: "ManagerMainId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerRole_Id",
                table: "ManagerRole",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerRoleAuths_ManagerRoleId",
                table: "ManagerRoleAuths",
                column: "ManagerRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerRoleAuths_ManagerRouterId",
                table: "ManagerRoleAuths",
                column: "ManagerRouterId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerRouter_Id",
                table: "ManagerRouter",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserLoginLogs_Id",
                table: "UserLoginLogs",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserLoginLogs_UserMainId",
                table: "UserLoginLogs",
                column: "UserMainId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMain_Account",
                table: "UserMain",
                column: "Account");

            migrationBuilder.CreateIndex(
                name: "IX_UserRefreshTokenLogs_UserMainId",
                table: "UserRefreshTokenLogs",
                column: "UserMainId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManagerLoginLogs");

            migrationBuilder.DropTable(
                name: "ManagerRefreshTokenLogs");

            migrationBuilder.DropTable(
                name: "ManagerRoleAuths");

            migrationBuilder.DropTable(
                name: "UserLoginLogs");

            migrationBuilder.DropTable(
                name: "UserRefreshTokenLogs");

            migrationBuilder.DropTable(
                name: "ManagerMain");

            migrationBuilder.DropTable(
                name: "ManagerRouter");

            migrationBuilder.DropTable(
                name: "UserMain");

            migrationBuilder.DropTable(
                name: "ManagerRole");
        }
    }
}
