using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioFrotas.Entidades
{
    public class Caminhao
    {
        public Caminhao(string chassi, string cor)
        {
            new Veiculo() { Chassi = chassi, Cor = cor, NumeroPassageiros = 2, TipoVeiculo = TipoVeiculo.Caminhao };
        }
    }
}
