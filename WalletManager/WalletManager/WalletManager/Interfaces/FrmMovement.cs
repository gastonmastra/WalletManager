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
using WalletManager.Enums;
using WalletManager.Model;
using WalletManager.Repository;
using WalletManager.Services;

namespace WalletManager.Interfaces
{
    public partial class FrmMovement : FrmBase
    {
        private UnidadDeTrabajo _unidadDeTrabajo;
        private Principal _principal;
        private ServicioMovimiento _servicioMovimiento;
        private ServicioWallet _servicioWallet;
        private List<Movements> _movements;
        public FrmMovement(UnidadDeTrabajo unidadDeTrabajo, Principal principal)
        {
            InitializeComponent();
            _unidadDeTrabajo = unidadDeTrabajo;
            _principal = principal;
            _servicioMovimiento = new ServicioMovimiento(_unidadDeTrabajo.RepositorioMovimiento);
            _servicioWallet = new ServicioWallet(_unidadDeTrabajo.RepositorioWallet);
            dgvMovements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FrmMovement_Load(object sender, EventArgs e)
        {
            SearchMovements();
        }

        private void SearchMovements()
        {
            _movements = _servicioMovimiento.ListMovements();
            ChargeDgvMovements(_movements);
        }

        private void ChargeDgvMovements(List<Movements> filteredMovements)
        {
            dgvMovements.Rows.Clear();
            var wallets = _servicioWallet.ListWallets();
            foreach (var wallet in wallets)
            {
                var orderedMovements = wallet.Movements.OrderBy(X => X.date).ToList(); //ordeno la lista para que salga ordenada por fecha en dgv
                decimal acum = 0;
                foreach (var movement in orderedMovements)
                {
                    if (movement.TypeOfMovements.id_typeMovement == (int)EnumTypeOfMovement.Ingresos)
                        acum += movement.mount;
                    else
                        acum -= movement.mount;
                    if (filteredMovements.Contains(movement))
                    {
                        var fila = new string[]
                        {
                            movement.id_movement.ToString(),
                            movement.date.ToString("yyyy-MM-dd HH:mm:ss"),
                            movement.mount.ToString(),
                            movement.descrip,
                            "-",
                            acum.ToString(),
                            wallet.walletName,
                        };
                        dgvMovements.Rows.Add(fila);
                    }

                }
            }
            this.dgvMovements.Sort(this.dgvMovements.Columns["Date"], ListSortDirection.Ascending);
        }

        private void btnNewMovement_Click(object sender, EventArgs e)
        {
            new FrmNewMovement(_unidadDeTrabajo, _principal).ShowDialog();
            SearchMovements();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var date1 = dateSince.Value;
            var date2 = dateUntil.Value;

            if (date1 > date2)
                MessageBox.Show("The date since can't be higher of the date until.");
            else
            {
                SearchMovements(date1, date2);
            }
        }

        private void SearchMovements(DateTime date1, DateTime date2)
        {
            List<Movements> filteredMovements = new List<Movements>();
            foreach (var movement in _movements)
            {
                if ((movement.date > date1) && (movement.date < date2))
                    filteredMovements.Add(movement);
            }
            ChargeDgvMovements(filteredMovements);
        }

        private void btnEditMovement_Click(object sender, EventArgs e)
        {
            int idMovement = Convert.ToInt32(dgvMovements.SelectedRows[0].Cells["Id"].Value);
            new FrmEditMovement(_unidadDeTrabajo, idMovement).ShowDialog();
            SearchMovements();
        }
    }
}
