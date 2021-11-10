using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FIAP.Global_ImpactWeb.Migrations
{
    public partial class Doacao2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    CodigoId = table.Column<int>(type: "int", nullable: true),
                    UserONGCodigoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_DOACAO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_DOACAO_T_ONG_UserONGCodigoId",
                        column: x => x.UserONGCodigoId,
                        principalTable: "T_ONG",
                        principalColumn: "CodigoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_DOACAO_UserONGCodigoId",
                table: "T_DOACAO",
                column: "UserONGCodigoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_DOACAO");
        }
    }
}
