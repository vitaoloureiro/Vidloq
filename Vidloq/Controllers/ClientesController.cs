using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidloq.Models;
using Vidloq.ViewModels;

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

        public ActionResult Adicionar()
        {
            //Fazendo uma consulta para pegar a lista de planos
            var planos = _context.Planos.ToList();
            //Como vão ser necessários vários dados do plano é melhor fazer uma ViewModel
            //Lembrar de alterar o @model da View @model Vidloq.ViewModels.AdicionarClienteViewModel
            var viewModel = new ClienteFormViewModel
            {

                //objeto da model = var planos
                Planos = planos
            };
            return View("ClienteForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //Model Binding
        public ActionResult Salvar(Cliente cliente)
        {
            
            // Validação, se o objeto não estiver consistente retornar para a view do Form
            if (!ModelState.IsValid)
            {
                var viewModel = new ClienteFormViewModel
                {
                    Cliente = cliente,
                    Planos = _context.Planos.ToList()
                };

                return View("ClienteForm", viewModel);
            }




            // Se Cliente for vazio cadastrar, senão atualizar
            if (cliente.ClienteId == 0)
                _context.Clientes.Add(cliente);
            else
            {
                var atualizar = _context.Clientes.Single(c => c.ClienteId == cliente.ClienteId);

                // Aqui poderia ser instalar o automapper, para não precisar especificar cada campo
                // Mapper.Map(cliente, atualizar)
                atualizar.Nome = cliente.Nome;
                atualizar.DataNascimento = cliente.DataNascimento;
                atualizar.PlanoId = cliente.PlanoId;
                atualizar.Newsletter = cliente.Newsletter;

            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Clientes");
        }

        public ActionResult Editar(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(c => c.ClienteId == id);

            if (cliente == null)
                return HttpNotFound();

            var viewModel = new ClienteFormViewModel
            {
                Cliente = cliente,
                Planos = _context.Planos.ToList()
            };

            return View("ClienteForm", viewModel);

        }
    }
    }