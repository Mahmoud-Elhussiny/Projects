﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pharmacy.Model;

#nullable disable

namespace Pharmacy.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("Pharmacy.Model.Entities.Account", b =>
                {
                    b.Property<decimal>("AccountId")
                        .HasColumnType("decimal(7,0)");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AccountId");

                    b.HasIndex("AccountName")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Pharmacy.Model.Entities.Drug", b =>
                {
                    b.Property<string>("DrugName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DrugCode")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("DrugId")
                        .HasColumnType("decimal(7,0)");

                    b.Property<decimal?>("ManufacturerId")
                        .HasColumnType("decimal(7,0)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("DrugName", "ExpireDate");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Drugs");
                });

            modelBuilder.Entity("Pharmacy.Model.Entities.Manufacturer", b =>
                {
                    b.Property<decimal>("ManufacturerId")
                        .HasColumnType("decimal(7,0)");

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
                        .HasColumnType("decimal(7,0)");

                    b.Property<DateTime>("OrdereDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(7, 2)");

                    b.Property<decimal>("UserId")
                        .HasColumnType("decimal(7,0)");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Pharmacy.Model.Entities.Order_Item", b =>
                {
                    b.Property<decimal>("OrderItemId")
                        .HasColumnType("decimal(7,0)");

                    b.Property<DateTime>("DrugExpireDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("DrugId")
                        .HasColumnType("decimal(7,0)");

                    b.Property<string>("DrugName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("OrderId")
                        .HasColumnType("decimal(7,0)");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("DrugName", "DrugExpireDate");

                    b.ToTable("Order_Items");
                });

            modelBuilder.Entity("Pharmacy.Model.Entities.User", b =>
                {
                    b.Property<decimal>("UserId")
                        .HasColumnType("decimal(7,0)");

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
                        .HasColumnType("decimal(7,0)");

                    b.Property<decimal>("AccountId")
                        .HasColumnType("decimal(7,0)");

                    b.Property<decimal>("Id")
                        .HasColumnType("decimal(7,0)");

                    b.HasKey("UserId", "AccountId");

                    b.HasIndex("AccountId");

                    b.ToTable("User_Accounts");
                });

            modelBuilder.Entity("Pharmacy.Model.Entities.Drug", b =>
                {
                    b.HasOne("Pharmacy.Model.Entities.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId");

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
                    b.HasOne("Pharmacy.Model.Entities.Order", "Order")
                        .WithMany("items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pharmacy.Model.Entities.Drug", "Drug")
                        .WithMany()
                        .HasForeignKey("DrugName", "DrugExpireDate")
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

            modelBuilder.Entity("Pharmacy.Model.Entities.Order", b =>
                {
                    b.Navigation("items");
                });
#pragma warning restore 612, 618
        }
    }
}
