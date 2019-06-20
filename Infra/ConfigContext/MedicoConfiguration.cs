using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Infra.ConfigContext
{
    public class MedicoConfiguration : EntityTypeConfiguration<Medicos>
    {
        public MedicoConfiguration()
        {
            this.HasKey<int>(s => s.IDMedico);

            this.Property(p => p.CRM)
                    .IsRequired()
                    .HasMaxLength(100);

            this.Property(p => p.Nome)
                    .HasMaxLength(100)
                    .IsRequired();

            this.Property(p => p.WebsiteBlog)
                    .HasMaxLength(150);

            this.Property(p => p.Bairro)
                    .HasMaxLength(80)
                    .IsRequired();

            this.Property(p => p.Email)
                    .HasMaxLength(100)
                    .IsRequired();
        }
    }
}
