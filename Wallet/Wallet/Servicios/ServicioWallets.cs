using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletManager.Model;
using WalletManager.Repository;

namespace WalletManager.Servicios
{
    public class ServicioWallets
    {
        private RepositorioWallet repositorioWallet;
        public ServicioWallets()
        {
            repositorioWallet = new RepositorioWallet();

        }

        public List<Wallet> GetAll()
        {
            return repositorioWallet.GetAll();
        }
    }
}
