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
    public class IhtarService : EfEntityRepositoryBase<Ihtar>,IIhtarService
    {
        HukukTakipDbContext _hukukTakipDbContext;
        public IhtarService(HukukTakipDbContext context) : base(context)
        {
            _hukukTakipDbContext = context;
        }

        public async Task<List<IhtarDto>> GetIhtarlar()
        {
            var result = from ihtar in _hukukTakipDbContext.Ihtarlar
                         join musteri in _hukukTakipDbContext.Musteriler on ihtar.MusteriId equals musteri.Id
                         select new IhtarDto
                         {
                             Id = ihtar.Id,
                             Ad = musteri.Ad,
                             Soyad = musteri.Soyad,
                             MusteriNo = musteri.MusteriNo,
                             IhtarTarihi = ihtar.IhtarTarihi,
                             IhtarTebligTarihi = ihtar.IhtarTebligTarihi,
                             NoterAd = ihtar.NoterAd,
                             TakipHesapNo = ihtar.TakipHesapNo,
                             YevmiyeNo = ihtar.YevmiyeNo,
                             IhtarTutar = ihtar.IhtarTutar
                         };

            return await result.ToListAsync();

        }

    }
}
