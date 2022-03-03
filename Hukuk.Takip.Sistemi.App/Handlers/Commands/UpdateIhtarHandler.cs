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
    public class UpdateIhtarHandler : IRequestHandler<UpdateIhtarRequest, UpdateIhtarResponse>
    {
        IIhtarService _ihtarService;

        public UpdateIhtarHandler(IIhtarService ihtarService)
        {
            _ihtarService = ihtarService;
        }

        public async Task<UpdateIhtarResponse> Handle(UpdateIhtarRequest request, CancellationToken cancellationToken)
        {
            var result = await _ihtarService.GetAsync(p => p.Id == request.Id);
            result.NoterAd = request.NoterAd;
            result.TakipHesapNo = request.TakipHesapNo;
            result.YevmiyeNo = request.YevmiyeNo;
            result.IhtarTarihi = request.IhtarTarihi;
            result.IhtarTebligTarihi = request.IhtarTebligTarihi;
            result.IhtarTutar = request.IhtarTutar;
            result.TakipHesapNo = request.TakipHesapNo;
            result.EklenmeTarihi = request.EklenmeTarihi;
            result.SilindiMi = request.SilindiMi;
            result.EkleyenKisi = request.EkleyenKisi;
            result.GuncellenmeTarihi = request.GuncellenmeTarihi;
            result.Guncelleyen = request.Guncelleyen;

            await _ihtarService.UpdateAsync(result);


            return new UpdateIhtarResponse{ };

        }
    }
}
