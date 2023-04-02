﻿// <auto-generated />
using System;
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
    [Migration("20230402100236_PDO_GetBrand")]
    partial class PDO_GetBrand
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_Address", b =>
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

                    b.Property<string>("ADD_MOBILE")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ADD_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("CT_ID")
                        .HasColumnType("int");

                    b.Property<int>("USR_ID")
                        .HasColumnType("int");

                    b.HasKey("ADD_ID");

                    b.HasIndex("CT_ID");

                    b.HasIndex("USR_ID");

                    b.ToTable("Tbl_Addresses");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_Brand", b =>
                {
                    b.Property<int>("BR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BR_ID"), 1L, 1);

                    b.Property<string>("BR_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("BR_ID");

                    b.ToTable("Tbl_Brands");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_Category", b =>
                {
                    b.Property<int>("CAT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CAT_ID"), 1L, 1);

                    b.Property<string>("CAT_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CAT_ID");

                    b.ToTable("Tbl_Categories");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_City", b =>
                {
                    b.Property<int>("CT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CT_ID"), 1L, 1);

                    b.Property<string>("CT_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("DT_ID")
                        .HasColumnType("int");

                    b.HasKey("CT_ID");

                    b.HasIndex("DT_ID");

                    b.ToTable("Tbl_Cities");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_District", b =>
                {
                    b.Property<int>("DT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DT_ID"), 1L, 1);

                    b.Property<string>("DT_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("DT_ID");

                    b.ToTable("Tbl_Districts");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_Product", b =>
                {
                    b.Property<int>("PR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PR_ID"), 1L, 1);

                    b.Property<int>("BR_ID")
                        .HasColumnType("int");

                    b.Property<int>("CAT_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PR_ADDED_DATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("PR_ADDED_USER")
                        .HasColumnType("int");

                    b.Property<string>("PR_COST")
                        .IsRequired()
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("PR_DESCRIPTION")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<byte[]>("PR_IMAGE")
                        .HasColumnType("varbinary(MAX)");

                    b.Property<string>("PR_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PR_PRICE")
                        .IsRequired()
                        .HasColumnType("nvarchar(7)");

                    b.Property<int>("PR_QTY")
                        .HasColumnType("int");

                    b.HasKey("PR_ID");

                    b.HasIndex("BR_ID");

                    b.HasIndex("CAT_ID");

                    b.ToTable("Tbl_Products");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_UpdateProduct", b =>
                {
                    b.Property<int>("UPDATE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UPDATE_ID"), 1L, 1);

                    b.Property<int>("PR_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UPDATE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("UPDATE_DESC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("USR_ID")
                        .HasColumnType("int");

                    b.HasKey("UPDATE_ID");

                    b.HasIndex("PR_ID");

                    b.HasIndex("USR_ID");

                    b.ToTable("Tbl_UpdateProducts");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_User", b =>
                {
                    b.Property<int>("USR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("USR_ID"), 1L, 1);

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

                    b.Property<bool>("USR_STATUS")
                        .HasColumnType("bit");

                    b.Property<string>("USR_TYPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)");

                    b.HasKey("USR_ID");

                    b.ToTable("Tbl_Users");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_Address", b =>
                {
                    b.HasOne("Bumble_bee_API_2.Database.tbl_City", "Tbl_City")
                        .WithMany("Tbl_Addresses")
                        .HasForeignKey("CT_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bumble_bee_API_2.Database.tbl_User", "Tbl_User")
                        .WithMany("ADDRESSES")
                        .HasForeignKey("USR_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tbl_City");

                    b.Navigation("Tbl_User");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_City", b =>
                {
                    b.HasOne("Bumble_bee_API_2.Database.tbl_District", "Tbl_District")
                        .WithMany("CITIES")
                        .HasForeignKey("DT_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tbl_District");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_Product", b =>
                {
                    b.HasOne("Bumble_bee_API_2.Database.tbl_Brand", "Tbl_Brand")
                        .WithMany("Tbl_Products")
                        .HasForeignKey("BR_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bumble_bee_API_2.Database.tbl_Category", "Tbl_Category")
                        .WithMany("Tbl_Products")
                        .HasForeignKey("CAT_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tbl_Brand");

                    b.Navigation("Tbl_Category");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_UpdateProduct", b =>
                {
                    b.HasOne("Bumble_bee_API_2.Database.tbl_Product", "Tbl_Product")
                        .WithMany("Tbl_UpdateProducts")
                        .HasForeignKey("PR_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bumble_bee_API_2.Database.tbl_User", "Tbl_User")
                        .WithMany("Tbl_UpdateProducts")
                        .HasForeignKey("USR_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tbl_Product");

                    b.Navigation("Tbl_User");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_Brand", b =>
                {
                    b.Navigation("Tbl_Products");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_Category", b =>
                {
                    b.Navigation("Tbl_Products");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_City", b =>
                {
                    b.Navigation("Tbl_Addresses");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_District", b =>
                {
                    b.Navigation("CITIES");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_Product", b =>
                {
                    b.Navigation("Tbl_UpdateProducts");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_User", b =>
                {
                    b.Navigation("ADDRESSES");

                    b.Navigation("Tbl_UpdateProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
