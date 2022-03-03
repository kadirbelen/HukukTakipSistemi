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
    public class CreateMusteriAdresHandler : IRequestHandler<CreateMusteriAdresRequest, CreateMusteriAdresResponse>
    {
        IMusteriAdresService _musteriAdresService;

        public CreateMusteriAdresHandler(IMusteriAdresService musteriAdresService)
        {
            _musteriAdresService = musteriAdresService;
        }

        public async Task<CreateMusteriAdresResponse> Handle(CreateMusteriAdresRequest request, CancellationToken cancellationToken)
        {
            await _musteriAdresService.InsertAsync(new MusteriAdres
            {
                MusteriId = request.MusteriId,
                Adres = request.Adres,
                AdresTipi = request.AdresTipi,
                Ilce = request.Ilce,
                Mahalle = request.Mahalle,
                Sehir = request.Sehir,
                PostaKodu = request.PostaKodu,
            });

            return new CreateMusteriAdresResponse
            {
                IsSuccess = true,
                Message = "Adres bilgisi eklendi"
            };

        }
    }
}
