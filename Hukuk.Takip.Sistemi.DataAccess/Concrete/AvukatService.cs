using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using Hukuk.Takip.Sistemi.Entities.Context;
using Hukuk.Takip.Sistemi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.DataAccess.Concrete
{
    public class AvukatService : EfEntityRepositoryBase<Avukat>, IAvukatService
    {
        public AvukatService(HukukTakipDbContext context) : base(context)
        {
        }
    }
}
