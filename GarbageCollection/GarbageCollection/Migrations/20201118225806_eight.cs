using Microsoft.EntityFrameworkCore.Migrations;

namespace GarbageCollection.Migrations
{
    public partial class eight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39218bf8-03f5-437d-9d77-d3a61c67777a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5545d5c0-53e6-4011-bd6f-acf078f6b74a");

            migrationBuilder.AddColumn<bool>(
                name: "Paid",
                table: "Transactions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d9fdfaf-8a06-4cbe-a9a3-37fb1fdeab95", "8ca03c27-b9da-45b0-9f4e-93c86c0b7109", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dcd8f414-0ac6-45c6-a78c-b59defc09821", "0bbfef32-e8da-4707-a4e8-61405d3df952", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d9fdfaf-8a06-4cbe-a9a3-37fb1fdeab95");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dcd8f414-0ac6-45c6-a78c-b59defc09821");

            migrationBuilder.DropColumn(
                name: "Paid",
                table: "Transactions");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5545d5c0-53e6-4011-bd6f-acf078f6b74a", "d7a2efc1-a7b5-4316-ab8c-3e945232a2de", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39218bf8-03f5-437d-9d77-d3a61c67777a", "28feb28e-0806-423e-9dbc-dc8bb53229c8", "Employee", "EMPLOYEE" });
        }
    }
}
