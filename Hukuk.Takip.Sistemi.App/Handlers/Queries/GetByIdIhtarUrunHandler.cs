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
    public class GetByIdIhtarUrunHandler : IRequestHandler<GetByIdIhtarUrunRequest, GetByIdIhtarUrunResponse>
    {
        IIhtarUrunService _ihtarUrunService;

        public GetByIdIhtarUrunHandler(IIhtarUrunService ihtarUrunService)
        {
            _ihtarUrunService = ihtarUrunService;
        }

        public async Task<GetByIdIhtarUrunResponse> Handle(GetByIdIhtarUrunRequest request, CancellationToken cancellationToken)
        {
            var result = await _ihtarUrunService.GetAsync(p => p.IhtarId == request.Id);

            return new GetByIdIhtarUrunResponse
            {
                //Id = result.Id,
                //MusteriUrunId = result.MusteriUrunId,
                //IhtarId = result.IhtarId,
                AnaParaTutar = result.AnaParaTutar,
                FaizTutar = result.FaizTutar,
                IhtarTutar = result.IhtarTutar,
                KomisyonTutar = result.KomisyonTutar,
                ToplamBorc = result.ToplamBorc
            };
        }
    }
}
