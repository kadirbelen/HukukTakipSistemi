using Hukuk.Takip.Sistemi.App.Queries.Request;
using Hukuk.Takip.Sistemi.App.Queries.Response;
using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace Hukuk.Takip.Sistemi.App.Handlers.Queries
{
    public class GetByIdIhtarHandler : IRequestHandler<GetByIdIhtarRequest, GetByIdIhtarResponse>
    {
        IIhtarService _ihtarService;

        public GetByIdIhtarHandler(IIhtarService ihtarService)
        {
            _ihtarService = ihtarService;
        }

        public async Task<GetByIdIhtarResponse> Handle(GetByIdIhtarRequest request, CancellationToken cancellationToken)
        {
            var result = await _ihtarService.GetAsync(p => p.Id == request.Id);
            return new GetByIdIhtarResponse
            {
                Id = result.Id,
                MusteriId = result.MusteriId,
                NoterAd=result.NoterAd,
                IhtarTarihi=result.IhtarTarihi,
                IhtarTebligTarihi=result.IhtarTebligTarihi,
                IhtarTutar=result.IhtarTutar,
                TakipHesapNo=result.TakipHesapNo,
                YevmiyeNo=result.YevmiyeNo
            };
        
        }
    }
}
