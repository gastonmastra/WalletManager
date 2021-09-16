//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wallet.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movement()
        {
            this.Wallets = new HashSet<Wallet>();
        }
    
        public int id_movement { get; set; }
        public string descrip { get; set; }
        public string isDebt { get; set; }
        public Nullable<int> idDeudor { get; set; }
        public decimal mount { get; set; }
        public int id_typeMovement { get; set; }
        public int id_clasification { get; set; }
    
        public virtual Clasification Clasification { get; set; }
        public virtual Person Person { get; set; }
        public virtual TypeOfMovement TypeOfMovement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wallet> Wallets { get; set; }
    }
}