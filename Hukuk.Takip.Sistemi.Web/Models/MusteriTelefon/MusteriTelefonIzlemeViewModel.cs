using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.Web.Models.MusteriTelefon
{
    public class MusteriTelefonIzlemeViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Müşteri No")]
        public long MusteriNo { get; set; }
        [Display(Name = "Ad")]
        public string Ad { get; set; }
        [Display(Name = "Soyad")]
        public string Soyad { get; set; }
        [Display(Name = "TC Kimlik No")]
        public string TCKN { get; set; }
        [Display(Name = "Vergi Kimlik No")]
        public string VKN { get; set; }
        [Display(Name = "Baba Adı")]
        public string BabaAdi { get; set; }
        [Display(Name = "Anne Adı")]
        public string AnaAdi { get; set; }
        [Display(Name = "Doğum Yeri")]
        public string DogumYeri { get; set; }
        [Display(Name = "Doğum Tarihi")]
        public DateTime? DogumTarihi { get; set; }
        [Display(Name = "Müşteri Tipi")]
        public string MusteriTipi { get; set; }
        [Display(Name = "Takip Şube Kodu")]
        public int? TakipSubeKodu { get; set; }
        [Display(Name = "Takip Şube Adı")]
        public string TakipSubeAdi { get; set; }
        [Display(Name = "Telefon Tipi")]
        public string TelefonTİpi { get; set; }
        [Display(Name = "Telefon No")]
        public string TelefonNo { get; set; }
    }
}
