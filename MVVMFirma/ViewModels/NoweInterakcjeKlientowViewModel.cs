using MVVMFirma.Helper;
using MVVMFirma.Models.Entieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{

    public class NoweInterakcjeKlientowViewModel : WorkspaceViewModel
    {

        #region DB
        private BazaCRMEntities BazaCRMEntities;

        #endregion
        #region Item
        private InterakcjeKlientow InterakcjeKlientow;

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
        public NoweInterakcjeKlientowViewModel()
        {
            base.DisplayName = "Dodaj Interakcje Klientów";
            BazaCRMEntities = new BazaCRMEntities();
            InterakcjeKlientow = new  InterakcjeKlientow();
        }
        #endregion
        #region Properties
        public int? Klient
        {
            get
            {
                return InterakcjeKlientow.IdKlienta;
            }
            set
            {
                Klient = value;
                OnPropertyChanged(() => Klient);
            }
        }
        public int? TypInterakcji
        {
            get
            {
                return InterakcjeKlientow.IdTypuInterakcji;
            }
            set
            {
                InterakcjeKlientow.IdTypuInterakcji = value;
                OnPropertyChanged(() => TypInterakcji);
            }
        }
        public DateTime? Data
                    {
            get
            {
                return InterakcjeKlientow.Data;
                           
            }
            set
            {
                InterakcjeKlientow.Data = value;
                OnPropertyChanged(() => Data);
            }
        }
        public string Opis
        {
            get
            {
                return InterakcjeKlientow.Opis;

            }
            set
            {
                InterakcjeKlientow.Opis = value;
                OnPropertyChanged(() => Opis);
            }
        }

        #endregion

        #region Helpers

        public void Save()
        {
            BazaCRMEntities.InterakcjeKlientow.Add(InterakcjeKlientow);
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
