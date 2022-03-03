using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Queries.Response
{
    public class GetByIdMusteriResponse
    {
        public long MusteriNo { get; set; }//uniqe
        public string Ad { get; set; }
        public string Soyad { get; set; } 
        public string TCKN { get; set; }
        public string VKN { get; set; }
        public string PasaportNo { get; set; }
        public string BabaAdi { get; set; }
        public string AnaAdi { get; set; }
        public string DogumYeri { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string MedeniHali { get; set; }
        public int MusteriTipi { get; set; }
        public int? TakipSubeKodu { get; set; }
        public string TakipSubeAdi { get; set; }
    }
}
