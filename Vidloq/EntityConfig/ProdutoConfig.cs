using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using Vidloq.Models;

namespace Vidloq.EntityConfig
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {

            Property(p => p.Titulo)
                .IsRequired()
                .HasMaxLength(255);

            ToTable("Produtos");

        }

    }
}