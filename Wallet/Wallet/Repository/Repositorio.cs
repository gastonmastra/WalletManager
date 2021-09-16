using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletManager.Model;

namespace WalletManager.Repository
{
    public class Repositorio
    {
        public DBEntities db;

        public Repositorio()
        {
            db = new DBEntities();
        }
        
    }
}
