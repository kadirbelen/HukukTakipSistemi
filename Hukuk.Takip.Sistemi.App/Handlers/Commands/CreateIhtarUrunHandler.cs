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
    public class CreateIhtarUrunHandler : IRequestHandler<CreateIhtarUrunRequest, CreateIhtarUrunResponse>
    {
        IIhtarUrunService _ihtarUrunService;

        public CreateIhtarUrunHandler(IIhtarUrunService ihtarUrunService)
        {
            _ihtarUrunService = ihtarUrunService;
        }

        public async Task<CreateIhtarUrunResponse> Handle(CreateIhtarUrunRequest request, CancellationToken cancellationToken)
        {
            await _ihtarUrunService.InsertAsync(new IhtarUrun
            {
                IhtarId = request.IhtarId,
                MusteriUrunId = request.MusteriUrunId,
                IhtarTutar = request.IhtarTutar,
                AnaParaTutar = request.AnaParaTutar,
                FaizTutar = request.FaizTutar,
                KomisyonTutar = request.KomisyonTutar,
                ToplamBorc = request.ToplamBorc,
                EklenmeTarihi = request.EklenmeTarihi,
                EkleyenKisi = request.EkleyenKisi,
                GuncellenmeTarihi = request.GuncellenmeTarihi,
                Guncelleyen = request.Guncelleyen,
                SilindiMi = request.SilindiMi,
               
            });

            return new CreateIhtarUrunResponse
            {
                IsSuccess = true,
                Message = "İşlem başarılı"
            };
        }
    }
}
