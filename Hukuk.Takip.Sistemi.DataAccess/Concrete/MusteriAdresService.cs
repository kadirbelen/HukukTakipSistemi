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
    public class MusteriAdresService : EfEntityRepositoryBase<MusteriAdres>, IMusteriAdresService
    {
        HukukTakipDbContext _hukukTakipDbContext;

        public MusteriAdresService(HukukTakipDbContext context) : base(context)
        {
            _hukukTakipDbContext = context;
        }

        public async Task<List<MusteriAdresDto>> GetMusteriAdresler()
        {

            var result = from adres in _hukukTakipDbContext.MusteriAdresler
                         join musteri in _hukukTakipDbContext.Musteriler on adres.MusteriId equals musteri.Id
                         select new MusteriAdresDto
                         {
                             Id = adres.Id,
                             Ad = musteri.Ad,
                             Adres = adres.Adres,
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
                             Sehir = adres.Sehir,
                             Ilce = adres.Ilce,
                             Mahalle = adres.Mahalle,

                         };

            return await result.ToListAsync();



        }
    }
}
