using LanchesMax.Models;

namespace LanchesMax.Repository.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchePreferidos { get; }
        Lanche GetLancheById(int lancheId);
    }
}
