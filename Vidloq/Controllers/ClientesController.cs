using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidloq.Models;

namespace Vidloq.Controllers
{
    public class ClientesController : Controller
    {
        public ViewResult Index()

        {
            var clientes = GetClientes();
            return View(clientes);
        }

        public ActionResult Detalhes(int id)
        {
            var cliente = GetClientes().SingleOrDefault(c => c.Cliente_Id == id);

            if (cliente == null)
                return HttpNotFound();

            return View(cliente);
        }

        private IEnumerable<Cliente> GetClientes()
        {
            return new List<Cliente>
            {
                new Cliente { Cliente_Id = 1, Nome = "Victor Augusto" },
                new Cliente { Cliente_Id = 2, Nome = "Cauã Victor" }
            };
        }
    }
}