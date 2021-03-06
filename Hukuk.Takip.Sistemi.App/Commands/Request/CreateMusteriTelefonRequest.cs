using Hukuk.Takip.Sistemi.App.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Commands.Request
{
    public class CreateMusteriTelefonRequest:IRequest<CreateMusteriTelefonResponse>
    {

        public int MusteriId { get; set; }
        public string TelefonTİpi { get; set; }
        public string TelefonNo { get; set; }
        public DateTime GuncellenmeTarihi { get; set; }
        public string Guncelleyen { get; set; }
        public bool SilindiMi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public string EkleyenKisi { get; set; }
    }
}
