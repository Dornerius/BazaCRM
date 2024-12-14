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
    
    public partial class Klienci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Klienci()
        {
            this.Faktury = new HashSet<Faktury>();
            this.InterakcjeKlientow = new HashSet<InterakcjeKlientow>();
            this.Projekty1 = new HashSet<Projekty>();
            this.RelacjeMiedzyKlientami = new HashSet<RelacjeMiedzyKlientami>();
            this.RelacjeMiedzyKlientami1 = new HashSet<RelacjeMiedzyKlientami>();
            this.Transakcje = new HashSet<Transakcje>();
            this.Uzytkownicy1 = new HashSet<Uzytkownicy>();
            this.ZapytaniaKlientow = new HashSet<ZapytaniaKlientow>();
            this.Zespoly1 = new HashSet<Zespoly>();
        }
    
        public int IdKlienta { get; set; }
        public Nullable<int> IdUzytkownika { get; set; }
        public Nullable<int> IdZespolu { get; set; }
        public Nullable<int> IdProjektu { get; set; }
        public string NazwaFirmy { get; set; }
        public string OsobowoscPrawna { get; set; }
        public string Email { get; set; }
        public Nullable<int> telefon { get; set; }
        public string Wojewodztwo { get; set; }
        public string KodPocztowy { get; set; }
        public string Powiat { get; set; }
        public string Miejscowosc { get; set; }
        public string Ulica { get; set; }
        public string NrBudynku { get; set; }
        public string NrLokalu { get; set; }
        public string Poczta { get; set; }
        public Nullable<int> Regon { get; set; }
        public Nullable<int> Nip { get; set; }
        public Nullable<int> Krs { get; set; }
        public string MediaSpolecznosciowe { get; set; }
        public string DodatkoweInformacje { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Faktury> Faktury { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InterakcjeKlientow> InterakcjeKlientow { get; set; }
        public virtual Projekty Projekty { get; set; }
        public virtual Uzytkownicy Uzytkownicy { get; set; }
        public virtual Zespoly Zespoly { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projekty> Projekty1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelacjeMiedzyKlientami> RelacjeMiedzyKlientami { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelacjeMiedzyKlientami> RelacjeMiedzyKlientami1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transakcje> Transakcje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uzytkownicy> Uzytkownicy1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZapytaniaKlientow> ZapytaniaKlientow { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zespoly> Zespoly1 { get; set; }
    }
}
