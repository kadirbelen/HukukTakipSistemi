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
    public class GetAllIhtarHandler : IRequestHandler<GetAllIhtarRequest, List<GetAllIhtarResponse>>
    {
        IIhtarService _ihtarService;

        public GetAllIhtarHandler(IIhtarService ihtarService)
        {
            _ihtarService = ihtarService;
        }

        public async Task<List<GetAllIhtarResponse>> Handle(GetAllIhtarRequest request, CancellationToken cancellationToken)
        {
            var result =await _ihtarService.GetAllAsync();

            var response = result.Select(p => new GetAllIhtarResponse
            {
                Id = p.Id,
                MusteriId = p.MusteriId,
                NoterAd = p.NoterAd,
                TakipHesapNo = p.TakipHesapNo,
                IhtarTutar = p.IhtarTutar,
                IhtarTarihi = p.IhtarTarihi,
                IhtarTebligTarihi = p.IhtarTebligTarihi,
                YevmiyeNo = p.YevmiyeNo,
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
