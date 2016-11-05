using System.ComponentModel.DataAnnotations;

namespace Vidloq.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public string Titulo { get; set; }
    }

}