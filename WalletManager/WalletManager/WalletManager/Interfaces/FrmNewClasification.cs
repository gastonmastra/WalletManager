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
    public partial class FrmNewClasification : FrmBase
    {
        private UnidadDeTrabajo _unidadDeTrabajo;
        private Principal _principal;
        private Clasifications _newClasification;
        private ServicioClasificacion _servicioClasificacion;
        public FrmNewClasification(UnidadDeTrabajo unidadDeTrabajo, Principal principal)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
            _principal = principal;
            _servicioClasificacion = new ServicioClasificacion(_unidadDeTrabajo.RepositorioClasificacion);
            InitializeComponent();
        }

        private void bntConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FrmUtilities.IsConfirmedOperation())
                    return;
                if (!IsValidClasification())
                    return;
                RegisterClasification();
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

        private void RegisterClasification()
        {
            bool insertMovement = _servicioClasificacion.Insert(_newClasification);
            if (!insertMovement)
            {
                MessageBox.Show("Ocurred an error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("The clasification was succesfull registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private bool IsValidClasification()
        {
            Clasifications newClasification = new Clasifications();
            newClasification.name = txtName.Text;
            newClasification.description = txtDescription.Text;
            _servicioClasificacion.ValidarClasificacion(newClasification);
            _newClasification = newClasification;
            return true;
        }
    }
}
