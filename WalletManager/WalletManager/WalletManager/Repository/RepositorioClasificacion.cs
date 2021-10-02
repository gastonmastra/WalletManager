using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletManager.Model;

namespace WalletManager.Repository
{

    public class RepositorioClasificacion : Repositorio<Clasifications>
    {
        public RepositorioClasificacion(DBContext dbContext) : base(dbContext)
        {
        }
    }
}
