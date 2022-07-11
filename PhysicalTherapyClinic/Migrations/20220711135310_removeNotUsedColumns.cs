using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhysicalTherapyClinic.Migrations
{
    public partial class removeNotUsedColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Is_Active",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Last_Modified_By",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "CompanyServices");

            migrationBuilder.DropColumn(
                name: "Is_Active",
                table: "CompanyServices");

            migrationBuilder.DropColumn(
                name: "Last_Modified_By",
                table: "CompanyServices");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Is_Active",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Last_Modified_By",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "ClientServices");

            migrationBuilder.DropColumn(
                name: "Is_Active",
                table: "ClientServices");

            migrationBuilder.DropColumn(
                name: "Last_Modified_By",
                table: "ClientServices");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Is_Active",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Last_Modified_By",
                table: "Clients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Created_By",
                table: "Services",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "Is_Active",
                table: "Services",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "Last_Modified_By",
                table: "Services",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Created_By",
                table: "CompanyServices",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "Is_Active",
                table: "CompanyServices",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "Last_Modified_By",
                table: "CompanyServices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Created_By",
                table: "Companies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "Is_Active",
                table: "Companies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "Last_Modified_By",
                table: "Companies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Created_By",
                table: "ClientServices",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "Is_Active",
                table: "ClientServices",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "Last_Modified_By",
                table: "ClientServices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Created_By",
                table: "Clients",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "Is_Active",
                table: "Clients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "Last_Modified_By",
                table: "Clients",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
