using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletManager.Repository;
using WalletManager.Model;


namespace WalletManager.Repository
{
    public class RepositorioWallet : Repositorio<Wallets>
    {
        public RepositorioWallet(DBContext dbContext) : base(dbContext)
        {
        }
    }
}
