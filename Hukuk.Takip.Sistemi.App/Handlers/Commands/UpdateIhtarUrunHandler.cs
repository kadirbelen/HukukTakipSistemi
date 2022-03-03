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
    public class UpdateIhtarUrunHandler : IRequestHandler<UpdateIhtarUrunRequest, UpdateIhtarUrunResponse>
    {
        IIhtarUrunService _ihtarUrunService;

        public UpdateIhtarUrunHandler(IIhtarUrunService ihtarUrunService)
        {
            _ihtarUrunService = ihtarUrunService;
        }

        public async Task<UpdateIhtarUrunResponse> Handle(UpdateIhtarUrunRequest request, CancellationToken cancellationToken)
        {
            var result = await _ihtarUrunService.GetAsync(p => p.Id == request.Id);

            result.IhtarId = request.IhtarId;
            result.MusteriUrunId = request.MusteriUrunId;
            result.IhtarTutar = request.IhtarTutar;
            result.AnaParaTutar = request.AnaParaTutar;
            result.FaizTutar = request.FaizTutar;
            result.KomisyonTutar = request.KomisyonTutar;
            result.ToplamBorc = request.ToplamBorc;
            result.EklenmeTarihi = request.EklenmeTarihi;
            result.EkleyenKisi = request.EkleyenKisi;
            result.GuncellenmeTarihi = request.GuncellenmeTarihi;
            result.Guncelleyen = request.Guncelleyen;
            result.SilindiMi = request.SilindiMi;

            await _ihtarUrunService.UpdateAsync(result);
            return new UpdateIhtarUrunResponse { };
        }
    }
}
