using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.Entities.Dto
{
    public class AvukatAtananUrunDto
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int MusteriUrunId { get; set; }
        public long MusteriNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string UrunAd { get; set; }
        public string UrunTipKod { get; set; }
        public int TakipSubeKod { get; set; }
        public string TakipSubeAd { get; set; }
        public string TakipHesapNo { get; set; }
        public string AvukatAd { get; set; }
        public string AvukatSoyad { get; set; }
        public string AvukatTip { get; set; }
        public bool DosyaYetkisi { get; set; }
        public string AvukatTelNo { get; set; }
        public string Durum { get; set; }

    }
}
