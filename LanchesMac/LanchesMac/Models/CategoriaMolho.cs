using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("CategoriaMolhos")]
    public class CategoriaMolho
    {
        [Key]
        public int CategoriaMolhoId {  get; set; }
        [StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome da categoria do molho")]
        [Display(Name = "Nome")]
        public string CategoriaMolhoNome { get; set; }
        [StringLength(200, ErrorMessage = "O tamanho máximo é de 200 caracteres")]
        [Required(ErrorMessage = "Informe a descrição da categoria do molho")]
        [Display(Name = "Descrição")]
        public string CategoriaMolhoDescricao { get; set; }

    }
}
