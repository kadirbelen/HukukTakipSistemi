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
    public class MusteriGuncellemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private List<SelectListItem> CinsiyetList()
        {
            List<SelectListItem> cinsiyetler = new List<SelectListItem>()
            {
              
                new SelectListItem { Value = "1", Text = "Erkek" },
                new SelectListItem { Value = "2", Text = "Kadın" },

            };




            return cinsiyetler;

        }
        private List<SelectListItem> MedeniHalList()
        {
            List<SelectListItem> medeniHaller = new List<SelectListItem>()
            {
              
                new SelectListItem { Value = "1", Text = "Bekar" },
                new SelectListItem { Value = "2", Text = "Evli" },

            };

            return medeniHaller;

        }
        private List<SelectListItem> MusteriTipList()
        {
            List<SelectListItem> musteriTipler = new List<SelectListItem>()
            {
           
                new SelectListItem { Value = "1", Text = "Bireysel" },
                new SelectListItem { Value = "2", Text = "Kurumsal" },

            };

            return musteriTipler;

        }


        public IActionResult Edit(int id)
        {
            MusteriGuncellemeViewModel musteriGuncelleme = null;
           

            using (var client=new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/musteriler/GetById");
                var responseTask = client.GetAsync("GetById?id=" + id.ToString());

                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<MusteriGuncellemeViewModel>();
                    readTask.Wait();

                    musteriGuncelleme = readTask.Result;
                    ViewBag.cinsiyetler = CinsiyetList().Where(p => p.Text == musteriGuncelleme.Cinsiyet.ToString()).ToList();

                    ViewBag.medeniHaller = MedeniHalList().Where(p => p.Text == musteriGuncelleme.MedeniHali.ToString()).ToList();

                    ViewBag.musteriTipler = MusteriTipList().Where(p => p.Value == musteriGuncelleme.MusteriTipi.ToString()).ToList();


                }
            }
            return View(musteriGuncelleme);
        }

        [HttpPost]
        public IActionResult Update(MusteriGuncellemeViewModel musteriGuncellemeModel)
        {
            musteriGuncellemeModel.MedeniHali = MedeniHalList().Where(p => p.Value == musteriGuncellemeModel.MedeniHalID.ToString()).Select(p => p.Text).FirstOrDefault();

            musteriGuncellemeModel.Cinsiyet = CinsiyetList().Where(p => p.Value == musteriGuncellemeModel.CinsiyetID.ToString()).Select(p => p.Text).FirstOrDefault();
            using (var client=new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/musteriler/UpdateMusteri");
                var putTask = client.PutAsJsonAsync<MusteriGuncellemeViewModel>("UpdateMusteri", musteriGuncellemeModel);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "MusteriIzleme");
                }
            }
            return View(musteriGuncellemeModel);
        }
    }
}