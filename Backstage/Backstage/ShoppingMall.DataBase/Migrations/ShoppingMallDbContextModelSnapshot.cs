﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Backstage.DbContextModel;

#nullable disable

namespace Backstage.DataBase.Migrations
{
    [DbContext(typeof(ShoppingMallDbContext))]
    partial class ShoppingMallDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Backstage.Models.Factory", b =>
                {
                    b.Property<int>("FactoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FactoryId"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FactoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.HasKey("FactoryId");

                    b.ToTable("Factory");
                });

            modelBuilder.Entity("Backstage.Models.ManagerLoginLog", b =>
                {
                    b.Property<int>("ManagerLoginLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ManagerLoginLogId"), 1L, 1);

                    b.Property<bool>("Flag")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<int>("ManagerMainManagerId")
                        .HasColumnType("int");

                    b.HasKey("ManagerLoginLogId");

                    b.HasIndex("ManagerId");

                    b.HasIndex("ManagerMainManagerId");

                    b.ToTable("ManagerLoginLogs");
                });

            modelBuilder.Entity("Backstage.Models.ManagerMain", b =>
                {
                    b.Property<int>("ManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ManagerId"), 1L, 1);

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("Date");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Flag")
                        .HasColumnType("bit");

                    b.Property<int>("ManagerRoleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ManagerId");

                    b.HasIndex("Account");

                    b.HasIndex("ManagerRoleId");

                    b.ToTable("ManagerMain");
                });

            modelBuilder.Entity("Backstage.Models.ManagerRefreshTokenLog", b =>
                {
                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RefreshToken", "ManagerId");

                    b.HasIndex("ManagerId");

                    b.ToTable("ManagerRefreshTokenLogs");
                });

            modelBuilder.Entity("Backstage.Models.ManagerRole", b =>
                {
                    b.Property<int>("ManagerRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ManagerRoleId"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ManagerRoleName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ManagerRoleId");

                    b.ToTable("ManagerRole");
                });

            modelBuilder.Entity("Backstage.Models.ManagerRoleAuth", b =>
                {
                    b.Property<int>("RouterId")
                        .HasColumnType("int");

                    b.Property<int>("ManagerRoleId")
                        .HasColumnType("int");

                    b.Property<string>("CreateAuth")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nchar(1)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeleteAuth")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nchar(1)");

                    b.Property<string>("ExportAuth")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nchar(1)");

                    b.Property<string>("ModifyAuth")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nchar(1)");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ViewAuth")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nchar(1)");

                    b.HasKey("RouterId", "ManagerRoleId");

                    b.HasIndex("ManagerRoleId");

                    b.HasIndex("RouterId");

                    b.ToTable("ManagerRoleAuths");
                });

            modelBuilder.Entity("Backstage.Models.ProductImg", b =>
                {
                    b.Property<int>("ProductImgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductImgId"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductImgPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductInformationId")
                        .HasColumnType("int");

                    b.HasKey("ProductImgId");

                    b.HasIndex("ProductInformationId");

                    b.ToTable("ProductImgs");
                });

            modelBuilder.Entity("Backstage.Models.ProductInformation", b =>
                {
                    b.Property<int>("ProductInformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductInformationId"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FactoryId")
                        .HasColumnType("int");

                    b.Property<int>("Inventory")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductImgPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("SellPrice")
                        .HasColumnType("int");

                    b.Property<int>("SuggestedPrice")
                        .HasColumnType("int");

                    b.HasKey("ProductInformationId");

                    b.HasIndex("FactoryId");

                    b.HasIndex("ProductInformationId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductInformation");
                });

            modelBuilder.Entity("Backstage.Models.ProductType", b =>
                {
                    b.Property<int>("ProductTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductTypeId"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductType");
                });

            modelBuilder.Entity("Backstage.Models.PurchaseOrder", b =>
                {
                    b.Property<int>("SalesOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesOrderId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SalesOrderId");

                    b.HasIndex("SalesOrderId");

                    b.ToTable("PurchaseOrders");
                });

            modelBuilder.Entity("Backstage.Models.PurchaseOrderDetails", b =>
                {
                    b.Property<int>("PurchaseOrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductInformationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductAmount")
                        .HasColumnType("int");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.Property<string>("是否結單")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nchar(1)");

                    b.HasKey("PurchaseOrderId", "ProductInformationId");

                    b.HasIndex("ProductInformationId");

                    b.HasIndex("PurchaseOrderId");

                    b.ToTable("PurchaseOrderDetails");
                });

            modelBuilder.Entity("Backstage.Models.Router", b =>
                {
                    b.Property<int>("RouterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RouterId"), 1L, 1);

                    b.Property<bool>("Flag")
                        .HasColumnType("bit");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Icon")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("RouterName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("RouterId");

                    b.ToTable("Router");
                });

            modelBuilder.Entity("Backstage.Models.SalesOrder", b =>
                {
                    b.Property<int>("SalesOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesOrderId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UserMainUserId")
                        .HasColumnType("int");

                    b.HasKey("SalesOrderId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserMainUserId");

                    b.ToTable("SalesOrders");
                });

            modelBuilder.Entity("Backstage.Models.SalesOrderDetails", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductInformationId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductAmount")
                        .HasColumnType("int");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductInformationId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductInformationId");

                    b.ToTable("SalesOrderDetails");
                });

            modelBuilder.Entity("Backstage.Models.UserLoginLog", b =>
                {
                    b.Property<int>("LoginLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoginLogId"), 1L, 1);

                    b.Property<bool>("Flag")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UserMainUserId")
                        .HasColumnType("int");

                    b.HasKey("LoginLogId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserMainUserId");

                    b.ToTable("UserLoginLogs");
                });

            modelBuilder.Entity("Backstage.Models.UserMain", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Address")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("Date");

                    b.Property<bool>("Cable")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Flag")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Privacy")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserId");

                    b.HasIndex("Account");

                    b.ToTable("UserMain");
                });

            modelBuilder.Entity("Backstage.Models.UserRefreshTokenLog", b =>
                {
                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RefreshToken", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRefreshTokenLogs");
                });

            modelBuilder.Entity("Backstage.Models.ManagerLoginLog", b =>
                {
                    b.HasOne("Backstage.Models.ManagerMain", "ManagerMain")
                        .WithMany("ManagerLoginLogs")
                        .HasForeignKey("ManagerMainManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManagerMain");
                });

            modelBuilder.Entity("Backstage.Models.ManagerMain", b =>
                {
                    b.HasOne("Backstage.Models.ManagerRole", "ManagerRole")
                        .WithMany("ManagerMains")
                        .HasForeignKey("ManagerRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManagerRole");
                });

            modelBuilder.Entity("Backstage.Models.ManagerRefreshTokenLog", b =>
                {
                    b.HasOne("Backstage.Models.ManagerMain", "ManagerMain")
                        .WithMany()
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManagerMain");
                });

            modelBuilder.Entity("Backstage.Models.ManagerRoleAuth", b =>
                {
                    b.HasOne("Backstage.Models.ManagerRole", "ManagerRole")
                        .WithMany("ManagerRoleAuths")
                        .HasForeignKey("ManagerRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backstage.Models.Router", "Router")
                        .WithMany("ManagerRoleAuths")
                        .HasForeignKey("RouterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManagerRole");

                    b.Navigation("Router");
                });

            modelBuilder.Entity("Backstage.Models.ProductImg", b =>
                {
                    b.HasOne("Backstage.Models.ProductInformation", "ProductInformation")
                        .WithMany("ProductImgs")
                        .HasForeignKey("ProductInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductInformation");
                });

            modelBuilder.Entity("Backstage.Models.ProductInformation", b =>
                {
                    b.HasOne("Backstage.Models.Factory", "Factory")
                        .WithMany("ProductInformations")
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backstage.Models.ProductType", "ProductType")
                        .WithMany("ProductInformations")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factory");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("Backstage.Models.PurchaseOrderDetails", b =>
                {
                    b.HasOne("Backstage.Models.ProductInformation", "ProductInformation")
                        .WithMany("PurchaseOrderDetails")
                        .HasForeignKey("ProductInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backstage.Models.PurchaseOrder", "PurchaseOrder")
                        .WithMany("PurchaseOrderDetails")
                        .HasForeignKey("PurchaseOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductInformation");

                    b.Navigation("PurchaseOrder");
                });

            modelBuilder.Entity("Backstage.Models.SalesOrder", b =>
                {
                    b.HasOne("Backstage.Models.UserMain", "UserMain")
                        .WithMany("SalesOrders")
                        .HasForeignKey("UserMainUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserMain");
                });

            modelBuilder.Entity("Backstage.Models.SalesOrderDetails", b =>
                {
                    b.HasOne("Backstage.Models.SalesOrder", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backstage.Models.ProductInformation", "ProductInformation")
                        .WithMany()
                        .HasForeignKey("ProductInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("ProductInformation");
                });

            modelBuilder.Entity("Backstage.Models.UserLoginLog", b =>
                {
                    b.HasOne("Backstage.Models.UserMain", "UserMain")
                        .WithMany("UserLoginLogs")
                        .HasForeignKey("UserMainUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserMain");
                });

            modelBuilder.Entity("Backstage.Models.UserRefreshTokenLog", b =>
                {
                    b.HasOne("Backstage.Models.UserMain", "UserMain")
                        .WithMany("UserRefreshTokenLogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserMain");
                });

            modelBuilder.Entity("Backstage.Models.Factory", b =>
                {
                    b.Navigation("ProductInformations");
                });

            modelBuilder.Entity("Backstage.Models.ManagerMain", b =>
                {
                    b.Navigation("ManagerLoginLogs");
                });

            modelBuilder.Entity("Backstage.Models.ManagerRole", b =>
                {
                    b.Navigation("ManagerMains");

                    b.Navigation("ManagerRoleAuths");
                });

            modelBuilder.Entity("Backstage.Models.ProductInformation", b =>
                {
                    b.Navigation("ProductImgs");

                    b.Navigation("PurchaseOrderDetails");
                });

            modelBuilder.Entity("Backstage.Models.ProductType", b =>
                {
                    b.Navigation("ProductInformations");
                });

            modelBuilder.Entity("Backstage.Models.PurchaseOrder", b =>
                {
                    b.Navigation("PurchaseOrderDetails");
                });

            modelBuilder.Entity("Backstage.Models.Router", b =>
                {
                    b.Navigation("ManagerRoleAuths");
                });

            modelBuilder.Entity("Backstage.Models.UserMain", b =>
                {
                    b.Navigation("SalesOrders");

                    b.Navigation("UserLoginLogs");

                    b.Navigation("UserRefreshTokenLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
