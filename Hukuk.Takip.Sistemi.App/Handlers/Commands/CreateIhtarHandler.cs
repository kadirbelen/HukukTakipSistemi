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
    public class CreateIhtarHandler : IRequestHandler<CreateIhtarRequest, CreateIhtarResponse>
    {
        IIhtarService _ihtarService;

        public CreateIhtarHandler(IIhtarService ihtarService)
        {
            _ihtarService = ihtarService;
        }

        public async Task<CreateIhtarResponse> Handle(CreateIhtarRequest request, CancellationToken cancellationToken)
        {
            await _ihtarService.InsertAsync(new Ihtar
            {
                MusteriId = request.MusteriId,
                NoterAd = request.NoterAd,
                TakipHesapNo = request.TakipHesapNo,
                IhtarTutar = request.IhtarTutar,
                IhtarTarihi = request.IhtarTarihi,
                IhtarTebligTarihi = request.IhtarTebligTarihi,
                YevmiyeNo = request.YevmiyeNo,
                EklenmeTarihi = request.EklenmeTarihi,
                EkleyenKisi = request.EkleyenKisi,
                GuncellenmeTarihi = request.GuncellenmeTarihi,
                Guncelleyen = request.Guncelleyen,
                SilindiMi = request.SilindiMi,
              
            });

            return new CreateIhtarResponse
            {
                IsSuccess = true,
                Message = "Ihtar oluşturuldu"
            };
        }
    }
}
