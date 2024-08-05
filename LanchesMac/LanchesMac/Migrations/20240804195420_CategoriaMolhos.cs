using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class CategoriaMolhos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaMolhos",
                columns: table => new
                {
                    CategoriaMolhoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaMolhoNome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoriaMolhoDescricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaMolhos", x => x.CategoriaMolhoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaMolhos");
        }
    }
}
