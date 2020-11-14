using Microsoft.EntityFrameworkCore.Migrations;

namespace GarbageCollection.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24ce41fd-4b1b-4c42-91ce-60396e711468");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e89ddb55-9bee-4371-af3e-8392fb6edb57", "c6014ddc-9829-4054-a344-6fe6a0b29a0b", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e89ddb55-9bee-4371-af3e-8392fb6edb57");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24ce41fd-4b1b-4c42-91ce-60396e711468", "8441d899-0d29-41d2-9904-48a3b4ac44b3", "Admin", "ADMIN" });
        }
    }
}
