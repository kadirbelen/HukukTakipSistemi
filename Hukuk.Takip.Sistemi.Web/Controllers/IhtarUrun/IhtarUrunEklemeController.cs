using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.Web.Models.Ihtar;
using Hukuk.Takip.Sistemi.Web.Models.IhtarUrun;
using Hukuk.Takip.Sistemi.Web.Models.MusteriUrun;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hukuk.Takip.Sistemi.Web.Controllers.IhtarUrun
{
    public class IhtarUrunEklemeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.MusteriUrunler = MusteriUrunler();
            ViewBag.Ihtarlar = Ihtarlar();
            return View();
        }

        private List<SelectListItem> MusteriUrunler()
        {

            List<MusteriUrunIzlemeViewModel> model = new List<MusteriUrunIzlemeViewModel>();
            List<SelectListItem> MusteriUrunler = new List<SelectListItem>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/MusteriUrunler/getall");

                var responseTask = client.GetAsync("getall");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<MusteriUrunIzlemeViewModel>>();
                    readTask.Wait();
                    model = readTask.Result;

                    foreach (var item in model)
                    {

                        MusteriUrunler.Add(
                            new SelectListItem
                            {
                                Value = item.Id.ToString(),
                                Text = item.UrunAd
                            });

                    }

                }

            }


            return MusteriUrunler;

        }

        private List<SelectListItem> Ihtarlar()
        {

            List<IhtarIzlemeViewModel> model = new List<IhtarIzlemeViewModel>();
            List<SelectListItem> Ihtarlar = new List<SelectListItem>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/Ihtarlar/getall");

                var responseTask = client.GetAsync("getall");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<IhtarIzlemeViewModel>>();
                    readTask.Wait();
                    model = readTask.Result;

                    foreach (var item in model)
                    {

                        Ihtarlar.Add(
                            new SelectListItem
                            {
                                Value = item.Id.ToString(),
                                Text = "Yevmiye No: "+item.YevmiyeNo + "Noter: " + item.NoterAd + "Takip Hesap: " + item.TakipHesapNo
                            });


                    }

                }

            }


            return Ihtarlar;

        }

        [HttpPost]
        public IActionResult Create(IhtarUrunEklemeViewModel ihtarUrunModel)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/IhtarUrunler/CreateIhtarUrun");
                var postTask = client.PostAsJsonAsync<IhtarUrunEklemeViewModel>("CreateIhtarUrun", ihtarUrunModel);
                postTask.Wait();

                var result = postTask.Result;

                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index", "IhtarUrunIzleme");

                }


            }
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            return View(ihtarUrunModel);
        }

    }
}