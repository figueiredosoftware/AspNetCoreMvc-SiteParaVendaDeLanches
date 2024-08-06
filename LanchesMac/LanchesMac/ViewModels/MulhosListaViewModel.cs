using LanchesMac.Models;

namespace LanchesMac.ViewModels
{
    public class MulhosListaViewModel
    {
        public IEnumerable<Mulho> Mulhos { get; set; }
        public string CategoriaAtual {  get; set; }
    }
}
