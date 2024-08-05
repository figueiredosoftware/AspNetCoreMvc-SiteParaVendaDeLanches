using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;

namespace LanchesMac.Repositories
{
    public class CategoriaMolhoRepository : ICategoriaMolhoRepository
    {
        private readonly AppDbContext _context;

        public CategoriaMolhoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CategoriaMolho> CategoriaMolhos => _context.CategoriaMolhos;
    }
}
