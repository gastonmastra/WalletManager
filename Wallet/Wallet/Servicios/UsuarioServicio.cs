using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletManager.Model;
using WalletManager.Repository;

namespace WalletManager.Servicios
{
    class UsuarioServicio
    {
        private UsuarioRepositorio usuarioRepositorio;
        public static User usuarioLogueado;

        public UsuarioServicio()
        {
            usuarioRepositorio = new UsuarioRepositorio();
        }
        public User Login(User usuarioIngresado)
        {
            var usuario = usuarioRepositorio.LoginBD(usuarioIngresado);
            usuarioLogueado = usuario;
            return usuario;
        }
    }
}
