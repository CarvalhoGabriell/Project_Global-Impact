using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FIAP.Global_ImpactWeb.Migrations
{
    public partial class AtualizandoFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_CONTA_BANCARIAS",
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
                    table.PrimaryKey("PK_T_CONTA_BANCARIAS", x => x.ContaId);
                });

            migrationBuilder.CreateTable(
                name: "T_ENDERECO",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Sigla = table.Column<int>(type: "int", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true)
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
                    ContaId = table.Column<int>(type: "int", nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ONG", x => x.CodigoId);
                    table.ForeignKey(
                        name: "FK_T_ONG_T_CONTA_BANCARIAS_ContaId",
                        column: x => x.ContaId,
                        principalTable: "T_CONTA_BANCARIAS",
                        principalColumn: "ContaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_ONG_T_ENDERECO_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "T_ENDERECO",
                        principalColumn: "EnderecoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_DOACAO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDoador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    EmailDoador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantia = table.Column<float>(type: "real", nullable: false),
                    DtDoacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodigoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_DOACAO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_DOACAO_T_ONG_CodigoId",
                        column: x => x.CodigoId,
                        principalTable: "T_ONG",
                        principalColumn: "CodigoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_DOACAO_CodigoId",
                table: "T_DOACAO",
                column: "CodigoId");

            migrationBuilder.CreateIndex(
                name: "IX_T_ONG_ContaId",
                table: "T_ONG",
                column: "ContaId");

            migrationBuilder.CreateIndex(
                name: "IX_T_ONG_EnderecoId",
                table: "T_ONG",
                column: "EnderecoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_DOACAO");

            migrationBuilder.DropTable(
                name: "T_ONG");

            migrationBuilder.DropTable(
                name: "T_CONTA_BANCARIAS");

            migrationBuilder.DropTable(
                name: "T_ENDERECO");
        }
    }
}
