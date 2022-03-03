using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hukuk.Takip.Sistemi.Entities.Models
{
    public class IhtarUrun
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }

        [ForeignKey("Ihtar")]
        public int IhtarId { get; set; }
        public Ihtar Ihtar { get; set; }

        [ForeignKey("MusteriUrun")]
        public int MusteriUrunId { get; set; }
        public MusteriUrun MusteriUrun { get; set; }


        [Column("IhtarTutar")]
        public decimal? IhtarTutar { get; set; }

        [Column("AnaParaTutar")]
        public decimal? AnaParaTutar { get; set; }

        [Column("FaizTutar")]
        public decimal? FaizTutar { get; set; }

        [Column("KomisyonTutar")]
        public decimal? KomisyonTutar { get; set; }

        [Column("ToplamBorc")]
        public decimal? ToplamBorc { get; set; }

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
