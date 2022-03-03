using Hukuk.Takip.Sistemi.Web.Models.AvukatAtananUrun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.Web.Models.IcraTakip
{
    public class IcraTakipEklemeViewModel
    {
        public int? MusteriId { get; set; }//fk
        public string Musteri { get; set; }
        public int? AvukatId { get; set; }
        public string Avukat { get; set; }
        public int AvukatAtananUrunlerId { get; set; }
        public string AvukatAtananUrun { get; set; }
        public string TakipTipi { get; set; }
        public string IcraDairesi { get; set; }
        public DateTime TakipTarihi { get; set; }
        public string DosyaNo { get; set; }

        

    }
}
