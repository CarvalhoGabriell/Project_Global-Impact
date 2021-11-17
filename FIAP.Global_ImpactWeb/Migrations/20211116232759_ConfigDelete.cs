using Microsoft.EntityFrameworkCore.Migrations;

namespace FIAP.Global_ImpactWeb.Migrations
{
    public partial class ConfigDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_DOACAO_T_ONG_CodigoId",
                table: "T_DOACAO");

            migrationBuilder.AddForeignKey(
                name: "FK_T_DOACAO_T_ONG_CodigoId",
                table: "T_DOACAO",
                column: "CodigoId",
                principalTable: "T_ONG",
                principalColumn: "CodigoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_DOACAO_T_ONG_CodigoId",
                table: "T_DOACAO");

            migrationBuilder.AddForeignKey(
                name: "FK_T_DOACAO_T_ONG_CodigoId",
                table: "T_DOACAO",
                column: "CodigoId",
                principalTable: "T_ONG",
                principalColumn: "CodigoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
