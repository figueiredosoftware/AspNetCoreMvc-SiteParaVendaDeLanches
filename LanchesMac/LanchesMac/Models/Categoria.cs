namespace LanchesMac.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }

        //Definindo relacionamento 1 para muitos com Lanche
        public List<Lanche> Lanches { get; set; }

    }
}
