using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.Web.Models.AvukatAtananUrun;
using Microsoft.AspNetCore.Mvc;

namespace Hukuk.Takip.Sistemi.Web.Controllers.AvukatAtananUrun
{
    public class AvukatAtananUrunGuncellemeController : Controller
    {
        AvukatAtananUrunGuncellemeViewModel avukatAtananUrunGuncelleme = null;
        public IActionResult Index()
        {
            return View();
        }
       
        public string AvukatDurum(int id, int type)
        {
            if (type == 3 && id == avukatAtananUrunGuncelleme.Id)
            {
                return avukatAtananUrunGuncelleme.Durum = "Avukat Tarafından Reddedildi";
            }
            else
            {
               
               return avukatAtananUrunGuncelleme.Durum = "Avukat Tarafından Onaylandı";
            }
            
        }

        public IActionResult Edit(int id , int type,string durum)
        {

            if (durum== "Avukat Kabulü Bekleniyor")
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri("http://localhost:57938/api/AvukatAtananUrun/GetById");
                    var responseTask = client.GetAsync("GetById?id=" + id.ToString());
                    responseTask.Wait();

                    var resultGetir = responseTask.Result;
                    if (resultGetir.IsSuccessStatusCode)
                    {
                        var readTask = resultGetir.Content.ReadAsAsync<AvukatAtananUrunGuncellemeViewModel>();
                        readTask.Wait();
                        avukatAtananUrunGuncelleme = readTask.Result;
                        avukatAtananUrunGuncelleme.AtamaTarihi = DateTime.Now;
                        AvukatDurum(id, type);

                    }


                }

                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri("http://localhost:57938/api/AvukatAtananUrun/UpdateAvukatAtananUrun");
                    var putTask = client.PutAsJsonAsync<AvukatAtananUrunGuncellemeViewModel>("UpdateAvukatAtananUrun", avukatAtananUrunGuncelleme);
                    putTask.Wait();

                    var result = putTask.Result;
                    if (result.IsSuccessStatusCode)
                    {

                        return RedirectToAction("Index", "AvukatAtananUrunIzleme");
                    }
                }
            }
          
            return RedirectToAction("Index", "AvukatAtananUrunIzleme");

            
        }


        //[HttpPost]
        //public IActionResult Update(AvukatAtananUrunGuncellemeViewModel avukatAtananUrunGuncelleme)
        //{
            
        //    using (var client = new HttpClient())
        //    {
               
        //        avukatAtananUrunGuncelleme.Durum = "Avukat Tarafından Onaylandı";
        //        client.BaseAddress = new Uri("http://localhost:57938/api/AvukatAtananUrun/UpdateAvukatAtananUrun");
        //        var putTask = client.PutAsJsonAsync<AvukatAtananUrunGuncellemeViewModel>("UpdateAvukatAtananUrun", avukatAtananUrunGuncelleme);
        //        putTask.Wait();

        //        var result = putTask.Result;
        //        if (result.IsSuccessStatusCode)
        //        {
                    
        //            return RedirectToAction("Index", "AvukatAtananUrunIzleme");
        //        }
        //    }
        //    return RedirectToAction("Index", "AvukatAtananUrunIzleme");
        //}
    }
}