using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Queries.Response
{
    public class GetIcraTakiplerResponse
    {
        public int Id { get; set; }
        public long MusteriNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string AvukatAd { get; set; }
        public string AvukatSoyad { get; set; }
        public string AvukatTip { get; set; }
        public string AvukatTelNo { get; set; }
        public DateTime KabulTarihi { get; set; }
        public DateTime DelegasyonTarihi { get; set; }
        public string IcraDairesi { get; set; }
        public DateTime TakipTarihi { get; set; }
        public string Aciklama { get; set; }
        public string DosyaNo { get; set; }
    }
}
