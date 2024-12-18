using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using MVVMFirma.Models.Entieties;
using MVVMFirma.Helper;
using System.Windows.Input;
using System.Net;

namespace MVVMFirma.ViewModels
{
    public class WszystkieTransakcjeViewModel : WszystkieViewModel<Transakcje>
    {


        #region Constructor
        public WszystkieTransakcjeViewModel()
            : base("Transakcje")
            {
            }
        #endregion
        #region Helpers

        public override void Load()
        {
            List = new ObservableCollection<Transakcje>
                (
                    bazaCRMEntities.Transakcje.ToList()
                );
        }

        #endregion

    }
}