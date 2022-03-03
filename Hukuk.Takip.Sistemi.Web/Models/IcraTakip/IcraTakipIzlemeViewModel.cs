using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.Web.Models.IcraTakip
{
    public class IcraTakipIzlemeViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Müşteri No")]
        public long MusteriNo { get; set; }

        [Display(Name = "Ad")]
        public string Ad { get; set; }

        [Display(Name = "Soyad")]
        public string Soyad { get; set; }

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

        [Display(Name = "Kabul Tarihi")]
        public DateTime KabulTarihi { get; set; }

        [Display(Name = "Delegasyon Tarihi")]
        public DateTime DelegasyonTarihi { get; set; }

        [Display(Name = "İcra Dairesi")]
        public string IcraDairesi { get; set; }

        [Display(Name = "Takip Tarihi")]
        public DateTime TakipTarihi { get; set; }

        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }

        [Display(Name = "Dosya No")]
        public string DosyaNo { get; set; }
    }
}
