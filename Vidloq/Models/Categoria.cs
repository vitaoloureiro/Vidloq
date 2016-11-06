using System.ComponentModel.DataAnnotations;

namespace Vidloq.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Titulo { get; set; }
        public string Imagem { get; set; }
    }
}