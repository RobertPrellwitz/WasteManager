using Microsoft.EntityFrameworkCore.Migrations;

namespace GarbageCollection.Migrations
{
    public partial class Four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78639cf0-27f7-4fe0-8f10-20a03222de8b");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "78639cf0-27f7-4fe0-8f10-20a03222de8b", "a554277a-8eb2-4496-a73d-8ae4806cf553", "Admin", "ADMIN" });
        }
    }
}
