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
            if (_veiculoRepositorio.ListarPorChassi(item.Chassi) != null)
                throw new InvalidOperationException("Chassi já existe cadastrado!");
            _veiculoRepositorio.Adicionar(item);
        }
        
        public void Editar(Veiculo item)
        {
            _veiculoRepositorio.Editar(item);
        }

        public IEnumerable<Veiculo> Listar(string filtro)
        {
            return _veiculoRepositorio.Listar(filtro);
        }

        public Veiculo ListarPorId(int id)
        {
            return _veiculoRepositorio.ListarPorId(id);
        }

        public void Remover(int id)
        {
            var item = ListarPorId(id);
            if (item == null)
                throw new NullReferenceException("Item não encontrado para deletar.");
            _veiculoRepositorio.Remover(item);
        }
        public void Dispose()
        {
            _veiculoRepositorio.Dispose();
        }
    }
}
