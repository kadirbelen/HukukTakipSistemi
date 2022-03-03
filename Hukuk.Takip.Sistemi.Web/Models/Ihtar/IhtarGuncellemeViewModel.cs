using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.Web.Models.Ihtar
{
    public class IhtarGuncellemeViewModel
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public string Musteri { get; set; }
        public string NoterAd { get; set; }
        public string TakipHesapNo { get; set; }
        public DateTime IhtarTarihi { get; set; }
        public DateTime? IhtarTebligTarihi { get; set; }
        public decimal? IhtarTutar { get; set; }
        public int? YevmiyeNo { get; set; }
    }
}
