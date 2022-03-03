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
    public class MusteriUrunService : EfEntityRepositoryBase<MusteriUrun>, IMusteriUrunService
    {
        HukukTakipDbContext _hukukTakipDbContext;
        public MusteriUrunService(HukukTakipDbContext context) : base(context)
        {
            _hukukTakipDbContext = context;
        }

        public async Task<List<MusteriUrunDto>> GetMusteriUrunler()
        {
            var result = from urun in _hukukTakipDbContext.MusteriUrunler
                         join musteri in _hukukTakipDbContext.Musteriler on urun.MusteriId equals musteri.Id
                         select new MusteriUrunDto
                         {
                             Id = urun.Id,
                             Ad = musteri.Ad,
                             Soyad = musteri.Soyad,
                             MusteriNo = musteri.MusteriNo,
                             MusteriId=musteri.Id,
                             MusteriUrunId=musteri.Id,
                             UrunAd = urun.UrunAd,
                             UrunTipKod = urun.UrunTipKod,
                             UrunDurumu = urun.UrunDurumu,
                             ParaBirimi = urun.ParaBirimi,
                             FaizSubeAd = urun.FaizSubeAd,
                             FaizHesap = urun.FaizHesap,
                             FaizSubeKod = urun.FaizSubeKod,
                             FaizTutar = urun.FaizTutar,
                             MasrafHesap = urun.MasrafHesap,
                             MasrafSubeAd = urun.MasrafSubeAd,
                             MasrafSubeKodu = urun.MasrafSubeKodu,
                             MasrafTutar = urun.MasrafTutar,
                             TakipHesapNo = urun.TakipHesapNo,
                             TakipSubeAd = urun.TakipSubeAd,
                             TakipSubeKod = urun.TakipSubeKod,
                             TakipTarihi = urun.TakipTarihi,
                             TakipTutar = urun.TakipTutar,
                             OnErteleme = urun.OnErteleme,
                             ErtelemeVarMi = urun.ErtelemeVarMi,
                             



                         };

            return await result.ToListAsync();
        }
    }
}
