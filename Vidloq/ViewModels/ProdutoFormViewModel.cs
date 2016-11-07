using System.Collections.Generic;
using Vidloq.Models;

namespace Vidloq.ViewModels
{
    public class ProdutoFormViewModel
    {
        public IEnumerable<Categoria> Categorias { get; set; }
        public Produto Produto { get; set; }

        public string Acao

        {
            get
            {
                return Produto != null ? "Editar" : "Adicionar";
            }

        }

    }
 
}
