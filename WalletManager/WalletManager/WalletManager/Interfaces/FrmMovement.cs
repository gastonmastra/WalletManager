using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public FrmMovement(UnidadDeTrabajo unidadDeTrabajo, Principal principal)
        {
            InitializeComponent();
            _unidadDeTrabajo = unidadDeTrabajo;
            _principal = principal;
            _servicioMovimiento = new ServicioMovimiento(_unidadDeTrabajo.RepositorioMovimiento);
            _servicioWallet = new ServicioWallet(_unidadDeTrabajo.RepositorioWallet);
        }

        private void FrmMovement_Load(object sender, EventArgs e)
        {
            SearchMovements();
        }

        private void SearchMovements()
        {
            List<Movements> movements = _servicioMovimiento.ListMovements();
            ChargeDgvMovements();
            dgvMovements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ChargeDgvMovements()
        {
            dgvMovements.Rows.Clear();
            var wallets = _servicioWallet.ListWallets();
            foreach (var wallet in wallets)
            {
                decimal acum = 0;
                var movements = wallet.Movements.ToList();
                var orderedMovements = movements.OrderBy(X => X.date).ToList(); //ordeno la lista para que salga ordenada por fecha en dgv
                foreach (var movement in orderedMovements)
                {
                    if (movement.TypeOfMovements.id_typeMovement == (int)EnumTypeOfMovement.Ingresos)
                        acum += movement.mount;
                    else
                        acum -= movement.mount;
                    var fila = new string[]
                    {
                        movement.date.ToString(),
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
    }
}
