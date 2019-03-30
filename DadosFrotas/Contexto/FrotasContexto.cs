using DadosFrotas.Configuracao;
using DominioFrotas.Entidades;
using System.Data.Entity;

namespace DadosFrotas.Contexto
{
    public class FrotasContexto : DbContext
    {
        public FrotasContexto() : base("FrotasConnectionString")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VeiculosMap());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
