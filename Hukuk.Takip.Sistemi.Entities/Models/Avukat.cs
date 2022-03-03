using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hukuk.Takip.Sistemi.Entities.Models
{
    public class Avukat
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("Ad", TypeName = "varchar(50)")]
        public string  Ad { get; set; }

        [Required]
        [Column("Soyad", TypeName = "varchar(50)")]
        public string Soyad { get; set; }

        [Column("Tip", TypeName = "varchar(150)")]
        public string Tip { get; set; }

        [Column("DosyaYetkisi")]
        public bool DosyaYetkisi { get; set; }

        [Required]
        [Column("TelNo", TypeName = "varchar(20)")]
        public string TelNo { get; set; }

        [Column("FaxNo", TypeName = "varchar(50)")]
        public string FaxNo { get; set; }

        [Required]
        [Column("TCKN", TypeName = "varchar(11)")]
        public string TCKN { get; set; }

        [Column("AktifMi")]
        public bool AktifMi { get; set; }

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
