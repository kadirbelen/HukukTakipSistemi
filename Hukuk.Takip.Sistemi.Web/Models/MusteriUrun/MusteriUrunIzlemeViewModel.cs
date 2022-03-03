using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.Web.Models.MusteriUrun
{
    public class MusteriUrunIzlemeViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Müşteri")]
        public int MusteriId { get; set; }

        [Display(Name = "Müşteri Ürün")]
        public int MusteriUrunId { get; set; }

        [Display(Name = "Müşteri No")]
        public long MusteriNo { get; set; }

        [Display(Name = "Ad")]
        public string Ad { get; set; }

        [Display(Name = "Soyad")]
        public string Soyad { get; set; }

        [Display(Name = "Ürün Ad")]
        public string UrunAd { get; set; }

        [Display(Name = "Ürün Tip")]
        public string UrunTipKod { get; set; }

        [Display(Name = "Takip Şube")]
        public int TakipSubeKod { get; set; }

        [Display(Name = "Takip Şube Ad")]
        public string TakipSubeAd { get; set; }

        [Display(Name = "Takip Hesap No")]
        public string TakipHesapNo { get; set; }

        [Display(Name = "Takip Tutar")]
        public decimal TakipTutar { get; set; }

        [Display(Name = "Para Birimi")]
        public string ParaBirimi { get; set; }

        [Display(Name = "Takip Tarihi")]
        public DateTime TakipTarihi { get; set; }

        [Display(Name = "Masraf Şube Kodu")]
        public int MasrafSubeKodu { get; set; }

        [Display(Name = "Masraf Şube Ad")]
        public string MasrafSubeAd { get; set; }

        [Display(Name = "Masraf Hesap")]
        public string MasrafHesap { get; set; }

        [Display(Name = "Masraf Tutar")]
        public decimal MasrafTutar { get; set; }

        [Display(Name = "Faiz Şube Kodu")]
        public int FaizSubeKod { get; set; }

        [Display(Name = "Faiz Şube Ad")]
        public string FaizSubeAd { get; set; }

        [Display(Name = "Faiz Hesap")]
        public string FaizHesap { get; set; }

        [Display(Name = "Faiz Tutar")]
        public decimal FaizTutar { get; set; }

        [Display(Name = "Erteleme Var Mı")]
        public bool ErtelemeVarMi { get; set; }

        [Display(Name = "Ön Erteleme")]
        public string OnErteleme { get; set; }

        [Display(Name = "Ürün Durumu")]
        public string UrunDurumu { get; set; }


    }
}
