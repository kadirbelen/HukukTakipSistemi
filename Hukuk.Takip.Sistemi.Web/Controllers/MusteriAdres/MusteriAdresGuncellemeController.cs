using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.Web.Models.Musteri;
using Hukuk.Takip.Sistemi.Web.Models.MusteriAdres;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hukuk.Takip.Sistemi.Web.Controllers.MusteriAdres
{
    public class MusteriAdresGuncellemeController : Controller
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
                            });

                        ViewBag.Musteriler = Musteriler;
                    }

                }

            }



            MusteriAdresGuncellemeViewModel musteriAdresGuncelleme = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/MusteriAdresler/GetById");
                var responseTask = client.GetAsync("GetById?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<MusteriAdresGuncellemeViewModel>();
                    readTask.Wait();

                    musteriAdresGuncelleme = readTask.Result;
                    ViewBag.Musteriler = Musteriler.Where(p => p.Value == musteriAdresGuncelleme.MusteriId.ToString()).ToList();

                }
            }
            return View(musteriAdresGuncelleme);
        }


        [HttpPost]
        public IActionResult Update(MusteriAdresGuncellemeViewModel musteriAdresGuncelleme)
        {
         
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/MusteriAdresler/UpdateMusteriAdres");
                var putTask = client.PutAsJsonAsync<MusteriAdresGuncellemeViewModel>("UpdateMusteriAdres", musteriAdresGuncelleme);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "MusteriTelefonIzleme");
                }
            }
            return View(musteriAdresGuncelleme);
        }

    }
}