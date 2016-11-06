using System;
using System.ComponentModel.DataAnnotations;

namespace Vidloq.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public string Titulo { get; set; }
        public DateTime? DataLancamento {get; set;}
        public DateTime DataCadastro {get; set;}
        public int QtDisponivel { get; set; }

        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
    }

}