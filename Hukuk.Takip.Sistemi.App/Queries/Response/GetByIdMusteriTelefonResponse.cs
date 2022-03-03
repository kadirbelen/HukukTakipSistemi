using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Queries.Response
{
    public class GetByIdMusteriTelefonResponse
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public string TelefonTİpi { get; set; }
        public string TelefonNo { get; set; }
    }
}
