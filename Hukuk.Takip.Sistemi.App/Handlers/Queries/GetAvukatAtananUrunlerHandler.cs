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
    public class GetAvukatAtananUrunlerHandler : IRequestHandler<GetAvukatAtananUrunlerRequest, List<GetAvukatAtananUrunlerResponse>>
    {
        IAvukatAtananUrunService _avukatAtananUrunService;

        public GetAvukatAtananUrunlerHandler(IAvukatAtananUrunService avukatAtananUrunService)
        {
            _avukatAtananUrunService = avukatAtananUrunService;
        }
        public async Task<List<GetAvukatAtananUrunlerResponse>> Handle(GetAvukatAtananUrunlerRequest request, CancellationToken cancellationToken)
        {
            var result = await _avukatAtananUrunService.GetAvukatAtananUrunler();
            var response = result.Select(p => new GetAvukatAtananUrunlerResponse
            {
                Id = p.Id,
                Ad = p.Ad,
                MusteriId=p.MusteriId,
                MusteriUrunId=p.MusteriUrunId,
                Soyad = p.Soyad,
                MusteriNo = p.MusteriNo,
                AvukatAd =p.AvukatAd,
                AvukatSoyad=p.AvukatSoyad,
                AvukatTelNo=p.AvukatTelNo,
                AvukatTip=p.AvukatTip,
                Durum=p.Durum,
                DosyaYetkisi=p.DosyaYetkisi,
                UrunAd=p.UrunAd,
                UrunTipKod=p.UrunTipKod,
                TakipSubeAd=p.TakipSubeAd,
                TakipSubeKod=p.TakipSubeKod,
                TakipHesapNo=p.TakipHesapNo


            }).ToList();
            return response;
        }
    }
}
