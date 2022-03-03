using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.Web.Models.Avukat;
using Hukuk.Takip.Sistemi.Web.Models.AvukatAtananUrun;
using Hukuk.Takip.Sistemi.Web.Models.IcraTakip;
using Hukuk.Takip.Sistemi.Web.Models.Musteri;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hukuk.Takip.Sistemi.Web.Controllers.IcraTakip
{
    public class IcraTakipEklemeController : Controller
    {
        public IActionResult Index()
        {
           ViewBag.Avukatlar = Avukatlar();
           ViewBag.Musteriler = Musteriler();
           ViewBag.AvukatAtananUrunler = AvukatAtananUrunler();
         
       

            return View();
        }

        [HttpPost]
        public IActionResult Create(IcraTakipEklemeViewModel icraTakipModel)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/IcraTakipler/CreateIcraTakip");
                var postTask = client.PostAsJsonAsync<IcraTakipEklemeViewModel>("CreateIcraTakip", icraTakipModel);
                postTask.Wait();

                var result = postTask.Result;

                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index", "IcraTakipIzleme");

                }


            }
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            return View(icraTakipModel);
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
                                Text = item.Ad + " " + item.Soyad
                            });

                    }

                }

            }
            return Avukatlar;
        }

        //public IActionResult GetSubCategory(int cid)
        //{
        //    var SubCategory_List = _repository.GetCategories().Where(s => s.Id == cid).FirstOrDefault().SubCategories.Select(c => new { Id = c.Id, Name = c.SubCategoryName }).ToList();
        //    return Json(SubCategory_List);
        //}
 
        private List<SelectListItem> AvukatAtananUrunler()
        {
            List<AvukatAtananUrunIzlemeViewModel> model = new List<AvukatAtananUrunIzlemeViewModel>();
            List<SelectListItem> AvukatAtananUrunler = new List<SelectListItem>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/AvukatAtananUrun/GetAvukatAtananUrunler");

                var responseTask = client.GetAsync("GetAvukatAtananUrunler");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<AvukatAtananUrunIzlemeViewModel>>();
                    readTask.Wait();
                    model = readTask.Result;




                    foreach (var item in model)
                    {

                        AvukatAtananUrunler.Add(
                            new SelectListItem
                            {
                                Value = item.Id.ToString(),
                                Text = "Avukat: " + item.AvukatAd + "  " + item.AvukatSoyad + "  " + "Müşteri: " + item.Ad + "  " + item.Soyad + "  " + "Durum: " + item.Durum
                            });

                    }

                }
                //var avukatAtananUrunler = model.Where(p => p.MusteriId == MusteriId).Select(c => new { Id = c.Id, Name = c.Durum }).ToList();
                return AvukatAtananUrunler;

            }
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
    }
}

