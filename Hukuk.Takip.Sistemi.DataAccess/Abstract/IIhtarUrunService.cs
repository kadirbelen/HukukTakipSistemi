using Hukuk.Takip.Sistemi.Entities.Dto;
using Hukuk.Takip.Sistemi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.DataAccess.Abstract
{
    public interface IIhtarUrunService:IEntityRepository<IhtarUrun>
    {
        Task<List<IhtarUrunDto>> GetIhtarUrunleri(int id);
    }
}
