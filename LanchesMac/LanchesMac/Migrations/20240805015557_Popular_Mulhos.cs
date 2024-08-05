using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class Popular_Mulhos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Mulhos (MulhoNome, MulhoDescricao, CategoriaMulhoId)" +
    "VALUES('Alho','Molho de alho', 1 )");
            migrationBuilder.Sql("INSERT INTO Mulhos (MulhoNome, MulhoDescricao, CategoriaMulhoId)" +
"VALUES('Cebola','Molho de cebola', 1 )");
            migrationBuilder.Sql("INSERT INTO Mulhos (MulhoNome, MulhoDescricao, CategoriaMulhoId)" +
"VALUES('Manjericao','Molho de manjericão', 1 )");
            migrationBuilder.Sql("INSERT INTO Mulhos (MulhoNome, MulhoDescricao, CategoriaMulhoId)" +
"VALUES('Cuminho','Molho de Cuminho', 1 )");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Mulhos");
        }
    }
}
