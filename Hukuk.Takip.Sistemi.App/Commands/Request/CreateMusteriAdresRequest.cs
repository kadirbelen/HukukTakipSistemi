using Hukuk.Takip.Sistemi.App.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Commands.Request
{
    public class CreateMusteriAdresRequest:IRequest<CreateMusteriAdresResponse>
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
