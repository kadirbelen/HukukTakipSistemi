using Hukuk.Takip.Sistemi.App.Queries.Request;
using Hukuk.Takip.Sistemi.App.Queries.Response;
using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace Hukuk.Takip.Sistemi.App.Handlers.Queries
{
    public class GetMusteriNoHandler : IRequestHandler<GetMusteriNoRequest, GetMusteriNoResponse>
    {
        IMusteriService _musteriService;

        public GetMusteriNoHandler(IMusteriService musteriService)
        {
            _musteriService = musteriService;
        }
        public async Task<GetMusteriNoResponse> Handle(GetMusteriNoRequest request, CancellationToken cancellationToken)
        {
            var  result =await _musteriService.GetMusteriNo(request.MusteriNo);

            return new GetMusteriNoResponse
            {
                Ad = result.Ad,
                Soyad = result.Soyad,
                TCKN = result.TCKN,
                MusteriNo = result.MusteriNo,
                MusteriTipi = result.MusteriTipi,
                //Sehir = result.Sehir,
                //Ilce = result.Ilce,
                //Mahalle = result.Mahalle,
                //TelefonNo = result.TelefonNo,
                //TelefonTİpi = result.TelefonTİpi

            };
           
      

        }
    }
}
