using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hukuk.Takip.Sistemi.Web.Models.Musteri
{
    public class MusteriEklemeViewModel
    {

        public long MusteriNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public string VKN { get; set; }
        public string PasaportNo { get; set; }
        public string BabaAdi { get; set; }
        public string AnaAdi { get; set; }
        public string DogumYeri { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string MedeniHali { get; set; }
        public int MusteriTipi { get; set; }
        public int? TakipSubeKodu { get; set; }
        public string TakipSubeAdi { get; set; }
        public DateTime? GuncellenmeTarihi { get; set; }
        public string Guncelleyen { get; set; }
        public bool SilindiMi { get; set; }
        public DateTime? EklenmeTarihi { get; set; }
        public string EkleyenKisi { get; set; }
        public bool HayattaMi { get; set; }
        public DateTime? VefatTarihi { get; set; }

       // public int MusteriTipID { get; set; }
        public int CinsiyetID { get; set; }

        public int MedeniHalID { get; set; }

       // public  List<SelectListItem> selectCinsiyetListItems { get; set; } = new List<SelectListItem>();

       //public List<SelectListItem> selectMedeniHalListItems { get; set; } = new List<SelectListItem>();
    }
}
