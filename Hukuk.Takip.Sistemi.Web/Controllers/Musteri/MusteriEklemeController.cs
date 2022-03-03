using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.Web.Models.Musteri;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hukuk.Takip.Sistemi.Web.Controllers.Musteri
{
    public class MusteriEklemeController : Controller
    {
        
        public IActionResult Index()
        {


            //MusteriEklemeViewModel musteriEklemeViewModel = new MusteriEklemeViewModel();
            //musteriEklemeViewModel.selectCinsiyetListItems = CinsiyetList();
            //musteriEklemeViewModel.selectMedeniHalListItems = MedeniHalList();

            ViewBag.cinsiyetler = CinsiyetList();

            ViewBag.medeniHaller = MedeniHalList();

            ViewBag.musteriTipler = MusteriTipList();


            return View();

          
           
        }

        private List<SelectListItem> CinsiyetList()
        {
            List<SelectListItem> cinsiyetler = new List<SelectListItem>()
            {
                new SelectListItem { Value = "0", Text = "Seçiniz" },
                new SelectListItem { Value = "1", Text = "Erkek" },
                new SelectListItem { Value = "2", Text = "Kadın" },

            };

          
             

            return cinsiyetler;
            
        }
        private List<SelectListItem> MedeniHalList()
        {
            List<SelectListItem> medeniHaller = new List<SelectListItem>()
            {
                new SelectListItem { Value = "0", Text = "Seçiniz" },
                new SelectListItem { Value = "1", Text = "Bekar" },
                new SelectListItem { Value = "2", Text = "Evli" },

            };

            return medeniHaller;
          
        }
        private List<SelectListItem> MusteriTipList()
        {
            List<SelectListItem> musteriTipler = new List<SelectListItem>()
            {
                new SelectListItem { Value = "0", Text = "Seçiniz" },
                new SelectListItem { Value = "1", Text = "Bireysel" },
                new SelectListItem { Value = "2", Text = "Kurumsal" },

            };
           
            return musteriTipler;

        }


        [HttpPost]
        public IActionResult Create(MusteriEklemeViewModel musteriModel)
        {

           musteriModel.MedeniHali = MedeniHalList().Where(p => p.Value == musteriModel.MedeniHalID.ToString()).Select(p => p.Text).FirstOrDefault();

           musteriModel.Cinsiyet = CinsiyetList().Where(p => p.Value == musteriModel.CinsiyetID.ToString()).Select(p => p.Text).FirstOrDefault();


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/musteriler/CreateMusteri");
                var postTask = client.PostAsJsonAsync<MusteriEklemeViewModel>("CreateMusteri", musteriModel);
                postTask.Wait();

                var result = postTask.Result;

                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index", "MusteriIzleme");

                }


            }
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            return View(musteriModel);
        }
    }
}