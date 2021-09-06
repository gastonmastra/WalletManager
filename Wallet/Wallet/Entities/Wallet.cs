using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet.Entities
{
    class Wallet
    {
        private string name;
        private List<Movement> movements;
        private List<FixedExpense> fixedExpenses;
    }
}
