using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.Web.Models.IhtarUrun
{
    public class IhtarUrunIzlemeViewModel
    {

        public int IhtarId { get; set; }
        public int Id { get; set; }
        [Display(Name = "İhtar Tutar")]
        public decimal? IhtarTutar { get; set; }
        [Display(Name = "Anapara Tutar")]
        public decimal? AnaParaTutar { get; set; }
        [Display(Name = "Faiz Tutar")]
        public decimal? FaizTutar { get; set; }
        [Display(Name = "Komisyon Tutar")]
        public decimal? KomisyonTutar { get; set; }
        [Display(Name = "Toplam Borç")]
        public decimal? ToplamBorc { get; set; }
        [Display(Name = "Ürün Adı")]
        public string UrunAd { get; set; }
        [Display(Name = "Ürün Tip Kodu")]
        public string UrunTipKod { get; set; }

    }
}
