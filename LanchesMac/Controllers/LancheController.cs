using LanchesMac.Models;
using LanchesMac.Repository.Interface;
using LanchesMac.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _LancheRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public LancheController(ILancheRepository lancheRepository, ICategoriaRepository categoriaRepository)
        {
            _LancheRepository = lancheRepository;
            _categoriaRepository = categoriaRepository; 
        }

        public IActionResult List(string categoria)
        {
            IEnumerable<Lanche> lanches;
            string CategoriaAtual = string.Empty;

            if(string.IsNullOrEmpty(categoria))
            {
                lanches = _LancheRepository.Lanches.OrderBy(l => l.Id);
                CategoriaAtual = "Todos os Lanches";
            }
            else
            {
                if (string.Equals("Normal", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _LancheRepository.Lanches.Where(c => c.Name.Equals("Normal")).OrderBy(l => l.Name);
                }
                else
                {
                    lanches = _LancheRepository.Lanches.Where(c => c.Name.Equals("Natural")).OrderBy(l => l.Name);
                }
              
            }
              var lancheListViewModel = new LancheListViewModel
                {
                    Lanches = lanches,
                    CategoriaAtual = CategoriaAtual,
                };
                
                return View(lancheListViewModel);
            
        }

    }
}
