using Hukuk.Takip.Sistemi.App.Queries.Request;
using Hukuk.Takip.Sistemi.App.Queries.Response;
using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using Hukuk.Takip.Sistemi.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.App.Handlers.Queries
{
    public class GetAllMusteriUrunHandler : IRequestHandler<GetAllMusteriUrunRequest, List<GetAllMusteriUrunResponse>>
    {
        IMusteriUrunService _musteriUrunService;

        public GetAllMusteriUrunHandler(IMusteriUrunService musteriUrunService)
        {
            _musteriUrunService = musteriUrunService;
        }

        public async Task<List<GetAllMusteriUrunResponse>> Handle(GetAllMusteriUrunRequest request, CancellationToken cancellationToken)
        {
            var result = await _musteriUrunService.GetAllAsync();

            var response = result.Select(p => new GetAllMusteriUrunResponse
            {
                Id=p.Id,
                UrunAd = p.UrunAd,
                UrunTipKod = p.UrunTipKod,
                UrunDurumu = p.UrunDurumu,
                ParaBirimi = p.ParaBirimi,
                FaizSubeAd = p.FaizSubeAd,
                FaizHesap = p.FaizHesap,
                FaizSubeKod = p.FaizSubeKod,
                FaizTutar = p.FaizTutar,
                MasrafHesap = p.MasrafHesap,
                MasrafSubeAd = p.MasrafSubeAd,
                MasrafSubeKodu = p.MasrafSubeKodu,
                MasrafTutar = p.MasrafTutar,
                TakipHesapNo = p.TakipHesapNo,
                TakipSubeAd = p.TakipSubeAd,
                TakipSubeKod = p.TakipSubeKod,
                TakipTarihi = p.TakipTarihi,
                TakipTutar = p.TakipTutar,
                OnErteleme = p.OnErteleme,
                ErtelemeVarMi = p.ErtelemeVarMi,
                ToplamRiskTutar = p.ToplamRiskTutar,
                MusteriId = p.MusteriId,
                EklenmeTarihi = p.EklenmeTarihi,
                EkleyenKisi = p.EkleyenKisi,
                GuncellenmeTarihi = p.GuncellenmeTarihi,
                Guncelleyen = p.Guncelleyen,
                SilindiMi = p.SilindiMi,
              
            }).ToList();

            return response;
        }
    }
}
