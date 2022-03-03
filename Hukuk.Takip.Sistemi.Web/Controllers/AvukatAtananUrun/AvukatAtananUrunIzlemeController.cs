using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.Web.Models.AvukatAtananUrun;
using Microsoft.AspNetCore.Mvc;

namespace Hukuk.Takip.Sistemi.Web.Controllers.AvukatAtananUrun
{
    public class AvukatAtananUrunIzlemeController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<AvukatAtananUrunIzlemeViewModel> model = null;


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/AvukatAtananUrun/GetAvukatAtananUrunler");



                var responseTask = client.GetAsync("GetAvukatAtananUrunler");
                responseTask.Wait();

                var result = responseTask.Result;

                //var data = responseTask.Result.Content;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<AvukatAtananUrunIzlemeViewModel>>();
                    readTask.Wait();
                    model = readTask.Result;

                }
                else
                {
                    model = Enumerable.Empty<AvukatAtananUrunIzlemeViewModel>();
                    ModelState.AddModelError(string.Empty, "Hata");
                }

            }

            return View(model);
        }
      
    }
}