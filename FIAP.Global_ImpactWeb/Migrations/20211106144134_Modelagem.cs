using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FIAP.Global_ImpactWeb.Migrations
{
    public partial class Modelagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_CONTA_BANCARIA",
                columns: table => new
                {
                    ContaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroConta = table.Column<int>(type: "int", nullable: false),
                    Agencia = table.Column<int>(type: "int", nullable: false),
                    NomeBanco = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CONTA_BANCARIA", x => x.ContaId);
                });

            migrationBuilder.CreateTable(
                name: "T_ENDERECO",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sigla = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ENDERECO", x => x.EnderecoId);
                });

            migrationBuilder.CreateTable(
                name: "T_ONG",
                columns: table => new
                {
                    CodigoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DtCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ONG", x => x.CodigoId);
                    table.ForeignKey(
                        name: "FK_T_ONG_T_CONTA_BANCARIA_ContaId",
                        column: x => x.ContaId,
                        principalTable: "T_CONTA_BANCARIA",
                        principalColumn: "ContaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_ONG_ContaId",
                table: "T_ONG",
                column: "ContaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_ENDERECO");

            migrationBuilder.DropTable(
                name: "T_ONG");

            migrationBuilder.DropTable(
                name: "T_CONTA_BANCARIA");
        }
    }
}
