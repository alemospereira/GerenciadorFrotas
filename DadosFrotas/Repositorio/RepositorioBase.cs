using DadosFrotas.Contexto;
using DominioFrotas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosFrotas.Repositorio
{
    public class RepositorioBase<T> : IDisposable, IRepositorioBase<T> where T : class
    {
        protected FrotasContexto Db = new FrotasContexto();
        public void Adicionar(T item)
        {
            Db.Set<T>().Add(item);
            Db.SaveChanges();
        }
        
        public virtual void Editar(T item)
        {
            Db.Entry(item).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }

        public IEnumerable<T> Listar()
        {
           return Db.Set<T>().ToList();
        }

        public T ListarPorId(int id)
        {
            return Db.Set<T>().Find(id);
        }

        public void Remover(T item)
        {            
            Db.Set<T>().Remove(item);
            Db.SaveChanges();
        }
        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
