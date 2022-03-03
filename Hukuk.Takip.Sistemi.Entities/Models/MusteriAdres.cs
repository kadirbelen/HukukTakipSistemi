using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hukuk.Takip.Sistemi.Entities.Models
{
    public class MusteriAdres
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }//pk

        [ForeignKey("Musteri")]
        public int MusteriId { get; set; }//fk
        public Musteri Musteri { get; set; }

        [Required]
        [Column("AdresTipi", TypeName = "varchar(25)")]
        public string AdresTipi { get; set; }

        [Required]
        [Column("AnaAdresMi")]
        public bool AnaAdresMi { get; set; }

        [Required]
        [Column("Adres", TypeName = "varchar(300)")]
        public string Adres { get; set; }

        [Required]
        [Column("Mahalle", TypeName = "varchar(50)")]
        public string Mahalle { get; set; }

        [Required]
        [Column("Ilce", TypeName = "varchar(40)")]
        public string Ilce { get; set; }

        [Required]
        [Column("Sehir", TypeName = "varchar(30)")]
        public string Sehir { get; set; }

        [Required]
        [Column("PostaKodu", TypeName = "varchar(5)")]
        public string PostaKodu { get; set; }

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
