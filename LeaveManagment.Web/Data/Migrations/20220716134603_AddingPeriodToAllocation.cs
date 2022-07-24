using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "leaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "425bb299-aa59-77cd-adc9-b8847a20c541",
                column: "ConcurrencyStamp",
                value: "3dc76db1-6a7c-4bc3-9411-3e965f7098c1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "425cc299-ff79-41ad-adc9-b8847b24c541",
                column: "ConcurrencyStamp",
                value: "323f4ce7-ae3d-4402-a283-f913f38e9777");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1559bfb-4cc1-4f57-a177-fb0710c0ecec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe89c325-98fe-4d52-af15-ef8d188853f0", "AQAAAAEAACcQAAAAEO0Wu+09gmIE0aO7CJUZuiXsp85k4T7bLfnsIQVm9WNZJcM61sw5TFn3ja8ROjYZ2A==", "8b004615-a5ed-4902-9e45-c288d50a65b9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "leaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a378139f-adcb-467a-bdac-9a89da4a0273", "AQAAAAEAACcQAAAAEKAUdVb7L5fDFeBnK94kJu0ZDC01P2yeX3DHhL//V0t0byBX2BukAga9BFc6SXHO6Q==", "1d9fa046-f33f-4901-9e8e-3bf6cb376e94" });
        }
    }
}
