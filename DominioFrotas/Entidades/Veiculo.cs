using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioFrotas.Entidades
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Chassi { get; set; }
        public TipoVeiculo TipoVeiculo { get; set; }
        public byte NumeroPassageiros { get; set; }
        public string Cor { get; set; }
    }

    public enum TipoVeiculo
    {
        Caminhao = 1,
        Onibus = 2
    }
}
