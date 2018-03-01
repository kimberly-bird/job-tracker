using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace jobtracker.Migrations
{
    public partial class AddedForeignKeysToModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Company_CompanyId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Job_Company_CompanyId",
                table: "Job");

            migrationBuilder.DropForeignKey(
                name: "FK_Job_Contact_ContactId",
                table: "Job");

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "Job",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Job",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Contact",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Company_CompanyId",
                table: "Contact",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Company_CompanyId",
                table: "Job",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Contact_ContactId",
                table: "Job",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Company_CompanyId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Job_Company_CompanyId",
                table: "Job");

            migrationBuilder.DropForeignKey(
                name: "FK_Job_Contact_ContactId",
                table: "Job");

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "Job",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Job",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Contact",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Company_CompanyId",
                table: "Contact",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Company_CompanyId",
                table: "Job",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Contact_ContactId",
                table: "Job",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
