using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallet.Entities;
using Wallet.Repository;

namespace Wallet.Repository
{
    class UsuarioRepositorio
    {
        public User LoginBD(User usuarioIngresado)
        {
            User usuarioResultado = null;
            var sentenciaSQL = $"SELECT * FROM Users WHERE username='{usuarioIngresado.username}' " +
                $"and passwd='{usuarioIngresado.password}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            if(tablaResultado.Rows.Count == 1)
            {
                var row = tablaResultado.Rows[0];
                usuarioResultado = new User();
                usuarioResultado.username = row["username"].ToString();
            }
            return usuarioResultado;
        }
    }
}
