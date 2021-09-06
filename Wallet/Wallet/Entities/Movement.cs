using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wallet.Entities
{
    internal class Movement
    {
        private Clasification clasification;
        private String description;
        private Boolean isDebt;
        private decimal mount;
        private Person person;
        private TypeMovement typeMovement;
    }
}