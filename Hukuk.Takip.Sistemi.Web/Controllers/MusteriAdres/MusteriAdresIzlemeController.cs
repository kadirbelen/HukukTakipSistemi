using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.Web.Models.MusteriAdres;
using Microsoft.AspNetCore.Mvc;

namespace Hukuk.Takip.Sistemi.Web.Controllers.MusteriAdres
{
    public class MusteriAdresIzlemeController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<MusteriAdresIzlemeViewModel> model = null;


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/MusteriAdresler/GetMusteriAdresler");



                var responseTask = client.GetAsync("GetMusteriAdresler");
                responseTask.Wait();

                var result = responseTask.Result;

                //var data = responseTask.Result.Content;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<MusteriAdresIzlemeViewModel>>();
                    readTask.Wait();
                    model = readTask.Result;

                }
                else
                {
                    model = Enumerable.Empty<MusteriAdresIzlemeViewModel>();
                    ModelState.AddModelError(string.Empty, "Hata");
                }

            }

            return View(model);
        }
    }
}