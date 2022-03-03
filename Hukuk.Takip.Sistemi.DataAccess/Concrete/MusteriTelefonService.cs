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
    public class MusteriTelefonService : EfEntityRepositoryBase<MusteriTelefon>,IMusteriTelefonService
    {
        HukukTakipDbContext _hukukTakipDbContext;
        public MusteriTelefonService(HukukTakipDbContext context) : base(context)
        {
            _hukukTakipDbContext = context;
        }

        public async Task<List<MusteriTelefonDto>> GetMusteriTelefonlar()
        {
            var result = from telefon in _hukukTakipDbContext.MusteriTelefonlar
                         join musteri in _hukukTakipDbContext.Musteriler on telefon.MusteriId equals musteri.Id
                         select new MusteriTelefonDto
                         {
                             Id = telefon.Id,
                             Ad = musteri.Ad,
                             Soyad = musteri.Soyad,
                             TCKN = musteri.TCKN,
                             AnaAdi = musteri.AnaAdi,
                             BabaAdi = musteri.BabaAdi,
                             TakipSubeAdi = musteri.TakipSubeAdi,
                             TakipSubeKodu = musteri.TakipSubeKodu,
                             DogumTarihi = musteri.DogumTarihi,
                             DogumYeri = musteri.DogumYeri,
                             VKN = musteri.VKN,
                             MusteriNo = musteri.MusteriNo,
                             MusteriTipi = musteri.MusteriTipi,
                             TelefonNo = telefon.TelefonNo,
                             TelefonTİpi = telefon.TelefonTİpi


                         };

            return await result.ToListAsync();
        }
    }
}
