using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Molhos")]
    public class Molho
    {
        [Key]
        public int MolhoId { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome do molho")]
        [Display(Name = "Nome do molho")]
        public string MolhoNome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máximo é de 200 caracteres")]
        [Required(ErrorMessage = "Informe a descrição do molho")]
        [Display(Name = "Descrição do molho")]
        public string MolhoDescricao { get; set; }
    }
}
