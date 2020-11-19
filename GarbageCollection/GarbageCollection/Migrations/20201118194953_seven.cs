using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GarbageCollection.Migrations
{
    public partial class seven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ff89fa7-31a5-4579-9ca4-3e2ddcdc6e42");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5b9f77e-6f02-45e2-95de-38ff53e5a380");

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    special = table.Column<bool>(nullable: false),
                    charge = table.Column<double>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5545d5c0-53e6-4011-bd6f-acf078f6b74a", "d7a2efc1-a7b5-4316-ab8c-3e945232a2de", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39218bf8-03f5-437d-9d77-d3a61c67777a", "28feb28e-0806-423e-9dbc-dc8bb53229c8", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_IdentityUserId",
                table: "Transactions",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39218bf8-03f5-437d-9d77-d3a61c67777a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5545d5c0-53e6-4011-bd6f-acf078f6b74a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5b9f77e-6f02-45e2-95de-38ff53e5a380", "b0fe0290-f0d9-496a-85fd-302a78e04a3a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ff89fa7-31a5-4579-9ca4-3e2ddcdc6e42", "2261a248-fe55-40ca-9cee-da66b89fcc05", "Employee", "EMPLOYEE" });
        }
    }
}
