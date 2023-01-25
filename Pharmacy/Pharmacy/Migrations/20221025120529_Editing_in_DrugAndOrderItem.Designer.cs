﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pharmacy.Model;

#nullable disable

namespace Pharmacy.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221025120529_Editing_in_DrugAndOrderItem")]
    partial class Editing_in_DrugAndOrderItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("Pharmacy.Model.Entities.Account", b =>
                {
                    b.Property<decimal>("AccountId")
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AccountId");

                    b.HasIndex("AccountName")
                        .IsUnique();

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AccountId = 1m,
                            AccountName = "مشرف النظام"
                        },
                        new
                        {
                            AccountId = 2m,
                            AccountName = "مستخدم"
                        });
                });

            modelBuilder.Entity("Pharmacy.Model.Entities.Catigory", b =>
                {
                    b.Property<decimal>("CatigoryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CatigoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("CatigoryId");

                    b.ToTable("Catigories");
                });

            modelBuilder.Entity("Pharmacy.Model.Entities.Drug", b =>
                {
                    b.Property<decimal>("DrugId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CatigoryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("DrugCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("DrugName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("ManufacturerId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("numofpices")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("totalNumofPices")
                        .HasColumnType("INTEGER");

                    b.HasKey("DrugId");

                    b.HasIndex("CatigoryId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("DrugName", "ExpireDate")
                        .IsUnique();

                    b.ToTable("Drugs");
                });

            modelBuilder.Entity("Pharmacy.Model.Entities.Manufacturer", b =>
                {
                    b.Property<decimal>("ManufacturerId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("ManufacturerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNum1")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNum2")
                        .HasColumnType("TEXT");

                    b.HasKey("ManufacturerId");

                    b.HasIndex("ManufacturerName")
                        .IsUnique();

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("Pharmacy.Model.Entities.Order", b =>
                {
                    b.Property<decimal>("OrderId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("OrdereDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(7, 2)");

                    b.Property<decimal>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Pharmacy.Model.Entities.Order_Item", b =>
                {
                    b.Property<decimal>("OrderItemId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("DrugId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("OrderId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderItemId");

                    b.HasIndex("DrugId");

                    b.HasIndex("OrderId");

                    b.ToTable("Order_Items");
                });

            modelBuilder.Entity("Pharmacy.Model.Entities.User", b =>
                {
                    b.Property<decimal>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNum1")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNum2")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1m,
                            FirstName = "Mahmoud",
                            LastName = "Hussein",
                            Password = "12345",
                            UserName = "asd123"
                        });
                });

            modelBuilder.Entity("Pharmacy.Model.Entities.User_Account", b =>
                {
                    b.Property<decimal>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("AccountId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Id")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "AccountId");

                    b.HasIndex("AccountId");

                    b.ToTable("User_Accounts");

                    b.HasData(
                        new
                        {
                            UserId = 1m,
                            AccountId = 1m,
                            Id = 1m
                        },
                        new
                        {
                            UserId = 1m,
                            AccountId = 2m,
                            Id = 2m
                        });
                });

            modelBuilder.Entity("Pharmacy.Model.Entities.Drug", b =>
                {
                    b.HasOne("Pharmacy.Model.Entities.Catigory", "Catigory")
                        .WithMany("Drugs")
                        .HasForeignKey("CatigoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pharmacy.Model.Entities.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId");

                    b.Navigation("Catigory");

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Pharmacy.Model.Entities.Order", b =>
                {
                    b.HasOne("Pharmacy.Model.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Pharmacy.Model.Entities.Order_Item", b =>
                {
                    b.HasOne("Pharmacy.Model.Entities.Drug", "Drug")
                        .WithMany()
                        .HasForeignKey("DrugId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pharmacy.Model.Entities.Order", "Order")
                        .WithMany("items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drug");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Pharmacy.Model.Entities.User_Account", b =>
                {
                    b.HasOne("Pharmacy.Model.Entities.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pharmacy.Model.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Pharmacy.Model.Entities.Catigory", b =>
                {
                    b.Navigation("Drugs");
                });

            modelBuilder.Entity("Pharmacy.Model.Entities.Order", b =>
                {
                    b.Navigation("items");
                });
#pragma warning restore 612, 618
        }
    }
}