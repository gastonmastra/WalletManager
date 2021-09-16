using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletManager.Model;

namespace WalletManager.Repository
{
 
    class UsuarioRepositorio : Repositorio
    {
        private List<User> usuarios;
        public User LoginBD(User usuarioIngresado)
        {
            User usuarioResultado = null;

            usuarios = this.GetAll();
            foreach (var user in usuarios)
            {
                if (usuarioIngresado.username == user.username && usuarioIngresado.passwd == user.passwd)
                    usuarioResultado = user;
            }
            return usuarioResultado;
        }

        public List<User> GetAll()
        // Return a list with all users in the database
        {
            var users = new List<User>();
            foreach (User user in db.Users)
            {
                users.Add(user);
            }
            return users;
        }
    }
}
