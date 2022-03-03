using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hukuk.Takip.Sistemi.Entities.Models
{
    public class MusteriTelefon
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }

       [ForeignKey("Musteri")]
        public int MusteriId { get; set; }
        public  Musteri Musteri { get; set; }

        [Required]
        [Column("TelefonTİpi", TypeName = "varchar(20)")]
        public string TelefonTİpi { get; set; }

        [Required]
        [Column("TelefonNo", TypeName = "varchar(20)")]
        public string TelefonNo { get; set; }

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
