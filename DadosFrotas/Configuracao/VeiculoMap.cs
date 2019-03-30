using DominioFrotas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosFrotas.Configuracao
{
    public class VeiculosMap : EntityTypeConfiguration<Veiculo>
    {

        public VeiculosMap()
        {
            this.ToTable("Veiculos");
            this.HasKey(k => k.Id);
            this.Property(p => p.Chassi).IsRequired().HasColumnType("varchar").HasMaxLength(17);
            this.Property(p => p.Cor).IsRequired().HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.NumeroPassageiros).IsRequired();
            this.Property(p => p.TipoVeiculo).IsRequired();
        }
    }
}
