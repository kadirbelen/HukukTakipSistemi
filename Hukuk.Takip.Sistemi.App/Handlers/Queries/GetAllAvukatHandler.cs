using Hukuk.Takip.Sistemi.App.Queries.Request;
using Hukuk.Takip.Sistemi.App.Queries.Response;
using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace Hukuk.Takip.Sistemi.App.Handlers.Queries
{
    public class GetAllAvukatHandler : IRequestHandler<GetAllAvukatRequest, List<GetAllAvukatResponse>>
    {
        IAvukatService _avukatService;

        public GetAllAvukatHandler(IAvukatService avukatService)
        {
            _avukatService = avukatService;
        }

        public async Task<List<GetAllAvukatResponse>> Handle(GetAllAvukatRequest request, CancellationToken cancellationToken)
        {
            var result = await _avukatService.GetAllAsync();
            var response = result.Select(p => new GetAllAvukatResponse
            {
                Id = p.Id,
                Ad = p.Ad,
                Soyad = p.Soyad,
                TCKN = p.TCKN,
                TelNo = p.TelNo,
                FaxNo = p.FaxNo,
                Tip = p.Tip,
                DosyaYetkisi = p.DosyaYetkisi,
                AktifMi = p.AktifMi,
                EklenmeTarihi = p.EklenmeTarihi,
                EkleyenKisi = p.EkleyenKisi,
                GuncellenmeTarihi = p.GuncellenmeTarihi,
                Guncelleyen = p.Guncelleyen,
                SilindiMi = p.SilindiMi,
              
            }).ToList();

            return response;
        }
    }
}
