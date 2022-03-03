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
    public class GetAllMusteriTelefonHandler : IRequestHandler<GetAllMusteriTelefonRequest, List<GetAllMusteriTelefonResponse>>
    {
        IMusteriTelefonService _musteriTelefonService;

        public GetAllMusteriTelefonHandler(IMusteriTelefonService musteriTelefonService)
        {
            _musteriTelefonService = musteriTelefonService;
        }

        public async Task<List<GetAllMusteriTelefonResponse>> Handle(GetAllMusteriTelefonRequest request, CancellationToken cancellationToken)
        {
            var result =await _musteriTelefonService.GetAllAsync();

            var response = result.Select(t => new GetAllMusteriTelefonResponse
            {
                Id = t.Id,
                MusteriId = t.MusteriId,
                TelefonNo = t.TelefonNo,
                TelefonTİpi = t.TelefonTİpi,
                SilindiMi = t.SilindiMi,
                EklenmeTarihi = t.EklenmeTarihi,
                EkleyenKisi = t.EkleyenKisi,
                GuncellenmeTarihi = t.GuncellenmeTarihi,
                Guncelleyen = t.Guncelleyen,
            }).ToList();

            return response;
        }
    }
}
