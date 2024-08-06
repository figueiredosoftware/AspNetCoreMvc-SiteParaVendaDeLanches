using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;

namespace LanchesMac.Repositories
{
    public class MulhoRepository : IMulhoRepository
    {
        private readonly AppDbContext _context;

        public MulhoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Mulho> Mulhos => _context.Mulhos;

        public Mulho GetMulhoById(int mulhoId)
        {
            return _context.Mulhos.FirstOrDefault(l => l.MulhoId == mulhoId);
        }
    }
}
