using Hukuk.Takip.Sistemi.App.Commands.Request;
using Hukuk.Takip.Sistemi.App.Commands.Response;
using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.App.Handlers.Commands
{
    public class UpdateAvukatAtananUrunHandler : IRequestHandler<UpdateAvukatAtananUrunRequest, UpdateAvukatAtananUrunResponse>
    {
        IAvukatAtananUrunService _avukatAtananUrunService;

        public UpdateAvukatAtananUrunHandler(IAvukatAtananUrunService avukatAtananUrunService)
        {
            _avukatAtananUrunService = avukatAtananUrunService;
        }

        public async Task<UpdateAvukatAtananUrunResponse> Handle(UpdateAvukatAtananUrunRequest request, CancellationToken cancellationToken)
        {
            var result = await _avukatAtananUrunService.GetAsync(p => p.Id == request.Id);

            result.Durum = request.Durum;
            result.KabulTarihi = request.KabulTarihi;
            result.DelegasyonTarihi = request.DelegasyonTarihi;
  


            await _avukatAtananUrunService.UpdateAsync(result);

            return new UpdateAvukatAtananUrunResponse { };
        }
    }
}
