using Hukuk.Takip.Sistemi.App.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Commands.Request
{
    public class CreateAvukatAtananUrunRequest:IRequest<CreateAvukatAtananUrunResponse>
    {
        public int MusteriId { get; set; }
        public int MusteriUrunId { get; set; }
        public int AvukatId { get; set; }
        public DateTime AtamaTarihi { get; set; }
        public DateTime KabulTarihi { get; set; }
        public DateTime DelegasyonTarihi { get; set; }
        public string Durum { get; set; }
        public DateTime? GuncellenmeTarihi { get; set; }
        public string Guncelleyen { get; set; }
        public bool SilindiMi { get; set; }
        public DateTime? EklenmeTarihi { get; set; }
        public string EkleyenKisi { get; set; }
    }
}
