
using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.Entities.Dto
{
    public class IhtarUrunDto
    {

        public int Id { get; set; }
        public int IhtarId { get; set; }
        public decimal? IhtarTutar { get; set; }
        public decimal? AnaParaTutar { get; set; }
        public decimal? FaizTutar { get; set; }
        public decimal? KomisyonTutar { get; set; }
        public decimal? ToplamBorc { get; set; }
        public string UrunAd { get; set; }
        public string UrunTipKod { get; set; }
        public DateTime IhtarTarihi { get; set; }

        public DateTime? IhtarTebligTarihi { get; set; }
        public int? YevmiyeNo { get; set; }
    }
}
