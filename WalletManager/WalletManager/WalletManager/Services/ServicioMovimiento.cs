using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletManager.Model;
using WalletManager.Repository;

namespace WalletManager.Services
{
    public class ServicioMovimiento : Servicio<Movements>
    {
        private RepositorioMovimiento _repositorioMovimiento;
        public ServicioMovimiento(RepositorioMovimiento repositorioMovimiento) : base(repositorioMovimiento)
        {
            _repositorioMovimiento = repositorioMovimiento;
        }
        public void ValidarMovimiento(Movements movement)
        {
            movement.ValidarMonto();
        }
        public List<Movements> ListMovements()
        {
            return _repositorioMovimiento.GetAll().ToList();
        }
    }
}
