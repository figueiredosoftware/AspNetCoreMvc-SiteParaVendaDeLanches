using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("CategoriaMulhos")]
    public class CategoriaMulho
    {
        [Key]
        public int CategoriaMulhoId { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome da categoria do molho")]
        [Display(Name = "Nome")]
        public string CategoriaMulhoNome { get; set; }
        [StringLength(200, ErrorMessage = "O tamanho máximo é de 200 caracteres")]
        [Required(ErrorMessage = "Informe a descrição da categoria do molho")]
        [Display(Name = "Descrição")]
        public string CategoriaMulhoDescricao { get; set; }

        //Definindo relacionamento 1 para muitos com Mulho
        public List<Mulho> Mulhos { get; set; }
    }
}
