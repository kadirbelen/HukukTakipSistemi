using Hukuk.Takip.Sistemi.App.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Commands.Request
{
    public class UpdateAvukatAtananUrunRequest:IRequest<UpdateAvukatAtananUrunResponse>
    {
        public int Id { get; set; }
        public string Durum { get; set; }
        public DateTime KabulTarihi { get; set; }
        public DateTime DelegasyonTarihi { get; set; }


    }
}
