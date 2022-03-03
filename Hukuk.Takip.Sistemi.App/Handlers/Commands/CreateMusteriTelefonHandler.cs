using Hukuk.Takip.Sistemi.App.Commands.Request;
using Hukuk.Takip.Sistemi.App.Commands.Response;
using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using Hukuk.Takip.Sistemi.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.App.Handlers.Commands
{
    public class CreateMusteriTelefonHandler : IRequestHandler<CreateMusteriTelefonRequest, CreateMusteriTelefonResponse>
    {
        IMusteriTelefonService _musteriTelefonService;

        public CreateMusteriTelefonHandler(IMusteriTelefonService musteriTelefonService)
        {
            _musteriTelefonService = musteriTelefonService;
        }

        public async Task<CreateMusteriTelefonResponse> Handle(CreateMusteriTelefonRequest request, CancellationToken cancellationToken)
        {
            await _musteriTelefonService.InsertAsync(new MusteriTelefon
            {
                MusteriId = request.MusteriId,
                TelefonNo = request.TelefonNo,
                TelefonTİpi = request.TelefonTİpi,
                SilindiMi = request.SilindiMi,
                EklenmeTarihi = request.EklenmeTarihi,
                EkleyenKisi = request.EkleyenKisi,
                GuncellenmeTarihi = request.GuncellenmeTarihi,
                Guncelleyen = request.Guncelleyen,
            });

            return new CreateMusteriTelefonResponse
            {
                IsSuccess = true,
                Message = "Musteri telefonu eklendi"
            };
        }
    }
}
