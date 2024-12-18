using MVVMFirma.Helper;
using MVVMFirma.Models.Entieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{

    public class NowyProjektViewModel : WorkspaceViewModel
    {

        #region DB
        private BazaCRMEntities BazaCRMEntities;

        #endregion
        #region Item
        private Projekty Projekty;

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
        public NowyProjektViewModel()
        {
            base.DisplayName = "Nowy Projekt";
            BazaCRMEntities = new BazaCRMEntities();
            Projekty = new Projekty();
        }
        #endregion
        #region Properties
        public string NazwaProjektu
        {
            get
            {
                return Projekty.NazwaProjektu;
            }
            set
            {
                Projekty.NazwaProjektu = value;
                OnPropertyChanged(() => NazwaProjektu);
            }
        }
        public DateTime? DataRozpoczecia
        {
            get
            {
                return Projekty.DataRozpoczecia;
            }
            set
            {
                Projekty.DataRozpoczecia = value;
                OnPropertyChanged(() => DataRozpoczecia);
            }
        }
        public DateTime? DataZakonczenia
                    {
            get
            {
                return Projekty.DataZakonczenia;
                           
            }
            set
            {
                Projekty.DataZakonczenia = value;
                OnPropertyChanged(() => DataZakonczenia);
            }
        }
        
        #endregion

        #region Helpers

        public void Save()
        {
            BazaCRMEntities.Projekty.Add(Projekty);
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
