using MVVMFirma.Helper;
using MVVMFirma.Models.Entieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Windows.Input;


namespace MVVMFirma.ViewModels
{
    public class NowaFakturaViewModel : WorkspaceViewModel
    {
        #region DB
        private BazaCRMEntities BazaCRMEntities;

        #endregion
        #region Item
        private Faktury faktury;

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
                if (SaveAndCloseCommand == null)
                    _SaveAndCloseCommand = new BaseCommand(() => SaveAndClose());
                return _SaveAndCloseCommand;
            }
        }
        #endregion
        #region Constructor
        public NowaFakturaViewModel()
        {
            
        }
        #region Properties

        public string 
        #endregion
        #endregion
        #region Helpers
        public void Save()
        {
            BazaCRMEntities.Faktury.Add(faktury);
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
