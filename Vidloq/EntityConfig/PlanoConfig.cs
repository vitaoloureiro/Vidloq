using System.Data.Entity.ModelConfiguration;
using Vidloq.Models;

namespace Vidloq.EntityConfig
{
    public class PlanoConfig : EntityTypeConfiguration<Plano>
    {
        public PlanoConfig()
        {

            Property(p => p.Titulo)
            .IsRequired()
            .HasMaxLength(150);

            ToTable("Planos");
        }
    }
}