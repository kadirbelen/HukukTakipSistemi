using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.Web.Models.MusteriTelefon;
using Microsoft.AspNetCore.Mvc;

namespace Hukuk.Takip.Sistemi.Web.Controllers.MusteriTelefon
{
    public class MusteriTelefonIzlemeController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<MusteriTelefonIzlemeViewModel> model = null;


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/MusteriTelefonlar/GetMusteriTelefonlar");



                var responseTask = client.GetAsync("GetMusteriTelefonlar");
                responseTask.Wait();

                var result = responseTask.Result;

                //var data = responseTask.Result.Content;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<MusteriTelefonIzlemeViewModel>>();
                    readTask.Wait();
                    model = readTask.Result;

                }
                else
                {
                    model = Enumerable.Empty<MusteriTelefonIzlemeViewModel>();
                    ModelState.AddModelError(string.Empty, "Hata");
                }

            }

            return View(model);
        }
    }
}