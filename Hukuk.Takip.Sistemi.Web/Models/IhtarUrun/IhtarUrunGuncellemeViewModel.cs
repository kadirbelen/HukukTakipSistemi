using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.Web.Models.IhtarUrun
{
    public class IhtarUrunGuncellemeViewModel
    {
        public int Id { get; set; }
        public int IhtarId { get; set; }
        public string Ihtar { get; set; }
        public int MusteriUrunId { get; set; }
        public string MusteriUrun { get; set; }
        public decimal? IhtarTutar { get; set; }
        public decimal? AnaParaTutar { get; set; }
        public decimal? FaizTutar { get; set; }
        public decimal? KomisyonTutar { get; set; }
        public decimal? ToplamBorc { get; set; }
        //public DateTime? GuncellenmeTarihi { get; set; }
        //public string Guncelleyen { get; set; }
        //public bool SilindiMi { get; set; }
        //public DateTime? EklenmeTarihi { get; set; }
        //public string EkleyenKisi { get; set; }
    }
}
