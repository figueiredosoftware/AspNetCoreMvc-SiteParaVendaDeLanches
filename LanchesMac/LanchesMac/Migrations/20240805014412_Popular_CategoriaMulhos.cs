using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class Popular_CategoriaMulhos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO CategoriaMulhos (CategoriaMulhoNome, CategoriaMulhoDescricao)" +
    "VALUES('Ervas','Molho com ervas orgânicas')");

            migrationBuilder.Sql("INSERT INTO CategoriaMulhos (CategoriaMulhoNome, CategoriaMulhoDescricao)" +
    "VALUES('Pimentas','Molho com pimentas orgânicas')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
