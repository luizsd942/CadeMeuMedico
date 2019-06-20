using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Infra.ConfigContext
{
    public class CidadeConfiguration : EntityTypeConfiguration<Cidades>
    {
        public CidadeConfiguration()
        {
            this.HasKey<int>(s => s.IDCidade);

            this.Property(p => p.Nome)
                    .IsRequired()
                    .HasMaxLength(100);
            
            this.HasMany<Medicos>(e => e.Medicos)
                .WithRequired(m => m.Cidade)
                .HasForeignKey(m => m.IDCidade);
        }
    }
}
