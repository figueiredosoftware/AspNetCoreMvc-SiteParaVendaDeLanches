using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;

namespace LanchesMac.Repositories
{
    public class MolhoRepository : IMolhoRepository
    {
        private readonly AppDbContext _context;

        public MolhoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Molho> Molhos => _context.Molhos;

        public Molho GetMolhoById(int molhoId)
        {
            return _context.Molhos.FirstOrDefault(l => l.MolhoId == molhoId);
        }
    }
}
