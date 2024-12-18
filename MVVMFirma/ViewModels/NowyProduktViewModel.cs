using MVVMFirma.Helper;
using MVVMFirma.Models.Entieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MVVMFirma.ViewModels
{

    public class NowyProduktViewModel : WorkspaceViewModel
    {

        #region DB
        private BazaCRMEntities BazaCRMEntities;

        #endregion
        #region Item
        private ProduktyUslugi ProduktyUslugi;

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
        public NowyProduktViewModel()
        {
            base.DisplayName = "Dodaj Produkt, Usługę";
            BazaCRMEntities = new BazaCRMEntities();
            ProduktyUslugi = new ProduktyUslugi();
        }
        #endregion
        #region Properties
        public string Nazwa
        {
            get
            {
                return ProduktyUslugi.Nazwa;
            }
            set
            {
                ProduktyUslugi.Nazwa = value;
                OnPropertyChanged(() => Nazwa);
            }
        }
        public string Opis
        {
            get
            {
                return ProduktyUslugi.Opis;
            }
            set
            {
                ProduktyUslugi.Opis = value;
                OnPropertyChanged(() => ProduktyUslugi);
            }
        }
        public decimal? Cena
        {
            get
            {
                return ProduktyUslugi.Cena;
                           
            }
            set
            {
                ProduktyUslugi.Cena = value;
                OnPropertyChanged(() => Cena);
            }
        }
        
        #endregion

        #region Helpers

        public void Save()
        {
            BazaCRMEntities.ProduktyUslugi.Add(ProduktyUslugi);
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
