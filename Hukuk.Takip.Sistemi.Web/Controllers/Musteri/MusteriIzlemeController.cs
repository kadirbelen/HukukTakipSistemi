using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.Web.Models.Musteri;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hukuk.Takip.Sistemi.Web.Controllers.Musteri
{
    public class MusteriIzlemeController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<MusteriIzlemeViewModel> model = null;
            

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57938/api/musteriler/getall");

            

                var responseTask = client.GetAsync("getall");
                responseTask.Wait();

                var result = responseTask.Result;

                //var data = responseTask.Result.Content;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<MusteriIzlemeViewModel>>(); 
                    readTask.Wait();
                    model = readTask.Result;
                   
                }
                else
                {
                    model = Enumerable.Empty<MusteriIzlemeViewModel>();
                    ModelState.AddModelError(string.Empty, "Hata");
                }

            }

            //List<MusteriIzlemeViewModel> musteriIzlemeViewModels = new List<MusteriIzlemeViewModel>();

            //musteriIzlemeViewModels.Add(
            //     new MusteriIzlemeViewModel
            //     {
            //         Id = 1,
            //         Ad = "Kadir",
            //         soyad = "BELEN",

            //     });

            //model = musteriIzlemeViewModels;


            return View(model);
        }

     

    }
}