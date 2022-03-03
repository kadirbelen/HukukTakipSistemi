using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hukuk.Takip.Sistemi.Entities.Models
{
    public class Musteri
    {

        [Column("Id")]
        [Key]
        public int Id { get; set; }

        [Column("MusteriNo")]
        public long MusteriNo { get; set; }

        [Required]
        [Column("Ad",TypeName ="varchar(25)")]
        public string Ad { get; set; }

        [Required]
        [Column("Soyad", TypeName = "varchar(25)")]
        public string Soyad { get; set;}

        [Column("TCKN", TypeName = "varchar(11)")]
        public string TCKN { get; set; }

        [Column("VKN", TypeName = "varchar(10)")]
        public string VKN { get; set; }

        [Column("PasaportNo", TypeName = "varchar(10)")]
        public string PasaportNo { get; set; }

 
        [Column("BabaAdi", TypeName = "varchar(25)")]
        public string BabaAdi { get; set; }

        [Column("AnaAdi", TypeName = "varchar(25)")]
        public string AnaAdi { get; set; }

        [Column("DogumYeri", TypeName = "varchar(25)")]
        public string DogumYeri { get; set; }

        [Column("DogumTarihi")]
        public DateTime? DogumTarihi { get; set; }

        [Column("Cinsiyet", TypeName = "varchar(10)")]
        public string Cinsiyet { get; set; }

        [Column("MedeniHali", TypeName = "varchar(10)")]
        public string MedeniHali { get; set; }

        [Column("MusteriTipi")]
        public int MusteriTipi { get; set; }

        [Column("TakipSubeKodu")]
        public int? TakipSubeKodu { get; set; }

        [Column("TakipSubeAdi", TypeName = "varchar(100)")]
        public string TakipSubeAdi { get; set; }

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

        [Column("HayattaMi")]
        public bool HayattaMi { get; set; }

        [Column("VefatTarihi")]
        public DateTime? VefatTarihi { get; set; }

      
    }
}
