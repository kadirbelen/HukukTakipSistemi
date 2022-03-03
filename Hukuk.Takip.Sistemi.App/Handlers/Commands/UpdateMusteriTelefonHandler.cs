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
    public class UpdateMusteriTelefonHandler : IRequestHandler<UpdateMusteriTelefonRequest, UpdateMusteriTelefonResponse>
    {
        IMusteriTelefonService _musteriTelefonService;

        public UpdateMusteriTelefonHandler(IMusteriTelefonService musteriTelefonService)
        {
            _musteriTelefonService = musteriTelefonService;
        }

        public async Task<UpdateMusteriTelefonResponse> Handle(UpdateMusteriTelefonRequest request, CancellationToken cancellationToken)
        {
            var result = await _musteriTelefonService.GetAsync(p => p.Id == request.Id);

            result.TelefonNo = request.TelefonNo;
            result.TelefonTİpi = request.TelefonTİpi;


            await _musteriTelefonService.UpdateAsync(result);

            return new UpdateMusteriTelefonResponse { };
        }
    }
}
