using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Entities;
using Wallet.Repository;

namespace Wallet.Repository
{
 
    class UsuarioRepositorio : Repositorio
    {
        private List<user> usuarios;
        public user LoginBD(user usuarioIngresado)
        {
            user usuarioResultado = null;

            usuarios = this.GetAll();
            foreach (var user in usuarios)
            {
                if (usuarioIngresado.username == user.username && usuarioIngresado.passwd == user.passwd)
                    usuarioResultado = user;
            }
            return usuarioResultado;
        }
    }
}
