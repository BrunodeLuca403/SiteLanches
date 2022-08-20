using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Informe o nome da categoria")]
        [DisplayName("Nome da Categoria")]
        [StringLength(100, ErrorMessage = "O tamanho maximo é 100 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Informe o nome da categoria ")]
        [DisplayName("Descrição da Categoria")]
        [StringLength(200, ErrorMessage = "O tamanho maximo é 200 caracteres")]
        public string Description { get; set; }
        public List<Lanche> Lanches { get; set; }

    }
}
