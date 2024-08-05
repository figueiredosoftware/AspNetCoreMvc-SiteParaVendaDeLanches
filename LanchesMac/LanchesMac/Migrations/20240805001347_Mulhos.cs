using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class Mulhos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaMulhos",
                columns: table => new
                {
                    CategoriaMulhoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaMulhoNome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoriaMulhoDescricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaMulhos", x => x.CategoriaMulhoId);
                });

            migrationBuilder.CreateTable(
                name: "Mulhos",
                columns: table => new
                {
                    MulhoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MulhoNome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MulhoDescricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CategoriaMulhoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mulhos", x => x.MulhoId);
                    table.ForeignKey(
                        name: "FK_Mulhos_CategoriaMulhos_CategoriaMulhoId",
                        column: x => x.CategoriaMulhoId,
                        principalTable: "CategoriaMulhos",
                        principalColumn: "CategoriaMulhoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mulhos_CategoriaMulhoId",
                table: "Mulhos",
                column: "CategoriaMulhoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mulhos");

            migrationBuilder.DropTable(
                name: "CategoriaMulhos");
        }
    }
}
