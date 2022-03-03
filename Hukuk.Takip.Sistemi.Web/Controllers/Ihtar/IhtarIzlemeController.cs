using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.Web.Models.Ihtar;
using Microsoft.AspNetCore.Mvc;

namespace Hukuk.Takip.Sistemi.Web.Controllers.Ihtar
{
    public class IhtarIzlemeController : Controller
    {


        public IActionResult Index()
        {
            IEnumerable<IhtarIzlemeViewModel> model = null;


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/Ihtarlar/GetIhtarlar");
                var responseTask = client.GetAsync("GetIhtarlar");
                responseTask.Wait();

                var result = responseTask.Result;

                //var data = responseTask.Result.Content;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<IhtarIzlemeViewModel>>();
                    readTask.Wait();
                    model = readTask.Result;

                }
                else
                {
                    model = Enumerable.Empty<IhtarIzlemeViewModel>();
                    ModelState.AddModelError(string.Empty, "Hata");
                }

            }

            return View(model);
        }
    }
}