using Microsoft.EntityFrameworkCore.Migrations;

namespace FIAP.Global_ImpactWeb.Migrations
{
    public partial class NomePK_Doacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "T_DOACAO",
                newName: "DoacaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DoacaoId",
                table: "T_DOACAO",
                newName: "Id");
        }
    }
}
