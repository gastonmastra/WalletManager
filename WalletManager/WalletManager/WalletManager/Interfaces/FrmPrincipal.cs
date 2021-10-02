using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletManager.Boundarys;
using WalletManager.Interfaces;
using WalletManager.Repository;

namespace WalletManager
{
    public partial class Principal : Form
    {
        private UnidadDeTrabajo _unidadDeTrabajo;
        public Principal(UnidadDeTrabajo unidadDeTrabajo)
        {
            InitializeComponent();
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            var frmLogin = new FrmLogin(_unidadDeTrabajo);
            frmLogin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmNewMovement(_unidadDeTrabajo, this).ShowDialog();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnMovements_Click(object sender, EventArgs e)
        {
            new FrmMovement(_unidadDeTrabajo, this).ShowDialog();
        }
    }
}
