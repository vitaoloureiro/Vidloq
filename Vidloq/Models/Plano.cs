using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidloq.Models
{
    public class Plano
    {
        [Key]
        public int PlanoId { get; set; }
        public string Titulo { get; set; }
        public short TaxaDeInscricao { get; set; }
        public byte DuracaoEmMeses { get; set; }
        public byte TaxaDeDesconto { get; set; }

        public static readonly byte Desconhecido = 0;
        public static readonly byte APagar = 1;
    }
}