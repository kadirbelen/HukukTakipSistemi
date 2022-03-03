using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hukuk.Takip.Sistemi.Entities.Models
{
    public class AvukatAtananUrun
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }

        [ForeignKey("Musteri")]
        public int MusteriId { get; set; }//fk
        public Musteri Musteri { get; set; }

        [ForeignKey("MusteriUrun")]
        public int MusteriUrunId { get; set; }
        public MusteriUrun MusteriUrun { get; set; }


        [ForeignKey("Avukat")]
        public int AvukatId { get; set; }
        public Avukat Avukat { get; set; }


        [Column("AtamaTarihi")]
        public DateTime AtamaTarihi { get; set; }


        [Column("KabulTarihi")]
        public DateTime KabulTarihi { get; set; }


        [Column("DelegasyonTarihi")]
        public DateTime DelegasyonTarihi { get; set; }

        [Column("Durum", TypeName ="varchar(300)")]
        public string Durum { get; set; }

        [Column("GuncellenmeTarihi")]
        public DateTime? GuncellenmeTarihi { get; set; }


        [Column("Guncelleyen", TypeName = "varchar(20)")]
        public string Guncelleyen { get; set; }


        [Column("SilindiMi")]
        public bool SilindiMi { get; set; }


        [Column("EklenmeTarihi")]
        public DateTime? EklenmeTarihi { get; set; }


        [Column("EkleyenKisi", TypeName = "varchar(20)")]
        public string EkleyenKisi { get; set; }

    }
}
