using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class Popular_Molhos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Molhos (MolhoNome, MolhoDescricao)" +
                "VALUES('Barbecue','Molho agridoce sabor churrasco')");

            migrationBuilder.Sql("INSERT INTO Molhos (MolhoNome, MolhoDescricao)" +
                "VALUES('Picante','Molho apimentado mexicano')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Molhos");
        }
    }
}
