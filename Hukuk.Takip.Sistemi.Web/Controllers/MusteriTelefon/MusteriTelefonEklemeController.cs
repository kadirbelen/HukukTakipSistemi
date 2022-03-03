using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.Web.Models.Musteri;
using Hukuk.Takip.Sistemi.Web.Models.MusteriTelefon;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hukuk.Takip.Sistemi.Web.Controllers.MusteriTelefon
{
    public class MusteriTelefonEklemeController : Controller
    {
        public IActionResult Index()
        {

            List<MusteriIzlemeViewModel> model = new List<MusteriIzlemeViewModel>();
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

                    List<SelectListItem> Musteriler = new List<SelectListItem>();


                    foreach (var item in model)
                    {

                        Musteriler.Add(
                            new SelectListItem
                            {
                                Value = item.Id.ToString(),
                                Text = item.Ad+' '+ item.Soyad,
                            });

                        ViewBag.Musteriler = Musteriler;
                    }

                }



            }
           return View();
        }




        [HttpPost]
        public IActionResult Create(MusteriTelefonEklemeViewModel musteriModel)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/MusteriTelefonlar/CreateMusteriTelefon");
                var postTask = client.PostAsJsonAsync<MusteriTelefonEklemeViewModel>("CreateMusteriTelefon", musteriModel);
                postTask.Wait();

                var result = postTask.Result;

                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index", "MusteriAdresIzleme");

                }


            }
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            return View(musteriModel);
        }
    }
}