using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMax.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho maximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome da categoria.")]
        [Display(Name = "Nome")]
        public string CategoriaNome { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho maximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome da categoria.")]
        [Display(Name = "Descrição")]
        public string CategoriaDescricao { get; set; }

        public List <Lanche> Lanches { get; set; }

    }
}
