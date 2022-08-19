using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LastShopping.Database.Migrations.LastShoppingDb
{
    public partial class _20220809UpdateComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "SalesOrders",
                type: "int",
                nullable: false,
                comment: "使用者Id",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "SalesOrders",
                type: "datetime2",
                nullable: true,
                comment: "修改時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalesOrders",
                type: "datetime2",
                nullable: false,
                comment: "建立時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SalesOrders",
                type: "int",
                nullable: false,
                comment: "銷售訂單Id",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "SalesOrderDetails",
                type: "int",
                nullable: false,
                comment: "銷售價格",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "OrderStatus",
                table: "SalesOrderDetails",
                type: "nvarchar(max)",
                nullable: false,
                comment: "訂單狀態",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "SalesOrderDetails",
                type: "datetime2",
                nullable: true,
                comment: "修改時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SalesOrderDetails",
                type: "datetime2",
                nullable: false,
                comment: "建立時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ArrivalDate",
                table: "SalesOrderDetails",
                type: "datetime2",
                nullable: true,
                comment: "到貨時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "SalesOrderDetails",
                type: "int",
                nullable: false,
                comment: "銷售數量",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductInformationId",
                table: "SalesOrderDetails",
                type: "int",
                nullable: false,
                comment: "產品Id",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SalesOrderId",
                table: "SalesOrderDetails",
                type: "int",
                nullable: false,
                comment: "銷售訂單Id",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "PurchaseOrders",
                type: "datetime2",
                nullable: true,
                comment: "修改時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PurchaseOrders",
                type: "datetime2",
                nullable: false,
                comment: "建立時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PurchaseOrders",
                type: "int",
                nullable: false,
                comment: "進貨訂單資訊Id",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "check",
                table: "PurchaseOrderDetails",
                type: "bit",
                nullable: false,
                comment: "是否結單",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "PurchaseOrderDetails",
                type: "int",
                nullable: false,
                comment: "進貨成本",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "PurchaseOrderDetails",
                type: "datetime2",
                nullable: true,
                comment: "修改時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PurchaseOrderDetails",
                type: "datetime2",
                nullable: false,
                comment: "建立時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "PurchaseOrderDetails",
                type: "int",
                nullable: false,
                comment: "進貨數量",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductInformationId",
                table: "PurchaseOrderDetails",
                type: "int",
                nullable: false,
                comment: "產品Id",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PurchaseOrderId",
                table: "PurchaseOrderDetails",
                type: "int",
                nullable: false,
                comment: "進貨訂單Id",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ProductType",
                type: "nvarchar(max)",
                nullable: false,
                comment: "產品類型",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ProductType",
                type: "datetime2",
                nullable: true,
                comment: "修改時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ProductType",
                type: "datetime2",
                nullable: false,
                comment: "建立時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ProductType",
                type: "int",
                nullable: false,
                comment: "產品類型Id",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "SuggestedPrice",
                table: "ProductInformation",
                type: "int",
                nullable: false,
                comment: "建議售價",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SellPrice",
                table: "ProductInformation",
                type: "int",
                nullable: false,
                comment: "售價",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductTypeId",
                table: "ProductInformation",
                type: "int",
                nullable: false,
                comment: "產品類型Id",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "ProductInformation",
                type: "nvarchar(max)",
                nullable: false,
                comment: "主要圖片路徑",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProductInformation",
                type: "nvarchar(max)",
                nullable: false,
                comment: "產品名稱",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ProductInformation",
                type: "datetime2",
                nullable: true,
                comment: "修改時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Inventory",
                table: "ProductInformation",
                type: "int",
                nullable: false,
                comment: "庫存量",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FactoryId",
                table: "ProductInformation",
                type: "int",
                nullable: false,
                comment: "廠商Id",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ProductInformation",
                type: "datetime2",
                nullable: false,
                comment: "建立時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ProductInformation",
                type: "int",
                nullable: false,
                comment: "產品Id",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ProductInformationId",
                table: "ProductImgs",
                type: "int",
                nullable: false,
                comment: "產品Id",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "ProductImgs",
                type: "nvarchar(max)",
                nullable: false,
                comment: "產品圖片路徑",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ProductImgs",
                type: "datetime2",
                nullable: false,
                comment: "修改時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ProductImgs",
                type: "datetime2",
                nullable: false,
                comment: "建立時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ProductImgs",
                type: "int",
                nullable: false,
                comment: "產品圖片Id",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                comment: "廠商名稱",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Factory",
                type: "datetime2",
                nullable: true,
                comment: "修改時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Factory",
                type: "datetime2",
                nullable: false,
                comment: "建立時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "SalesOrders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "使用者Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "SalesOrders",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "修改時間");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalesOrders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "建立時間");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SalesOrders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "銷售訂單Id")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "SalesOrderDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "銷售價格");

            migrationBuilder.AlterColumn<string>(
                name: "OrderStatus",
                table: "SalesOrderDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "訂單狀態");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "SalesOrderDetails",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "修改時間");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SalesOrderDetails",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "建立時間");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ArrivalDate",
                table: "SalesOrderDetails",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "到貨時間");

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "SalesOrderDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "銷售數量");

            migrationBuilder.AlterColumn<int>(
                name: "ProductInformationId",
                table: "SalesOrderDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "產品Id");

            migrationBuilder.AlterColumn<int>(
                name: "SalesOrderId",
                table: "SalesOrderDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "銷售訂單Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "PurchaseOrders",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "修改時間");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PurchaseOrders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "建立時間");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PurchaseOrders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "進貨訂單資訊Id")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "check",
                table: "PurchaseOrderDetails",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "是否結單");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "PurchaseOrderDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "進貨成本");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "PurchaseOrderDetails",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "修改時間");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "PurchaseOrderDetails",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "建立時間");

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "PurchaseOrderDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "進貨數量");

            migrationBuilder.AlterColumn<int>(
                name: "ProductInformationId",
                table: "PurchaseOrderDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "產品Id");

            migrationBuilder.AlterColumn<int>(
                name: "PurchaseOrderId",
                table: "PurchaseOrderDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "進貨訂單Id");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ProductType",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "產品類型");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ProductType",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "修改時間");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ProductType",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "建立時間");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ProductType",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "產品類型Id")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "SuggestedPrice",
                table: "ProductInformation",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "建議售價");

            migrationBuilder.AlterColumn<int>(
                name: "SellPrice",
                table: "ProductInformation",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "售價");

            migrationBuilder.AlterColumn<int>(
                name: "ProductTypeId",
                table: "ProductInformation",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "產品類型Id");

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "ProductInformation",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "主要圖片路徑");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ProductInformation",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "產品名稱");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ProductInformation",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "修改時間");

            migrationBuilder.AlterColumn<int>(
                name: "Inventory",
                table: "ProductInformation",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "庫存量");

            migrationBuilder.AlterColumn<int>(
                name: "FactoryId",
                table: "ProductInformation",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "廠商Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ProductInformation",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "建立時間");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ProductInformation",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "產品Id")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ProductInformationId",
                table: "ProductImgs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "產品Id");

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "ProductImgs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "產品圖片路徑");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ProductImgs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "修改時間");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ProductImgs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "建立時間");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ProductImgs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "產品圖片Id")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Factory",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "廠商名稱");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "Factory",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "修改時間");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Factory",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "建立時間");
        }
    }
}
