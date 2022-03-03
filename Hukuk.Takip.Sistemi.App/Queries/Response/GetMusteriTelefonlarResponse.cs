using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Queries.Response
{
    public class GetMusteriTelefonlarResponse
    {
        public int Id { get; set; }
        public long MusteriNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public string VKN { get; set; }
        public string BabaAdi { get; set; }
        public string AnaAdi { get; set; }
        public string DogumYeri { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string MusteriTipi { get; set; }
        public int? TakipSubeKodu { get; set; }
        public string TakipSubeAdi { get; set; }
        public string TelefonTİpi { get; set; }
        public string TelefonNo { get; set; }
    }
}
