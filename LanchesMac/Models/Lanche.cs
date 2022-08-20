using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "O nome do lanche é obrigatório, por favor preencha corretamente")]
        [Display(Name = "Nome do Lanche")]
        [MinLength(2, ErrorMessage = "O nome deve ter no minimo {20} caracteres")]
        [MaxLength(100, ErrorMessage = "O nome não pode execeder {1} caracteries")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A descrição do lanche é obrigatório, por favor preencha corretamente")]
        [Display(Name = "Descrição curta")]
        [MaxLength(200, ErrorMessage = "Descrição não pode execeder {1} caracteries")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no minimo {1} caracteres")]
        public string DescriptionSmall { get; set; }

        [Required(ErrorMessage = "A descrição do lanche é obrigatório, por favor preencha corretamente")]
        [Display(Name = "Descrição Longa")]
        [MaxLength(200, ErrorMessage = "Descrição não pode execeder {1} caracteries")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no minimo {1} caracteres")]
        public string DescriptionLong { get; set; }

        [Required (ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage ="O preço deve estar entre 1 e 999.99")]
        public decimal price { get; set; }

        [Display(Name = "Imagem ")]
        [StringLength(200, ErrorMessage = "O {0} deve te no máximo {1} caracteres")]
        public string ImageBig { get; set; }

        [Display(Name = "Imagem Pequena")]
        [StringLength(200, ErrorMessage = "O {0} deve te no máximo {1} caracteres")]
        public string ImageSmall { get; set; }

        [Display(Name="Preferido ?")]
        public bool  IsFavorite { get; set; }

        [Display(Name="Estoque")]
        public bool InStrock { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
