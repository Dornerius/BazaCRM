using MVVMFirma.Helper;
using MVVMFirma.Models.Entieties;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
                if (_SaveAndCloseCommand == null)
                    _SaveAndCloseCommand = new BaseCommand(() => SaveAndClose());
                return _SaveAndCloseCommand;
            }
        }
        #endregion
        #region Constructor
        public NowaFakturaViewModel()
        {
            base.DisplayName = "Wystaw Fakturę";
            BazaCRMEntities = new BazaCRMEntities();
            faktury = new Faktury();
        }
        #region Properties

        public string NrFaktury
        {
            get
            {
                return faktury.NrFaktury;

            }

            set
            {
                faktury.NrFaktury = value;
                OnPropertyChanged(() => NrFaktury);
            }
        }

        public DateTime? DataWystawienia
        {
            get
            {
                return faktury.DataWystawienia;
            }

            set
            {
                faktury.DataWystawienia = value;
                OnPropertyChanged(() => DataWystawienia);
            }

        }

        public decimal? KwotaNetto
        {
            get
            {
                return faktury.KwotaNetto;
            }

            set
            {
                faktury.KwotaNetto = value;
                OnPropertyChanged(() => KwotaNetto);
            }

        }

        public decimal? KwotaBrutto
        {
            get
            {
                return faktury.KwotaBrutto;
            }

            set
            {
                faktury.KwotaBrutto = value;
                OnPropertyChanged(() => KwotaBrutto);
            }

        }

        public int? Podatek
        {
            get 
            {
                return faktury.Podatek;

            }

            set
            {
                faktury.Podatek = value;
                OnPropertyChanged(() => Podatek);
            }
        }

        public  int? IloscSztuk
        {
            get
            {
                return faktury.IloscSztuk;
            }

            set
            {
                faktury.IloscSztuk = value; 
                OnPropertyChanged(() => IloscSztuk);
            }
        }
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
