using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using MVVMFirma.Models.Entieties;
using MVVMFirma.Helper;
using System.Windows.Input;
using System.Net;
using System.Runtime.CompilerServices;

namespace MVVMFirma.ViewModels
{
    public class WszystkieProjektyViewModel : WorkspaceViewModel
    {
        #region DB
        private readonly BazaCRMEntities bazaCRMEntities;
        #endregion
        #region LoadCommand
        private BaseCommand _LoadCommand;
        public ICommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                    _LoadCommand = new BaseCommand(() => load());
                return _LoadCommand;
            }
        }
        #endregion
        #region List
        private ObservableCollection<Projekty> _List;

        public ObservableCollection<Projekty> List
        {
            get 
            {
                if (_List == null)
                    load();
                return _List;
            }
            set 
            {
                _List = value;
                OnPropertyChanged(()=>List);
            }
        }
        #endregion
        #region Constructor
        public WszystkieProjektyViewModel()
        {
            base.DisplayName = "Projekty";
            bazaCRMEntities = new BazaCRMEntities();
        }
       
        #endregion
        #region Helpers
        private void load() 
        {
            List=new ObservableCollection<Projekty>
                (
                    bazaCRMEntities.Projekty.ToList()
                );
        }
        #endregion

    }
}