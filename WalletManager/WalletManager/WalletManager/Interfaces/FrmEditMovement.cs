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
using WalletManager.Utilities;

namespace WalletManager.Interfaces
{
    public partial class FrmEditMovement : FrmBase
    {
        private Movements _movementToEdit;
        private UnidadDeTrabajo _unidadDeTrabajo;
        private ServicioMovimiento _servicioMovimiento;
        private ServicioClasificacion _servicioClasificacion;
        private ServicioTipoMovimiento _servicioTipoMovimiento;
        private ServicioWallet _servicioWallet;
        public FrmEditMovement(UnidadDeTrabajo unidadDeTrabajo, int idMovement)
        {
            InitializeComponent();
            _unidadDeTrabajo = unidadDeTrabajo;
            _servicioMovimiento = new ServicioMovimiento(_unidadDeTrabajo.RepositorioMovimiento);
            _servicioClasificacion = new ServicioClasificacion(_unidadDeTrabajo.RepositorioClasificacion);
            _servicioWallet = new ServicioWallet(_unidadDeTrabajo.RepositorioWallet);
            _servicioTipoMovimiento = new ServicioTipoMovimiento(_unidadDeTrabajo.RepositorioTipoMovimiento);
            _movementToEdit = _servicioMovimiento.GetById(idMovement); 
        }

        private void FrmEditMovement_Load(object sender, EventArgs e)
        {
            ChargeData();
            SetMovementData();
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
        private void SetMovementData()
        {
            txtDescription.Text = _movementToEdit.descrip;
            txtMount.Text = _movementToEdit.mount.ToString();
            dateMovement.Value = _movementToEdit.date;
            cmbClasification.SelectedItem = _movementToEdit.Clasifications;
            cmbTypeOfMovement.SelectedItem = _movementToEdit.TypeOfMovements;
            cmbWallets.SelectedItem = _movementToEdit.Wallets;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FrmUtilities.IsConfirmedOperation())
                    return;
                if (!IsValidMovement())
                    return;
                UpdateMovement();//lanza un error al cambiar la clave foranea de las clasificaciones.
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show("Unespected error, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void UpdateMovement()
        {
            _servicioMovimiento.Update(_movementToEdit);
            MessageBox.Show("The movement was succesfull updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private bool IsValidMovement()
        {
            Movements movement = new Movements();
            movement.Clasifications = (Clasifications)cmbClasification.SelectedItem;
            movement.Wallets = (Wallets)cmbWallets.SelectedItem;
            movement.mount = Convert.ToDecimal(txtMount.Text);
            movement.descrip = txtDescription.Text;
            movement.TypeOfMovements = (TypeOfMovements)cmbTypeOfMovement.SelectedItem;
            movement.date = DateTime.Now;
            _servicioMovimiento.ValidarMovimiento(movement);
            _movementToEdit = movement;
            return true;
        }
    }
}
