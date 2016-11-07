using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidloq.Models;

namespace Vidloq.ViewModels
{
    public class ClienteFormViewModel
    {
        // Pegando a lista de planos
        public IEnumerable<Plano> Planos { get; set; }
        // Pegando os dados do cliente
        public Cliente Cliente { get; set; }


        public string Acao

        {
            get
            {
                return Cliente != null ? "Editar" : "Adicionar";
            }

        }

        /*
            public string Acao
         {
             get
             {
                 if (Cliente != null && Cliente.ClienteId != 0)
                 {
                     return "Editar";
                 }
                 else
                 {
                     return "Adicionar";
                 }
             }
         }
         */



    }
}