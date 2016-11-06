﻿using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidloq.Models;

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




    }
}