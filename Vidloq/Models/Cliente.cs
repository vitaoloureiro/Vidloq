using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidloq.Models
{
    public class Cliente
    {
    // Usando DataAnnotations, 
    // vamos utilizar Fluent API, ver arquivo tips em One/dotnet
        [Key]
        public int ClienteId { get; set; }

        [MaxLength(255, ErrorMessage = "Máximo de 255 caracters excedido.")]
        [MinLength(2, ErrorMessage = "O nome não poder conter menos de 2 caracteres.")]
        [Required(ErrorMessage = "Prencha o campo nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A opção por Newsletter não preenchido.")]
        public bool Newsletter { get; set; }

        [Display(Name = "Data de Aniversário")]
        [Required(ErrorMessage = "Preencha a data de aniversário.")]
        [MenorIdade]
        public DateTime? DataNascimento { get; set; }
        
        public Plano Plano { get; set; }

        [Display(Name = "Plano")]
        [Required(ErrorMessage = "Selecione um plano de assinatura.")]
        public int PlanoId { get; set; }

    }

}