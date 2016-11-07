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
    public class ProdutosController : Controller
    {
        // Setando a conexão
        private ApplicationDbContext _context;

        public ProdutosController()
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
            var produtos = _context.Produtos.Include(p => p.Categoria).ToList();

            return View(produtos);
        }

        public ActionResult Detalhes(int id)
        {
            var produto = _context.Produtos
                .Include(p => p.Categoria)
                .SingleOrDefault(p => p.ProdutoId == id);

            if (produto == null)
                return HttpNotFound();

            return View(produto);
        }

        public ActionResult Adicionar()
        {
            
            var categorias = _context.Categorias.ToList();
            var viewModel = new ProdutoFormViewModel()
            {
                //objeto da view = var planos
                Categorias = categorias
            };
            return View("ProdutoForm", viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Salvar(Produto produto)
        {

            if (produto.ProdutoId == 0)
            { 

            produto.DataCadastro = DateTime.Now;
            _context.Produtos.Add(produto);

            }

            else

            {
                var atualizar = _context.Produtos.Single(c => c.ProdutoId == produto.ProdutoId);

                atualizar.Titulo = produto.Titulo;
                atualizar.DataLancamento = produto.DataLancamento;
                atualizar.QtDisponivel = produto.QtDisponivel;
                atualizar.CategoriaId = produto.CategoriaId;

            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Produtos");
        }

        public ActionResult Editar(int id)
        {
            var produto = _context.Produtos.SingleOrDefault(c => c.ProdutoId == id);

            if (produto == null)
                return HttpNotFound();

            var viewModel = new ProdutoFormViewModel
            {
                Produto = produto,
                Categorias = _context.Categorias.ToList()
            };

            return View("ProdutoForm", viewModel);

        }

    }
}