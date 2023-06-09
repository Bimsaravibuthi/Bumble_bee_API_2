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
    [Migration("20230401205225_User_and_Address")]
    partial class User_and_Address
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

                    b.Property<int>("USR_ID")
                        .HasColumnType("int");

                    b.HasKey("ADD_ID");

                    b.HasIndex("USR_ID");

                    b.ToTable("Tbl_Addresses");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

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

                    b.HasKey("ID");

                    b.ToTable("Tbl_Users");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_Address", b =>
                {
                    b.HasOne("Bumble_bee_API_2.Database.tbl_User", "Tbl_User")
                        .WithMany("ADDRESSES")
                        .HasForeignKey("USR_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tbl_User");
                });

            modelBuilder.Entity("Bumble_bee_API_2.Database.tbl_User", b =>
                {
                    b.Navigation("ADDRESSES");
                });
#pragma warning restore 612, 618
        }
    }
}
