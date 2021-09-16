using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Entities;
using Wallet.Repository;

namespace Wallet.Servicios
{
    class UsuarioServicio
    {
        private UsuarioRepositorio usuarioRepositorio;
        public static user usuarioLogueado;

        public UsuarioServicio()
        {
            usuarioRepositorio = new UsuarioRepositorio();
        }
        public user Login(user usuarioIngresado)
        {
            var usuario = usuarioRepositorio.LoginBD(usuarioIngresado);
            usuarioLogueado = usuario;
            return usuario;
        }
    }
}
