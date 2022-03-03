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
    public class GetAllIhtarUrunHandler : IRequestHandler<GetAllIhtarUrunRequest, List<GetAllIhtarUrunResponse>>
    {
        IIhtarUrunService _ıhtarUrunService;

        public GetAllIhtarUrunHandler(IIhtarUrunService ıhtarUrunService)
        {
            _ıhtarUrunService = ıhtarUrunService;
        }

        public async Task<List<GetAllIhtarUrunResponse>> Handle(GetAllIhtarUrunRequest request, CancellationToken cancellationToken)
        {
            var result = await _ıhtarUrunService.GetAllAsync();

            var response = result.Select(p => new GetAllIhtarUrunResponse
            {
                Id = p.Id,
                IhtarId = p.IhtarId,
                MusteriUrunId = p.MusteriUrunId,
                IhtarTutar = p.IhtarTutar,
                AnaParaTutar = p.AnaParaTutar,
                FaizTutar = p.FaizTutar,
                KomisyonTutar = p.KomisyonTutar,
                ToplamBorc = p.ToplamBorc,
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
