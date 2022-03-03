using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.Web.Models.IcraTakip;
using Microsoft.AspNetCore.Mvc;

namespace Hukuk.Takip.Sistemi.Web.Controllers.IcraTakip
{
    public class IcraTakipIzlemeController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<IcraTakipIzlemeViewModel> model = null;


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/IcraTakipler/GetIcraTakipler");
                var responseTask = client.GetAsync("GetIcraTakipler");
                responseTask.Wait();

                var result = responseTask.Result;

                //var data = responseTask.Result.Content;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<IcraTakipIzlemeViewModel>>();
                    readTask.Wait();
                    model = readTask.Result;

                }
                else
                {
                    model = Enumerable.Empty<IcraTakipIzlemeViewModel>();
                    ModelState.AddModelError(string.Empty, "Hata");
                }

            }

            return View(model);
        }
    }
}