using LanchesMax.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMax.ViewModels
{
    public class CarrinhoCompraViewModel 
    {
       public CarrinhoCompra CarrinhoCompra { get; set; }
        public decimal CarrinhoCompraTotal { get; set; }

    }
}
