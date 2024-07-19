using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            //teste
            int a = 0;
        }
    }
}
