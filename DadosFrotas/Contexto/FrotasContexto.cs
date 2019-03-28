using DominioFrotas.Entidades;
using System.Data.Entity;

namespace DadosFrotas.Contexto
{
    public class FrotasContexto : DbContext
    {
        public FrotasContexto() : base("FrotasConnectionString")
        {

        }

        public DbSet<VeiculoBase> Veiculos { get; set; }
    }
}
