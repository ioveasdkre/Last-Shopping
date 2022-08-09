using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LastShopping.Database.Migrations.UserAppDb
{
    public partial class _20220809UpdateComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "UserRefreshTokenLogs",
                type: "datetime2",
                nullable: false,
                comment: "Token有效時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "UserRefreshTokenLogs",
                type: "datetime2",
                nullable: false,
                comment: "建立時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "UserMainId",
                table: "UserRefreshTokenLogs",
                type: "int",
                nullable: false,
                comment: "使用者Id",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "RefreshToken",
                table: "UserRefreshTokenLogs",
                type: "nvarchar(450)",
                nullable: false,
                comment: "使用者Token紀錄",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<bool>(
                name: "Privacy",
                table: "UserMain",
                type: "bit",
                nullable: false,
                comment: "隱私權",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "UserMain",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                comment: "密碼",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserMain",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "姓名",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "UserMain",
                type: "datetime2",
                nullable: true,
                comment: "修改時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Flag",
                table: "UserMain",
                type: "bit",
                nullable: false,
                comment: "帳號是否開啟",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "UserMain",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                comment: "電子信箱",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserMain",
                type: "datetime2",
                nullable: false,
                comment: "建立時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "Cable",
                table: "UserMain",
                type: "bit",
                nullable: false,
                comment: "電報功能",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "UserMain",
                type: "Date",
                nullable: false,
                comment: "出生年月日",
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "UserMain",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                comment: "地址",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "UserMain",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "帳號",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "UserMain",
                type: "int",
                nullable: false,
                comment: "使用者Id",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "UserMainId",
                table: "UserLoginLogs",
                type: "int",
                nullable: false,
                comment: "使用者Id",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "UserLoginLogs",
                type: "datetime2",
                nullable: false,
                comment: "登入時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "Flag",
                table: "UserLoginLogs",
                type: "bit",
                nullable: false,
                comment: "登入成功失敗",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "UserLoginLogs",
                type: "int",
                nullable: false,
                comment: "使用者登入紀錄Id",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ManagerRouter",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                comment: "路由名稱",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "ManagerRouter",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                comment: "網頁連結",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "ManagerRouter",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                comment: "圖標",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "ManagerRouter",
                type: "int",
                nullable: false,
                comment: "路由身分",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "Flag",
                table: "ManagerRouter",
                type: "bit",
                nullable: false,
                comment: "路由使用權限",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ManagerRouter",
                type: "int",
                nullable: false,
                comment: "路由Id",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "ViewAuth",
                table: "ManagerRoleAuths",
                type: "bit",
                nullable: false,
                comment: "瀏覽權限",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ManagerRoleAuths",
                type: "datetime2",
                nullable: true,
                comment: "修改時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ModifyAuth",
                table: "ManagerRoleAuths",
                type: "bit",
                nullable: false,
                comment: "修改權限",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "ExportAuth",
                table: "ManagerRoleAuths",
                type: "bit",
                nullable: false,
                comment: "檔案權限",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "DeleteAuth",
                table: "ManagerRoleAuths",
                type: "bit",
                nullable: false,
                comment: "刪除權限",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ManagerRoleAuths",
                type: "datetime2",
                nullable: false,
                comment: "建立時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "CreateAuth",
                table: "ManagerRoleAuths",
                type: "bit",
                nullable: false,
                comment: "新增權限",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerRouterId",
                table: "ManagerRoleAuths",
                type: "int",
                nullable: false,
                comment: "路由ID",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerRoleId",
                table: "ManagerRoleAuths",
                type: "int",
                nullable: false,
                comment: "管理平台身分Id",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ManagerRole",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "身分名稱",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ManagerRole",
                type: "datetime2",
                nullable: true,
                comment: "修改時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ManagerRole",
                type: "datetime2",
                nullable: false,
                comment: "建立時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ManagerRole",
                type: "int",
                nullable: false,
                comment: "管理平台身分Id",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "ManagerRefreshTokenLogs",
                type: "datetime2",
                nullable: false,
                comment: "Token有效時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ManagerRefreshTokenLogs",
                type: "datetime2",
                nullable: false,
                comment: "建立時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerMainId",
                table: "ManagerRefreshTokenLogs",
                type: "int",
                nullable: false,
                comment: "管理者Id",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "RefreshToken",
                table: "ManagerRefreshTokenLogs",
                type: "nvarchar(450)",
                nullable: false,
                comment: "Token紀錄",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "ManagerMain",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "姓名",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "ManagerMain",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                comment: "密碼",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ManagerMain",
                type: "datetime2",
                nullable: true,
                comment: "修改時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ManagerRoleId",
                table: "ManagerMain",
                type: "int",
                nullable: false,
                comment: "管理者身分Id",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "Flag",
                table: "ManagerMain",
                type: "bit",
                nullable: false,
                comment: "帳號是否開啟",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ManagerMain",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                comment: "電子信箱",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ManagerMain",
                type: "datetime2",
                nullable: false,
                comment: "建立時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "ManagerMain",
                type: "Date",
                nullable: false,
                comment: "管理者登入紀錄表Id",
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "ManagerMain",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                comment: "地址",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "ManagerMain",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "帳號",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ManagerMain",
                type: "int",
                nullable: false,
                comment: "管理者ID",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerMainId",
                table: "ManagerLoginLogs",
                type: "int",
                nullable: false,
                comment: "管理者Id",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "ManagerLoginLogs",
                type: "datetime2",
                nullable: false,
                comment: "管理者登入時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "Flag",
                table: "ManagerLoginLogs",
                type: "bit",
                nullable: false,
                comment: "管理者登入成功失敗",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ManagerLoginLogs",
                type: "int",
                nullable: false,
                comment: "管理者登入紀錄表Id",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "UserRefreshTokenLogs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Token有效時間");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "UserRefreshTokenLogs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "建立時間");

            migrationBuilder.AlterColumn<int>(
                name: "UserMainId",
                table: "UserRefreshTokenLogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "使用者Id");

            migrationBuilder.AlterColumn<string>(
                name: "RefreshToken",
                table: "UserRefreshTokenLogs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldComment: "使用者Token紀錄");

            migrationBuilder.AlterColumn<bool>(
                name: "Privacy",
                table: "UserMain",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "隱私權");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "UserMain",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldComment: "密碼");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserMain",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "姓名");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "UserMain",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "修改時間");

            migrationBuilder.AlterColumn<bool>(
                name: "Flag",
                table: "UserMain",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "帳號是否開啟");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "UserMain",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldComment: "電子信箱");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "UserMain",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "建立時間");

            migrationBuilder.AlterColumn<bool>(
                name: "Cable",
                table: "UserMain",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "電報功能");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "UserMain",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldComment: "出生年月日");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "UserMain",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true,
                oldComment: "地址");

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "UserMain",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "帳號");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "UserMain",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "使用者Id")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "UserMainId",
                table: "UserLoginLogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "使用者Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "UserLoginLogs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "登入時間");

            migrationBuilder.AlterColumn<bool>(
                name: "Flag",
                table: "UserLoginLogs",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "登入成功失敗");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "UserLoginLogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "使用者登入紀錄Id")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ManagerRouter",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldComment: "路由名稱");

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "ManagerRouter",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldComment: "網頁連結");

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "ManagerRouter",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "圖標");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "ManagerRouter",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "路由身分");

            migrationBuilder.AlterColumn<bool>(
                name: "Flag",
                table: "ManagerRouter",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "路由使用權限");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ManagerRouter",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "路由Id")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<bool>(
                name: "ViewAuth",
                table: "ManagerRoleAuths",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "瀏覽權限");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ManagerRoleAuths",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "修改時間");

            migrationBuilder.AlterColumn<bool>(
                name: "ModifyAuth",
                table: "ManagerRoleAuths",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "修改權限");

            migrationBuilder.AlterColumn<bool>(
                name: "ExportAuth",
                table: "ManagerRoleAuths",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "檔案權限");

            migrationBuilder.AlterColumn<bool>(
                name: "DeleteAuth",
                table: "ManagerRoleAuths",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "刪除權限");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ManagerRoleAuths",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "建立時間");

            migrationBuilder.AlterColumn<bool>(
                name: "CreateAuth",
                table: "ManagerRoleAuths",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "新增權限");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerRouterId",
                table: "ManagerRoleAuths",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "路由ID");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerRoleId",
                table: "ManagerRoleAuths",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "管理平台身分Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ManagerRole",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "身分名稱");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ManagerRole",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "修改時間");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ManagerRole",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "建立時間");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ManagerRole",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "管理平台身分Id")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "ManagerRefreshTokenLogs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Token有效時間");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "ManagerRefreshTokenLogs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "建立時間");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerMainId",
                table: "ManagerRefreshTokenLogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "管理者Id");

            migrationBuilder.AlterColumn<string>(
                name: "RefreshToken",
                table: "ManagerRefreshTokenLogs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldComment: "Token紀錄");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "ManagerMain",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "姓名");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "ManagerMain",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldComment: "密碼");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifyDate",
                table: "ManagerMain",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "修改時間");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerRoleId",
                table: "ManagerMain",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "管理者身分Id");

            migrationBuilder.AlterColumn<bool>(
                name: "Flag",
                table: "ManagerMain",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "帳號是否開啟");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ManagerMain",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldComment: "電子信箱");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ManagerMain",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "建立時間");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "ManagerMain",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldComment: "管理者登入紀錄表Id");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "ManagerMain",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldComment: "地址");

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "ManagerMain",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "帳號");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ManagerMain",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "管理者ID")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerMainId",
                table: "ManagerLoginLogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "管理者Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoginTime",
                table: "ManagerLoginLogs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "管理者登入時間");

            migrationBuilder.AlterColumn<bool>(
                name: "Flag",
                table: "ManagerLoginLogs",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "管理者登入成功失敗");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ManagerLoginLogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "管理者登入紀錄表Id")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
