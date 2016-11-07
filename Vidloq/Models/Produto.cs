using System;
using System.ComponentModel.DataAnnotations;

namespace Vidloq.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [MaxLength(255, ErrorMessage = "Máximo de 255 caracters excedido.")]
        [Required(ErrorMessage = "Prencha o campo Titulo.")]
        public string Titulo { get; set; }

        [Display(Name = "Data de Lançamento")]
        [Required(ErrorMessage = "Prencha a data de Lançamento.")]
        public DateTime DataLancamento {get; set;}

        public DateTime DataCadastro {get; set;}

        [Display(Name = "Em Estoque")]
        [Range(1,20, ErrorMessage = "O estoque precisa estar entre 1 e 20.")]
        public int QtDisponivel { get; set; }

        public Categoria Categoria { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Selecione uma categoria.")]
        public int CategoriaId { get; set; }
    }

}