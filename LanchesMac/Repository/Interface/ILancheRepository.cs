using LanchesMac.Models;

namespace LanchesMac.Repository.Interface
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferido { get; }
        Lanche GetLancheById (int id);    
            
    }
}
