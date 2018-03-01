using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace jobtracker.Migrations
{
    public partial class updatedJobModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Applied",
                table: "Job",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Interviewed",
                table: "Job",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Applied",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "Interviewed",
                table: "Job");
        }
    }
}
