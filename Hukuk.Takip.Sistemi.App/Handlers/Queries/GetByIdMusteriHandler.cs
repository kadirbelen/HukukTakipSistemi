using Hukuk.Takip.Sistemi.App.Queries.Request;
using Hukuk.Takip.Sistemi.App.Queries.Response;
using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using MediatR;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.App.Handlers.Queries
{
    public class GetByIdMusteriHandler : IRequestHandler<GetByIdMusteriRequest, GetByIdMusteriResponse>
    {
        IMusteriService _musteriService;

        public GetByIdMusteriHandler(IMusteriService musteriService)
        {
            _musteriService = musteriService;
        }

        public async Task<GetByIdMusteriResponse> Handle(GetByIdMusteriRequest request, CancellationToken cancellationToken)
        {
            var result = await _musteriService.GetAsync(p=>p.Id==request.Id);

            return new GetByIdMusteriResponse
            {
                Ad = result.Ad,
                Soyad = result.Soyad,
                MusteriNo = result.MusteriNo,
                MusteriTipi = result.MusteriTipi,
                AnaAdi = result.AnaAdi,
                BabaAdi = result.BabaAdi,
                TCKN = result.TCKN,
                VKN = result.VKN,
                TakipSubeKodu = result.TakipSubeKodu,
                DogumTarihi = result.DogumTarihi,
                DogumYeri = result.DogumYeri,
                Cinsiyet = result.Cinsiyet,
                MedeniHali = result.MedeniHali,
                PasaportNo = result.PasaportNo,
                TakipSubeAdi=result.TakipSubeAdi
                
            };
        }
    }
}
