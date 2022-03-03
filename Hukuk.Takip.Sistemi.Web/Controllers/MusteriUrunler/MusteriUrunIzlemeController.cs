using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.Web.Models.MusteriUrun;
using Microsoft.AspNetCore.Mvc;

namespace Hukuk.Takip.Sistemi.Web.Controllers.MusteriUrunler
{
    public class MusteriUrunIzlemeController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<MusteriUrunIzlemeViewModel> model = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/MusteriUrunler/GetMusteriUrunler");

                var responseTask = client.GetAsync("GetMusteriUrunler");
                responseTask.Wait();

                var result = responseTask.Result;

                //var data = responseTask.Result.Content;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<MusteriUrunIzlemeViewModel>>();
                    readTask.Wait();
                    model = readTask.Result;

                }
                else
                {
                    model = Enumerable.Empty<MusteriUrunIzlemeViewModel>();
                    ModelState.AddModelError(string.Empty, "Hata");
                }

                return View(model);
            }
        }
    }
}