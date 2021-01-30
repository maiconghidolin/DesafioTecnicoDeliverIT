using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ProjetoBase.Migrations
{
    public partial class ContasAPagar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contaapagar",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    valororiginal = table.Column<decimal>(type: "numeric", nullable: false),
                    valorcorrigido = table.Column<decimal>(type: "numeric", nullable: false),
                    datavencimento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    datapagamento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    diasdeatraso = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_contaapagar", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contaapagar");
        }
    }
}
