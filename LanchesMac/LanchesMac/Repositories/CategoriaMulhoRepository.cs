using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;

namespace LanchesMac.Repositories
{
    public class CategoriaMulhoRepository : ICategoriaMulhoRepository
    {
        private readonly AppDbContext _context;

        public CategoriaMulhoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CategoriaMulho> CategoriaMulhos => _context.CategoriaMulhos;
    }
}
