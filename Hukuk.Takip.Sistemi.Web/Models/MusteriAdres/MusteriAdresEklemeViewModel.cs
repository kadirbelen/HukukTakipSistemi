using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.Web.Models.MusteriAdres
{
    public class MusteriAdresEklemeViewModel
    {
        public int MusteriId { get; set; }
        public string Musteri { get; set; }
        public string AdresTipi { get; set; }
        public string Adres { get; set; }
        public string Mahalle { get; set; }
        public string Ilce { get; set; }
        public string Sehir { get; set; }
        public string PostaKodu { get; set; }
    }
}
