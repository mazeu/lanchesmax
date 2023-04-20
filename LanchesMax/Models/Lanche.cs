using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMax.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }
        [Required]
        [Display(Name="Nome do Lanche")]
        [StringLength(80, MinimumLength =10, ErrorMessage ="")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O descrição do lanche deve ser informada.")]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(20, ErrorMessage="Descrição deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no maximo {1} caracteres")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "O descrição detalhada deve conter deve conter operações")]
        [Display(Name ="Descrição detalhada do lanche")]
        [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição detalhada deve ter no maximo {1} caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name ="Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage ="o preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [Display(Name ="Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} caracteres")]
        public string ImageUrl { get; set; }

        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} caracteres")]
        public string ImageThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name ="Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
