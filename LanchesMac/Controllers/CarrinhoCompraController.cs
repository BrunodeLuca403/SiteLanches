using LanchesMac.Models;
using LanchesMac.Repository.Interface;
using LanchesMac.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(ILancheRepository lancheRepository, CarrinhoCompra carrinhoCompra)
        {
            _lancheRepository = lancheRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItems = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoTotal()
            };
            return View(carrinhoCompraVM);
        }

        public RedirectToActionResult AdicionarItemNoCarrinhoCompra(int id)
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(p => p.Id == id);

            if (lancheSelecionado != null)
            {
                _carrinhoCompra.AdicionarCarrinho(lancheSelecionado);
            }

            return RedirectToAction("Index");
        }

        public IActionResult RemoverItemDoCarrinho (int id)
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(p => p.Id == id);

            if (lancheSelecionado != null)
            {
                _carrinhoCompra.RemoverCarrinho(lancheSelecionado);
            }

            return RedirectToAction("Index");
        }
    }
}
