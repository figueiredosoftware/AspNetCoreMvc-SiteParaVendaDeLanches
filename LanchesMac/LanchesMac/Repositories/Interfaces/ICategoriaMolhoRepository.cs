using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface ICategoriaMolhoRepository
    {
        //Por padrão todos acessos são públicos na interface
        public IEnumerable<CategoriaMolho> CategoriaMolhos {  get; }
    }
}
