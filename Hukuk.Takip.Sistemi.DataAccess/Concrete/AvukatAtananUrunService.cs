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
    public class AvukatAtananUrunService : EfEntityRepositoryBase<AvukatAtananUrun>, IAvukatAtananUrunService
    {
        HukukTakipDbContext _hukukTakipDbContext;
        public AvukatAtananUrunService(HukukTakipDbContext context) : base(context)
        {
            _hukukTakipDbContext = context;
        }

        public async Task<List<AvukatAtananUrunDto>> GetAvukatAtananUrunler()
        {
            var result = from avukatAtanan in _hukukTakipDbContext.AvukatAtananUrunler
                         join musteri in _hukukTakipDbContext.Musteriler on avukatAtanan.MusteriId equals musteri.Id
                         join musteriUrun in _hukukTakipDbContext.MusteriUrunler on avukatAtanan.MusteriUrunId equals musteriUrun.Id
                         join avukat in _hukukTakipDbContext.Avukatlar on avukatAtanan.AvukatId equals avukat.Id

                         select new AvukatAtananUrunDto
                         {
                             Id = avukatAtanan.Id,
                             Ad = musteri.Ad,
                             Soyad = musteri.Soyad,
                             MusteriId=musteri.Id,
                             MusteriNo = musteri.MusteriNo,
                             MusteriUrunId=musteriUrun.Id,
                             UrunAd = musteriUrun.UrunAd,
                             UrunTipKod = musteriUrun.UrunTipKod,
                             TakipSubeAd = musteriUrun.TakipSubeAd,
                             TakipHesapNo = musteriUrun.TakipHesapNo,
                             TakipSubeKod = musteriUrun.TakipSubeKod,
                             AvukatAd = avukat.Ad,
                             AvukatSoyad = avukat.Soyad,
                             AvukatTelNo = avukat.TelNo,
                             AvukatTip = avukat.Tip,
                             DosyaYetkisi = avukat.DosyaYetkisi,
                             Durum=avukatAtanan.Durum

                         }; 

            return await result.ToListAsync();


        }
    }
}
