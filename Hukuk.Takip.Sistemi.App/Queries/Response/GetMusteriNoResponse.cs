using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Queries.Response
{
    public class GetMusteriNoResponse
    {
        public long MusteriNo { get; set; }//uniqe
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        //public string VKN { get; set; }
        //public string BabaAdi { get; set; }
        //public string AnaAdi { get; set; }
        //public string DogumYeri { get; set; }
        //public DateTime DogumTarihi { get; set; }
        public int MusteriTipi { get; set; }
        //public int TakipSubeKodu { get; set; }
        //public string TakipSubeAdi { get; set; }

        public string Adres { get; set; }
        public string Mahalle { get; set; }
        public string Ilce { get; set; }
        public string Sehir { get; set; }

        public string TelefonTİpi { get; set; }
        public string TelefonNo { get; set; }

    }
}
