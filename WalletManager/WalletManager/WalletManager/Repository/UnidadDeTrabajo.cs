using System;
using WalletManager.Model;

namespace WalletManager.Repository
{
    public class UnidadDeTrabajo : IDisposable
    {
        private readonly DBContext _dbContext;
        public RepositorioMovimiento RepositorioMovimiento;
        public RepositorioClasificacion RepositorioClasificacion;
        public RepositorioWallet RepositorioWallet;
        public RepositorioUsuario RepositorioUsuario;
        public RepositorioTipoMovimiento RepositorioTipoMovimiento;
        public UnidadDeTrabajo(DBContext dbContext)
        {
            _dbContext = dbContext;
            RepositorioMovimiento = new RepositorioMovimiento(_dbContext);
            RepositorioClasificacion = new RepositorioClasificacion(_dbContext);
            RepositorioWallet = new RepositorioWallet(_dbContext);
            RepositorioUsuario = new RepositorioUsuario(_dbContext);
            RepositorioTipoMovimiento = new RepositorioTipoMovimiento(_dbContext);
        }
        public int Save()
        {
            return _dbContext.SaveChanges();
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
