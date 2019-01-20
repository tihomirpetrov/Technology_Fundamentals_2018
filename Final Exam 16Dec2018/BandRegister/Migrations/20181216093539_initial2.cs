using Microsoft.EntityFrameworkCore.Migrations;

namespace BandRegister.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Honorarium",
                table: "Bands",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Honorarium",
                table: "Bands",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
