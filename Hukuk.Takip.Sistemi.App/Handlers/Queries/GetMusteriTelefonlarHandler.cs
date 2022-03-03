using Hukuk.Takip.Sistemi.App.Queries.Request;
using Hukuk.Takip.Sistemi.App.Queries.Response;
using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.App.Handlers.Queries
{
    public class GetMusteriTelefonlarHandler : IRequestHandler<GetMusteriTelefonlarRequest, List<GetMusteriTelefonlarResponse>>
    {

        IMusteriTelefonService _musteriTelefonService;

        public GetMusteriTelefonlarHandler(IMusteriTelefonService musteriTelefonService)
        {
            _musteriTelefonService = musteriTelefonService;
        }

        public async Task<List<GetMusteriTelefonlarResponse>> Handle(GetMusteriTelefonlarRequest request, CancellationToken cancellationToken)
        {
            var result = await _musteriTelefonService.GetMusteriTelefonlar();
            var response = result.Select(p => new GetMusteriTelefonlarResponse
            {
                Id = p.Id,
                Ad = p.Ad,
                Soyad = p.Soyad,
                AnaAdi = p.AnaAdi,
                BabaAdi = p.BabaAdi,
                DogumTarihi = p.DogumTarihi,
                DogumYeri = p.DogumYeri,
                TakipSubeAdi = p.TakipSubeAdi,
                TakipSubeKodu = p.TakipSubeKodu,
                VKN = p.VKN,
                TCKN = p.TCKN,
                MusteriNo = p.MusteriNo,
                MusteriTipi = MusteriTip(p.MusteriTipi),
                TelefonNo = p.TelefonNo,
                TelefonTİpi = p.TelefonTİpi


            }).ToList();
            return response;
        }

        public string MusteriTip(int val)
        {

            string retVal = null;
            if (val == 1)
            {
                retVal = "Bireysel";

                return retVal;

            }
            else if (val == 2)
            {
                retVal = "Kurumsal";

                return retVal;
            }
            else
            {
                retVal = "Diğer";

                return retVal;
            }

        }
    }
}
