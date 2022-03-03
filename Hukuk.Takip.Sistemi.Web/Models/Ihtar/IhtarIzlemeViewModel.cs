using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.Web.Models.Ihtar
{
    public class IhtarIzlemeViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Müşteri No")]
        public long MusteriNo { get; set; }
        [Display(Name = "Ad")]
        public string Ad { get; set; }
        [Display(Name = "Soyad")]
        public string Soyad { get; set; }
        [Display(Name = "Noter Ad")]
        public string NoterAd { get; set; }
        [Display(Name = "Takip Hesap No")]
        public string TakipHesapNo { get; set; }
        [Display(Name = "İhtar Tarihi")]
        public DateTime IhtarTarihi { get; set; }
        [Display(Name = "İhtar Tebliğ Tarihi")]
        public DateTime? IhtarTebligTarihi { get; set; }
        [Display(Name = "İhtar Tutar")]
        public decimal? IhtarTutar { get; set; }
        [Display(Name = "Yevmiye No")]
        public int? YevmiyeNo { get; set; }
    }
}
