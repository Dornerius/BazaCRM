using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using MVVMFirma.Models.Entieties;
using MVVMFirma.Helper;
using System.Windows.Input;
using System.Net;
using MVVMFirma.Models.EntitiesForView;

namespace MVVMFirma.ViewModels
{
    public class WszystkieFakturyViewModel : WszystkieViewModel<FakturyForAllView>
    {


        #region Constructor
        public WszystkieFakturyViewModel()
            : base("Faktury")
            {
            }
        #endregion
        #region Helpers

        public override void Load()
        {
            List = new ObservableCollection<FakturyForAllView>
                (
                    from faktury in bazaCRMEntities.Faktury
                    select new FakturyForAllView
                    {
                        IdFaktury=faktury.IdFaktury,
                        NrFaktury=faktury.NrFaktury,
                        DataWystawienia=faktury.DataWystawienia,
                        KlienciNazwaFirmy=faktury.Klienci.NazwaFirmy,
                        ProduktyUslugiNazwa=faktury.ProduktyUslugi.Nazwa,
                        ProduktyUslugiCena = faktury.ProduktyUslugi.Cena,
                        IloscSztuk=faktury.IloscSztuk,
                        KwotaNetto=faktury.KwotaNetto,
                        Podatek=faktury.Podatek,
                        KwotaBrutto=faktury.KwotaBrutto,
                        RodzajPlatnosciNazwaRodzajuPlatnosci=faktury.RodzajePlatnosci.NazwaRodzajuPlatnosci,
                        StatusFakturyNazwaStatusu=faktury.StatusFaktury.NazwaStatusu,

                    }
                );
        }

        #endregion

    }
}