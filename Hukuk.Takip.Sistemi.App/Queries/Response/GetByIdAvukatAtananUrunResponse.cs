using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Queries.Response
{
    public class GetByIdAvukatAtananUrunResponse
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int MusteriUrunId { get; set; }
        public string Durum { get; set; }

    }
}
