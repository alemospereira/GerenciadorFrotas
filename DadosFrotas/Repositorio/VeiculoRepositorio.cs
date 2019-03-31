using DominioFrotas.Entidades;
using DominioFrotas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosFrotas.Repositorio
{
    public class VeiculoRepositorio : RepositorioBase<Veiculo>, IVeiculoRepositorio
    {

        public override void Editar(Veiculo item)
        {
            //Somente a cor pode ser alterada
            var itemEditar = base.ListarPorId(item.Id);
            itemEditar.Cor = item.Cor;
            base.Editar(itemEditar);
        }

        public IEnumerable<Veiculo> Listar(string filtro)
        {
            var query = Db.Set<Veiculo>();
            if (string.IsNullOrEmpty(filtro))
                return query.ToList();
           return query.Where(x => x.Chassi.Contains(filtro)).ToList();
        }

        public Veiculo ListarPorChassi(string chassi)
        {
            return Db.Set<Veiculo>().FirstOrDefault(x => x.Chassi == chassi);
        }
    }
}
