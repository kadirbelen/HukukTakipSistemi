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
    public class GetIcraTakiplerHandler : IRequestHandler<GetIcraTakiplerRequest, List<GetIcraTakiplerResponse>>
    {
        IIcraTakipService _icraTakipService;

        public GetIcraTakiplerHandler(IIcraTakipService icraTakipService)
        {
            _icraTakipService = icraTakipService;
        }

        public async Task<List<GetIcraTakiplerResponse>> Handle(GetIcraTakiplerRequest request, CancellationToken cancellationToken)
        {
            var result = await _icraTakipService.GetIcraTakipler();
            var response = result.Select(p => new GetIcraTakiplerResponse
            {
                Id = p.Id,
                Ad = p.Ad,
                Soyad = p.Soyad,
                IcraDairesi = p.IcraDairesi,
                Aciklama = p.Aciklama,
                DosyaNo = p.DosyaNo,
                TakipTarihi = p.TakipTarihi,
                MusteriNo = p.MusteriNo,
                AvukatAd = p.AvukatAd,
                AvukatSoyad = p.AvukatSoyad,
                AvukatTelNo = p.AvukatTelNo,
                AvukatTip = p.AvukatTip,
                KabulTarihi = p.KabulTarihi,
                DelegasyonTarihi = p.DelegasyonTarihi


            }).ToList();
            return response;
        }
    }
}
