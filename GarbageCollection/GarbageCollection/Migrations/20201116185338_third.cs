using Microsoft.EntityFrameworkCore.Migrations;

namespace GarbageCollection.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afddf17e-0811-4414-8c38-e649205266be");

            migrationBuilder.AddColumn<string>(
                name: "PickupDay",
                table: "customer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "78639cf0-27f7-4fe0-8f10-20a03222de8b", "a554277a-8eb2-4496-a73d-8ae4806cf553", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78639cf0-27f7-4fe0-8f10-20a03222de8b");

            migrationBuilder.DropColumn(
                name: "PickupDay",
                table: "customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "afddf17e-0811-4414-8c38-e649205266be", "cac15f6c-2df3-4362-8db3-de3152bd1eef", "Admin", "ADMIN" });
        }
    }
}
