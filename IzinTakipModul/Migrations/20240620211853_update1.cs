using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IzinTakipModul.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DefultDays",
                table: "EmployeeLeaveTypes",
                newName: "DefaultDays");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "EmployeeLeaveTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DefaultDays",
                table: "EmployeeLeaveTypes",
                newName: "DefultDays");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "EmployeeLeaveTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
