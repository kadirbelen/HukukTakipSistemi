using Hukuk.Takip.Sistemi.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.Entities.Context
{
    public class HukukTakipDbContext:DbContext
    {
        public HukukTakipDbContext(DbContextOptions<HukukTakipDbContext> options) : base(options)
        {

        }
        public HukukTakipDbContext()
        {

        }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<MusteriAdres> MusteriAdresler { get; set; }
        public DbSet<MusteriTelefon> MusteriTelefonlar { get; set; }
        public DbSet<MusteriUrun> MusteriUrunler { get; set; }
        public DbSet<Ihtar> Ihtarlar { get; set; }
        public DbSet<IhtarUrun> IhtarUrunler { get; set; }
        public DbSet<Avukat> Avukatlar { get; set; }
        public DbSet<AvukatAtananUrun> AvukatAtananUrunler { get; set; }
        public DbSet<IcraTakip> IcraTakipler { get; set; }

    }
}
