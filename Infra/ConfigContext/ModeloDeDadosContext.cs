namespace Infra.ConfigContext
{
    using Domain.Entities;
    using System.Data.Entity;

    public partial class ModeloDeDadosContext : DbContext
    {
        public ModeloDeDadosContext()
            : base("name=ModeloDeDadosContext")
        {
        }
    
        public virtual DbSet<Cidades> Cidades { get; set; }
        public virtual DbSet<Especialidades> Especialidades { get; set; }
        public virtual DbSet<Medicos> Medicos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MedicoConfiguration());
            modelBuilder.Configurations.Add(new EspecialidadeConfiguration());
            modelBuilder.Configurations.Add(new CidadeConfiguration());
        }
    
    }
}
