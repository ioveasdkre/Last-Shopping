using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LastShopping.Database.Migrations.LastShoppingDb
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Factory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "廠商名稱"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "建立時間"),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "修改時間")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "產品類型Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "產品類型"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "建立時間"),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "修改時間")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "進貨訂單資訊Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "建立時間"),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "修改時間")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "銷售訂單Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "建立時間"),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "修改時間"),
                    UserId = table.Column<int>(type: "int", nullable: false, comment: "使用者Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "產品Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "產品名稱"),
                    SuggestedPrice = table.Column<int>(type: "int", nullable: false, comment: "建議售價"),
                    Inventory = table.Column<int>(type: "int", nullable: false, comment: "庫存量"),
                    SellPrice = table.Column<int>(type: "int", nullable: false, comment: "售價"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "建立時間"),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "修改時間"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "主要圖片路徑"),
                    FactoryId = table.Column<int>(type: "int", nullable: false, comment: "廠商Id"),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false, comment: "產品類型Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductInformation_Factory_FactoryId",
                        column: x => x.FactoryId,
                        principalTable: "Factory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInformation_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImgs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "產品圖片Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "產品圖片路徑"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "建立時間"),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "修改時間"),
                    ProductInformationId = table.Column<int>(type: "int", nullable: false, comment: "產品Id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImgs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImgs_ProductInformation_ProductInformationId",
                        column: x => x.ProductInformationId,
                        principalTable: "ProductInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderDetails",
                columns: table => new
                {
                    PurchaseOrderId = table.Column<int>(type: "int", nullable: false, comment: "進貨訂單Id"),
                    ProductInformationId = table.Column<int>(type: "int", nullable: false, comment: "產品Id"),
                    Amount = table.Column<int>(type: "int", nullable: false, comment: "進貨數量"),
                    Price = table.Column<int>(type: "int", nullable: false, comment: "進貨成本"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "建立時間"),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "修改時間"),
                    check = table.Column<bool>(type: "bit", nullable: false, comment: "是否結單")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderDetails", x => new { x.PurchaseOrderId, x.ProductInformationId });
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetails_ProductInformation_ProductInformationId",
                        column: x => x.ProductInformationId,
                        principalTable: "ProductInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetails_PurchaseOrders_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderDetails",
                columns: table => new
                {
                    SalesOrderId = table.Column<int>(type: "int", nullable: false, comment: "銷售訂單Id"),
                    ProductInformationId = table.Column<int>(type: "int", nullable: false, comment: "產品Id"),
                    Amount = table.Column<int>(type: "int", nullable: false, comment: "銷售數量"),
                    Price = table.Column<int>(type: "int", nullable: false, comment: "銷售價格"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "建立時間"),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "修改時間"),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "訂單狀態: 0成立訂單, 1撿貨, 2理貨, 3出貨, 4已送達, 5成立退貨, 6商品回收中, 7檢驗中, 8退款中, 9已退款"),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "到貨時間")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderDetails", x => new { x.SalesOrderId, x.ProductInformationId });
                    table.ForeignKey(
                        name: "FK_SalesOrderDetails_ProductInformation_ProductInformationId",
                        column: x => x.ProductInformationId,
                        principalTable: "ProductInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderDetails_SalesOrders_SalesOrderId",
                        column: x => x.SalesOrderId,
                        principalTable: "SalesOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImgs_Id",
                table: "ProductImgs",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImgs_ProductInformationId",
                table: "ProductImgs",
                column: "ProductInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInformation_FactoryId",
                table: "ProductInformation",
                column: "FactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInformation_Id",
                table: "ProductInformation",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInformation_ProductTypeId",
                table: "ProductInformation",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductType_Id",
                table: "ProductType",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetails_ProductInformationId",
                table: "PurchaseOrderDetails",
                column: "ProductInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetails_PurchaseOrderId",
                table: "PurchaseOrderDetails",
                column: "PurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_Id",
                table: "PurchaseOrders",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderDetails_ProductInformationId",
                table: "SalesOrderDetails",
                column: "ProductInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderDetails_SalesOrderId",
                table: "SalesOrderDetails",
                column: "SalesOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrders_Id",
                table: "SalesOrders",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrders_UserId",
                table: "SalesOrders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImgs");

            migrationBuilder.DropTable(
                name: "PurchaseOrderDetails");

            migrationBuilder.DropTable(
                name: "SalesOrderDetails");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "ProductInformation");

            migrationBuilder.DropTable(
                name: "SalesOrders");

            migrationBuilder.DropTable(
                name: "Factory");

            migrationBuilder.DropTable(
                name: "ProductType");
        }
    }
}
