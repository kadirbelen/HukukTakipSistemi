﻿using Hukuk.Takip.Sistemi.Entities.Dto;
using Hukuk.Takip.Sistemi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.DataAccess.Abstract
{
    public interface IAvukatAtananUrunService:IEntityRepository<AvukatAtananUrun>
    {
        Task<List<AvukatAtananUrunDto>> GetAvukatAtananUrunler();
    }
}
