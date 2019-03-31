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

        public Veiculo()
        {

        }
        public Veiculo(string chassi, string cor, TipoVeiculo tipo)
        {
            switch (tipo)
            {
                case TipoVeiculo.Caminhao:
                    this.Chassi = chassi;
                    this.Cor = cor;
                    this.TipoVeiculo = TipoVeiculo.Caminhao;
                    this.NumeroPassageiros = 2;
                   break;
                case TipoVeiculo.Onibus:
                    this.Chassi = chassi;
                    this.Cor = cor;
                    this.TipoVeiculo = TipoVeiculo.Onibus;
                    this.NumeroPassageiros = 42;
                    break;
                default:
                    break;
            }

        }
    }

    public enum TipoVeiculo
    {
        Caminhao = 1,
        Onibus = 2
    }
}
