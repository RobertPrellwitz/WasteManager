using Microsoft.EntityFrameworkCore.Migrations;

namespace GarbageCollection.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "505a1943-c083-4dca-a23b-7a45281030f8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24ce41fd-4b1b-4c42-91ce-60396e711468", "8441d899-0d29-41d2-9904-48a3b4ac44b3", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24ce41fd-4b1b-4c42-91ce-60396e711468");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "505a1943-c083-4dca-a23b-7a45281030f8", "2f40d65b-c27a-46a7-8f49-e0c273b2f31b", "Admin", "ADMIN" });
        }
    }
}
