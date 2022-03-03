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
    public class GetIhtarUrunlerHandler : IRequestHandler<GetIhtarUrunlerRequest, List<GetIhtarUrunlerResponse>>
    {
        IIhtarUrunService _ihtarUrunService;

        public GetIhtarUrunlerHandler(IIhtarUrunService ihtarUrunService)
        {
            _ihtarUrunService = ihtarUrunService;
        }

        public async Task<List<GetIhtarUrunlerResponse>> Handle(GetIhtarUrunlerRequest request, CancellationToken cancellationToken)
        {
            var result = await _ihtarUrunService.GetIhtarUrunleri(request.Id);
            var response = result.Select(p => new GetIhtarUrunlerResponse
            {
                Id = p.Id,
                IhtarId=p.IhtarId,
                IhtarTarihi=p.IhtarTarihi,
                IhtarTebligTarihi=p.IhtarTebligTarihi,
                YevmiyeNo=p.YevmiyeNo,
                UrunAd = p.UrunAd,
                UrunTipKod = p.UrunTipKod,
                AnaParaTutar =p.AnaParaTutar,
                FaizTutar=p.FaizTutar,
                IhtarTutar=p.IhtarTutar,
                KomisyonTutar=p.KomisyonTutar,
                ToplamBorc=p.ToplamBorc,
            }).ToList();
            return response;
        }
    }
}
