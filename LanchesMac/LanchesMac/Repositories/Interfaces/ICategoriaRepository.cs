using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        //Por padrão todos acessos são públicos na interface
        public IEnumerable<Categoria> Categorias { get; }
    }
}
