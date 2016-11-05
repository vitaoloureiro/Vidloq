using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidloq.Models;

namespace Vidloq.ViewModels
{
    public class QualquerFilmeViewModel
    {
        public Filme Filme { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}