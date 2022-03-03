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
    public class CreateAvukatHandler : IRequestHandler<CreateAvukatRequest, CreateAvukatResponse>
    {
        IAvukatService _avukatService;

        public CreateAvukatHandler(IAvukatService avukatService)
        {
            _avukatService = avukatService;
        }

        public async Task<CreateAvukatResponse> Handle(CreateAvukatRequest request, CancellationToken cancellationToken)
        {
            await _avukatService.InsertAsync(new Avukat
            {
                Ad = request.Ad,
                Soyad = request.Soyad,
                TCKN = request.TCKN,
                TelNo = request.TelNo,
                FaxNo = request.FaxNo,
                Tip = request.Tip,
                DosyaYetkisi = request.DosyaYetkisi,
                AktifMi = request.AktifMi,
                EklenmeTarihi = request.EklenmeTarihi,
                EkleyenKisi = request.EkleyenKisi,
                GuncellenmeTarihi = request.GuncellenmeTarihi,
                Guncelleyen = request.Guncelleyen,
                SilindiMi = request.SilindiMi,
              
            });

            return new CreateAvukatResponse
            {
                IsSuccess = true,
                Message = "Avukat Bilgileri Eklendi"
            };
        }
    }
}
