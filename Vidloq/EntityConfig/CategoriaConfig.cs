using System.Data.Entity.ModelConfiguration;
using Vidloq.Models;

namespace Vidloq.EntityConfig
{
    public class CategoriaConfig : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfig()
        {
            HasKey(c => c.CategoriaId);

            Property(c => c.Titulo)
            .IsRequired()
            .HasMaxLength(150);

            ToTable("Categorias");
        }
    }
}