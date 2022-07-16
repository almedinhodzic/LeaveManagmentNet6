using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "425bb299-aa59-77cd-adc9-b8847a20c541", "d91507bc-292f-43b9-9dc3-9dca8680c9ad", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "425cc299-ff79-41ad-adc9-b8847b24c541", "b1cb0ac6-0c8c-4765-9dac-debc03e32b52", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e1559bfb-4cc1-4f57-a177-fb0710c0ecec", 0, "a990b145-456a-4592-91d1-367e1725dd6f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", false, "System", "Admin", false, null, "ADMIN@ADMIN.COM", null, "AQAAAAEAACcQAAAAEIxuen+XfDyPOX/31OiOtnbi9FTHoUVlY5bJUsTJxCOl2ZM22iunWK1lsvh2tfzDRA==", null, false, "759d32c4-db46-4656-919a-da3407fd516e", null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "425cc299-ff79-41ad-adc9-b8847b24c541", "e1559bfb-4cc1-4f57-a177-fb0710c0ecec" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "425bb299-aa59-77cd-adc9-b8847a20c541");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "425cc299-ff79-41ad-adc9-b8847b24c541", "e1559bfb-4cc1-4f57-a177-fb0710c0ecec" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "425cc299-ff79-41ad-adc9-b8847b24c541");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1559bfb-4cc1-4f57-a177-fb0710c0ecec");
        }
    }
}
