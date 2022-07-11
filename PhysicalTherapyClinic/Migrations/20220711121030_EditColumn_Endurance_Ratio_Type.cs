using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhysicalTherapyClinic.Migrations
{
    public partial class EditColumn_Endurance_Ratio_Type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Endurance_Ratio",
                table: "ClientServices",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Endurance_Ratio",
                table: "ClientServices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
