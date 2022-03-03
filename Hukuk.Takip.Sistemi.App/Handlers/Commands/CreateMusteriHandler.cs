using Hukuk.Takip.Sistemi.App.Commands.Request;
using Hukuk.Takip.Sistemi.App.Commands.Response;
using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using Hukuk.Takip.Sistemi.Entities.Dto;
using Hukuk.Takip.Sistemi.Entities.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.App.Handlers.Commands
{
    public class CreateMusteriHandler : IRequestHandler<CreateMusteriRequest, CreateMusteriResponse>
    {
        IMusteriService _musteriService;

        public CreateMusteriHandler(IMusteriService musteriService)
        {
            _musteriService = musteriService;
        }

        public async Task<CreateMusteriResponse> Handle(CreateMusteriRequest request, CancellationToken cancellationToken)
        {

            await _musteriService.InsertAsync(new Musteri
            {
                Ad = request.Ad,
                Soyad = request.Soyad,
                MusteriNo = request.MusteriNo,
                TCKN = request.TCKN,
                MusteriTipi = request.MusteriTipi,
                VKN=request.VKN,
                BabaAdi=request.BabaAdi,
                AnaAdi=request.AnaAdi,
                DogumYeri=request.DogumYeri,
                DogumTarihi=request.DogumTarihi,
                TakipSubeAdi=request.TakipSubeAdi,
                TakipSubeKodu=request.TakipSubeKodu,
                Cinsiyet=request.Cinsiyet,
                MedeniHali=request.MedeniHali,
                PasaportNo=request.PasaportNo,
                HayattaMi=request.HayattaMi,
                EklenmeTarihi=request.EklenmeTarihi,
                SilindiMi=request.SilindiMi,
                EkleyenKisi=request.EkleyenKisi,
                GuncellenmeTarihi=request.GuncellenmeTarihi,
                Guncelleyen=request.Guncelleyen,
                VefatTarihi=request.VefatTarihi

            });

            return new CreateMusteriResponse
            {
                IsSuccess = true,
                Message = "İşlem Başarılı"
            };
        }
    }
}
