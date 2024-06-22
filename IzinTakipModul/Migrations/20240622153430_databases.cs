using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IzinTakipModul.Migrations
{
    /// <inheritdoc />
    public partial class databases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeLeaveReques_AspNetUsers_RequestingEmployeeId",
                table: "EmployeeLeaveReques");

            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmployeeId",
                table: "EmployeeLeaveReques",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedEmlooyeId",
                table: "EmployeeLeaveReques",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeLeaveReques_AspNetUsers_RequestingEmployeeId",
                table: "EmployeeLeaveReques",
                column: "RequestingEmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeLeaveReques_AspNetUsers_RequestingEmployeeId",
                table: "EmployeeLeaveReques");

            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmployeeId",
                table: "EmployeeLeaveReques",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedEmlooyeId",
                table: "EmployeeLeaveReques",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeLeaveReques_AspNetUsers_RequestingEmployeeId",
                table: "EmployeeLeaveReques",
                column: "RequestingEmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
