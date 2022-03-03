using Hukuk.Takip.Sistemi.App.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Commands.Request
{
    public class CreateIcraTakipRequest:IRequest<CreateIcraTakipResponse>
    {
        public int? MusteriId { get; set; }
        public int? AvukatId { get; set; }
        public int AvukatAtananUrunlerId { get; set; }
        public string TakipTipi { get; set; }
        public string IcraDairesi { get; set; }
        public DateTime TakipTarihi { get; set; }
        public string Aciklama { get; set; }
        public string DosyaNo { get; set; }
        public DateTime? GuncellenmeTarihi { get; set; }
        public string Guncelleyen { get; set; }
        public bool SilindiMi { get; set; }
        public DateTime? EklenmeTarihi { get; set; }
        public string EkleyenKisi { get; set; }
    }
}
