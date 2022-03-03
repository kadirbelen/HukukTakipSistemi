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
    public class CreateIcraTakipHandler : IRequestHandler<CreateIcraTakipRequest, CreateIcraTakipResponse>
    {
        IIcraTakipService _icraTakipService;

        public CreateIcraTakipHandler(IIcraTakipService icraTakipService)
        {
            _icraTakipService = icraTakipService;
        }

        public async Task<CreateIcraTakipResponse> Handle(CreateIcraTakipRequest request, CancellationToken cancellationToken)
        {
            await _icraTakipService.InsertAsync(new IcraTakip
            {
                MusteriId = request.MusteriId,
                AvukatId = request.AvukatId,
                AvukatAtananUrunlerId = request.AvukatAtananUrunlerId,
                IcraDairesi = request.IcraDairesi,
                TakipTarihi = request.TakipTarihi,
                DosyaNo = request.DosyaNo,
                TakipTipi = request.TakipTipi,
                Aciklama = request.Aciklama,
                EkleyenKisi = request.EkleyenKisi,
                EklenmeTarihi = request.EklenmeTarihi,
                Guncelleyen = request.Guncelleyen,
                GuncellenmeTarihi = request.GuncellenmeTarihi,
                SilindiMi = request.SilindiMi,


            });

            return new CreateIcraTakipResponse { };
        }
    }
}
