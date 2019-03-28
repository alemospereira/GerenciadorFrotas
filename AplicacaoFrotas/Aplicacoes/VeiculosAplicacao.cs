using DominioFrotas.Entidades;
using DominioFrotas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoFrotas.Aplicacoes
{
    public class VeiculosAplicacao : IVeiculoAplicacao
    {
        private readonly IVeiculoRepositorio _veiculoRepositorio;

        public VeiculosAplicacao(IVeiculoRepositorio veiculoRepositorio)
        {
            _veiculoRepositorio = veiculoRepositorio;
        }
        public void Adicionar(VeiculoBase item)
        {
            _veiculoRepositorio.Adicionar(item);
        }
        
        public void Editar(VeiculoBase item)
        {
            _veiculoRepositorio.Editar(item);
        }

        public IEnumerable<VeiculoBase> Listar()
        {
            return _veiculoRepositorio.Listar();
        }

        public VeiculoBase ListarPorId(int id)
        {
            return _veiculoRepositorio.ListarPorId(id);
        }

        public void Remover(VeiculoBase item)
        {
            _veiculoRepositorio.Remover(item);
        }
        public void Dispose()
        {
            _veiculoRepositorio.Dispose();
        }
    }
}
