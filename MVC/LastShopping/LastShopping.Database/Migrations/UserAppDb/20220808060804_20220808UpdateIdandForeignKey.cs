using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LastShopping.Database.Migrations.UserAppDb
{
    public partial class _20220808UpdateIdandForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ManagerRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManagerRoleName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManagerRouter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouterName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Link = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    Flag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerRouter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserMain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Account = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Birthday = table.Column<DateTime>(type: "Date", nullable: false),
                    Flag = table.Column<bool>(type: "bit", nullable: false),
                    Cable = table.Column<bool>(type: "bit", nullable: false),
                    Privacy = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMain", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManagerMain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Account = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Birthday = table.Column<DateTime>(type: "Date", nullable: false),
                    Flag = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ManagerRoleId = table.Column<int>(type: "int", nullable: false)
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
                    ManagerRoleId = table.Column<int>(type: "int", nullable: false),
                    ManagerRouterId = table.Column<int>(type: "int", nullable: false),
                    ViewAuth = table.Column<bool>(type: "bit", nullable: false),
                    CreateAuth = table.Column<bool>(type: "bit", nullable: false),
                    ModifyAuth = table.Column<bool>(type: "bit", nullable: false),
                    DeleteAuth = table.Column<bool>(type: "bit", nullable: false),
                    ExportAuth = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Flag = table.Column<bool>(type: "bit", nullable: false),
                    UserMainId = table.Column<int>(type: "int", nullable: false)
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
                    RefreshToken = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserMainId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Flag = table.Column<bool>(type: "bit", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerLoginLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManagerLoginLogs_ManagerMain_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "ManagerMain",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManagerRefreshTokenLogs",
                columns: table => new
                {
                    RefreshToken = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ManagerMainId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "IX_ManagerLoginLogs_ManagerId",
                table: "ManagerLoginLogs",
                column: "ManagerId");

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
