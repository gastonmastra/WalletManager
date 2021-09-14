using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet.Entities
{
    class User
    {
        public int ID { get; set; }
        public string username { get; set; }

        public string password { get; set; }

        public void ValidarNombre()
        {
            if (string.IsNullOrEmpty(username))
                throw new ApplicationException("Debe ingresar algun nombre de usuario");
            if (username.Length > 20)
                throw new ApplicationException("El nombre de usuario debe ser menor que 20 caracteres");
        }

        public void ValidarPassword()
        {
            if (string.IsNullOrEmpty(password))
                throw new ApplicationException("Debe ingresar alguna contraseña");
            if (password.Length > 20)
                throw new ApplicationException("La contraseña debe contener menos de 20 caracteres");
        }
        
    }
}
