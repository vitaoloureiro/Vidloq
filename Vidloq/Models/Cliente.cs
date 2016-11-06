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
        //[Required]
        //[StringLength(255)]
        public string Nome { get; set; }

        public bool Newsletter { get; set; }

        [Display(Name = "Data de Aniversário")]
        public DateTime? DataNascimento { get; set; }

        public Plano Plano { get; set; }

        [Display(Name = "Plano")]
        public int PlanoId { get; set; }

    }

}