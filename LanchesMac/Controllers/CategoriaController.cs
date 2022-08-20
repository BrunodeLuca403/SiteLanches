using LanchesMac.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult List()
        {
            var categoria = _categoriaRepository.Categorias;
            return View(categoria);
        }
    }
}