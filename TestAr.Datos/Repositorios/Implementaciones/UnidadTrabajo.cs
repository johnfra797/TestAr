using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAr.Datos.Repositorios.Definiciones;

namespace TestAr.Datos.Repositorios.Implementaciones
{
    public class UnidadTrabajo : DbContext, IUnidadTrabajo
    {
        //private readonly ILogger _logger;
        private DbContextTransaction _dbContextTransaction;

        protected UnidadTrabajo() : base(ResolveProvider(), true)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            //_logger = new Logger(typeof(UnidadTrabajo));

            try
            {
                var objCtx = ((IObjectContextAdapter)this).ObjectContext;
                objCtx.SavingChanges += ObjCtxOnSavingChanges;
            }
            catch (Exception ex)
            {
                //_logger.LogException(ex);
            }
        }

        public void BeginTransaction()
        {
            _dbContextTransaction = Database.BeginTransaction();
        }

        public void Commit()
        {
            if (_dbContextTransaction != null)
            {
                try
                {
                    SaveChanges();
                    _dbContextTransaction.Commit();
                }
                catch (Exception ex)
                {
                    //_logger.LogException(ex);
                    _dbContextTransaction.Rollback();
                }
            }
            else
            {
                SaveChanges();
            }
        }

        public new void Dispose()
        {
            base.Dispose();
        }

        private static void ObjCtxOnSavingChanges(object sender, EventArgs eventArgs)
        {
        }

        private static DbConnection ResolveProvider()
        {
            return new SqlConnection("Server=DESKTOP-TS7UAAQ\\SQLEXPRESS;Database=ArandaTest;Trusted_Connection=True;");
           
        }
    }
}
