using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using Vidloq.Models;

namespace Vidloq.EntityConfig
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            /*
                       Property(c => c.CPF)
                            .IsRequired()
                            .HasMaxLength(11)
                            .IsFixedLength()
                            .HasColumnAnnotation("Index", new IndexAnnotation(
                                new IndexAttribute() {IsUnique = true}));

                        Property(c => c.Email)
                            .IsRequired()
                            .HasMaxLength(150);
            */

            ToTable("Clientes");


        }
        
    }
}