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
using WalletManager.Servicios;

namespace WalletManager.Boundarys
{
    public partial class FrmNewMovement : Form
    {
        private ServicioClasificaciones servicioClasificaciones;
        private ServicioWallets servicioWallets;
        private Principal principal;

        public FrmNewMovement()
        {
            InitializeComponent();
        }

        public FrmNewMovement(Principal _principal)
        {
            principal = _principal;
            servicioClasificaciones = new ServicioClasificaciones();
            servicioWallets = new ServicioWallets();
            InitializeComponent();

        }

        private void NewMovement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            principal.Show();

        }

        private void NewMovement_Load(object sender, EventArgs e)
        {
            ChargeClasifications(cmbClasification);
            ChargeWallets(cmbWallets);
        }

        private void ChargeClasifications(ComboBox combo)
        {
            var clasifications = servicioClasificaciones.GetAll();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = clasifications;
            combo.DataSource = bindingSource;
            combo.DisplayMember = "name";
            combo.ValueMember = "id_clasification";
        }
        private void ChargeWallets(ComboBox combo)
        {
            var wallets = servicioWallets.GetAll();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = wallets;
            combo.DataSource = bindingSource;
            combo.DisplayMember = "walletName";
            combo.ValueMember = "id_wallet";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Movement movement = new Movement();
            movement.Clasification = (Clasification)cmbClasification.SelectedItem;
            movement.Wallets = (Wallet)cmbWallets.SelectedItem;
        }
    }
}
