using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Infra.ConfigContext
{
    public class EspecialidadeConfiguration : EntityTypeConfiguration<Especialidades>
    {
        public EspecialidadeConfiguration()
        {
            this.HasKey<int>(s => s.IDEspecialidade);

            this.Property(p => p.Nome)
                    .IsRequired()
                    .HasMaxLength(150);

            
            this.HasMany<Medicos>(e => e.Medicos)
                .WithRequired(m => m.Especialidade)
                .HasForeignKey(m => m.IDEspecialidade);
        }
    }
}
