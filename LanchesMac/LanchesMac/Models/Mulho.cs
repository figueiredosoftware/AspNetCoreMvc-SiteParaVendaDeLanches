using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Mulhos")]
    public class Mulho
    {
        [Key]
        public int MulhoId { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome do molho")]
        [Display(Name = "Nome do molho")]
        public string MulhoNome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máximo é de 200 caracteres")]
        [Required(ErrorMessage = "Informe a descrição do molho")]
        [Display(Name = "Descrição do molho")]
        public string MulhoDescricao { get; set; }

        //Definindo a chave estrangeira e navegação
        public int CategoriaMulhoId { get; set; }

        public virtual CategoriaMulho CategoriaMulho { get; set; }
    }
}
