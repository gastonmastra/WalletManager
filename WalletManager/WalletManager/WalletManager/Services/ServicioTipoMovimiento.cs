using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletManager.Model;
using WalletManager.Repository;

namespace WalletManager.Services
{
    public class ServicioTipoMovimiento : Servicio<TypeOfMovements>
    {
        private RepositorioTipoMovimiento _repositorioTipoMovimiento;
        public ServicioTipoMovimiento(RepositorioTipoMovimiento repositorioTipoMovimiento) : base(repositorioTipoMovimiento)
        {
            _repositorioTipoMovimiento = repositorioTipoMovimiento;
        }
        public List<TypeOfMovements> ListTypesOfMovements()
        {
            return _repositorioTipoMovimiento.GetAll().ToList();
        }
    }
}
