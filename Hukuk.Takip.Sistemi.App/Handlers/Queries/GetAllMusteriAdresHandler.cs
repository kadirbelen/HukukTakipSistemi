using Hukuk.Takip.Sistemi.App.Queries.Request;
using Hukuk.Takip.Sistemi.App.Queries.Response;
using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.App.Handlers.Queries
{
    public class GetAllMusteriAdresHandler : IRequestHandler<GetAllMusteriAdresRequest, List<GetAllMusteriAdresResponse>>
    {
        IMusteriAdresService _musteriAdresService;

        public GetAllMusteriAdresHandler(IMusteriAdresService musteriAdresService)
        {
            _musteriAdresService = musteriAdresService;
        }

        public async Task<List<GetAllMusteriAdresResponse>> Handle(GetAllMusteriAdresRequest request, CancellationToken cancellationToken)
        {

            var result = await _musteriAdresService.GetAllAsync();
                
                
                
            var response = result.Select(m => new GetAllMusteriAdresResponse
            {
                MusteriId = m.MusteriId,
                Adres = m.Adres,
                AdresTipi = m.AdresTipi,
                Ilce = m.Ilce,
                Mahalle = m.Mahalle,
                Sehir = m.Sehir,
                PostaKodu = m.PostaKodu
            }).ToList();

            return response;
        }
    }
}
