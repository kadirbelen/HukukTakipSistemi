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
    public class CreateAvukatAtananUrunHandler : IRequestHandler<CreateAvukatAtananUrunRequest, CreateAvukatAtananUrunResponse>
    {
        IAvukatAtananUrunService _avukatAtananUrunService;

        public CreateAvukatAtananUrunHandler(IAvukatAtananUrunService avukatAtananUrunService)
        {
            _avukatAtananUrunService = avukatAtananUrunService;
        }

        public async Task<CreateAvukatAtananUrunResponse> Handle(CreateAvukatAtananUrunRequest request, CancellationToken cancellationToken)
        {
            await _avukatAtananUrunService.InsertAsync(new AvukatAtananUrun
            {
                MusteriId = request.MusteriId,
                AvukatId = request.AvukatId,
                MusteriUrunId = request.MusteriUrunId,
                AtamaTarihi = request.AtamaTarihi,
                DelegasyonTarihi = request.DelegasyonTarihi,
                Durum = request.Durum,
                KabulTarihi = request.KabulTarihi,
                EklenmeTarihi = request.EklenmeTarihi,
                EkleyenKisi = request.EkleyenKisi,
                GuncellenmeTarihi = request.GuncellenmeTarihi,
                Guncelleyen = request.Guncelleyen,
                SilindiMi = request.SilindiMi,

            });
            return new CreateAvukatAtananUrunResponse
            {
                IsSuccess = true,
                Message = "Başarılı"
            };
        }
    }
}
