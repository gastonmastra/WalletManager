using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletManager.Interfaces;
using WalletManager.Model;
using WalletManager.Repository;
using WalletManager.Services;
using WalletManager.Utilities;

namespace WalletManager.Boundarys
{
    public partial class FrmNewMovement : Interfaces.FrmBase
    {
        private ServicioMovimiento _servicioMovimiento;
        private ServicioClasificacion _servicioClasificacion;
        private ServicioWallet _servicioWallet;
        private Movements _newMovement;
        private UnidadDeTrabajo _unidadDeTrabajo;
        private ServicioTipoMovimiento _servicioTipoMovimiento;
        private Principal _frmPrincipal;

        public FrmNewMovement(UnidadDeTrabajo unidadDeTrabajo, Principal principal)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
            _frmPrincipal = principal;
            _servicioMovimiento = new ServicioMovimiento(_unidadDeTrabajo.RepositorioMovimiento);
            _servicioClasificacion = new ServicioClasificacion(_unidadDeTrabajo.RepositorioClasificacion);
            _servicioWallet = new ServicioWallet(_unidadDeTrabajo.RepositorioWallet);
            _servicioTipoMovimiento = new ServicioTipoMovimiento(_unidadDeTrabajo.RepositorioTipoMovimiento);
            InitializeComponent();

        }

        private void NewMovement_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            _frmPrincipal.Show();
        }

        private void NewMovement_Load(object sender, EventArgs e)
        {
            ChargeData();
        }

        private void ChargeData()
        {
            List<Clasifications> clasifications = _servicioClasificacion.ListClasifications();
            BindingSource conectorClasifications = new BindingSource();
            conectorClasifications.DataSource = clasifications;
            List<Wallets> wallets = _servicioWallet.ListWallets();
            BindingSource conectorWallets = new BindingSource();
            conectorWallets.DataSource = wallets;
            List<TypeOfMovements> typesOfMovements = _servicioTipoMovimiento.ListTypesOfMovements();
            BindingSource conectorTypeOfMovement = new BindingSource();
            conectorTypeOfMovement.DataSource = typesOfMovements;
            FrmUtilities.ChargeCombo(ref cmbClasification, conectorClasifications, "name", "id_clasification");
            FrmUtilities.ChargeCombo(ref cmbWallets, conectorWallets, "walletName", "id_wallet");
            FrmUtilities.ChargeCombo(ref cmbTypeOfMovement, conectorTypeOfMovement, "Name", "id_typeMovement");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FrmUtilities.IsConfirmedOperation())
                    return;
                if (!IsValidMovement())
                    return;
                RegisterMovement();
            }
            catch(ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show("Unespected error, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void RegisterMovement()
        {
            bool insertMovement = _servicioMovimiento.Insert(_newMovement);
            if (!insertMovement)
            {
                MessageBox.Show("Ocurred an error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("The movement was succesfull registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private bool IsValidMovement()
        {
            Movements newMovement = new Movements();
            newMovement.Clasifications = (Clasifications)cmbClasification.SelectedItem;
            newMovement.Wallets = (Wallets)cmbWallets.SelectedItem;
            newMovement.mount = Convert.ToDecimal(txtMount.Text);
            newMovement.descrip = txtDescription.Text;
            newMovement.TypeOfMovements = (TypeOfMovements)cmbTypeOfMovement.SelectedItem;
            newMovement.date = DateTime.Now;

            _servicioMovimiento.ValidarMovimiento(newMovement);
            _newMovement = newMovement;
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddClasification_Click(object sender, EventArgs e)
        {
            new FrmNewClasification(_unidadDeTrabajo, _frmPrincipal).ShowDialog();
            ChargeData();

        }
    }
}
