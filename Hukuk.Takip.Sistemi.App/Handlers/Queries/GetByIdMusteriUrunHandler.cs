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
    public class GetByIdMusteriUrunHandler : IRequestHandler<GetByIdMusteriUrunRequest, GetByIdMusteriUrunResponse>
    {
        IMusteriUrunService _musteriUrunService;

        public GetByIdMusteriUrunHandler(IMusteriUrunService musteriUrunService)
        {
            _musteriUrunService = musteriUrunService;
        }

        public async Task<GetByIdMusteriUrunResponse> Handle(GetByIdMusteriUrunRequest request, CancellationToken cancellationToken)
        {
            var result = await _musteriUrunService.GetAsync(p => p.Id == request.Id);

            return new GetByIdMusteriUrunResponse
            {
                UrunAd = result.UrunAd,
                UrunTipKod = result.UrunTipKod,
                UrunDurumu = result.UrunDurumu,
                ParaBirimi = result.ParaBirimi,
                FaizSubeAd = result.FaizSubeAd,
                FaizHesap = result.FaizHesap,
                FaizSubeKod = result.FaizSubeKod,
                FaizTutar = result.FaizTutar,
                MasrafHesap = result.MasrafHesap,
                MasrafSubeAd = result.MasrafSubeAd,
                MasrafSubeKodu = result.MasrafSubeKodu,
                MasrafTutar = result.MasrafTutar,
                TakipHesapNo = result.TakipHesapNo,
                TakipSubeAd = result.TakipSubeAd,
                TakipSubeKod = result.TakipSubeKod,
                TakipTarihi = result.TakipTarihi,
                TakipTutar = result.TakipTutar,
                OnErteleme = result.OnErteleme,
                ErtelemeVarMi = result.ErtelemeVarMi,
                MusteriId = result.MusteriId,
            };
        }
    }
}
