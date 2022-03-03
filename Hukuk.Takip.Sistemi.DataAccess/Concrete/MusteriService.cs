using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using Hukuk.Takip.Sistemi.Entities.Context;
using Hukuk.Takip.Sistemi.Entities.Dto;
using Hukuk.Takip.Sistemi.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.DataAccess.Concrete
{
    public class MusteriService : EfEntityRepositoryBase<Musteri>, IMusteriService
    {
        HukukTakipDbContext _hukukTakipDbContext;

        public MusteriService(HukukTakipDbContext context) : base(context)
        {
            _hukukTakipDbContext = context;
        }

       
       

       

        public async Task<Musteri> GetMusteriNo(long musteriNo)
        {
            var result = from musteri in _hukukTakipDbContext.Musteriler
                         where musteri.MusteriNo == musteriNo
                         select new Musteri
                         {
                             Ad = musteri.Ad,
                             Soyad = musteri.Soyad,
                             TCKN = musteri.TCKN,
                             MusteriNo = musteri.MusteriNo,
                             MusteriTipi = musteri.MusteriTipi

                         };

            return await result.FirstOrDefaultAsync();

        }

     
    }
}
