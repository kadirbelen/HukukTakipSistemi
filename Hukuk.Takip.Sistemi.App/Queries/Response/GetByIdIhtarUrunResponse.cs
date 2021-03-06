using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Queries.Response
{
    public class GetByIdIhtarUrunResponse
    {
        public int Id { get; set; }
        public int IhtarId { get; set; }
        public int MusteriUrunId { get; set; }
        public decimal? IhtarTutar { get; set; }
        public decimal? AnaParaTutar { get; set; }
        public decimal? FaizTutar { get; set; }
        public decimal? KomisyonTutar { get; set; }
        public decimal? ToplamBorc { get; set; }
      
    }
}
