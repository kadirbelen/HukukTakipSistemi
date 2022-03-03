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
    public class UpdateMusteriUrunHandler : IRequestHandler<UpdateMusteriUrunRequest, UpdateMusteriUrunResponse>
    {
        IMusteriUrunService _musteriUrunService;

        public UpdateMusteriUrunHandler(IMusteriUrunService musteriUrunService)
        {
            _musteriUrunService = musteriUrunService;
        }

        public async Task<UpdateMusteriUrunResponse> Handle(UpdateMusteriUrunRequest request, CancellationToken cancellationToken)
        {
            var result = await _musteriUrunService.GetAsync(p => p.Id == request.Id);

            result.UrunAd = request.UrunAd;
            result.UrunTipKod = request.UrunTipKod;
            result.UrunDurumu = request.UrunDurumu;
            result.ParaBirimi = request.ParaBirimi;
            result.FaizSubeAd = request.FaizSubeAd;
            result.FaizHesap = request.FaizHesap;
            result.FaizSubeKod = request.FaizSubeKod;
            result.FaizTutar = request.FaizTutar;
            result.MasrafHesap = request.MasrafHesap;
            result.MasrafSubeAd = request.MasrafSubeAd;
            result.MasrafSubeKodu = request.MasrafSubeKodu;
            result.MasrafTutar = request.MasrafTutar;
            result.TakipHesapNo = request.TakipHesapNo;
            result.TakipSubeAd = request.TakipSubeAd;
            result.TakipSubeKod = request.TakipSubeKod;
            result.TakipTarihi = request.TakipTarihi;
            result.TakipTutar = request.TakipTutar;
            result.OnErteleme = request.OnErteleme;
            result.ErtelemeVarMi = request.ErtelemeVarMi;
            result.ToplamRiskTutar = request.ToplamRiskTutar;
            result.MusteriId = request.MusteriId;
            result.EklenmeTarihi = request.EklenmeTarihi;
            result.EkleyenKisi = request.EkleyenKisi;
            result.GuncellenmeTarihi = request.GuncellenmeTarihi;
            result.Guncelleyen = request.Guncelleyen;
            result.SilindiMi = request.SilindiMi;

            await _musteriUrunService.UpdateAsync(result);
            return new UpdateMusteriUrunResponse { };

        }
    }
}
