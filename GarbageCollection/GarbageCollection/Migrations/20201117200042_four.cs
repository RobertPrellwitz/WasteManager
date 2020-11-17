using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GarbageCollection.Migrations
{
    public partial class four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "840c8640-26dd-4a51-8ac6-2b3cc44eb2e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5c6a5e6-c06a-433a-9ebc-eca00501ba2e");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartSuspend",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SpecialPickup",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndSuspend",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d5da7d1-6bbd-4eb8-954b-992d498ec258", "4b4ac58f-b99f-49e6-bcde-d691c528e456", "Customers", "CUSTOMERS" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5309d031-904d-4ca0-9886-186234c8e600", "d7456dbd-668d-40e9-a2b6-a673f5200a25", "Employees", "EMPLOYEES" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d5da7d1-6bbd-4eb8-954b-992d498ec258");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5309d031-904d-4ca0-9886-186234c8e600");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartSuspend",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SpecialPickup",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndSuspend",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "840c8640-26dd-4a51-8ac6-2b3cc44eb2e0", "976f384a-57de-4a47-9b83-bf8de8bd1b45", "Customers", "CUSTOMERS" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5c6a5e6-c06a-433a-9ebc-eca00501ba2e", "2b6064b9-13de-4463-8ce4-656aa7c9dd65", "Employees", "EMPLOYEES" });
        }
    }
}
