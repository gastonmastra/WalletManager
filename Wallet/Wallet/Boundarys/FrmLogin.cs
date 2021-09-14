using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wallet.Entities;
using Wallet.Servicios;

namespace Wallet.Boundarys
{
    public partial class FrmLogin : Form
    {
        private UsuarioServicio usuarioServicio;
        public FrmLogin()
        {
            InitializeComponent();
            usuarioServicio = new UsuarioServicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuario = new User();
            usuario.username = txtName.Text;
            usuario.password = txtPassword.Text;

            var usuarioLogueado = usuarioServicio.Login(usuario);
            if (usuarioLogueado == null)
                MessageBox.Show("Usuario/Contraseña inválida", "Información", MessageBoxButtons.OK);
            else
            {
                this.Dispose();
            }
        }
    }
}
