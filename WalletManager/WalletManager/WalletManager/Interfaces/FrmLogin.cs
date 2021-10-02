using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletManager.Model;
using WalletManager.Repository;
using WalletManager.Services;

namespace WalletManager.Boundarys
{
    public partial class FrmLogin : Form
    {
        private ServicioUsuario _servicioUsuario;
        private UnidadDeTrabajo _unidadDeTrabajo;
        public FrmLogin(UnidadDeTrabajo unidadDeTrabajo)
        {
            InitializeComponent();
            _unidadDeTrabajo = unidadDeTrabajo;
            _servicioUsuario = new ServicioUsuario(_unidadDeTrabajo.RepositorioUsuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string passwd = txtPassword.Text;
            Users usuarioLogueado = _servicioUsuario.Login(username, passwd);
            if (usuarioLogueado == null)
                MessageBox.Show("Usuario/Contraseña inválida", "Información", MessageBoxButtons.OK);
            else
            {
                this.Dispose();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
