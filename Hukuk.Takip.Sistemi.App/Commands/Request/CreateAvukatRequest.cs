using Hukuk.Takip.Sistemi.App.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Commands.Request
{
    public class CreateAvukatRequest:IRequest<CreateAvukatResponse>
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tip { get; set; }
        public bool DosyaYetkisi { get; set; }
        public string TelNo { get; set; }
        public string FaxNo { get; set; }
        public string TCKN { get; set; }
        public bool AktifMi { get; set; }
        public DateTime? GuncellenmeTarihi { get; set; }
        public string Guncelleyen { get; set; }
        public bool SilindiMi { get; set; }
        public DateTime? EklenmeTarihi { get; set; }
        public string EkleyenKisi { get; set; }
    }
}
