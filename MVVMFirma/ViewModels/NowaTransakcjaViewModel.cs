using MVVMFirma.Helper;
using MVVMFirma.Models.Entieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{

    public class NowaTransakcjaViewModel : WorkspaceViewModel
    {

        #region DB
        private BazaCRMEntities BazaCRMEntities;

        #endregion
        #region Item
        private Transakcje Transakcje;

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
        public NowaTransakcjaViewModel()
        {
            base.DisplayName = "Nowa Transakcja";
            BazaCRMEntities = new BazaCRMEntities();
            Transakcje = new Transakcje();
        }
        #endregion
        #region Properties
        public string RodzajTransakcji
        {
            get
            {
                return Transakcje.RodzajTransakcji;
            }
            set
            {
                Transakcje.RodzajTransakcji = value;
                OnPropertyChanged(() => RodzajTransakcji);
            }
        }
        public DateTime? DataTransakcji
        {
            get
            {
                return Transakcje.DataTransakcji;
            }
            set
            {
                Transakcje.DataTransakcji = value;
                OnPropertyChanged(() => DataTransakcji);
            }
        }
        public Decimal? KwotaTransakcji
                    {
            get
            {
                return Transakcje.KwotaTransakcji;
                           
            }
            set
            {
                Transakcje.KwotaTransakcji = value;
                OnPropertyChanged(() => KwotaTransakcji);
            }
        }
        public string DodatkoweInformacje
        {
            get
            {
                return Transakcje.DodatkoweInformacje;
            }
            set
            {
                Transakcje.DodatkoweInformacje = value;
                OnPropertyChanged(() => DodatkoweInformacje);
            }
        }

        #endregion

        #region Helpers

        public void Save()
        {
            BazaCRMEntities.Transakcje.Add(Transakcje);
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
