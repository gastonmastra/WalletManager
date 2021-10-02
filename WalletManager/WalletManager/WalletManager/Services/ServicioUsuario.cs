using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletManager.Model;
using WalletManager.Repository;

namespace WalletManager.Services
{
    class ServicioUsuario : Servicio<Users>
    {
        private RepositorioUsuario _repositorioUsuario;
        public static Users usuarioLogueado;

        public ServicioUsuario(RepositorioUsuario repositorioUsuario) : base (repositorioUsuario)
        {
            _repositorioUsuario = repositorioUsuario;
        }
        public Users Login(string username, string passwd)
        {
            List<Users> listaUsuarios = ListarUsuarios();
            foreach(Users usuario in listaUsuarios)
            {
                if (usuario.username == username && usuario.passwd == passwd)
                {
                    usuarioLogueado = usuario;
                    return usuario;
                }
            }
            return null;
        }

        private List<Users> ListarUsuarios()
        {
            return _repositorioUsuario.GetAll().ToList();
        }
    }
}
