using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hukuk.Takip.Sistemi.Entities.Models
{
    public class MusteriUrun
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }

       
        [ForeignKey("Musteri")]
        public int? MusteriId { get; set; }
        public Musteri Musteri { get; set; }

        [Required]
        [Column("UrunAd", TypeName = "varchar(40)")]
        public string UrunAd { get; set; }

        [Required]
        [Column("UrunTipKod", TypeName = "varchar(40)")]
        public string UrunTipKod { get; set; }


        [Column("TakipSubeKod", TypeName = "varchar(25)")]
        public int TakipSubeKod { get; set; }

        [Required]
        [Column("TakipSubeAd", TypeName = "varchar(50)")]
        public string TakipSubeAd { get; set; }

        [Required]
        [Column("TakipHesapNo", TypeName = "varchar(8)")]
        public string TakipHesapNo { get; set; }


        [Column("TakipTutar", TypeName = "varchar(40)")]
        public decimal TakipTutar { get; set; }

        [Required]
        [Column("ParaBirimi", TypeName = "varchar(20)")]
        public string ParaBirimi { get; set; }


        [Column("TakipTarihi")]
        public DateTime TakipTarihi { get; set; }


        [Column("MasrafSubeKodu")]
        public int MasrafSubeKodu { get; set; }

        [Required]
        [Column("MasrafSubeAd", TypeName = "varchar(140)")]
        public string MasrafSubeAd { get; set; }

        [Required]
        [Column("MasrafHesap", TypeName = "varchar(8)")]
        public string MasrafHesap { get; set; }


        [Column("MasrafTutar")]
        public decimal MasrafTutar { get; set; }

        [Column("FaizSubeKod", TypeName = "varchar(25)")]
        public int FaizSubeKod { get; set; }

        [Required]
        [Column("FaizSubeAd", TypeName = "varchar(125)")]
        public string FaizSubeAd { get; set; }

        [Required]
        [Column("FaizHesap", TypeName = "varchar(8)")]
        public string FaizHesap { get; set; }

        [Column("FaizTutar")]
        public decimal FaizTutar { get; set; }

        [Column("ErtelemeVarMi")]
        public bool ErtelemeVarMi { get; set; }

        [Column("OnErteleme", TypeName = "varchar(20)")]
        public string OnErteleme { get; set; }

        [Column("UrunDurumu", TypeName = "varchar(140)")]
        public string UrunDurumu { get; set; }

        [Column("ToplamRiskTutar")]
        public decimal? ToplamRiskTutar { get; set; }

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
