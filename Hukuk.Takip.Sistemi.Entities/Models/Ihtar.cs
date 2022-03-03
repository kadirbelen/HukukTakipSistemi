using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hukuk.Takip.Sistemi.Entities.Models
{
    public class Ihtar
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }

        [ForeignKey("Musteri")]
        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }

        [Required]
        [Column("NoterAd", TypeName = "varchar(100)")]
        public string NoterAd { get; set; }

        [Column("TakipHesapNo", TypeName = "varchar(25)")]
        public string TakipHesapNo { get; set; }

        [Column("IhtarTarihi")]
        public DateTime IhtarTarihi { get; set; }

        [Column("IhtarTebliğTarihi")]
        public DateTime? IhtarTebligTarihi { get; set; }

        [Column("IhtarTutar")]
        public decimal? IhtarTutar { get; set; }

        [Column("YevmiyeNo")]
        public int? YevmiyeNo { get; set; }

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


       // public virtual List<IhtarUrun> IhtarUrunler { get; set; }
        

    }
}
