using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Queries.Response
{
    public class GetAllMusteriAdresResponse
    {
        public int MusteriId { get; set; }//fk
        public string AdresTipi { get; set; }
        public string Adres { get; set; }
        public string Mahalle { get; set; }
        public string Ilce { get; set; }
        public string Sehir { get; set; }
        public string PostaKodu { get; set; }
    }
}
