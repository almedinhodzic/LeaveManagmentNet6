using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "425bb299-aa59-77cd-adc9-b8847a20c541",
                column: "ConcurrencyStamp",
                value: "2a895fe0-e924-47a3-9df9-ae43acbbf650");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "425cc299-ff79-41ad-adc9-b8847b24c541",
                column: "ConcurrencyStamp",
                value: "ea4133f0-33ac-4276-aae0-1a413c58dd6f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1559bfb-4cc1-4f57-a177-fb0710c0ecec",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a378139f-adcb-467a-bdac-9a89da4a0273", true, "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEKAUdVb7L5fDFeBnK94kJu0ZDC01P2yeX3DHhL//V0t0byBX2BukAga9BFc6SXHO6Q==", "1d9fa046-f33f-4901-9e8e-3bf6cb376e94", "admin@admin.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "425bb299-aa59-77cd-adc9-b8847a20c541",
                column: "ConcurrencyStamp",
                value: "d91507bc-292f-43b9-9dc3-9dca8680c9ad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "425cc299-ff79-41ad-adc9-b8847b24c541",
                column: "ConcurrencyStamp",
                value: "b1cb0ac6-0c8c-4765-9dac-debc03e32b52");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1559bfb-4cc1-4f57-a177-fb0710c0ecec",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a990b145-456a-4592-91d1-367e1725dd6f", false, null, "AQAAAAEAACcQAAAAEIxuen+XfDyPOX/31OiOtnbi9FTHoUVlY5bJUsTJxCOl2ZM22iunWK1lsvh2tfzDRA==", "759d32c4-db46-4656-919a-da3407fd516e", null });
        }
    }
}
