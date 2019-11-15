using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TestAr.Datos.Repositorios.Definiciones;

namespace TestAr.Datos.Repositorios.Implementaciones
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
       // private readonly ILogger _logger;
        private readonly UnidadTrabajo _unidadTrabajo;

        public Repositorio(IUnidadTrabajo unidadTrabajo)
        {
            if (unidadTrabajo == null)
            {
                throw new ArgumentNullException(GetType().FullName);
            }

            _unidadTrabajo = (UnidadTrabajo)unidadTrabajo;
           // _logger = new Logger(typeof(Repositorio<T>));
        }

        public IUnidadTrabajo UnidadTrabajo => _unidadTrabajo;

        public virtual IQueryable<T> ObtenerTodo(bool? asNoTracking = false)
        {
            if (!asNoTracking.HasValue)
            {
                return _unidadTrabajo.Set<T>();
            }

            return asNoTracking.Value ? _unidadTrabajo.Set<T>().AsNoTracking() : _unidadTrabajo.Set<T>();
        }

        public IQueryable<T> ObtenerPor(Expression<Func<T, bool>> predicate)
        {
            var theQuery = _unidadTrabajo.Set<T>().Where(predicate);
            return theQuery;
        }

        public void Crear(T entity)
        {
            try
            {
                if (entity != null)
                {
                    _unidadTrabajo.Entry(entity).State = EntityState.Added;
                }
            }
            catch (Exception ex)
            {
                //_logger.LogException(ex);
            }
        }

        public virtual void Actualizar(T entity)
        {
            try
            {
                if (entity != null)
                {
                    _unidadTrabajo.Entry(entity).State = EntityState.Modified;
                }
            }
            catch (Exception ex)
            {
                //_logger.LogException(ex);
            }
        }

        public virtual void Eliminar(T entity)
        {
            try
            {
                if (entity != null)
                {
                    _unidadTrabajo.Entry(entity).State = EntityState.Deleted;
                }
            }
            catch (OptimisticConcurrencyException ex)
            {
                //_logger.LogException(ex);
            }
            catch (Exception ex)
            {
                //_logger.LogException(ex);
            }
        }
        
    }
}
