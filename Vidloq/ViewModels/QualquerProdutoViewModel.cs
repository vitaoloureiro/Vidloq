using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidloq.Models;

namespace Vidloq.ViewModels
{
    public class QualquerProdutoViewModel
    {
        public Produto Produto { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}