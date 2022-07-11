using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhysicalTherapyClinic.Migrations
{
    public partial class EditColumnsName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServicePrice",
                table: "ClientServices",
                newName: "Service_Price");

            migrationBuilder.RenameColumn(
                name: "ClientName",
                table: "Clients",
                newName: "Client_Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Service_Price",
                table: "ClientServices",
                newName: "ServicePrice");

            migrationBuilder.RenameColumn(
                name: "Client_Name",
                table: "Clients",
                newName: "ClientName");
        }
    }
}
