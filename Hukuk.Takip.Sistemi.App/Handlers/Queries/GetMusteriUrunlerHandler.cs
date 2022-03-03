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
    public class GetMusteriUrunlerHandler : IRequestHandler<GetMusteriUrunlerRequest, List<GetMusteriUrunlerResponse>>
    {
        IMusteriUrunService _musteriUrunService;

        public GetMusteriUrunlerHandler(IMusteriUrunService musteriUrunService)
        {
            _musteriUrunService = musteriUrunService;
        }

        public async Task<List<GetMusteriUrunlerResponse>> Handle(GetMusteriUrunlerRequest request, CancellationToken cancellationToken)
        {
            var result = await _musteriUrunService.GetMusteriUrunler();
            var response = result.Select(p => new GetMusteriUrunlerResponse
            {
                Id = p.Id,
                Ad = p.Ad,
                Soyad = p.Soyad,
                MusteriNo = p.MusteriNo,
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


            }).ToList();
            return response;
        }
    }
}
