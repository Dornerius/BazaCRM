using MVVMFirma.Helper;
using MVVMFirma.Models.Entieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{

    public class NowyKlientViewModel : WorkspaceViewModel
    {
        
        #region DB
        private BazaCRMEntities BazaCRMEntities;

        #endregion
        #region Item
        private Klienci klienci;

        #endregion
        #region Command
        private BaseCommand _SaveCommand;          
    
        public ICommand SaveCommand
        {
            get
            {
                if (_SaveCommand == null)
                    _SaveCommand = new BaseCommand(() => save());
                return _SaveCommand;
            }
        }
        private BaseCommand _SaveAndCloseCommand;

        public ICommand SaveAndCloseCommand
        {

            get 
            { 
                if (_SaveAndCloseCommand == null)
                    _SaveAndCloseCommand = new BaseCommand(() => SaveAndClose());
                return _SaveAndCloseCommand; 
            } 
        }
        #endregion
        #region Constructor
        public NowyKlientViewModel()
        {
            base.DisplayName = "Dodaj Klienta";
            BazaCRMEntities = new BazaCRMEntities();
            klienci = new Klienci();
        }
        #endregion
        #region Properties
        public string NazwaFirmy
        {
            get
            {
                return klienci.NazwaFirmy;
            }
            set
            {
                klienci.NazwaFirmy = value;
                OnPropertyChanged(() => NazwaFirmy);
            }
        }
        public string OsobowoscPrawna
        {
            get
            {
                return klienci.OsobowoscPrawna;
            }
            set
            {
                klienci.OsobowoscPrawna = value;
                OnPropertyChanged(() => OsobowoscPrawna);
            }
        }
        public string Email
        {
            get
            {
                return klienci.Email;
            }
            set
            {
                klienci.Email = value;
                OnPropertyChanged(() => Email);
            }
        }
        public int? telefon
        {
            get
            {
                return klienci.telefon;
            }
            set
            {
                klienci.telefon = value;
                OnPropertyChanged(() => telefon);
            }
        }
        public string Wojewodztwo
        {
            get
            {
                return klienci.Wojewodztwo;
            }
            set
            {
                klienci.Wojewodztwo = value;
                OnPropertyChanged(() => Wojewodztwo);
            }
        }
        public string KodPocztowy
        {
            get
            {
                return klienci.KodPocztowy;
            }
            set
            {
                klienci.KodPocztowy = value;
                OnPropertyChanged(() => KodPocztowy);
            }
        }
        public string Powiat
        {
            get
            {
                return klienci.Powiat;
            }
            set
            {
                klienci.Powiat = value;
                OnPropertyChanged(() => Powiat);
            }
        }
        public string Miejscowosc
        {
            get
            {
                return klienci.Miejscowosc;
            }
            set
            {
                klienci.Miejscowosc = value;
                OnPropertyChanged(() => Miejscowosc);
            }
        }
        public string Ulica
        {
            get
            {
                return klienci.Ulica;
            }
            set
            {
                klienci.Ulica = value;
                OnPropertyChanged(() => Ulica);
            }
        }
        public string NrBudynku
        {
            get
            {
                return klienci.NrBudynku;
            }
            set
            {
                klienci.NrBudynku = value;
                OnPropertyChanged(() => NrBudynku);
            }
        }
        public string NrLokalu
        {
            get
            {
                return klienci.NrLokalu;
            }
            set
            {
                klienci.NrLokalu = value;
                OnPropertyChanged(() => NrLokalu);
            }
        }
        public string Poczta
        {
            get
            {
                return klienci.Poczta;
            }
            set
            {
                klienci.Poczta = value;
                OnPropertyChanged(() => Poczta);
            }
        }
        public int? Regon
        {
            get
            {
                return klienci.Regon;
            }
            set
            {
                klienci.Regon = value;
                OnPropertyChanged(() => Regon);
            }
        }
        public int? Nip
        {
            get
            {
                return klienci.Nip;
            }
            set
            {
                klienci.Nip = value;
                OnPropertyChanged(() => Nip);
            }
        }
        public int? Krs
        {
            get
            {
                return klienci.Krs;
            }
            set
            {
                klienci.Krs = value;
                OnPropertyChanged(() => Krs);
            }
        }
        public string MediaSpolecznosciowe
        {
            get
            {
                return klienci.MediaSpolecznosciowe;
            }
            set
            {
                klienci.MediaSpolecznosciowe = value;
                OnPropertyChanged(() => MediaSpolecznosciowe);
            }
        }
        public string DodatkoweInformacje
        {
            get
            {
                return klienci.DodatkoweInformacje;
            }
            set
            {
                klienci.DodatkoweInformacje = value;
                OnPropertyChanged(() => DodatkoweInformacje);
            }
        }
        #endregion

        #region Helpers

        public void Save()
        {
            BazaCRMEntities.Klienci.Add(klienci);
            BazaCRMEntities.SaveChanges();
        }
        public void SaveAndClose()
        {
            Save();
            base.OnRequestClose();
        }
        public void save()
        {
            Save();
        }

      
        #endregion

    }
}
