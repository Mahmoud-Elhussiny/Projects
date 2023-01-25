using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.Migrations
{
    public partial class initialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<decimal>(type: "TEXT", nullable: false),
                    AccountName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Catigories",
                columns: table => new
                {
                    CatigoryId = table.Column<decimal>(type: "TEXT", nullable: false),
                    CatigoryName = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catigories", x => x.CatigoryId);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    ManufacturerId = table.Column<decimal>(type: "TEXT", nullable: false),
                    ManufacturerName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNum1 = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNum2 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.ManufacturerId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<decimal>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNum1 = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNum2 = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Drugs",
                columns: table => new
                {
                    DrugId = table.Column<decimal>(type: "TEXT", nullable: false),
                    DrugName = table.Column<string>(type: "TEXT", nullable: false),
                    DrugCode = table.Column<string>(type: "TEXT", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(6, 2)", nullable: false),
                    numofpices = table.Column<int>(type: "INTEGER", nullable: true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    ManufacturerId = table.Column<decimal>(type: "TEXT", nullable: true),
                    CatigoryId = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.DrugId);
                    table.ForeignKey(
                        name: "FK_Drugs_Catigories_CatigoryId",
                        column: x => x.CatigoryId,
                        principalTable: "Catigories",
                        principalColumn: "CatigoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Drugs_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerId");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<decimal>(type: "TEXT", nullable: false),
                    OrdereDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(7, 2)", nullable: false),
                    UserId = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Accounts",
                columns: table => new
                {
                    UserId = table.Column<decimal>(type: "TEXT", nullable: false),
                    AccountId = table.Column<decimal>(type: "TEXT", nullable: false),
                    Id = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Accounts", x => new { x.UserId, x.AccountId });
                    table.ForeignKey(
                        name: "FK_User_Accounts_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Accounts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order_Items",
                columns: table => new
                {
                    OrderItemId = table.Column<decimal>(type: "TEXT", nullable: false),
                    OrderId = table.Column<decimal>(type: "TEXT", nullable: false),
                    DrugId = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Items", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_Order_Items_Drugs_DrugId",
                        column: x => x.DrugId,
                        principalTable: "Drugs",
                        principalColumn: "DrugId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Items_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountId", "AccountName" },
                values: new object[] { 1m, "مشرف النظام" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountId", "AccountName" },
                values: new object[] { 2m, "مستخدم" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "FirstName", "LastName", "Password", "PhoneNum1", "PhoneNum2", "UserName" },
                values: new object[] { 1m, null, "Mahmoud", "Hussein", "12345", null, null, "asd123" });

            migrationBuilder.InsertData(
                table: "User_Accounts",
                columns: new[] { "AccountId", "UserId", "Id" },
                values: new object[] { 1m, 1m, 1m });

            migrationBuilder.InsertData(
                table: "User_Accounts",
                columns: new[] { "AccountId", "UserId", "Id" },
                values: new object[] { 2m, 1m, 2m });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AccountName",
                table: "Accounts",
                column: "AccountName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_CatigoryId",
                table: "Drugs",
                column: "CatigoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_DrugName_ExpireDate",
                table: "Drugs",
                columns: new[] { "DrugName", "ExpireDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_ManufacturerId",
                table: "Drugs",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturers_ManufacturerName",
                table: "Manufacturers",
                column: "ManufacturerName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_Items_DrugId",
                table: "Order_Items",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Items_OrderId",
                table: "Order_Items",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Accounts_AccountId",
                table: "User_Accounts",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order_Items");

            migrationBuilder.DropTable(
                name: "User_Accounts");

            migrationBuilder.DropTable(
                name: "Drugs");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Catigories");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
