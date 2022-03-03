using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.Web.Models.AvukatAtananUrun
{
    public class AvukatAtananUrunEklemeViewModel
    {
        public int MusteriId { get; set; }
        public int MusteriUrunId { get; set; }
        public int AvukatId { get; set; }
        public DateTime AtamaTarihi { get; set; }
        public DateTime KabulTarihi { get; set; }
        public DateTime DelegasyonTarihi { get; set; }
        public string Durum { get; set; } 

    }
}
