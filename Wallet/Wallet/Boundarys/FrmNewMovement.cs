using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wallet.Servicios;

namespace Wallet.Boundarys
{
    public partial class FrmNewMovement : Form
    {
        private UsuarioServicio usuarioServicio;
        private Principal principal;

        public FrmNewMovement()
        {
            InitializeComponent();
        }

        public FrmNewMovement(Principal _principal)
        {
            principal = _principal;
            usuarioServicio = new UsuarioServicio();
            InitializeComponent();

        }

        private void NewMovement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            principal.Show();

        }

        private void NewMovement_Load(object sender, EventArgs e)
        {

        }
    }
}
