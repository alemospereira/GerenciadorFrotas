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
        /// <summary>
        /// Retorna o item pelo Id informado
        /// </summary>
        /// <param name="id"></param>
        /// <returns>item</returns>
        T ListarPorId(int id);
        /// <summary>
        /// Retorna um lista de itens podendo filtrar pelo chassi
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns>List</returns>
        IEnumerable<T> Listar(string filtro);
        /// <summary>
        /// Edita o item com os paramentros informados
        /// </summary>
        /// <param name="item"></param>
        void Editar(T item);
        /// <summary>
        /// Remove o item com o id informado
        /// </summary>
        /// <param name="id"></param>
        void Remover(int id);
        void Dispose();


    }
}
