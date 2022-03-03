using Hukuk.Takip.Sistemi.App.Commands.Request;
using Hukuk.Takip.Sistemi.App.Commands.Response;
using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using Hukuk.Takip.Sistemi.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.App.Handlers.Commands
{
    public class UpdateMusteriHandler : IRequestHandler<UpdateMusteriRequest, UpdateMusteriResponse>
    {
        IMusteriService _musteriService;

        public UpdateMusteriHandler(IMusteriService musteriService)
        {
            _musteriService = musteriService;
        }

        public async Task<UpdateMusteriResponse> Handle(UpdateMusteriRequest request, CancellationToken cancellationToken)
        {
             var result = await _musteriService.GetAsync(p => p.Id == request.Id);
            result.Ad = request.Ad;
            result.Soyad = request.Soyad;
            result.MusteriNo = request.MusteriNo;
            result.TCKN = request.TCKN;
            result.MusteriTipi = request.MusteriTipi;
            result.VKN = request.VKN;
            result.BabaAdi = request.BabaAdi;
            result.AnaAdi = request.AnaAdi;
            result.DogumYeri = request.DogumYeri;
            result.DogumTarihi = request.DogumTarihi;
            result.TakipSubeAdi = request.TakipSubeAdi;
            result.TakipSubeKodu = request.TakipSubeKodu;
            result.Cinsiyet = request.Cinsiyet;
            result.MedeniHali = request.MedeniHali;
            result.PasaportNo = request.PasaportNo;
            result.HayattaMi = request.HayattaMi;
            result.EklenmeTarihi = request.EklenmeTarihi;
            result.SilindiMi = request.SilindiMi;
            result.EkleyenKisi = request.EkleyenKisi;
            result.GuncellenmeTarihi = request.GuncellenmeTarihi;
            result.Guncelleyen = request.Guncelleyen;
            result.VefatTarihi = request.VefatTarihi;


            await _musteriService.UpdateAsync(result);

            return new UpdateMusteriResponse
            {
                IsSuccess = true,
                Message = "Güncelleme başarılı"
            };
        }
    }
}
