using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Queries.Response
{
    public class GetByIdMusteriUrunResponse
    {
        public int Id { get; set; }
        public int? MusteriId { get; set; }
        public string UrunAd { get; set; }
        public string UrunTipKod { get; set; }
        public int TakipSubeKod { get; set; }
        public string TakipSubeAd { get; set; }
        public string TakipHesapNo { get; set; }
        public decimal TakipTutar { get; set; }
        public string ParaBirimi { get; set; }
        public DateTime TakipTarihi { get; set; }
        public int MasrafSubeKodu { get; set; }
        public string MasrafSubeAd { get; set; }
        public string MasrafHesap { get; set; }
        public decimal MasrafTutar { get; set; }
        public int FaizSubeKod { get; set; }
        public string FaizSubeAd { get; set; }
        public string FaizHesap { get; set; }
        public decimal FaizTutar { get; set; }
        public bool ErtelemeVarMi { get; set; }
        public string OnErteleme { get; set; }
        public string UrunDurumu { get; set; }
    }
}
