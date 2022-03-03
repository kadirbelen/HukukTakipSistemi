using Hukuk.Takip.Sistemi.App.Queries.Request;
using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Hukuk.Takip.Sistemi.App.Queries.Response;

namespace Hukuk.Takip.Sistemi.App.Handlers.Queries
{
    public class GetAllMusteriHandler : IRequestHandler<GetAllMusteriRequest, List<GetAllMusteriResponse>>
    {
        IMusteriService _musteriService;

        public GetAllMusteriHandler(IMusteriService musteriService)
        {
            _musteriService = musteriService;
        }


        public async Task<List<GetAllMusteriResponse>> Handle(GetAllMusteriRequest request, CancellationToken cancellationToken)
        {
            var result = await _musteriService.GetAllAsync();
                
                
            var response=result.Select(m => new GetAllMusteriResponse
            {
                
                Ad = m.Ad,
                Id=m.Id,
                Soyad = m.Soyad,
                AnaAdi = m.AnaAdi,
                BabaAdi = m.BabaAdi,
                Cinsiyet = m.Cinsiyet,
                DogumTarihi = m.DogumTarihi,
                DogumYeri = m.DogumYeri,
                MusteriNo = m.MusteriNo,
                MedeniHali = m.MedeniHali,
                MusteriTipi = MusteriTip(m.MusteriTipi),
                TakipSubeAdi = m.TakipSubeAdi,
                TakipSubeKodu = m.TakipSubeKodu,
                TCKN = m.TCKN,
                VKN = m.VKN,
                PasaportNo = m.PasaportNo,
                Guncelleyen = m.Guncelleyen,
                GuncellenmeTarihi = m.GuncellenmeTarihi,
                EkleyenKisi = m.EkleyenKisi,
                EklenmeTarihi = m.EklenmeTarihi,
                SilindiMi = m.SilindiMi,
                HayattaMi = m.HayattaMi,
                VefatTarihi = m.VefatTarihi
            }).ToList();

            return response;
        }


        public string  MusteriTip(int val)
        {

            string retVal = null;
            if(val == 1)
            {
                retVal = "Bireysel";

                return retVal;
                
            }
            else if(val == 2)
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
