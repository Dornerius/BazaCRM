//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVVMFirma.Models.Entieties
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProduktyUslugi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProduktyUslugi()
        {
            this.Faktury = new HashSet<Faktury>();
            this.Zamowienia = new HashSet<Zamowienia>();
        }
    
        public int IdProduktuUslugi { get; set; }
        public string Nazawa { get; set; }
        public string Opis { get; set; }
        public Nullable<decimal> Cena { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Faktury> Faktury { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamowienia> Zamowienia { get; set; }
    }
}
