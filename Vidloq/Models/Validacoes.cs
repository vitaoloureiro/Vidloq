using System;
using System.ComponentModel.DataAnnotations;

namespace Vidloq.Models
{
    // Verifica se cliente tem mais de 18 anos para assinar um tipo de plano
    public class MenorIdade : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var cliente = (Cliente)validationContext.ObjectInstance;


            // Cliente menor de idade não pode assinar o plano 'A Pagar'
            // Evitando magic numbers, na model foi adiciona um public static readonly com o valor do plano A pagar
            //if (cliente.PlanoId != 1)
            if (cliente.PlanoId != Plano.APagar)
                return ValidationResult.Success;

            if (cliente.DataNascimento == null)
                return new ValidationResult("Data de Aniversário é obrigatório.");

            var idade = DateTime.Today.Year - cliente.DataNascimento.Value.Year;

            return (idade >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Cliente precisa ter 18 anos para este plano");
        }
    }

    public class Vascaino : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return base.IsValid(value, validationContext);
        }
    }


}