﻿// <auto-generated />
using System;
using LastShopping.Database.DbContextModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LastShopping.Database.Migrations.UserAppDb
{
    [DbContext(typeof(UserAppDbContext))]
    [Migration("20220808062119_20220808UpdateTableName")]
    partial class _20220808UpdateTableName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerLoginLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Flag")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ManagerMainId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("ManagerMainId");

                    b.ToTable("ManagerLoginLogs");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerMain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    b.HasKey("Id");

                    b.HasIndex("Account");

                    b.HasIndex("ManagerRoleId");

                    b.ToTable("ManagerMain");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerRefreshTokenLog", b =>
                {
                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ManagerMainId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RefreshToken", "ManagerMainId");

                    b.HasIndex("ManagerMainId");

                    b.ToTable("ManagerRefreshTokenLogs");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("ManagerRole");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerRoleAuth", b =>
                {
                    b.Property<int>("ManagerRoleId")
                        .HasColumnType("int");

                    b.Property<int>("ManagerRouterId")
                        .HasColumnType("int");

                    b.Property<bool>("CreateAuth")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DeleteAuth")
                        .HasColumnType("bit");

                    b.Property<bool>("ExportAuth")
                        .HasColumnType("bit");

                    b.Property<bool>("ModifyAuth")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ViewAuth")
                        .HasColumnType("bit");

                    b.HasKey("ManagerRoleId", "ManagerRouterId");

                    b.HasIndex("ManagerRoleId");

                    b.HasIndex("ManagerRouterId");

                    b.ToTable("ManagerRoleAuths");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerRouter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Flag")
                        .HasColumnType("bit");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Icon")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("ManagerRouter");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.UserLoginLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Flag")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserMainId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("UserMainId");

                    b.ToTable("UserLoginLogs");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.UserMain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Privacy")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Account");

                    b.ToTable("UserMain");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.UserRefreshTokenLog", b =>
                {
                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("UserMainId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RefreshToken", "UserMainId");

                    b.HasIndex("UserMainId");

                    b.ToTable("UserRefreshTokenLogs");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerLoginLog", b =>
                {
                    b.HasOne("LastShopping.Database.UserAppModels.ManagerMain", "ManagerMain")
                        .WithMany("ManagerLoginLogs")
                        .HasForeignKey("ManagerMainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManagerMain");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerMain", b =>
                {
                    b.HasOne("LastShopping.Database.UserAppModels.ManagerRole", "ManagerRole")
                        .WithMany("ManagerMains")
                        .HasForeignKey("ManagerRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManagerRole");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerRefreshTokenLog", b =>
                {
                    b.HasOne("LastShopping.Database.UserAppModels.ManagerMain", "ManagerMain")
                        .WithMany("ManagerRefreshTokenLogs")
                        .HasForeignKey("ManagerMainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManagerMain");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerRoleAuth", b =>
                {
                    b.HasOne("LastShopping.Database.UserAppModels.ManagerRole", "ManagerRole")
                        .WithMany("ManagerRoleAuths")
                        .HasForeignKey("ManagerRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LastShopping.Database.UserAppModels.ManagerRouter", "ManagerRouter")
                        .WithMany("ManagerRoleAuths")
                        .HasForeignKey("ManagerRouterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ManagerRole");

                    b.Navigation("ManagerRouter");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.UserLoginLog", b =>
                {
                    b.HasOne("LastShopping.Database.UserAppModels.UserMain", "UserMain")
                        .WithMany("UserLoginLogs")
                        .HasForeignKey("UserMainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserMain");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.UserRefreshTokenLog", b =>
                {
                    b.HasOne("LastShopping.Database.UserAppModels.UserMain", "UserMain")
                        .WithMany("UserRefreshTokenLogs")
                        .HasForeignKey("UserMainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserMain");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerMain", b =>
                {
                    b.Navigation("ManagerLoginLogs");

                    b.Navigation("ManagerRefreshTokenLogs");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerRole", b =>
                {
                    b.Navigation("ManagerMains");

                    b.Navigation("ManagerRoleAuths");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.ManagerRouter", b =>
                {
                    b.Navigation("ManagerRoleAuths");
                });

            modelBuilder.Entity("LastShopping.Database.UserAppModels.UserMain", b =>
                {
                    b.Navigation("UserLoginLogs");

                    b.Navigation("UserRefreshTokenLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
