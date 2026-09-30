using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class Vanglavalueaddition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "Date",
                table: "VisitingHrs",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<int>(
                name: "ChamberId",
                table: "Shifts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateOnly>(
                name: "Date",
                table: "Shifts",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<int>(
                name: "ChamberId",
                table: "Prisoners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GuestId",
                table: "Prisoners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PrisonerId",
                table: "Guests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "Date",
                table: "Guards",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<int>(
                name: "BlockId",
                table: "Chambers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrisonerId",
                table: "Chambers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShiftId",
                table: "Chambers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ChamberId",
                table: "Blocks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "VisitingHrs");

            migrationBuilder.DropColumn(
                name: "ChamberId",
                table: "Shifts");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Shifts");

            migrationBuilder.DropColumn(
                name: "ChamberId",
                table: "Prisoners");

            migrationBuilder.DropColumn(
                name: "GuestId",
                table: "Prisoners");

            migrationBuilder.DropColumn(
                name: "PrisonerId",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Guards");

            migrationBuilder.DropColumn(
                name: "BlockId",
                table: "Chambers");

            migrationBuilder.DropColumn(
                name: "PrisonerId",
                table: "Chambers");

            migrationBuilder.DropColumn(
                name: "ShiftId",
                table: "Chambers");

            migrationBuilder.DropColumn(
                name: "ChamberId",
                table: "Blocks");
        }
    }
}
