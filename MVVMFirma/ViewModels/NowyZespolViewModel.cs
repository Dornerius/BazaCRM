using MVVMFirma.Helper;
using MVVMFirma.Models.Entieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{

    public class NowyZespolViewModel : WorkspaceViewModel
    {

        #region DB
        private BazaCRMEntities BazaCRMEntities;

        #endregion
        #region Item
        private Zespoly Zespoly;

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
        public NowyZespolViewModel()
        {
            base.DisplayName = "Dodaj Zespół";
            BazaCRMEntities = new BazaCRMEntities();
            Zespoly = new Zespoly();
        }
        #endregion
        #region Properties
        public string Nazwa
        {
            get
            {
                return Zespoly.Nazwa;
            }
            set
            {
                Zespoly.Nazwa = value;
                OnPropertyChanged(() => Zespoly);
            }
        }
        public string Opis
        {
            get
            {
                return Zespoly.Opis;
            }
            set
            {
                Zespoly.Opis = value;
                OnPropertyChanged(() => Zespoly);
            }
        }
       
        #endregion

        #region Helpers

        public void Save()
        {
            BazaCRMEntities.Zespoly.Add(Zespoly);
            BazaCRMEntities.SaveChanges();
        }
        public void SaveAndClose()
        {
            Save();
            base.OnRequestClose();            
        }

        public  void save()
        {
            Save();
        }
                #endregion

    }
}
