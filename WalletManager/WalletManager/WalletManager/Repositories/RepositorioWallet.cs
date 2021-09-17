using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletManager.Repository;
using WalletManager.Model;


namespace WalletManager.Repository
{
    public class RepositorioWallet : Repositorio
    {
        List<Wallet> wallets;
        public RepositorioWallet()
        {
            wallets = new List<Wallet>();
        }
        public List<Wallet> GetAll()
        {
            foreach (Wallet wallet in db.Wallets)
            {
                wallets.Add(wallet);
            }
            return wallets;
        }
    }
}
