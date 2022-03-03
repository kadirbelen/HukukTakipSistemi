using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using Hukuk.Takip.Sistemi.Entities.Context;
using Hukuk.Takip.Sistemi.Entities.Dto;
using Hukuk.Takip.Sistemi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Hukuk.Takip.Sistemi.DataAccess.Concrete
{
    public class IcraTakipService : EfEntityRepositoryBase<IcraTakip>, IIcraTakipService
    {
        HukukTakipDbContext _hukukTakipDbContext;
        public IcraTakipService(HukukTakipDbContext context) : base(context)
        {
            _hukukTakipDbContext = context;
        }

        public async Task<List<IcraTakipDto>> GetIcraTakipler()
        {
            var result = from icra in _hukukTakipDbContext.IcraTakipler 
                         join musteri in _hukukTakipDbContext.Musteriler on icra.MusteriId equals musteri.Id
                         join avukat in _hukukTakipDbContext.Avukatlar on icra.AvukatId equals avukat.Id
                         join avukatAtanan in _hukukTakipDbContext.AvukatAtananUrunler on icra.AvukatAtananUrunlerId equals avukatAtanan.Id
                         select new IcraTakipDto
                         {
                             Id = icra.Id,
                             IcraDairesi=icra.IcraDairesi,
                             Aciklama=icra.Aciklama,
                             DosyaNo=icra.DosyaNo,
                             TakipTarihi=icra.TakipTarihi,
                             Ad = musteri.Ad,
                             Soyad = musteri.Soyad,
                             MusteriNo = musteri.MusteriNo,
                             AvukatAd=avukat.Ad,
                             AvukatSoyad=avukat.Soyad,
                             AvukatTelNo=avukat.TelNo,
                             AvukatTip=avukat.Tip,
                             KabulTarihi=avukatAtanan.KabulTarihi,
                             DelegasyonTarihi=avukatAtanan.DelegasyonTarihi
                         };

            return await result.ToListAsync();
        }
    }
}
