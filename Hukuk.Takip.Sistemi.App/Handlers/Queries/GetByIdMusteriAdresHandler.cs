using Hukuk.Takip.Sistemi.App.Queries.Request;
using Hukuk.Takip.Sistemi.App.Queries.Response;
using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.App.Handlers.Queries
{
    public class GetByIdMusteriAdresHandler : IRequestHandler<GetByIdMusteriAdresRequest, GetByIdMusteriAdresResponse>
    {
        IMusteriAdresService _musteriAdresService;

        public GetByIdMusteriAdresHandler(IMusteriAdresService musteriAdresService)
        {
            _musteriAdresService = musteriAdresService;
        }

        public async Task<GetByIdMusteriAdresResponse> Handle(GetByIdMusteriAdresRequest request, CancellationToken cancellationToken)
        {
             var result=await _musteriAdresService.GetAsync(p => p.Id == request.Id);

            return new GetByIdMusteriAdresResponse
            {
                Id = result.Id,
                Adres = result.Adres,
                AdresTipi = result.AdresTipi,
                Ilce = result.Ilce,
                Mahalle = result.Mahalle,
                MusteriId = result.MusteriId,
                PostaKodu = result.PostaKodu,
                Sehir = result.Sehir
            };
        }
    }
}
