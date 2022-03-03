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
using System.Linq.Expressions;

namespace Hukuk.Takip.Sistemi.DataAccess.Concrete
{
    public class IhtarUrunService : EfEntityRepositoryBase<IhtarUrun>,IIhtarUrunService
    {
        HukukTakipDbContext _hukukTakipDbContext;
        public IhtarUrunService(HukukTakipDbContext context) : base(context)
        {
            _hukukTakipDbContext = context;
        }

        public async Task<List<IhtarUrunDto>> GetIhtarUrunleri(int id)
        {
            var result = from ihtarUrun in _hukukTakipDbContext.IhtarUrunler
                         join urunler in _hukukTakipDbContext.MusteriUrunler on ihtarUrun.MusteriUrunId equals urunler.Id
                         join ihtar  in _hukukTakipDbContext.Ihtarlar on ihtarUrun.IhtarId equals ihtar.Id
                         where ihtarUrun.IhtarId == id
                         select new IhtarUrunDto
                         {
                             Id = ihtarUrun.Id,
                             IhtarId=ihtar.Id,
                             IhtarTarihi=ihtar.IhtarTarihi,
                             IhtarTebligTarihi=ihtar.IhtarTebligTarihi,
                             YevmiyeNo=ihtar.YevmiyeNo,
                             IhtarTutar = ihtarUrun.IhtarTutar,
                             AnaParaTutar = ihtarUrun.AnaParaTutar,
                             FaizTutar = ihtarUrun.FaizTutar,
                             KomisyonTutar = ihtarUrun.KomisyonTutar,
                             ToplamBorc = ihtarUrun.ToplamBorc,
                             UrunAd = urunler.UrunAd,
                             UrunTipKod = urunler.UrunTipKod

                         };

            return await result.ToListAsync();

        }
    }
}
