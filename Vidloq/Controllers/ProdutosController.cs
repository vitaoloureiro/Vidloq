using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidloq.Models;
using Vidloq.ViewModels;

namespace Vidloq.Controllers
{
    public class ProdutosController : Controller
    {


        public ViewResult Index()
        {
            var produtos = GetProdutos();

            return View(produtos);
        }


        private IEnumerable<Produto> GetProdutos()
        {
            return new List<Produto>
            {
                new Produto { ProdutoId = 1, Titulo = "Gears of War 4" },
                new Produto { ProdutoId = 2, Titulo = "Forza Motorsports 6" },
                new Produto { ProdutoId = 3, Titulo = "Destiny" }
            };
        }

        // GET: Produtos/QualquerUm
        public ActionResult QualquerUm()
        {
            var produto = new Produto() {Titulo = "Avengers 3"};
            var clientes = new List<Cliente>
            {
                new Cliente {Nome = "Victor Augusto"},
                new Cliente {Nome = "Cauã Loureiro"},
                new Cliente {Nome = "Chico Bento"}
            };


        var viewModel = new QualquerProdutoViewModel
            {
                Produto = produto,
                Clientes = clientes
            };

            return View(viewModel);
        }




        //[Route("filmes/lancados/{ano}/{mes:regex(\\d{2}):range(1,12)}")]
        [Route("filmes/lancados/{ano}/{mes}")]
        public ActionResult PorData(int ano, int mes)
        {
            return Content(ano + "/" + mes);
        }








/*        public ActionResult Index(int? pagina, string ordem)
        {
            if (!pagina.HasValue)
                pagina = 1;
            if (String.IsNullOrWhiteSpace(ordem))
                ordem = "Titulo";
           
            return Content(String.Format("pagina={0}&ordem={1}", pagina, ordem));
            //{0} é o 1º valor da query, {1} o segundo ...
        }
*/

    }
}