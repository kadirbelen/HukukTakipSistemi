using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.Web.Models.Ihtar;
using Hukuk.Takip.Sistemi.Web.Models.Musteri;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hukuk.Takip.Sistemi.Web.Controllers.Ihtar
{
    public class IhtarGuncellemeController : Controller
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






            IhtarGuncellemeViewModel ihtarGuncelleme = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/Ihtarlar/GetById");
                var responseTask = client.GetAsync("GetById?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IhtarGuncellemeViewModel>();
                    readTask.Wait();

                    ihtarGuncelleme = readTask.Result;
                    ViewBag.Musteriler = Musteriler.Where(p => p.Value == ihtarGuncelleme.MusteriId.ToString()).ToList();

                }
            }
            return View(ihtarGuncelleme);
        }


        [HttpPost]
        public IActionResult Update(IhtarGuncellemeViewModel ihtarGuncelleme)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/Ihtarlar/UpdateIhtar");
                var putTask = client.PutAsJsonAsync<IhtarGuncellemeViewModel>("UpdateIhtar", ihtarGuncelleme);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "IhtarIzleme");
                }
            }
            return View(ihtarGuncelleme);
        }

    }
}
