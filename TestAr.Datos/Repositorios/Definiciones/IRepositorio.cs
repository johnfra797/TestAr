using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TestAr.Datos.Repositorios.Definiciones
{
    public interface IRepositorio<T>
    {
        IUnidadTrabajo UnidadTrabajo { get; }
        IQueryable<T> ObtenerTodo(bool? asNoTracking = false);
        IQueryable<T> ObtenerPor(Expression<Func<T, bool>> predicate);
        void Crear(T entity);
        void Actualizar(T entity);
        void Eliminar(T entity);
    }
}
