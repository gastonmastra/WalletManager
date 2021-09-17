using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletManager.Model;
using WalletManager.Repository;

namespace WalletManager.Services
{
    public class ServicioClasificaciones
    {
        private RepositorioClasificacion repositorioClasificaciones;
        public ServicioClasificaciones()
        {
            repositorioClasificaciones = new RepositorioClasificacion();
        }
        public List<Clasification> GetAll()
        {
            return repositorioClasificaciones.GetAll();
        }
    }
}
