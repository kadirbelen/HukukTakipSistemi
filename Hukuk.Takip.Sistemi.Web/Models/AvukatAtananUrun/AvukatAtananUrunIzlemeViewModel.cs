using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.Web.Models.AvukatAtananUrun
{
    public class AvukatAtananUrunIzlemeViewModel
    {
        public int Id { get; set; }

        public int MusteriId { get; set; }
        public int MusteriUrunId { get; set; }
        [Display(Name = "Müşteri No")]
        public long MusteriNo { get; set; }
        [Display(Name = "Ad")]
        public string Ad { get; set; }
        [Display(Name = "Soyad")]
        public string Soyad { get; set; }
        [Display(Name = "Ürün Ad")]
        public string UrunAd { get; set; }
        [Display(Name = "Ürün Tip Kodu")]
        public string UrunTipKod { get; set; }
        [Display(Name = "Takip Şube Kodu")]
        public int TakipSubeKod { get; set; }
        [Display(Name = "Takip Şube Ad")]
        public string TakipSubeAd { get; set; }
        [Display(Name = "Takip Hesap No")]
        public string TakipHesapNo { get; set; }

        [Display(Name = "Avukat Adı")]
        public string AvukatAd { get; set; }
        [Display(Name = "Avukat Soyadı")]
        public string AvukatSoyad { get; set; }
        [Display(Name = "Avukat Tip")]
        public string AvukatTip { get; set; }
        [Display(Name = "Dosya Yetkisi")]
        public bool DosyaYetkisi { get; set; }
        [Display(Name = "Avukat Telefon No")]
        public string AvukatTelNo { get; set; }
        [Display(Name = "Durum")]
        public string Durum { get; set; }
    }
}
