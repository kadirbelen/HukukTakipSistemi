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
    public class IhtarUrunGuncellemeController : Controller
    {
        public IActionResult Index()
        {
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
                                Text = item.MusteriNo+" "+item.YevmiyeNo+" "+item.NoterAd+" "+item.TakipHesapNo
                            });


                    }

                }

            }


            return Ihtarlar;

        }




        public IActionResult Edit(int id)
        {
            //ViewBag.MusteriUrunler = MusteriUrunler();
            //ViewBag.Ihtarlar = Ihtarlar();

            IhtarUrunGuncellemeViewModel  ihtarUrunGuncelleme = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/IhtarUrunler/GetById");
                var responseTask = client.GetAsync("GetById?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IhtarUrunGuncellemeViewModel>();
                    readTask.Wait();

                    ihtarUrunGuncelleme = readTask.Result;
                    ViewBag.MusteriUrunler = MusteriUrunler().Where(p => p.Value == ihtarUrunGuncelleme.MusteriUrunId.ToString()).ToList();
                    ViewBag.Ihtarlar = Ihtarlar().Where(p => p.Value == ihtarUrunGuncelleme.IhtarId.ToString()).ToList();

                }
            }
            return View(ihtarUrunGuncelleme);
        }

        [HttpPost]
        public IActionResult Update(IhtarUrunGuncellemeViewModel ihtarUrunGuncelleme)
        {
       
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/IhtarUrunler/UpdateIhtarUrun");
                var putTask = client.PutAsJsonAsync<IhtarUrunGuncellemeViewModel>("UpdateIhtarUrun", ihtarUrunGuncelleme);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "IhtarUrunIzleme");
                }
            }
            return View(ihtarUrunGuncelleme);
        }
    }
}