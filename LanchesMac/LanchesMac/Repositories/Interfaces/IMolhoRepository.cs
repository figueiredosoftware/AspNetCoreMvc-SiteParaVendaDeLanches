using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface IMolhoRepository
    {
        public IEnumerable<Molho> Molhos { get; }
        public Molho GetMolhoById(int molhoId);
    }
}
