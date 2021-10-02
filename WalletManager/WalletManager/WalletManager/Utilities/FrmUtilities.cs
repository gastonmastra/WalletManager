using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalletManager.Utilities
{
    public class FrmUtilities
    {
        public static void ChargeCombo(ref ComboBox cmb, BindingSource conector, string displayMember, string valueMember)
        {
            if (conector is null)
                throw new ArgumentNullException(nameof(conector));
            cmb.DataSource = conector;
            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
        }
    }
}
