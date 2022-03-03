using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.Entities.Dto
{
    public class IhtarDto
    {
        public int Id { get; set; }
        public long MusteriNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string NoterAd { get; set; }
        public string TakipHesapNo { get; set; }
        public DateTime IhtarTarihi { get; set; }
        public DateTime? IhtarTebligTarihi { get; set; }
        public decimal? IhtarTutar { get; set; }
        public int? YevmiyeNo { get; set; }

    }
}
