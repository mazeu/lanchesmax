using LanchesMax.Context;
using LanchesMax.Models;
using LanchesMax.Repository.Interfaces;

namespace LanchesMax.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
