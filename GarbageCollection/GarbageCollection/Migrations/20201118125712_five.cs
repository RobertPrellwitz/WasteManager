using Microsoft.EntityFrameworkCore.Migrations;

namespace GarbageCollection.Migrations
{
    public partial class five : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d5da7d1-6bbd-4eb8-954b-992d498ec258");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5309d031-904d-4ca0-9886-186234c8e600");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4edd0756-7413-4438-93c7-18ef138945f8", "aa32adb5-226a-450e-bea7-635bf3709d23", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c79e18a5-3843-4c77-b1a9-e23dfbf9829c", "04441cb4-41b2-4378-8b29-89e01b7875f7", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4edd0756-7413-4438-93c7-18ef138945f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c79e18a5-3843-4c77-b1a9-e23dfbf9829c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d5da7d1-6bbd-4eb8-954b-992d498ec258", "4b4ac58f-b99f-49e6-bcde-d691c528e456", "Customers", "CUSTOMERS" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5309d031-904d-4ca0-9886-186234c8e600", "d7456dbd-668d-40e9-a2b6-a673f5200a25", "Employees", "EMPLOYEES" });
        }
    }
}
