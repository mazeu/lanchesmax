using LanchesMax.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMax.Controllers
{
	public class PedidoController : Controller
	{
		private readonly IPedidoRepository _petoRepository;
		private readonly CarrinhoCompraController _carrinhoCompra;

		public PedidoController(IPedidoRepository petoRepository, CarrinhoCompraController carrinhoCompra)
		{
			_petoRepository = petoRepository;
			_carrinhoCompra = carrinhoCompra;
		}

		[HttpGet]
		public IActionResult Checkout()
		{
			return View();
		}

        [HttpPost]
        public IActionResult Checkout(PedidoController pedido)
        {
            return View();
        }
    }
}
