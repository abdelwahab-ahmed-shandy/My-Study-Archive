﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P02_SalesDataBase_UsingFluent_API.Migrations
{
    /// <inheritdoc />
    public partial class SalaseAddDateDefult : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Sale",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Sale");
        }
    }
}
