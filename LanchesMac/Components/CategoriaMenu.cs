using LanchesMac.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaRrepository;

        public CategoriaMenu(ICategoriaRepository categoriaRrepository)
        {
            _categoriaRrepository = categoriaRrepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRrepository.Categorias.OrderBy(c => c.Name);
            return View(categorias); 
        }
    }
}
