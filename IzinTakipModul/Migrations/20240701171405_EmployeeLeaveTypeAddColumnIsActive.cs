﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IzinTakipModul.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeLeaveTypeAddColumnIsActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "EmployeeLeaveTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "EmployeeLeaveTypes");
        }
    }
}
