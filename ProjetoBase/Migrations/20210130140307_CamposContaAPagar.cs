using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoBase.Migrations
{
    public partial class CamposContaAPagar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "percentualjuros",
                table: "contaapagar",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "percentualmulta",
                table: "contaapagar",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "percentualjuros",
                table: "contaapagar");

            migrationBuilder.DropColumn(
                name: "percentualmulta",
                table: "contaapagar");
        }
    }
}
