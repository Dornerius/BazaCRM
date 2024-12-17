using MVVMFirma.Helper;
using MVVMFirma.Models.Entieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{

    public class NowyUzytkownikViewModel : WorkspaceViewModel
    {

        #region DB
        private BazaCRMEntities BazaCRMEntities;

        #endregion
        #region Item
        private Uzytkownicy Uzytkownicy;

        #endregion
        #region Command
        private BaseCommand _SaveCommand;
        public ICommand SaveCommand
        {
            get
            {
                if (_SaveCommand == null)
                    _SaveCommand = new BaseCommand(() => Save());
                return _SaveCommand;
            }
        }
        #endregion
        #region Constructor
        public NowyUzytkownikViewModel()
        {
            base.DisplayName = "Dodaj Użytkownika";
            BazaCRMEntities = new BazaCRMEntities();
            Uzytkownicy = new Uzytkownicy();
        }
        #endregion
        #region Properties
        public string Imie
        {
            get
            {
                return Uzytkownicy.Imie;
            }
            set
            {
                Uzytkownicy.Imie = value;
                OnPropertyChanged(() => Imie);
            }
        }
        public string Nazwisko
        {
            get
            {
                return Uzytkownicy.Nazwisko;
            }
            set
            {
                Uzytkownicy.Nazwisko = value;
                OnPropertyChanged(() => Uzytkownicy);
            }
        }
        public string Email
        {
            get
            {
                return Uzytkownicy.Email;
            }
            set
            {
                Uzytkownicy.Email = value;
                OnPropertyChanged(() => Email);
            }
        }
        public int? Telefon
        {
            get
            {
                return Uzytkownicy.Telefon;
            }
            set
            {
                Uzytkownicy.Telefon = value;
                OnPropertyChanged(() => Telefon);
            }
        }
        public string Rola
        {
            get
            {
                return Uzytkownicy.Rola;
            }
            set
            {
                Uzytkownicy.Rola = value;
                OnPropertyChanged(() => Rola);
            }
        }
        
        #endregion

        #region Helpers

        public void Save()
        {
            BazaCRMEntities.Uzytkownicy.Add(Uzytkownicy);
            BazaCRMEntities.SaveChanges();
        }
        public void SaveAndClose()
        {
            Save();
            base.OnRequestClose();            
        }
                #endregion

    }
}
