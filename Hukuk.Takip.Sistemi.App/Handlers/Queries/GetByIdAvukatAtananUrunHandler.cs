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
    public class GetByIdAvukatAtananUrunHandler : IRequestHandler<GetByIdAvukatAtananUrunRequest, GetByIdAvukatAtananUrunResponse>
    {
        IAvukatAtananUrunService _avukatAtananUrunService;

        public GetByIdAvukatAtananUrunHandler(IAvukatAtananUrunService avukatAtananUrunService)
        {
            _avukatAtananUrunService = avukatAtananUrunService;
        }
        public async Task<GetByIdAvukatAtananUrunResponse> Handle(GetByIdAvukatAtananUrunRequest request, CancellationToken cancellationToken)
        {
            var result = await _avukatAtananUrunService.GetAsync(p => p.Id == request.Id);

            return new GetByIdAvukatAtananUrunResponse
            {
                Id = result.Id,
                MusteriId = result.MusteriId,
               MusteriUrunId=result.MusteriUrunId,
               Durum=result.Durum
            };
        }
    }
}
