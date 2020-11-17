using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GarbageCollection.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "156f1061-af7d-4ddc-8774-ae6588ba33e3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e795942-34b5-428a-95c4-5d42a842dd16");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93a38094-01e8-456f-8c58-ff7393b8866c");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndSuspend",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SpecialPickup",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartSuspend",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "840c8640-26dd-4a51-8ac6-2b3cc44eb2e0", "976f384a-57de-4a47-9b83-bf8de8bd1b45", "Customers", "CUSTOMERS" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5c6a5e6-c06a-433a-9ebc-eca00501ba2e", "2b6064b9-13de-4463-8ce4-656aa7c9dd65", "Employees", "EMPLOYEES" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "840c8640-26dd-4a51-8ac6-2b3cc44eb2e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5c6a5e6-c06a-433a-9ebc-eca00501ba2e");

            migrationBuilder.DropColumn(
                name: "EndSuspend",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SpecialPickup",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "StartSuspend",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e795942-34b5-428a-95c4-5d42a842dd16", "60a64933-6c9b-41d6-89eb-4f6d6fc6b8ed", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "156f1061-af7d-4ddc-8774-ae6588ba33e3", "95223e62-8edf-4789-bb2e-10c114e3243a", "Customers", "CUSTOMERS" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "93a38094-01e8-456f-8c58-ff7393b8866c", "a67042ff-5483-477c-ac66-78acfa5be0b0", "Employees", "EMPLOYEES" });
        }
    }
}
