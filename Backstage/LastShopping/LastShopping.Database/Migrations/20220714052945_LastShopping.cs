using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LastShopping.Database.Migrations
{
    public partial class LastShopping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Factory",
                columns: table => new
                {
                    FactoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factory", x => x.FactoryId);
                });

            migrationBuilder.CreateTable(
                name: "ManagerRole",
                columns: table => new
                {
                    ManagerRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManagerRoleName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerRole", x => x.ManagerRoleId);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    ProductTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.ProductTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    SalesOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.SalesOrderId);
                });

            migrationBuilder.CreateTable(
                name: "Router",
                columns: table => new
                {
                    RouterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouterName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Link = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    Flag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Router", x => x.RouterId);
                });

            migrationBuilder.CreateTable(
                name: "UserMain",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_UserMain", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ManagerMain",
                columns: table => new
                {
                    ManagerId = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_ManagerMain", x => x.ManagerId);
                    table.ForeignKey(
                        name: "FK_ManagerMain_ManagerRole_ManagerRoleId",
                        column: x => x.ManagerRoleId,
                        principalTable: "ManagerRole",
                        principalColumn: "ManagerRoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInformation",
                columns: table => new
                {
                    ProductInformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuggestedPrice = table.Column<int>(type: "int", nullable: false),
                    Inventory = table.Column<int>(type: "int", nullable: false),
                    SellPrice = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProductImgPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactoryId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInformation", x => x.ProductInformationId);
                    table.ForeignKey(
                        name: "FK_ProductInformation_Factory_FactoryId",
                        column: x => x.FactoryId,
                        principalTable: "Factory",
                        principalColumn: "FactoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInformation_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManagerRoleAuths",
                columns: table => new
                {
                    ManagerRoleId = table.Column<int>(type: "int", nullable: false),
                    RouterId = table.Column<int>(type: "int", nullable: false),
                    ViewAuth = table.Column<string>(type: "nchar(1)", maxLength: 1, nullable: false),
                    CreateAuth = table.Column<string>(type: "nchar(1)", maxLength: 1, nullable: false),
                    ModifyAuth = table.Column<string>(type: "nchar(1)", maxLength: 1, nullable: false),
                    DeleteAuth = table.Column<string>(type: "nchar(1)", maxLength: 1, nullable: false),
                    ExportAuth = table.Column<string>(type: "nchar(1)", maxLength: 1, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerRoleAuths", x => new { x.RouterId, x.ManagerRoleId });
                    table.ForeignKey(
                        name: "FK_ManagerRoleAuths_ManagerRole_ManagerRoleId",
                        column: x => x.ManagerRoleId,
                        principalTable: "ManagerRole",
                        principalColumn: "ManagerRoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManagerRoleAuths_Router_RouterId",
                        column: x => x.RouterId,
                        principalTable: "Router",
                        principalColumn: "RouterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrders",
                columns: table => new
                {
                    SalesOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserMainUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrders", x => x.SalesOrderId);
                    table.ForeignKey(
                        name: "FK_SalesOrders_UserMain_UserMainUserId",
                        column: x => x.UserMainUserId,
                        principalTable: "UserMain",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLoginLogs",
                columns: table => new
                {
                    LoginLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Flag = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserMainUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLoginLogs", x => x.LoginLogId);
                    table.ForeignKey(
                        name: "FK_UserLoginLogs_UserMain_UserMainUserId",
                        column: x => x.UserMainUserId,
                        principalTable: "UserMain",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRefreshTokenLogs",
                columns: table => new
                {
                    RefreshToken = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRefreshTokenLogs", x => new { x.RefreshToken, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserRefreshTokenLogs_UserMain_UserId",
                        column: x => x.UserId,
                        principalTable: "UserMain",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManagerLoginLogs",
                columns: table => new
                {
                    ManagerLoginLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Flag = table.Column<bool>(type: "bit", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    ManagerMainManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerLoginLogs", x => x.ManagerLoginLogId);
                    table.ForeignKey(
                        name: "FK_ManagerLoginLogs_ManagerMain_ManagerMainManagerId",
                        column: x => x.ManagerMainManagerId,
                        principalTable: "ManagerMain",
                        principalColumn: "ManagerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManagerRefreshTokenLogs",
                columns: table => new
                {
                    RefreshToken = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerRefreshTokenLogs", x => new { x.RefreshToken, x.ManagerId });
                    table.ForeignKey(
                        name: "FK_ManagerRefreshTokenLogs_ManagerMain_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "ManagerMain",
                        principalColumn: "ManagerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImgs",
                columns: table => new
                {
                    ProductImgId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductImgPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductInformationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImgs", x => x.ProductImgId);
                    table.ForeignKey(
                        name: "FK_ProductImgs_ProductInformation_ProductInformationId",
                        column: x => x.ProductInformationId,
                        principalTable: "ProductInformation",
                        principalColumn: "ProductInformationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderDetails",
                columns: table => new
                {
                    PurchaseOrderId = table.Column<int>(type: "int", nullable: false),
                    ProductInformationId = table.Column<int>(type: "int", nullable: false),
                    ProductAmount = table.Column<int>(type: "int", nullable: false),
                    ProductPrice = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    是否結單 = table.Column<string>(type: "nchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderDetails", x => new { x.PurchaseOrderId, x.ProductInformationId });
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetails_ProductInformation_ProductInformationId",
                        column: x => x.ProductInformationId,
                        principalTable: "ProductInformation",
                        principalColumn: "ProductInformationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetails_PurchaseOrders_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrders",
                        principalColumn: "SalesOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductInformationId = table.Column<int>(type: "int", nullable: false),
                    ProductAmount = table.Column<int>(type: "int", nullable: false),
                    ProductPrice = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderDetails", x => new { x.OrderId, x.ProductInformationId });
                    table.ForeignKey(
                        name: "FK_SalesOrderDetails_ProductInformation_ProductInformationId",
                        column: x => x.ProductInformationId,
                        principalTable: "ProductInformation",
                        principalColumn: "ProductInformationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderDetails_SalesOrders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "SalesOrders",
                        principalColumn: "SalesOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManagerLoginLogs_ManagerId",
                table: "ManagerLoginLogs",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerLoginLogs_ManagerMainManagerId",
                table: "ManagerLoginLogs",
                column: "ManagerMainManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerMain_Account",
                table: "ManagerMain",
                column: "Account");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerMain_ManagerRoleId",
                table: "ManagerMain",
                column: "ManagerRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerRefreshTokenLogs_ManagerId",
                table: "ManagerRefreshTokenLogs",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerRoleAuths_ManagerRoleId",
                table: "ManagerRoleAuths",
                column: "ManagerRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerRoleAuths_RouterId",
                table: "ManagerRoleAuths",
                column: "RouterId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImgs_ProductInformationId",
                table: "ProductImgs",
                column: "ProductInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInformation_FactoryId",
                table: "ProductInformation",
                column: "FactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInformation_ProductInformationId",
                table: "ProductInformation",
                column: "ProductInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInformation_ProductTypeId",
                table: "ProductInformation",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductType_ProductTypeId",
                table: "ProductType",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetails_ProductInformationId",
                table: "PurchaseOrderDetails",
                column: "ProductInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetails_PurchaseOrderId",
                table: "PurchaseOrderDetails",
                column: "PurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_SalesOrderId",
                table: "PurchaseOrders",
                column: "SalesOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderDetails_OrderId",
                table: "SalesOrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderDetails_ProductInformationId",
                table: "SalesOrderDetails",
                column: "ProductInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrders_UserId",
                table: "SalesOrders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrders_UserMainUserId",
                table: "SalesOrders",
                column: "UserMainUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLoginLogs_UserId",
                table: "UserLoginLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLoginLogs_UserMainUserId",
                table: "UserLoginLogs",
                column: "UserMainUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMain_Account",
                table: "UserMain",
                column: "Account");

            migrationBuilder.CreateIndex(
                name: "IX_UserRefreshTokenLogs_UserId",
                table: "UserRefreshTokenLogs",
                column: "UserId");
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
                name: "ProductImgs");

            migrationBuilder.DropTable(
                name: "PurchaseOrderDetails");

            migrationBuilder.DropTable(
                name: "SalesOrderDetails");

            migrationBuilder.DropTable(
                name: "UserLoginLogs");

            migrationBuilder.DropTable(
                name: "UserRefreshTokenLogs");

            migrationBuilder.DropTable(
                name: "ManagerMain");

            migrationBuilder.DropTable(
                name: "Router");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "ProductInformation");

            migrationBuilder.DropTable(
                name: "SalesOrders");

            migrationBuilder.DropTable(
                name: "ManagerRole");

            migrationBuilder.DropTable(
                name: "Factory");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "UserMain");
        }
    }
}
