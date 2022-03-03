using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using Hukuk.Takip.Sistemi.Entities.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Hukuk.Takip.Sistemi.DataAccess.Concrete
{
    /// <summary>
    /// Veri Tabanı ekleme metodlarımız generic olarak oşuşturuldu.
    /// Metodlarımız asenkron olarak oluşturmamızın sebebi app katmanındaki handle sınıflarımızın asenkron çalışmasıdır.
    /// </summary>
    /// <typeparam name="Tentity"></typeparam>
    public class EfEntityRepositoryBase<Tentity> : IEntityRepository<Tentity>
         where Tentity : class

    {
        HukukTakipDbContext _context;
        private DbSet<Tentity> entities;

        public EfEntityRepositoryBase(HukukTakipDbContext context)
        {
            _context = context;
            entities = context.Set<Tentity>();
        }
        

       
        public async Task InsertAsync(Tentity entity)
        {
            await entities.AddAsync(entity);
            await _context.SaveChangesAsync();
            
            
        }

        public async Task<List<Tentity>> GetAllAsync()
        {

            return await entities.ToListAsync();
        }

        public async Task UpdateAsync(Tentity entity)
        {
            entities.Update(entity);
            await _context.SaveChangesAsync();
           
        }

        public async Task DeleteAsync(Tentity entity)
        {
            entities.Remove(entity);
            await _context.SaveChangesAsync();
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Kullanıcıdan alıcağımız id parametresine göre o ürünün bilgilerini getirme</param>
        /// <returns></returns>
        public async Task<Tentity> GetAsync(Expression<Func<Tentity, bool>> filter)
        {
            return await entities.SingleOrDefaultAsync(filter);
        }
    }
}
