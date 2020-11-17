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
                keyValue: "114b878c-599a-4698-b82e-08134331b7c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dddb311-debd-4294-9f2f-d2026e2ee996");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43e46832-21c2-4a30-9d71-3fa2343cbe2e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6878d0ce-ac0b-4003-8e60-bf4673cfe069", "a8d9cd83-f386-4171-b9f1-9f309d7bff77", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0afa1a7-9607-46e4-a291-6c286059dc7d", "fefd9cad-7d69-46a3-bcb5-933a726eb4c5", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0cd2197a-cae4-46b3-8b99-453972b1427b", "b503149f-df42-4b35-809e-fe1b5529201f", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cd2197a-cae4-46b3-8b99-453972b1427b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6878d0ce-ac0b-4003-8e60-bf4673cfe069");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0afa1a7-9607-46e4-a291-6c286059dc7d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "114b878c-599a-4698-b82e-08134331b7c3", "6f3a8e6d-1e40-47f2-bb51-c5b37f32fcdf", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2dddb311-debd-4294-9f2f-d2026e2ee996", "ac63b183-86c5-4ad3-9166-0c9b0fad4114", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43e46832-21c2-4a30-9d71-3fa2343cbe2e", "5b541ec0-4fc2-445c-9aff-6850118393fc", "Employee", "Employee" });
        }
    }
}
