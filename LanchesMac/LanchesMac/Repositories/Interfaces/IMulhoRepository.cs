using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface IMulhoRepository
    {
        public IEnumerable<Mulho> Mulhos { get; }
        public Mulho GetMulhoById(int mulhoId);
    }
}
