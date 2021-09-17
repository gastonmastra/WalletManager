using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletManager.Model;

namespace WalletManager.Repository
{

    public class RepositorioClasificacion : Repositorio
    {
        List<Clasification> clasifications;
        public RepositorioClasificacion()
        {
            clasifications = new List<Clasification>();
        }
        public List<Clasification> GetAll()
        {
            foreach(Clasification clas in db.Clasifications)
            {
                clasifications.Add(clas);
            }
            return clasifications;
        }
    }
}
