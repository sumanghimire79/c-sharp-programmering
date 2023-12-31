﻿// <auto-generated />
using System;
using ILS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ILS.Migrations
{
    [DbContext(typeof(ILSdb))]
    [Migration("20231113194052_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ILS.Models.ContactForm", b =>
                {
                    b.Property<int>("CFID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CFID"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CFID");

                    b.ToTable("contactForms");

                    b.HasData(
                        new
                        {
                            CFID = 1,
                            Email = "testContactEmail@seed.dk",
                            Message = "0.This is test seed message",
                            Name = "testName"
                        },
                        new
                        {
                            CFID = 2,
                            Email = "testContactEmail@seed1.dk",
                            Message = "1.This is test seed message",
                            Name = "testName2"
                        },
                        new
                        {
                            CFID = 3,
                            Email = "testContactEmail@seed2.dk",
                            Message = "2.This is test seed message",
                            Name = "testName3"
                        });
                });

            modelBuilder.Entity("ILS.Models.Item", b =>
                {
                    b.Property<int>("IID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IID"));

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("IID");

                    b.ToTable("items");

                    b.HasData(
                        new
                        {
                            IID = 1,
                            Category = 0,
                            Description = "all in one bore maskine",
                            Name = "Bose bore maskine",
                            UnitPrice = 300.0
                        },
                        new
                        {
                            IID = 2,
                            Category = 1,
                            Description = "reusable party plate",
                            Name = "plastic plate",
                            UnitPrice = 5.0
                        },
                        new
                        {
                            IID = 3,
                            Category = 2,
                            Description = "light tent for summer",
                            Name = "tent",
                            UnitPrice = 500.0
                        });
                });

            modelBuilder.Entity("ILS.Models.Lend", b =>
                {
                    b.Property<int>("LID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LID"));

                    b.Property<int>("IID")
                        .HasColumnType("int");

                    b.Property<DateTime>("LendingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LendingDays")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("LID");

                    b.HasIndex("IID");

                    b.ToTable("lends");

                    b.HasData(
                        new
                        {
                            LID = 1,
                            IID = 1,
                            LendingDate = new DateTime(2023, 11, 13, 20, 40, 51, 995, DateTimeKind.Local).AddTicks(3401),
                            LendingDays = 1,
                            Note = " thank you for the support.",
                            TotalAmount = 100.0
                        },
                        new
                        {
                            LID = 2,
                            IID = 2,
                            LendingDate = new DateTime(2023, 11, 13, 20, 40, 51, 995, DateTimeKind.Local).AddTicks(3433),
                            LendingDays = 3,
                            Note = " thank you for the Lending.",
                            TotalAmount = 200.0
                        },
                        new
                        {
                            LID = 3,
                            IID = 3,
                            LendingDate = new DateTime(2023, 11, 13, 20, 40, 51, 995, DateTimeKind.Local).AddTicks(3435),
                            LendingDays = 2,
                            Note = " thank you for the great support.",
                            TotalAmount = 300.0
                        });
                });

            modelBuilder.Entity("ILS.Models.Lend", b =>
                {
                    b.HasOne("ILS.Models.Item", "Item")
                        .WithMany("Lends")
                        .HasForeignKey("IID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("ILS.Models.Item", b =>
                {
                    b.Navigation("Lends");
                });
#pragma warning restore 612, 618
        }
    }
}
