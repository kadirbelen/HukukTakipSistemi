using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.Web.Models.Musteri;
using Hukuk.Takip.Sistemi.Web.Models.MusteriUrun;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hukuk.Takip.Sistemi.Web.Controllers.MusteriUrunler
{
    public class MusteriUrunGuncellemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Edit(int id)
        {
            List<MusteriIzlemeViewModel> model = new List<MusteriIzlemeViewModel>();
            List<SelectListItem> Musteriler = new List<SelectListItem>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/musteriler/getall");

                var responseTask = client.GetAsync("getall");
                responseTask.Wait();

                var result = responseTask.Result;

              
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<MusteriIzlemeViewModel>>();
                    readTask.Wait();
                    model = readTask.Result;

                   


                    foreach (var item in model)
                    {

                        Musteriler.Add(
                            new SelectListItem
                            {
                                Value = item.Id.ToString(),
                                Text = item.Ad + ' ' + item.Soyad,
                                Selected=true
                               
                            });

                        ViewBag.Musteriler = Musteriler;
                    }

                  

                }

                 



            }

            MusteriUrunGuncellemeViewModel musteriGuncelleme = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/MusteriUrunler/GetById");
                var responseTask = client.GetAsync("GetById?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<MusteriUrunGuncellemeViewModel>();
                    readTask.Wait();

                    musteriGuncelleme = readTask.Result;

                    ViewBag.Musteriler = Musteriler.Where(p => p.Value == musteriGuncelleme.MusteriId.ToString()).ToList();

                }
            }
            return View(musteriGuncelleme);
        }

        [HttpPost]
        public IActionResult Update(MusteriUrunGuncellemeViewModel musteriGuncellemeModel)
        {
            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/MusteriUrunler/UpdateMusteriUrun");
                var putTask = client.PutAsJsonAsync<MusteriUrunGuncellemeViewModel>("UpdateMusteriUrun", musteriGuncellemeModel);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "MusteriUrunIzleme");
                }
            }
            return View(musteriGuncellemeModel);
        }
    }
}