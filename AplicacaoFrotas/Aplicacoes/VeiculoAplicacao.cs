using DominioFrotas.Entidades;
using DominioFrotas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoFrotas.Aplicacoes
{
    public class VeiculoAplicacao : IVeiculoAplicacao
    {
        private readonly IVeiculoRepositorio _veiculoRepositorio;

        public VeiculoAplicacao(IVeiculoRepositorio veiculoRepositorio)
        {
            _veiculoRepositorio = veiculoRepositorio;
        }
        public void Adicionar(Veiculo item)
        {
            _veiculoRepositorio.Adicionar(item);
        }
        
        public void Editar(Veiculo item)
        {
            _veiculoRepositorio.Editar(item);
        }

        public IEnumerable<Veiculo> Listar()
        {
            return _veiculoRepositorio.Listar();
        }

        public Veiculo ListarPorId(int id)
        {
            return _veiculoRepositorio.ListarPorId(id);
        }

        public void Remover(Veiculo item)
        {
            _veiculoRepositorio.Remover(item);
        }
        public void Dispose()
        {
            _veiculoRepositorio.Dispose();
        }
    }
}
