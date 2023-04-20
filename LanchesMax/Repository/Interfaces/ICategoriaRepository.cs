using LanchesMax.Models;

namespace LanchesMax.Repository.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
