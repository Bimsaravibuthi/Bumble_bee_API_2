﻿// <auto-generated />
using System;
using Bumble_bee_API_2.DAL;
using Bumble_bee_API_2.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bumble_bee_API_2.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230328102851_Product_updated")]
    partial class Product_updated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Bumble_bee_API_2.DAL.tbl_Address", b =>
                {
                    b.Property<int>("ADD_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ADD_ID"), 1L, 1);

                    b.Property<string>("ADD_LINE1")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ADD_LINE2")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ADD_MOBILE")
                        .HasColumnType("int");

                    b.Property<string>("ADD_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("CITYCT_ID")
                        .HasColumnType("int");

                    b.Property<int>("USERUSR_ID")
                        .HasColumnType("int");

                    b.HasKey("ADD_ID");

                    b.HasIndex("CITYCT_ID");

                    b.HasIndex("USERUSR_ID");

                    b.ToTable("tbl_Addresses");
                });

            modelBuilder.Entity("Bumble_bee_API_2.DAL.tbl_Brand", b =>
                {
                    b.Property<int>("BR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BR_ID"), 1L, 1);

                    b.Property<string>("BR_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("BR_ID");

                    b.ToTable("tbl_Brands");
                });

            modelBuilder.Entity("Bumble_bee_API_2.DAL.tbl_Category", b =>
                {
                    b.Property<int>("CAT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CAT_ID"), 1L, 1);

                    b.Property<string>("CAT_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CAT_ID");

                    b.ToTable("tbl_Category");
                });

            modelBuilder.Entity("Bumble_bee_API_2.DAL.tbl_City", b =>
                {
                    b.Property<int>("CT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CT_ID"), 1L, 1);

                    b.Property<string>("CT_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<int?>("DISTRICTDT_ID")
                        .HasColumnType("int");

                    b.HasKey("CT_ID");

                    b.HasIndex("DISTRICTDT_ID");

                    b.ToTable("tbl_Cities");
                });

            modelBuilder.Entity("Bumble_bee_API_2.DAL.tbl_District", b =>
                {
                    b.Property<int>("DT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DT_ID"), 1L, 1);

                    b.Property<string>("DT_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("DT_ID");

                    b.ToTable("tbl_Districts");
                });

            modelBuilder.Entity("Bumble_bee_API_2.DAL.tbl_Product", b =>
                {
                    b.Property<int>("PR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PR_ID"), 1L, 1);

                    b.Property<int?>("BRANDBR_ID")
                        .HasColumnType("int");

                    b.Property<int?>("CATEGORYCAT_ID")
                        .HasColumnType("int");

                    b.Property<string>("PR_COST")
                        .IsRequired()
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("PR_DESCRIPTION")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("PR_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PR_PRICE")
                        .IsRequired()
                        .HasColumnType("nvarchar(7)");

                    b.Property<int>("PR_QTY")
                        .HasColumnType("int");

                    b.HasKey("PR_ID");

                    b.HasIndex("BRANDBR_ID");

                    b.HasIndex("CATEGORYCAT_ID");

                    b.ToTable("tbl_Product");
                });

            modelBuilder.Entity("Bumble_bee_API_2.DAL.tbl_User", b =>
                {
                    b.Property<int>("USR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("USR_ID"), 1L, 1);

                    b.Property<bool>("CUS_STATUS")
                        .HasColumnType("bit");

                    b.Property<string>("USR_EMAIL")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("USR_FNAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("USR_LNAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("USR_NIC")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)");

                    b.Property<byte[]>("USR_PWD")
                        .IsRequired()
                        .HasColumnType("varbinary(MAX)");

                    b.Property<string>("USR_TYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)");

                    b.HasKey("USR_ID");

                    b.ToTable("tbl_Users");
                });

            modelBuilder.Entity("Bumble_bee_API_2.DAL.tbl_UserProduct", b =>
                {
                    b.Property<int>("USER_ID")
                        .HasColumnType("int");

                    b.Property<int>("PRODUCT_ID")
                        .HasColumnType("int");

                    b.Property<int>("ADDED_USER")
                        .HasColumnType("int");

                    b.Property<int>("LAST_UP_USER")
                        .HasColumnType("int");

                    b.HasKey("USER_ID", "PRODUCT_ID");

                    b.HasIndex("PRODUCT_ID");

                    b.ToTable("tbl_UserProduct");
                });

            modelBuilder.Entity("Bumble_bee_API_2.DAL.tbl_Address", b =>
                {
                    b.HasOne("Bumble_bee_API_2.DAL.tbl_City", "CITY")
                        .WithMany("ADDRESS")
                        .HasForeignKey("CITYCT_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bumble_bee_API_2.DAL.tbl_User", "USER")
                        .WithMany("ADDRESS")
                        .HasForeignKey("USERUSR_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CITY");

                    b.Navigation("USER");
                });

            modelBuilder.Entity("Bumble_bee_API_2.DAL.tbl_City", b =>
                {
                    b.HasOne("Bumble_bee_API_2.DAL.tbl_District", "DISTRICT")
                        .WithMany("CITY")
                        .HasForeignKey("DISTRICTDT_ID");

                    b.Navigation("DISTRICT");
                });

            modelBuilder.Entity("Bumble_bee_API_2.DAL.tbl_Product", b =>
                {
                    b.HasOne("Bumble_bee_API_2.DAL.tbl_Brand", "BRAND")
                        .WithMany("PRODUCT")
                        .HasForeignKey("BRANDBR_ID");

                    b.HasOne("Bumble_bee_API_2.DAL.tbl_Category", "CATEGORY")
                        .WithMany("PRODUCTS")
                        .HasForeignKey("CATEGORYCAT_ID");

                    b.Navigation("BRAND");

                    b.Navigation("CATEGORY");
                });

            modelBuilder.Entity("Bumble_bee_API_2.DAL.tbl_UserProduct", b =>
                {
                    b.HasOne("Bumble_bee_API_2.DAL.tbl_Product", "tbl_Product")
                        .WithMany("tbl_UserProducts")
                        .HasForeignKey("PRODUCT_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bumble_bee_API_2.DAL.tbl_User", "tbl_User")
                        .WithMany("tbl_UserProducts")
                        .HasForeignKey("USER_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tbl_Product");

                    b.Navigation("tbl_User");
                });

            modelBuilder.Entity("Bumble_bee_API_2.DAL.tbl_Brand", b =>
                {
                    b.Navigation("PRODUCT");
                });

            modelBuilder.Entity("Bumble_bee_API_2.DAL.tbl_Category", b =>
                {
                    b.Navigation("PRODUCTS");
                });

            modelBuilder.Entity("Bumble_bee_API_2.DAL.tbl_City", b =>
                {
                    b.Navigation("ADDRESS");
                });

            modelBuilder.Entity("Bumble_bee_API_2.DAL.tbl_District", b =>
                {
                    b.Navigation("CITY");
                });

            modelBuilder.Entity("Bumble_bee_API_2.DAL.tbl_Product", b =>
                {
                    b.Navigation("tbl_UserProducts");
                });

            modelBuilder.Entity("Bumble_bee_API_2.DAL.tbl_User", b =>
                {
                    b.Navigation("ADDRESS");

                    b.Navigation("tbl_UserProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
