using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletManager.Model;
using WalletManager.Repository;

namespace WalletManager.Services
{
    public class ServicioWallet : Servicio<Wallets>
    {
        private RepositorioWallet _repositorioWallet;
        public ServicioWallet(RepositorioWallet repositorioWallet) : base(repositorioWallet)
        {
            _repositorioWallet = repositorioWallet;
        }

        public List<Wallets> ListWallets()
        {
            return _repositorioWallet.GetAll().ToList();
        }
    }
}
