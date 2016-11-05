using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidloq.Models;

namespace Vidloq.Controllers
{
    public class ClientesController : Controller
    {

        // Setando a conexão
        private ApplicationDbContext _context;

        public ClientesController()
        {
            _context = new ApplicationDbContext();
        }

        // Fechando a conexão
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()

        {
            //var clientes = GetClientes();
            //Iniciando a consulta aos Clientes
            // _context.Clientes, .Clientes é um DbSet que configuramos no contexto, no caso IdentityModels.cs
            var clientes = _context.Clientes.Include(c => c.Plano).ToList(); // Include faz parte do Data.Entity, fazer referência no topo
            return View(clientes);
        }

        public ActionResult Detalhes(int id)
        {
            
            // Como eu fiz, embora no return View() só tenha passado cliente, a View exibiu os dados corretamente
            //var cliente = _context.Clientes.SingleOrDefault(c => c.ClienteId == id);
            //var plano = _context.Planos.SingleOrDefault(p => p.PlanoId == cliente.PlanoId);
            var cliente = _context.Clientes
                .Include(c => c.Plano)
                .SingleOrDefault(c => c.ClienteId == id);

              if (cliente == null)
                return HttpNotFound();

            return View(cliente);
        }


/*
        private IEnumerable<Cliente> GetClientes()
        {
            return new List<Cliente>
            {
                new Cliente { ClienteId = 1, Nome = "Victor Augusto" },
                new Cliente { ClienteId = 2, Nome = "Cauã Victor" }
            };
*/
       
        }
    }