using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioFrotas.Entidades
{
    public class Caminhao : VeiculoBase
    {
        public Caminhao(string chassi, string cor)
        {
            base.TipoVeiculo = TipoVeiculo.Caminhao;
            base.NumeroPassageiros = 2;
            base.Chassi = chassi;
            base.Cor = cor;
        }
    }
}
