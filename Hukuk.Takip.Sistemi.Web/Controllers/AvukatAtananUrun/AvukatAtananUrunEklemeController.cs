using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.Web.Models.Avukat;
using Hukuk.Takip.Sistemi.Web.Models.AvukatAtananUrun;
using Hukuk.Takip.Sistemi.Web.Models.Musteri;
using Hukuk.Takip.Sistemi.Web.Models.MusteriUrun;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hukuk.Takip.Sistemi.Web.Controllers.AvukatAtananUrun
{
    public class AvukatAtananUrunEklemeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Avukatlar = Avukatlar();
            AvukatAtananUrunEklemeViewModel avukatAtanan = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/MusteriUrunler/GetById");
                var responseTask = client.GetAsync("GetById?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<AvukatAtananUrunEklemeViewModel>();
                    readTask.Wait();

                    avukatAtanan = readTask.Result;

                    ViewBag.Musteriler = Musteriler().Where(p => p.Value == avukatAtanan.MusteriId.ToString()).ToList();
                    ViewBag.MusteriUrunler = MusteriUrunler().Where(p => p.Value == id.ToString()).ToList();

                }
            }
            return View(avukatAtanan);
        }
        private List<SelectListItem> Musteriler()
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


                    }

                }

                return Musteriler;

            }
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
        private List<SelectListItem> Avukatlar()
        {

            List<AvukatIzlemeViewModel> model = new List<AvukatIzlemeViewModel>();
            List<SelectListItem> Avukatlar = new List<SelectListItem>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/Avukatlar/getall");

                var responseTask = client.GetAsync("getall");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<AvukatIzlemeViewModel>>();
                    readTask.Wait();
                    model = readTask.Result;

                    foreach (var item in model)
                    {

                        Avukatlar.Add(
                            new SelectListItem
                            {
                                Value = item.Id.ToString(),
                                Text = item.Ad+" "+item.Soyad
                            });

                    }

                }

            }


            return Avukatlar;

        }


        [HttpPost]
        public IActionResult Create(AvukatAtananUrunEklemeViewModel avukatAtananUrunModel)
        {

            using (var client = new HttpClient())
            {
                avukatAtananUrunModel.Durum = "Avukat Kabulü Bekleniyor";
                client.BaseAddress = new Uri("http://localhost:57938/api/AvukatAtananUrun/CreateAvukatAtananUrun");
                var postTask = client.PostAsJsonAsync<AvukatAtananUrunEklemeViewModel>("CreateAvukatAtananUrun", avukatAtananUrunModel);
                postTask.Wait();

                var result = postTask.Result;

                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index", "AvukatAtananUrunIzleme");

                }


            }
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            return View(avukatAtananUrunModel);
        }
    }
}