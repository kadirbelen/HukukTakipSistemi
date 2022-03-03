using Hukuk.Takip.Sistemi.App.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Commands.Request
{
    public class UpdateMusteriTelefonRequest:IRequest<UpdateMusteriTelefonResponse>
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public string TelefonTİpi { get; set; }
        public string TelefonNo { get; set; }
    }
}
