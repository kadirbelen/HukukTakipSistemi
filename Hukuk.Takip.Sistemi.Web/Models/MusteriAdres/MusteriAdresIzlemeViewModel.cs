using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.Web.Models.MusteriAdres

{
    public class MusteriAdresIzlemeViewModel
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
        [Display(Name = "Adres")]
        public string Adres { get; set; }
        [Display(Name = "Mahalle")]
        public string Mahalle { get; set; }
        [Display(Name = "İlçe")]
        public string Ilce { get; set; }
        [Display(Name = "Şehir")]
        public string Sehir { get; set; }

    }
}
