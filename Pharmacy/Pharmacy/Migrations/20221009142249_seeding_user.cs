using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.Migrations
{
    public partial class seeding_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "FirstName", "LastName", "Password", "PhoneNum1", "PhoneNum2", "UserName" },
                values: new object[] { 1m, null, "Mahmoud", "Hussein", "12345", null, null, "asd123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1m);
        }
    }
}
