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
    public class GetAllAvukatAtananUrunHandler : IRequestHandler<GetAllAvukatAtananUrunRequest, List<GetAllAvukatAtananUrunResponse>>
    {
        IAvukatAtananUrunService _avukatAtananUrunService;

        public GetAllAvukatAtananUrunHandler(IAvukatAtananUrunService avukatAtananUrunService)
        {
            _avukatAtananUrunService = avukatAtananUrunService;
        }

        public async Task<List<GetAllAvukatAtananUrunResponse>> Handle(GetAllAvukatAtananUrunRequest request, CancellationToken cancellationToken)
        {
            var result = await _avukatAtananUrunService.GetAllAsync();

            var response = result.Select(p => new GetAllAvukatAtananUrunResponse
            {
                Id = p.Id,
                MusteriId = p.MusteriId,
                AvukatId = p.AvukatId,
                MusteriUrunId = p.MusteriUrunId,
                AtamaTarihi = p.AtamaTarihi,
                DelegasyonTarihi = p.DelegasyonTarihi,
                Durum = p.Durum,
                KabulTarihi = p.KabulTarihi,
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
