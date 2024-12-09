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
    public class WszystkieTowaryViewModel : WszystkieViewModel<Klienci>
    {
        

        #region Constructor
        public WszystkieTowaryViewModel()
            :base("Klienci")
            { 
            }
        #endregion
        #region Helpers

        public override void Load()
        { 
            List = new ObservableCollection<Klienci>
                (
                    bazaCRMEntities.Klienci.ToList()
                );
        }

        #endregion

    }
}