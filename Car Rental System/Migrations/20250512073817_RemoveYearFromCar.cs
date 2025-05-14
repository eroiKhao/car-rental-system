﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Rental_System.Migrations
{
    /// <inheritdoc />
    public partial class RemoveYearFromCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Year",
                table: "Cars");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Cars",
                type: "int",
                nullable: true);
        }
    }
}
