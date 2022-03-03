using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hukuk.Takip.Sistemi.Entities.Models
{
    public class IcraTakip
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }

        [ForeignKey("Musteri")]
        public int? MusteriId { get; set; }//fk
        public Musteri Musteri { get; set; }

        [ForeignKey("Avukat")]
        public int? AvukatId { get; set; }
        public Avukat Avukat { get; set; }

        [ForeignKey("AvukatAtananUrun")]
        public int AvukatAtananUrunlerId { get; set; }
        public AvukatAtananUrun AvukatAtananUrun { get; set; }

        [Required]
        [Column("TakipTipi", TypeName = "varchar(50)")]
        public string TakipTipi { get; set; }

        [Required]
        [Column("IcraDairesi", TypeName = "varchar(100)")]
        public string IcraDairesi { get; set; }

        [Column("TakipTarihi")]
        public DateTime TakipTarihi { get; set; }

        [Column("Aciklama", TypeName = "varchar(300)")]
        public string Aciklama { get; set; }

        [Required]
        [Column("DosyaNo", TypeName = "varchar(150)")]
        public string DosyaNo { get; set; }


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
