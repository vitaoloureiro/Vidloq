using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidloq.Models;

namespace Vidloq.Controllers
{
    public class CategoriasController : Controller
    {
        // Setando a conexão
        private ApplicationDbContext _context;

        public CategoriasController()
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
            var categorias = _context.Categorias.ToList(); 
            return View(categorias);
        }

    }
}