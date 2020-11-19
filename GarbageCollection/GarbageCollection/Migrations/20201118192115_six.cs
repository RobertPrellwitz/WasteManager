using Microsoft.EntityFrameworkCore.Migrations;

namespace GarbageCollection.Migrations
{
    public partial class six : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4edd0756-7413-4438-93c7-18ef138945f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c79e18a5-3843-4c77-b1a9-e23dfbf9829c");

            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "Employees",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5b9f77e-6f02-45e2-95de-38ff53e5a380", "b0fe0290-f0d9-496a-85fd-302a78e04a3a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ff89fa7-31a5-4579-9ca4-3e2ddcdc6e42", "2261a248-fe55-40ca-9cee-da66b89fcc05", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ff89fa7-31a5-4579-9ca4-3e2ddcdc6e42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5b9f77e-6f02-45e2-95de-38ff53e5a380");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4edd0756-7413-4438-93c7-18ef138945f8", "aa32adb5-226a-450e-bea7-635bf3709d23", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c79e18a5-3843-4c77-b1a9-e23dfbf9829c", "04441cb4-41b2-4378-8b29-89e01b7875f7", "Employee", "EMPLOYEE" });
        }
    }
}
