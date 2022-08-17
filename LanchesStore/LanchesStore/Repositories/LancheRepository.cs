using LanchesStore.Context;
using LanchesStore.Models;
using LanchesStore.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesStore.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p => p.IsLanchePreferio).Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheld) => _context.Lanches.FirstOrDefault(l => l.LancheId == lancheld);
    }
}
