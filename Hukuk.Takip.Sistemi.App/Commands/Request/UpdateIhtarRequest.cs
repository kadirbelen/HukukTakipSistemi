using Hukuk.Takip.Sistemi.App.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Commands.Request
{
    public class UpdateIhtarRequest:IRequest<UpdateIhtarResponse>
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public string NoterAd { get; set; }
        public string TakipHesapNo { get; set; }
        public DateTime IhtarTarihi { get; set; }
        public DateTime? IhtarTebligTarihi { get; set; }
        public decimal? IhtarTutar { get; set; }
        public int? YevmiyeNo { get; set; }
        public DateTime? GuncellenmeTarihi { get; set; }
        public string Guncelleyen { get; set; }
        public bool SilindiMi { get; set; }
        public DateTime? EklenmeTarihi { get; set; }
        public string EkleyenKisi { get; set; }
    }
}
