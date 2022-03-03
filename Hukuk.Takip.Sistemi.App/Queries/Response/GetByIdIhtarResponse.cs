using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Queries.Response
{
    public class GetByIdIhtarResponse
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public string NoterAd { get; set; }
        public string TakipHesapNo { get; set; }
        public DateTime IhtarTarihi { get; set; }
        public DateTime? IhtarTebligTarihi { get; set; }
        public decimal? IhtarTutar { get; set; }
        public int? YevmiyeNo { get; set; }
    }
}
