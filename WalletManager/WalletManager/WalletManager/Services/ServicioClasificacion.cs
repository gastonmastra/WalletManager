using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletManager.Model;
using WalletManager.Repository;

namespace WalletManager.Services
{
    public class ServicioClasificacion : Servicio<Clasifications>
    {
        private RepositorioClasificacion _repositorioClasificacion;
        public ServicioClasificacion(RepositorioClasificacion repositorioClasificacion) : base(repositorioClasificacion)
        {
            _repositorioClasificacion = repositorioClasificacion;
        }
        public List<Clasifications> ListClasifications()
        {
            return _repositorioClasificacion.GetAll().ToList();
        }
    }
}
