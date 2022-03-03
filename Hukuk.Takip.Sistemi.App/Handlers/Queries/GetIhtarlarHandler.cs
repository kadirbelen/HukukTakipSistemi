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
    public class GetIhtarlarHandler : IRequestHandler<GetIhtarlarRequest, List<GetIhtarlarResponse>>
    {
        IIhtarService _ihtarService;

        public GetIhtarlarHandler(IIhtarService ihtarService)
        {
            _ihtarService = ihtarService;
        }

        public async Task<List<GetIhtarlarResponse>> Handle(GetIhtarlarRequest request, CancellationToken cancellationToken)
        {
            var result = await _ihtarService.GetIhtarlar();
            var response = result.Select(p => new GetIhtarlarResponse
            {
                Id = p.Id,
                Ad = p.Ad,
                Soyad = p.Soyad,
                MusteriNo = p.MusteriNo,
                NoterAd = p.NoterAd,
                IhtarTarihi = p.IhtarTarihi,
                IhtarTebligTarihi = p.IhtarTebligTarihi,
                TakipHesapNo = p.TakipHesapNo,
                YevmiyeNo = p.YevmiyeNo,
                IhtarTutar = p.IhtarTutar

            }).ToList();
            return response;
        }
    }
}
