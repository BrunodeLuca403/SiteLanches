using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Repository
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferido => _context.Lanches.Where(i => i.IsFavorite).Include(c => c.Categoria);

        public Lanche GetLancheById(int id)
        {
           return _context.Lanches.FirstOrDefault(c => c.Id == id);
        }
    }
}
