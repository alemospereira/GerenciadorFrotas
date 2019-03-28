using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioFrotas.Entidades
{
    public class Onibus : VeiculoBase
    {
        public Onibus(string chassi, string cor)
        {
            base.TipoVeiculo = TipoVeiculo.Onibus;
            base.NumeroPassageiros = 42;
            base.Chassi = chassi;
            base.Cor = cor;
        }
    }
}
