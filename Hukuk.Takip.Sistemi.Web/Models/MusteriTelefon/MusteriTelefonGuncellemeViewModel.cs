using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.Web.Models.MusteriTelefon
{
    public class MusteriTelefonGuncellemeViewModel
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public string Musteri { get; set; }
        public string TelefonTİpi { get; set; }
        public string TelefonNo { get; set; }
    }
}
