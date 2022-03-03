using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.Web.Models.IhtarUrun;
using Microsoft.AspNetCore.Mvc;

namespace Hukuk.Takip.Sistemi.Web.Controllers.IhtarUrun
{
    public class IhtarUrunIzlemeController : Controller
    {
        public IActionResult Index(int id)
        {
            IEnumerable<IhtarUrunIzlemeViewModel> model = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/IhtarUrunler/GetIhtarUrunler");
                var responseTask = client.GetAsync("GetIhtarUrunler?id=" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;

                //var data = responseTask.Result.Content;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<IhtarUrunIzlemeViewModel>>();
                    readTask.Wait();
                    model = readTask.Result;

                }
                else
                {
                    model = Enumerable.Empty<IhtarUrunIzlemeViewModel>();
                    ModelState.AddModelError(string.Empty, "Hata");
                }

            }

            return View(model);
        }
    }
}