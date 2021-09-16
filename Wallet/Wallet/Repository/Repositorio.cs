using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Entities;

namespace Wallet.Repository
{
    class Repositorio
    {
        private walletManagerDBEntities db;

        public Repositorio()
        {
            db = new walletManagerDBEntities();
        }

        public List<user> GetAll()
            // Return a list with all users in the database
        {
            var users = new List<user>();
            foreach (var user in db.users)
            {
                users.Add(user);
            }
            return users;
        }
        
    }
}
