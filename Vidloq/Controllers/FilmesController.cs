using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidloq.Models;
using Vidloq.ViewModels;

namespace Vidloq.Controllers
{
    public class FilmesController : Controller
    {


        public ViewResult Index()
        {
            var filmes = GetFilmes();

            return View(filmes);
        }


        private IEnumerable<Filme> GetFilmes()
        {
            return new List<Filme>
            {
                new Filme { Filme_Id = 1, Titulo = "Shrek" },
                new Filme { Filme_Id = 2, Titulo = "Wall-e" }
            };
        }

        // GET: Filmes/QualquerUm
        public ActionResult QualquerUm()
        {
            var filme = new Filme() {Titulo = "Avengers 3"};
            var clientes = new List<Cliente>
            {
                new Cliente {Nome = "Victor Augusto"},
                new Cliente {Nome = "Cauã Loureiro"},
                new Cliente {Nome = "Chico Bento"}
            };


        var viewModel = new QualquerFilmeViewModel
            {
                Filme = filme,
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