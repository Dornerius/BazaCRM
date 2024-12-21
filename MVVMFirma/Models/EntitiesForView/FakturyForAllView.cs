using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFirma.Models.EntitiesForView
{
    public class FakturyForAllView
    {
        public int IdFaktury {  get; set; }

        public string NrFaktury {  get; set; }
        
        public DateTime? DataWystawienia { get; set; }

        public string KlienciNazwaFirmy { get; set; }

        public string ProduktyUslugiNazwa { get; set; }

        public decimal? ProduktyUslugiCena { get; set; }

        public int? IloscSztuk {  get; set; }

        public decimal? KwotaNetto { get; set; }

        public  decimal? Podatek {  get; set; }

        public decimal? KwotaBrutto { get; set; }

        public string RodzajPlatnosciNazwaRodzajuPlatnosci {  get; set; }

        public string StatusFakturyNazwaStatusu { get; set; }
    }
}
