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
    public class UpdateMusteriAdresHandler : IRequestHandler<UpdateMusteriAdresRequest, UpdateMusteriAdresResponse>
    {
        IMusteriAdresService _musteriAdresService;

        public UpdateMusteriAdresHandler(IMusteriAdresService musteriAdresService)
        {
            _musteriAdresService = musteriAdresService;
        }

        public async Task<UpdateMusteriAdresResponse> Handle(UpdateMusteriAdresRequest request, CancellationToken cancellationToken)
        {
            var result = await _musteriAdresService.GetAsync(p => p.Id == request.Id);

            result.Adres = request.Adres;
            result.AdresTipi = request.AdresTipi;
            result.Ilce = request.Ilce;
            result.Mahalle = request.Mahalle;
            result.Sehir = request.Sehir;
            result.PostaKodu = request.PostaKodu;
            

            await _musteriAdresService.UpdateAsync(result);

            return new UpdateMusteriAdresResponse { };

           
           
        }
    }
}
