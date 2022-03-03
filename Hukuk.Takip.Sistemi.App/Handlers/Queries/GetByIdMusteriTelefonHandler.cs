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
    public class GetByIdMusteriTelefonHandler : IRequestHandler<GetByIdMusteriTelefonRequest, GetByIdMusteriTelefonResponse>
    {
        IMusteriTelefonService _musteriTelefonService;

        public GetByIdMusteriTelefonHandler(IMusteriTelefonService musteriTelefonService)
        {
            _musteriTelefonService = musteriTelefonService;
        }

        public async Task<GetByIdMusteriTelefonResponse> Handle(GetByIdMusteriTelefonRequest request, CancellationToken cancellationToken)
        {
            var result = await _musteriTelefonService.GetAsync(p => p.Id == request.Id);

            return new GetByIdMusteriTelefonResponse
            {
                Id = result.Id,
                MusteriId = result.MusteriId,
                TelefonNo = result.TelefonNo,
                TelefonTİpi = result.TelefonTİpi
            };
        }
    }
}
