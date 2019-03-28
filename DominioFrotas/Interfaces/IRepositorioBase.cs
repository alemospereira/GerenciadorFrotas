using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioFrotas.Interfaces
{
    public interface IRepositorioBase<T> where T : class
    {
        void Adicionar(T item);
        T ListarPorId(int id);
        IEnumerable<T> Listar();
        void Editar(T item);
        void Remover(T item);
        void Dispose();


    }
}
