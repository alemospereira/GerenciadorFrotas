using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioFrotas.Interfaces
{
    public interface IAplicacaoBase<T> where T : class
    {
        /// <summary>
        /// Adiciona um item na base de dados.
        /// </summary>
        /// <param name="item"></param>
        void Adicionar(T item);
        T ListarPorId(int id);
        IEnumerable<T> Listar();
        void Editar(T item);
        void Remover(T item);
        void Dispose();


    }
}
