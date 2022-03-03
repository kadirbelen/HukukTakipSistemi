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
    public class CreateMusteriUrunHandler : IRequestHandler<CreateMusteriUrunRequest, CreateMusteriUrunResponse>
    {
        IMusteriUrunService _musteriUrunService;

        public CreateMusteriUrunHandler(IMusteriUrunService musteriUrunService)
        {
            _musteriUrunService = musteriUrunService;
        }

        public async Task<CreateMusteriUrunResponse> Handle(CreateMusteriUrunRequest request, CancellationToken cancellationToken)
        {
            await _musteriUrunService.InsertAsync(new MusteriUrun
            {
                UrunAd = request.UrunAd,
                UrunTipKod = request.UrunTipKod,
                UrunDurumu = request.UrunDurumu,
                ParaBirimi = request.ParaBirimi,
                FaizSubeAd = request.FaizSubeAd,
                FaizHesap = request.FaizHesap,
                FaizSubeKod = request.FaizSubeKod,
                FaizTutar = request.FaizTutar,
                MasrafHesap = request.MasrafHesap,
                MasrafSubeAd = request.MasrafSubeAd,
                MasrafSubeKodu = request.MasrafSubeKodu,
                MasrafTutar = request.MasrafTutar,
                TakipHesapNo = request.TakipHesapNo,
                TakipSubeAd = request.TakipSubeAd,
                TakipSubeKod = request.TakipSubeKod,
                TakipTarihi = request.TakipTarihi,
                TakipTutar = request.TakipTutar,
                OnErteleme = request.OnErteleme,
                ErtelemeVarMi = request.ErtelemeVarMi,
                ToplamRiskTutar = request.ToplamRiskTutar,
                MusteriId = request.MusteriId,
                EklenmeTarihi = request.EklenmeTarihi,
                EkleyenKisi = request.EkleyenKisi,
                GuncellenmeTarihi = request.GuncellenmeTarihi,
                Guncelleyen = request.Guncelleyen,
                SilindiMi = request.SilindiMi,
              

            });

            return new CreateMusteriUrunResponse
            {
                IsSuccess = true,
                Message = "Müşteri Ürün Eklendi"
            };
        }
    }
}
