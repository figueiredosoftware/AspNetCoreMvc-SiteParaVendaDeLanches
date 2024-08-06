using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface ICategoriaMulhoRepository
    {
        //Por padrão todos acessos são públicos na interface
        public IEnumerable<CategoriaMulho> CategoriaMulhos {  get; }
    }
}
