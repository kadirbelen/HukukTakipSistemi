using Hukuk.Takip.Sistemi.App.Queries.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hukuk.Takip.Sistemi.App.Queries.Request
{
    public class GetByIdAvukatAtananUrunRequest:IRequest<GetByIdAvukatAtananUrunResponse>
    {
        public int Id { get; set; }

    }
}
