using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Context
{
    //aqui eu vou definir as classes do meu modelo de domínio que eu quero mapear
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
        }

        //aqui informo que minha classe parq eu seja mapeada numa tabelas quando eu criar o banco de dados e as tabelas
        public DbSet<Categoria> Categorias { get; set; } 
        public DbSet<Lanche> Lanches { get; set; } 
        public DbSet<Molho> Molhos { get; set; } 
    }
}
