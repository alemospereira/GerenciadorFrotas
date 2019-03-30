using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioFrotas.Entidades
{
    public class Onibus
    {
        public Onibus(string chassi, string cor)
        {
            new Veiculo() { Chassi = chassi, Cor = cor, NumeroPassageiros = 42, TipoVeiculo = TipoVeiculo.Onibus };
        }
    }
}
